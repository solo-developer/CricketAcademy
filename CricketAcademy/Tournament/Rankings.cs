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
    public partial class Rankings : Form
    {
        public string tournamentId = "";
        public Rankings()
        {
            InitializeComponent();
        }

        private void Rankings_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT name FROM tournament WHERE tournament_id='" + tournamentId + "'";
                label1.Text = Library.DataAccessLayer.Instance.ExecuteScalar(sql);
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadData()
        {
            string sql = "SELECT ranking.tournament_team_id, tournament_team.name AS 'Team',tournament_team.place AS 'Place',ranking.matches_played AS 'Matches Played',ranking.won AS 'Won',ranking.lost AS 'Lost',ranking.draw AS 'Drawn',ranking.points AS 'Points',ranking.net_run_rate AS 'Run Rate' from ranking inner join tournament_team on tournament_team.tournament_team_id=ranking.tournament_team_id WHERE tournament_team.tournament_id='"+ tournamentId +"' ORDER BY points DESC,net_run_rate DESC";

            DataTable dt = Library.DataAccessLayer.Instance.ExecuteQuery(sql);
            viewAll.DataSource = dt;
            viewAll.Columns["tournament_team_id"].Visible = false;
        }
    }
}
