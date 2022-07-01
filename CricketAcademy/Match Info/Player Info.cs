using System;
using System.Data;
using System.Windows.Forms;

namespace CricketAcademy.Match_Info
{
    public partial class Player_Info : Form
    {
        public string student_id = "";
        Library.DateConverter dc = new Library.DateConverter();
        public Player_Info()
        {
            InitializeComponent();
        }

        private void Player_Info_Load(object sender, EventArgs e)
        {
            try
            {
                this.cmbPosition.SelectedIndexChanged -= new EventHandler(this.cmbPosition_SelectedIndexChanged);
                this.cmbCompetition.SelectedIndexChanged -= new EventHandler(this.cmbCompetition_SelectedIndexChanged);
                loadCompetitions();
                loadPositions();
                string sql = "SELECT MIN(game_date) as game_date FROM student_scores WHERE student_id='" + student_id + "'";

                DateTime date = DateTime.Now.AddMonths(-2);
                if (Library.DataAccessLayer.Instance.ExecuteQuery(sql).Rows.Count != 0)
                {
                    txtFrom.Text = dc.ToBS(date);
                }
                txtTo.Text = dc.ToBS(DateTime.Now.AddDays(1));

                this.cmbCompetition.SelectedIndexChanged += new EventHandler(this.cmbCompetition_SelectedIndexChanged);
                this.cmbPosition.SelectedIndexChanged += new EventHandler(this.cmbPosition_SelectedIndexChanged);
                loadData();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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
                catch (Exception ex)
                {

                    MessageBox.Show("Please enter valid dates in mm/dd/yyyy format.");
                    return;
                }

                #region  cleanup
                lblMaidens.Text = "";
                lblMatches.Text = "";
                lblRunsConceeded.Text = "";
                lblRunsScored.Text = "";
                lblAverage.Text = "";
                lblStrikeRate.Text = "";
                lblOversBowled.Text = "";
                lblWickets.Text = "";
                lblHighScore.Text = "";
                lblNotOuts.Text = "";
                lblBallsFaced.Text = "";
                lblEconomy.Text = "";
                #endregion
                string sql = @"SELECT SUM(student_scores.no_of_matches) AS 'matches',SUM(student_scores.balls_faced) AS 'balls_faced',SUM(student_scores.runs_made) AS 'runs_made',
                  concat(
                   (SUM(student_scores.overs_bowled)*6+sum(student_scores.balls_bowled))/6,'.',((SUM(student_scores.overs_bowled)*6+sum(student_scores.balls_bowled))%6)) as 'overs_bowled',

                 SUM(student_scores.overs_bowled) AS 'bowled_overs',
                 SUM(student_scores.balls_bowled) AS 'bowled_balls',
                 SUM(student_scores.maidens_bowled) AS 'maidens',
                 SUM(student_scores.runs_conceeded) as 'runs_given',SUM(student_scores.wickets) as 'wickets',
                 (select max(student_scores.runs_made) from student_scores where student_id='" + student_id + "') AS 'high_score',SUM(CASE student_scores.is_not_out WHEN '1' THEN 1 ELSE 0 end) AS 'not_out'  FROM student_scores WHERE 1=1";

                sql += " AND game_date BETWEEN '" + date_from + "' AND '" + date_to + "'";

                if (cmbCompetition.SelectedIndex > 0)
                    sql += " AND league_name='" + cmbCompetition.Text + "'";
                if (cmbPosition.SelectedIndex > 0)
                    sql += " AND batting_postition='" + cmbPosition.Text + "'";

                sql += " AND student_scores.student_id='" + student_id + "'";

                DataTable dt = Library.DataAccessLayer.Instance.ExecuteQuery(sql);

                if (dt.Rows.Count == 0 || dt.Rows[0]["matches"] == DBNull.Value)
                    lblMatches.Text = "0";
                else
                {
                    //batting
                    lblMatches.Text = dt.Rows[0]["matches"].ToString();
                    lblNotOuts.Text = dt.Rows[0]["not_out"].ToString();
                    lblRunsScored.Text = dt.Rows[0]["runs_made"].ToString();
                    lblBallsFaced.Text = dt.Rows[0]["balls_faced"].ToString();
                    lblHighScore.Text = dt.Rows[0]["high_score"].ToString();

                    decimal to_be_divided = Convert.ToDecimal(dt.Rows[0]["matches"]) - Convert.ToDecimal(dt.Rows[0]["not_out"]);
                    decimal average = 0;
                    if (to_be_divided == 0)
                    {
                        average = Convert.ToDecimal(dt.Rows[0]["runs_made"]);
                    }
                    else
                    {
                        average = Convert.ToDecimal(dt.Rows[0]["runs_made"]) / to_be_divided;
                    }
                    lblAverage.Text = average.ToString();

                    //strike rate
                    decimal strike_rate = 0;
                    if (Convert.ToDecimal(dt.Rows[0]["balls_faced"]) != 0)
                    {
                        strike_rate = (Convert.ToDecimal(dt.Rows[0]["runs_made"]) / Convert.ToDecimal(dt.Rows[0]["balls_faced"]) * 100);
                    }
                    lblStrikeRate.Text = Math.Round(strike_rate, 2).ToString();


                    //bowling
                    lblRunsConceeded.Text = dt.Rows[0]["runs_given"].ToString();
                    lblOversBowled.Text = dt.Rows[0]["overs_bowled"].ToString();
                    lblMaidens.Text = dt.Rows[0]["maidens"].ToString();
                    lblWickets.Text = dt.Rows[0]["wickets"].ToString();

                    //calculate economy
                    decimal economy = 0;
                    decimal overs_bowled = Convert.ToDecimal(dt.Rows[0]["bowled_overs"]);
                    decimal balls_bowled = Convert.ToDecimal(dt.Rows[0]["bowled_balls"]);
                    if (overs_bowled > 0 || balls_bowled>0)
                    {
                        economy = (Convert.ToDecimal(dt.Rows[0]["runs_given"])*6) / (overs_bowled * 6 + balls_bowled);
                    }

                    lblEconomy.Text = Math.Round(economy,2).ToString();

                }
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
                string sql = "SELECT distinct(league_name) as leagues FROM student_scores WHERE student_id='" + student_id + "'";
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

        private void loadPositions()
        {
            try
            {
                string sql = "SELECT distinct(batting_postition) as position FROM student_scores WHERE student_id='" + student_id + "'";
                DataTable dt = Library.DataAccessLayer.Instance.ExecuteQuery(sql);
                DataRow dr = dt.NewRow();

                dr[0] = "0";

                dt.Rows.InsertAt(dr, 0);
                cmbPosition.DataSource = dt;
                cmbPosition.DisplayMember = "position";
                cmbPosition.ValueMember = "position";
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

        private void cmbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lblMatches.Text == "0")
                return;
            Print.PlayerProfile profile = new Print.PlayerProfile();
            profile.date_from = txtFrom.Text;
            profile.date_to = txtTo.Text;
            profile.matches = lblMatches.Text;
            profile.balls_faced = lblBallsFaced.Text;
            profile.runs_scored = lblRunsScored.Text;
            profile.not_outs = lblNotOuts.Text;
            profile.average = lblAverage.Text;
            profile.strike_rate = lblStrikeRate.Text;
            profile.high_score = lblHighScore.Text;
            profile.overs_bowled = lblOversBowled.Text;
            profile.maidens = lblMaidens.Text;
            profile.runs_conceeded = lblRunsConceeded.Text;
            profile.wickets = lblWickets.Text;
            profile.economy = lblEconomy.Text;
            profile.student_id = student_id;
            profile.ShowDialog();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
