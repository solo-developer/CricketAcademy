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
    public partial class Add_Scores : Form
    {
        public Add_Scores()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtMobile1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal balls_faced = Convert.ToInt32(txtBallsFaced.Text);
                if (balls_faced == 0)
                    txtRunsContributed.Text = "0";
            }
            catch (Exception)
            {

                txtBallsFaced.Text = "0";
                txtRunsContributed.Text = "0";

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(txtPosition.Text);
            }
            catch (Exception)
            {
                txtPosition.Text = "0";
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Add_Scores_Load(object sender, EventArgs e)
        {
            loadStudents();
        }

        private void loadStudents()
        {
            try
            {
                string sql = "SELECT student_id,student_name FROM student WHERE is_active=1";

                DataTable dt = Library.DataAccessLayer.Instance.ExecuteQuery(sql);
                cmbStudent.DataSource = dt;
                cmbStudent.DisplayMember = "student_name";
                cmbStudent.ValueMember = "student_id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtRunsContributed_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(txtRunsContributed.Text);
            }
            catch (Exception)
            {

                txtRunsContributed.Text = "0";

            }
        }

        private void txtMaidens_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(txtMaidens.Text);
            }
            catch (Exception)
            {
                txtMaidens.Text = "0";
            }
        }

        private void txtWickets_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(txtWickets.Text);
            }
            catch (Exception)
            {
                txtWickets.Text = "0";
            }
        }

        private void txtRunsConceeded_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(txtRunsConceeded.Text);
            }
            catch (Exception)
            {
                txtRunsConceeded.Text = "0";
            }
        }

        private void txtOversBowled_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(txtOversBowled.Text);
            }
            catch (Exception)
            {
                txtOversBowled.Text = "0";
                txtMaidens.Text = "0";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbStudent.SelectedIndex == -1)
                {
                    MessageBox.Show("Please choose a student.");
                    return;
                }

                if (txtCompetition.Text == "")
                {
                    MessageBox.Show("Please enter a competition name.");
                    return;
                }

                if (txtLocation.Text == "")
                {
                    MessageBox.Show("WTF ?  Use your common sense. How can you play cricket without location? Are you playing in Pluto? ");
                    return;
                }

                Library.DateConverter dc = new Library.DateConverter();
                DateTime game_date = DateTime.Now;
                try
                {
                    game_date = dc.ToAD(maskedTextBox1.Text);
                }
                catch (Exception)
                {

                    MessageBox.Show("invalid game date.Please enter a valid date in specified date format.");
                    return;
                }


                DialogResult dr = MessageBox.Show("Make sure all details are alright. This can't be undone.", "Confirm!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.No)
                    return;


                int is_not_out = chkNotOut.Checked ? 1 : 0;

                string sql = "INSERT INTO student_scores(student_id,no_of_matches,is_not_out,balls_faced,runs_made,overs_bowled,balls_bowled,maidens_bowled,runs_conceeded,wickets,league_name,match_location,batting_postition,game_date,nep_game_date) VALUES ('" + cmbStudent.SelectedValue + "','1','" + is_not_out + "','" + txtBallsFaced.Text + "','" + txtRunsContributed.Text + "','" + txtOversBowled.Text + "','"+ txtBallsBowled.Text +"','" + txtMaidens.Text + "','" + txtRunsConceeded.Text + "','" + txtWickets.Text + "','" + txtCompetition.Text + "','" + txtLocation.Text + "','" + txtPosition.Text + "','" + game_date + "','" + maskedTextBox1.Text + "')";

                Library.DataAccessLayer.Instance.ExecuteNonQuery(sql);
                MessageBox.Show("Data inserted successfully.");
                cmbStudent.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBallsBowled_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int balls = Convert.ToInt32(txtBallsBowled.Text);
                if (balls < 0 || balls > 6)
                    txtBallsBowled.Text = "0";
            }
            catch (Exception)
            {
                txtBallsBowled.Text = "0";
            }
        }
    }
}
