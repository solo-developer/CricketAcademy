using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CricketAcademy.Student
{
    public partial class Student_Image : Form
    {
        public string student_id = "";
        public Student_Image()
        {
            InitializeComponent();
        }

        private void Student_Image_Load(object sender, EventArgs e)
        {
            if (student_id != "")
            {
                string sql = "SELECT * FROM student WHERE student_id='" + student_id + "'";
                DataRow dr = Library.DataAccessLayer.Instance.ExecuteQuery(sql).Rows[0];
           
                //load image
                if (dr["image"].ToString() != "")
                {
                    byte[] imageData = (byte[])dr["image"];
                    var stream = new MemoryStream(imageData);
                    pictureBox1.Image = Image.FromStream(stream);
                }
            }
        }
    }
}
