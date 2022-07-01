using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CricketAcademy.Match_Info
{
    public partial class Info : Form
    {
        Library.DateConverter dc = new Library.DateConverter();
        public Info()
        {
            InitializeComponent();
        }

        private void cmbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void Info_Load(object sender, EventArgs e)
        {
            txtFrom.Text = dc.ToBS(DateTime.Now.AddMonths(-1));
            txtTo.Text = dc.ToBS(DateTime.Now);
            loadStudents();
            loadCompetitions();
        }

        private void loadStudents()
        {
            try
            {
                string sql = "SELECT student_id,student_name FROM student";
                DataTable dt = Library.DataAccessLayer.Instance.ExecuteQuery(sql);
                DataRow dr = dt.NewRow();
                dr[1] = "---Select All---";
                dr[0] = "0";

                dt.Rows.InsertAt(dr, 0);
                cmbStudent.DataSource = dt;
                cmbStudent.DisplayMember = "student_name";
                cmbStudent.ValueMember = "student_id";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void loadCompetitions()
        {
            try
            {
                string sql = "SELECT distinct(league_name) as leagues FROM student_scores";
                DataTable dt = Library.DataAccessLayer.Instance.ExecuteQuery(sql);
                DataRow dr = dt.NewRow();
               
                dr[0] = "SELECT ALL";

                dt.Rows.InsertAt(dr, 0);
                cmbCompetition.DataSource = dt;
                cmbCompetition.DisplayMember = "leagues";
                cmbCompetition.ValueMember = "leagues";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            try
            {

                DateTime date_from = DateTime.Now;
                DateTime date_to = DateTime.Now;
                try
                {
                    date_from = dc.ToAD(txtFrom.Text);
                    date_to = dc.ToAD(txtTo.Text);
                }
                catch (Exception)
                {

                    MessageBox.Show("Please enter valid dates.");
                    return;
                }

                string sql = @"SELECT student_scores.student_id,student.student_name AS 'Student Name',student_scores.league_name AS 'Competition',student_scores.match_location AS 'Location',student_scores.nep_game_date AS 'Game Date',student_scores.balls_faced AS 'Balls Faced',student_scores.runs_made AS 'Runs Made',student_scores.batting_postition AS 'Batting Position',student_scores.is_not_out as 'Not Out',CONCAT((student_scores.overs_bowled*6+student_scores.balls_bowled)/6,'.',(student_scores.overs_bowled*6+student_scores.balls_bowled)%6) as 'Overs Bowled',student_scores.maidens_bowled AS 'Maidens',student_scores.runs_conceeded as 'Runs Given',student_scores.wickets as 'Wickets'  FROM student INNER JOIN student_scores ON student_scores.student_id=student.student_id WHERE 1=1";

                if (cmbStudent.SelectedIndex != 0)
                    sql += " AND student_scores.student_id='" + cmbStudent.SelectedValue + "'";

                if (cmbCompetition.SelectedIndex != 0)
                    sql += " AND student_scores.league_name='" + cmbCompetition.SelectedValue + "'";

                sql += " AND game_date BETWEEN '" + date_from.AddDays(-1) + "' AND '" + date_to + "'";

                sql += " ORDER BY game_date DESC";

                DataTable dt = Library.DataAccessLayer.Instance.ExecuteQuery(sql);

                viewAll.DataSource = dt;
                viewAll.Columns["student_id"].Visible = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void cmbCompetition_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void viewAll_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
