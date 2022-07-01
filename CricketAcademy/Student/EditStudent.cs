using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CricketAcademy.Student
{
    public partial class EditStudent : Form
    {
        string imagePath = "";
        public int student_id;

        public EditStudent()
        {
            InitializeComponent();
        }

        private void EditStudent_Load(object sender, EventArgs e)
        {
            this.cmbSkill.SelectedIndexChanged -= new System.EventHandler(this.cmbSkill_SelectedIndexChanged);
            loadSkills();
            loadTypes();
            this.cmbSkill.SelectedIndexChanged += new System.EventHandler(this.cmbSkill_SelectedIndexChanged);
            loadDetails();
        }

        private void loadSkills()
        {
            string sql = "SELECT * FROM skill";
            DataTable dt = Library.DataAccessLayer.Instance.ExecuteQuery(sql);
            cmbSkill.DataSource = dt;
            cmbSkill.DisplayMember = "skill_name";
            cmbSkill.ValueMember = "skill_id";
        }

        private void loadTypes(int skill_id=0)
        {
            string sql = "SELECT * FROM skill_type WHERE 1=1";
            if (skill_id != 0)
                sql += " AND skill_id='" + skill_id + "'";
            DataTable dt = Library.DataAccessLayer.Instance.ExecuteQuery(sql);
            cmbType.DataSource = dt;
            cmbType.DisplayMember = "skill_type_name";
            cmbType.ValueMember = "skill_type_id";
        }

        private void loadDetails()
        {
            try
            {
                string sql = "SELECT * FROM student WHERE student_id='" + student_id + "'";
                DataRow dr = Library.DataAccessLayer.Instance.ExecuteQuery(sql).Rows[0];
                txtName.Text = dr["student_name"].ToString();
                txtOccupation.Text = dr["occupation"].ToString();
                txtAddress.Text = dr["address"].ToString();
                txtMobile1.Text = dr["mobile_1"].ToString();
                txtMobile2.Text = dr["mobile_2"].ToString();
                txtEmail.Text = dr["email"].ToString();
                txtGuardianName.Text = dr["guardian_name"].ToString();
                maskedTextBox1.Text = dr["nep_dob"].ToString();
               chkActive.Checked =(bool)( dr["is_active"]);
                cmbSkill.SelectedValue = Convert.ToInt32(dr["skill_id"]);
                cmbType.SelectedValue = Convert.ToInt32(dr["skill_type_id"]);

                //load image
                if (dr["image"].ToString() != "")
                {
                    byte[] imageData = (byte[])dr["image"];
                    var stream = new MemoryStream(imageData);
                    pictureBox1.Image = Image.FromStream(stream);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "" || txtAddress.Text == "" || txtMobile1.Text == "" || cmbSkill.SelectedIndex == -1 || cmbType.SelectedIndex == -1 || txtOccupation.Text == "" || txtGuardianName.Text == "" || maskedTextBox1.Text == "  /  /")
                {
                    MessageBox.Show("Please enter all details.");
                    return;
                }

                Regex reg = new Regex(@"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}$", RegexOptions.IgnoreCase); ///Object initialization for Regex 
                if (!reg.IsMatch(txtEmail.Text))
                {
                    MessageBox.Show("Invalid email.Please use a valid email address.");
                    return;
                }

                Library.DateConverter dc = new Library.DateConverter();
                DateTime eng_dob = new DateTime();
                try
                {
                    eng_dob = dc.ToAD(maskedTextBox1.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please enter valid date of birth.");
                }
                byte[] image = null;

                if (pictureBox1.Image != null)
                {
                    Size size = new Size(512, 512);
                    Image im = resizeImage(pictureBox1.Image, size);
                    image = imageToByteArray(im);
                }
                SqlCommand cmd = new SqlCommand();
                string sql = "UPDATE student SET student_name='"+ txtName.Text +"',occupation='"+ txtOccupation.Text +"',guardian_name='"+ txtGuardianName.Text +"',address='"+ txtAddress.Text +"',mobile_1='"+ txtMobile1.Text +"',mobile_2='"+ txtMobile2.Text +"',skill_id='"+ cmbSkill.SelectedValue +"',skill_type_id='"+ cmbType.SelectedValue +"',nep_dob='"+ maskedTextBox1.Text +"',dob='"+ eng_dob + "',image=@image_data WHERE student_id='" + student_id +"'";

                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@image_data", (image == null) ? (object)DBNull.Value : image).SqlDbType = SqlDbType.Image;
                Library.DataAccessLayer.Instance.ExecuteNonQuery(cmd);
                MessageBox.Show("Student updated successfully.");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbSkill_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadTypes(Convert.ToInt32(cmbSkill.SelectedValue));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonbrowseImage_Click(object sender, EventArgs e)
        {
            OpenImage();
        }
        private void OpenImage()
        {
            openFileDialog1.Title = "Choose a student image.";
            openFileDialog1.FileName = "";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.Multiselect = false;
            //openFileDialog1.Filter = "JPEG|*.jpg;*.jpeg;*.jpe;";
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                try
                {
                    imagePath = openFileDialog1.FileName;

                }
                catch
                {
                    MessageBox.Show("Invalid file!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public static Image resizeImage(Image imgToResize, Size size)
        {
            int sourceWidth = imgToResize.Width;
            int sourceHeight = imgToResize.Height;

            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;

            nPercentW = ((float)size.Width / (float)sourceWidth);
            nPercentH = ((float)size.Height / (float)sourceHeight);

            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;

            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();

            return (Image)b;
        }

        //convert image to byte array
        public static byte[] imageToByteArray(Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                return ms.ToArray();
            }
        }
    }
}
