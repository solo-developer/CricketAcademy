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
    public partial class Add_Team : Form
    {
        public Add_Team()
        {
            InitializeComponent();
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
                Library.DataAccessLayer.Instance.BeginTransaction();
                string sql = "INSERT INTO tournament_team(name,place,tournament_id) VALUES ('" + txtTeamName.Text + "','" + txtPlace.Text + "','" + cmbTournament.SelectedValue + "')";
                Library.DataAccessLayer.Instance.ExecuteNonQuery(sql);

                sql = "SELECT SCOPE_IDENTITY()";
                string tournamentTeamId = Library.DataAccessLayer.Instance.ExecuteScalar(sql);

                sql = "INSERT INTO ranking(tournament_team_id,matches_played,won,lost,draw,points,net_run_rate) VALUES ('" + tournamentTeamId + "','0','0','0','0','0','0')";
                Library.DataAccessLayer.Instance.ExecuteNonQuery(sql);
                Library.DataAccessLayer.Instance.CommitTransaction();
                this.Close();
                Add_Team add = new Add_Team();
                add.ShowDialog();
            }
            catch (Exception ex)
            {
                Library.DataAccessLayer.Instance.RollbackTransaction();
                MessageBox.Show(ex.Message);
            }
        }

        private void Add_Team_Load(object sender, EventArgs e)
        {
            loadTournaments();
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
