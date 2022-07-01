using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CricketAcademy.Tournament
{
    public partial class MatchSummary : Form
    {
        Library.DateConverter dc = new Library.DateConverter();
        public MatchSummary()
        {
            InitializeComponent();
        }

        private void MatchSummary_Load(object sender, EventArgs e)
        {
            txtMatchDate.Text = dc.ToBS(DateTime.Now);
            cmbWinner.SelectedIndex = 0;
            cmbToss.SelectedIndex = 0;
            cmbChoice.SelectedIndex = 0;
            this.cmbTournament.SelectedIndexChanged -= new EventHandler(this.cmbTournament_SelectedIndexChanged);
            loadTournaments();
            this.cmbTournament.SelectedIndexChanged += new EventHandler(this.cmbTournament_SelectedIndexChanged);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                #region validation
                if (cmbTournament.SelectedIndex < 0)
                {
                    MessageBox.Show("Tournament must be selected.");
                    return;
                }

                if (cmbTeam.SelectedIndex < 0)
                {
                    MessageBox.Show("Team must be selected.");
                    return;
                }

                if (cmbOpposition.SelectedIndex < 0)
                {
                    MessageBox.Show("Opposition Team must be selected.");
                    return;
                }

                if (cmbToss.SelectedIndex < 0)
                {
                    MessageBox.Show("Toss detail must be provided.");
                    return;
                }

                if (cmbChoice.SelectedIndex < 0)
                {
                    MessageBox.Show("Choice after toss must be selected.");
                    return;
                }
                DateTime matchDate = DateTime.Now;
                try
                {
                    matchDate = dc.ToAD(txtMatchDate.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid match date.Please enter date in MM/dd/yyyy format.");
                    return;
                }

                if (numBallsBatted.Value > 6 || numBallsBowled.Value > 6 || numWicketsLost.Value > 10 || numWicketsTaken.Value > 10)
                {
                    MessageBox.Show("Invalid batting/bowling details.");
                    return;
                }

                if (cmbTeam.SelectedValue == cmbOpposition.SelectedValue)
                {
                    MessageBox.Show("Opposition and team cannot be same.");
                    return;
                }

                #endregion

                #region  insertion

                MatchDetail detail = new MatchDetail();
                detail.team_id = Convert.ToDecimal(cmbTeam.SelectedValue);
                detail.opposition_team_id = Convert.ToDecimal(cmbOpposition.SelectedValue);

                detail.team_id = Convert.ToDecimal(cmbTeam.SelectedValue);

                detail.is_toss_won = cmbToss.SelectedIndex == 0;
                detail.is_bowling_first = cmbChoice.SelectedIndex == 1;

                if (cmbWinner.SelectedIndex == 0)
                    detail.match_result = Enums.Result.won;
                else if (cmbWinner.SelectedIndex == 0)
                    detail.match_result = Enums.Result.lost;
                else
                    detail.match_result = Enums.Result.draw;

                detail.match_date = matchDate;
                detail.nep_match_date = txtMatchDate.Text;

                detail.balls_batted = (int)numBallsBatted.Value;
                detail.overs_batted = (int)numOversBatted.Value;
                detail.wickets_lost = (int)numWicketsLost.Value;
                detail.runs_scored = (int)numRunsScored.Value;

                detail.balls_bowled = (int)numBallsBowled.Value;
                detail.overs_bowled = (int)numOversBowled.Value;
                detail.wickets_taken = (int)numWicketsTaken.Value;
                detail.runs_conceeded = (int)numRunsConceeded.Value;

                MatchDetailModel.save(detail);
                #endregion

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadTournaments()
        {
            try
            {
                string sql = "SELECT tournament_id,name FROM tournament ORDER BY tournament_id DESC";
                DataTable dt = Library.DataAccessLayer.Instance.ExecuteQuery(sql);
                cmbTournament.DataSource = dt;

                cmbTournament.DisplayMember = "name";
                cmbTournament.ValueMember = "tournament_id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbTournament_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadTeams();
        }

        private void loadTeams()
        {
            try
            {
                string sql = "SELECT tournament_team_id,name FROM tournament_team WHERE tournament_id='" + cmbTournament.SelectedValue + "'";
                DataTable teamDt = Library.DataAccessLayer.Instance.ExecuteQuery(sql);
                DataTable oppositionDt = Library.DataAccessLayer.Instance.ExecuteQuery(sql);
                cmbTeam.DataSource = teamDt;

                cmbTeam.DisplayMember = "name";
                cmbTeam.ValueMember = "tournament_team_id";

                cmbOpposition.DataSource = oppositionDt;

                cmbOpposition.DisplayMember = "name";
                cmbOpposition.ValueMember = "tournament_team_id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
