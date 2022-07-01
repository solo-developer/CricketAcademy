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
    public partial class EditTeam : Form
    {
        public string tournament_team_id = "";
        public EditTeam()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            #region  validation
            if (string.IsNullOrWhiteSpace(txtTeamName.Text))
            {
                MessageBox.Show("Team name is required.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPlace.Text))
            {
                MessageBox.Show("Team place is required.");
                return;
            }

            if (cmbTournament.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a tournament.");
                return;
            }
            #endregion
            try
            {
                string sql = "UPDATE tournament_team SET name='" + txtTeamName.Text + "',place='" + txtPlace.Text + "',tournament_id='" + cmbTournament.SelectedValue + "' WHERE tournament_team_id='" + tournament_team_id + "'";
                Library.DataAccessLayer.Instance.ExecuteNonQuery(sql);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditTeam_Load(object sender, EventArgs e)
        {
            try
            {
                loadTournaments();
                string sql = "SELECT * FROM tournament_team WHERE tournament_team_id='" + tournament_team_id + "'";
                DataTable dt = Library.DataAccessLayer.Instance.ExecuteQuery(sql);

                DataRow dr = dt.Rows[0];
                txtPlace.Text = dr["place"].ToString();
                txtTeamName.Text = dr["name"].ToString();
                cmbTournament.SelectedValue = dr["tournament_id"];
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
    }
}
