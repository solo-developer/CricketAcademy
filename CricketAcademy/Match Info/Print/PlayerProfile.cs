
using CricketAcademy.Account;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CricketAcademy.Match_Info.Print
{
    public partial class PlayerProfile : Form
    {
        //batting
        public string student_id = "";
        public string matches = "";
        public string balls_faced = "";
        public string runs_scored = "";
        public string not_outs = "";
        public string average = "";
        public string strike_rate = "";
        public string high_score = "";

        //balling
        public string overs_bowled = "";
        public string maidens = "";
        public string runs_conceeded = "";
        public string wickets = "";
        public string economy = "";

        //other
        public string date_from = "";
        public string date_to = "";

        public PlayerProfile()
        {
            InitializeComponent();
        }

        private void PlayerProfile_Load(object sender, EventArgs e)
        {
            try
            {
                reportViewer1.LocalReport.DataSources.Clear();
                ReportParameter[] parameters = new ReportParameter[18];
                List<ReportParameter> rpc = new List<ReportParameter>();

                parameters[0] = new ReportParameter("matches", matches);
                parameters[1] = new ReportParameter("balls_faced", balls_faced);
                parameters[2] = new ReportParameter("runs_scored", runs_scored);
                parameters[3] = new ReportParameter("not_outs", not_outs);
                parameters[4] = new ReportParameter("average", average);
                parameters[5] = new ReportParameter("strike_rate", strike_rate);
                parameters[6] = new ReportParameter("high_score", high_score);
                parameters[7] = new ReportParameter("overs_bowled", overs_bowled);
                parameters[8] = new ReportParameter("maidens", maidens);
                parameters[9] = new ReportParameter("runs_conceeded", runs_conceeded);
                parameters[10] = new ReportParameter("wickets", wickets);
                parameters[11] = new ReportParameter("economy", economy);
                parameters[12] = new ReportParameter("date_from", date_from);
                parameters[13] = new ReportParameter("date_to", date_to);

                //student details
                string sql = "SELECT * FROM student WHERE student_id='" + student_id + "'";
                DataTable dt = Library.DataAccessLayer.Instance.ExecuteQuery(sql);
                if (dt.Rows.Count > 0)
                {
                    parameters[14] = new ReportParameter("student_name", dt.Rows[0]["student_name"].ToString());
                    parameters[15] = new ReportParameter("dob", dt.Rows[0]["nep_dob"].ToString());
                    parameters[16] = new ReportParameter("address", dt.Rows[0]["address"].ToString());
                }
                else
                {
                    parameters[14] = new ReportParameter("student_name", " ");
                    parameters[15] = new ReportParameter("dob", " ");
                    parameters[16] = new ReportParameter("address", " ");
                }

                //student_age parameter

                if (string.IsNullOrEmpty(dt.Rows[0]["dob"].ToString()))

                    parameters[17] = new ReportParameter("student_age", " ");
                else
                {
                    sql = @"DECLARE @date datetime, @tmpdate datetime, @years int, @months int, @days int
SELECT @date = '" + dt.Rows[0]["dob"] + "' SELECT @tmpdate = @date SELECT @years = DATEDIFF(yy, @tmpdate, GETDATE()) - CASE WHEN (MONTH(@date) > MONTH(GETDATE())) OR (MONTH(@date) = MONTH(GETDATE()) AND DAY(@date) > DAY(GETDATE())) THEN 1 ELSE 0 END SELECT @tmpdate = DATEADD(yy, @years, @tmpdate) SELECT @months = DATEDIFF(m, @tmpdate, GETDATE()) - CASE WHEN DAY(@date) > DAY(GETDATE()) THEN 1 ELSE 0 END SELECT @tmpdate = DATEADD(m, @months, @tmpdate) SELECT @days = DATEDIFF(d, @tmpdate, GETDATE()) SELECT CAST(@years as nvarchar(50))+' years '+CAST(@months as nvarchar(50))+' months '+CAST(@days as nvarchar(50))+' days'";

                    string age = Library.DataAccessLayer.Instance.ExecuteScalar(sql);
                    parameters[17] = new ReportParameter("student_age",age);
                }
                reportViewer1.LocalReport.SetParameters(parameters);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }
        }
    }
}
