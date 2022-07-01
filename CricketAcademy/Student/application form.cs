using Microsoft.Reporting.WinForms;
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
    public partial class application_form : Form
    {
        public string student_id = "";
        public application_form()
        {
            InitializeComponent();
        }

        private void application_form_Load(object sender, EventArgs e)
        {
            try
            {


                reportViewer1.LocalReport.DataSources.Clear();
                dsApplicationForm ds = new dsApplicationForm();
                try
                {
                    string sql = "SELECT student_id,student_name,address,mobile_1,mobile_2,skill.skill_name,occupation,entry_date,email,guardian_name,dob,nep_dob,image FROM student INNER JOIN skill ON skill.skill_id=student.skill_id WHERE student_id='" + student_id + "'";
                    DataTable dt = Library.DataAccessLayer.Instance.ExecuteQuery(sql);

                    ds.dtStudentInfo.Rows.Add(dt.Rows[0]["student_id"].ToString(), dt.Rows[0]["student_name"].ToString(), dt.Rows[0]["address"].ToString(), dt.Rows[0]["mobile_1"].ToString(), dt.Rows[0]["mobile_2"].ToString(), dt.Rows[0]["skill_name"].ToString(), dt.Rows[0]["occupation"].ToString(),Convert.ToDateTime(dt.Rows[0]["entry_date"]).ToString("d"), dt.Rows[0]["email"].ToString(), dt.Rows[0]["guardian_name"].ToString(), dt.Rows[0]["dob"].ToString(), dt.Rows[0]["nep_dob"].ToString(),dt.Rows[0]["image"].ToString()==""?null: (byte[])dt.Rows[0]["image"]);
                    reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", (DataTable)ds.dtStudentInfo));
                    this.reportViewer1.RefreshReport();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
