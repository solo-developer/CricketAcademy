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
    public partial class All_Teams : Form
    {
        public All_Teams()
        {
            InitializeComponent();
        }

        private void All_Teams_Load(object sender, EventArgs e)
        {
            loadTournaments();
            loadData();
        }

        private void loadTournaments()
        {
            try
            {
                string sql = "SELECT tournament_id,name FROM tournament ORDER BY tournament_id DESC";
                DataTable dt = Library.DataAccessLayer.Instance.ExecuteQuery(sql);
                DataRow dr = dt.NewRow();
                dr["tournament_id"] = "0";
                dr["name"] = "--SELECT--";
                dt.Rows.InsertAt(dr, 0);
                cmbTournament.DataSource = dt;

                cmbTournament.DisplayMember = "name";
                cmbTournament.ValueMember = "tournament_id";
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


                string sql = "SELECT tournament_team_id,tournament_team.name,place,tournament.name AS 'Tournament' FROM tournament_team INNER JOIN tournament ON tournament.tournament_id=tournament_team.tournament_id WHERE 1=1";

                if (cmbTournament.SelectedIndex != 0)
                {
                    sql += " AND tournament_team.tournament_id='" + cmbTournament.SelectedValue + "'";
                }

                DataTable dt = Library.DataAccessLayer.Instance.ExecuteQuery(sql);

                viewAll.DataSource = dt;
                viewAll.Columns["tournament_team_id"].Visible = false;
                viewAll.Columns["name"].HeaderText = "Team Name";
                viewAll.Columns["place"].HeaderText = "Place";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbTournament_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (viewAll.SelectedRows.Count == 0)
                    return;
                string tournament_team_id = viewAll.SelectedRows[0].Cells["tournament_team_id"].Value.ToString();

                string sql = "SELECT * FROM team_match_detail WHERE tournament_team_id='" + tournament_team_id + "'";
                DataTable dt = Library.DataAccessLayer.Instance.ExecuteQuery(sql);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("The specified team has already been involved in at least a game in tournament.");
                    return;
                }
                sql = "DELETE FROM tournament_team WHERE tournament_team_id='" + tournament_team_id + "'";
                Library.DataAccessLayer.Instance.ExecuteNonQuery(sql);

                sql = "DELETE FROM ranking WHERE tournament_team_id='" + tournament_team_id + "'";
                Library.DataAccessLayer.Instance.ExecuteNonQuery(sql);

                MessageBox.Show("Team removed successfully from tournament.");
                loadData();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (viewAll.SelectedRows.Count == 0)
                return;
            string tournament_team_id = viewAll.SelectedRows[0].Cells["tournament_team_id"].Value.ToString();

            EditTeam edit = new EditTeam();
            edit.tournament_team_id = tournament_team_id;
            edit.ShowDialog();
            loadData();
        }
    }
}
