using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CricketAcademy.Student
{
    public partial class View_Students : Form
    {
        public View_Students()
        {
            InitializeComponent();
        }

        private void View_Students_Load(object sender, EventArgs e)
        {
            this.cmbSkills.SelectedIndexChanged -= new System.EventHandler(this.cmbSkills_SelectedIndexChanged);
            loadSkills();
            cmbSkills.SelectedIndex = 0;
            this.cmbSkills.SelectedIndexChanged += new System.EventHandler(this.cmbSkills_SelectedIndexChanged);
            cmbType.SelectedIndex = 0;
            loadData();
          
        }

        private void loadSkills()
        {
            try
            {
                string sql = "SELECT * from skill WHERE 1=1";

                DataTable dt = Library.DataAccessLayer.Instance.ExecuteQuery(sql);
                DataRow dr = dt.NewRow();
                dr[1] = "---Select All---";
                dr[0] = "0";

                dt.Rows.InsertAt(dr, 0);
                cmbSkills.DataSource = dt;
                cmbSkills.DisplayMember = "skill_name";
                cmbSkills.ValueMember = "skill_id";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadData()
        {
            try
            {
                string sql = "SELECT student_id,student_name as 'Student Name',skill.skill_name as 'Skill',skill_type.skill_type_name as 'Skill Type',address as 'Address',mobile_1 as 'Mobile 1', mobile_2 as 'Mobile 2',occupation as 'Occupation',entry_date as 'Entered Date',email as 'Email',guardian_name as 'Guardian Name',dob as 'DOB',nep_dob as 'DOB' FROM student  INNER JOIN skill ON skill.skill_id=student.skill_id INNER JOIN skill_type ON skill_type.skill_type_id=student.skill_type_id WHERE 1=1";
                if (txtSearch.Text != "")
                    sql += " AND student_name LIKE '"+ txtSearch.Text +"%'";

                if(cmbType.SelectedIndex==1)
                    sql += " AND is_active=1";

                if (cmbType.SelectedIndex == 2)
                    sql += " AND is_active=0";

                if (cmbSkills.SelectedIndex != 0)
                    sql += " AND skill.skill_id='" + cmbSkills.SelectedValue + "'";

                DataTable dt = Library.DataAccessLayer.Instance.ExecuteQuery(sql);
                viewAll.DataSource = dt;
                viewAll.Columns["student_id"].Visible = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load datas.");
            }
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnAge_Click(object sender, EventArgs e)
        {
            try
            {
                if (viewAll.SelectedRows.Count == 0)
                    return;

                if (string.IsNullOrEmpty(viewAll.SelectedRows[0].Cells["dob"].Value.ToString()))
                {
                    MessageBox.Show("Date of birth is not valid.");
                    return;
                }
                string sql = @"DECLARE @date datetime, @tmpdate datetime, @years int, @months int, @days int
SELECT @date = '"+ viewAll.SelectedRows[0].Cells["dob"].Value.ToString() +"' SELECT @tmpdate = @date SELECT @years = DATEDIFF(yy, @tmpdate, GETDATE()) - CASE WHEN (MONTH(@date) > MONTH(GETDATE())) OR (MONTH(@date) = MONTH(GETDATE()) AND DAY(@date) > DAY(GETDATE())) THEN 1 ELSE 0 END SELECT @tmpdate = DATEADD(yy, @years, @tmpdate) SELECT @months = DATEDIFF(m, @tmpdate, GETDATE()) - CASE WHEN DAY(@date) > DAY(GETDATE()) THEN 1 ELSE 0 END SELECT @tmpdate = DATEADD(m, @months, @tmpdate) SELECT @days = DATEDIFF(d, @tmpdate, GETDATE()) SELECT CAST(@years as nvarchar(50))+' years '+CAST(@months as nvarchar(50))+' months '+CAST(@days as nvarchar(50))+' days'";

                string age = Library.DataAccessLayer.Instance.ExecuteScalar(sql);

                MessageBox.Show(age);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (viewAll.SelectedRows.Count == 0)
                    return;
                EditStudent s = new EditStudent();
                s.student_id =Convert.ToInt32(viewAll.SelectedRows[0].Cells["student_id"].Value);
                s.ShowDialog();
                loadData();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cmbSkills_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnForm_Click(object sender, EventArgs e)
        {
            if (viewAll.Rows.Count == 0)
                return;
            application_form f = new application_form();
            f.student_id = viewAll.SelectedRows[0].Cells["student_id"].Value.ToString();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Match_Info.Player_Info p = new Match_Info.Player_Info();
            p.student_id = viewAll.SelectedRows[0].Cells["student_id"].Value.ToString();
            p.ShowDialog();
        }

        private void viewAll_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Student_Image image = new Student_Image();
                image.student_id= viewAll.SelectedRows[0].Cells["student_id"].Value.ToString();
                image.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Failed to load image.");
            }
        }
    }
}
