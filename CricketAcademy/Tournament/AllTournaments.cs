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
    public partial class AllTournaments : Form
    {
        Library.DateConverter dc = new Library.DateConverter();
        public AllTournaments()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void AllTournaments_Load(object sender, EventArgs e)
        {
            txtFrom.Text = dc.ToBS(DateTime.Now.AddMonths(-2));
            txtTo.Text = dc.ToBS(DateTime.Now);
        }

        private void loadData()
        {
            DateTime dateFrom = DateTime.Now;
            DateTime dateTo = DateTime.Now;
            try
            {
                dateFrom = dc.ToAD(txtFrom.Text);
                dateTo = dc.ToAD(txtTo.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid date. Date should be in MM/dd/yyyy format.");
                return;
            }
            try
            {
                string sql = "SELECT * FROM tournament WHERE 1=1";
                sql += " AND eng_start_date >='" + dateFrom + "' AND eng_start_date<='" + dateTo + "'";
                if (!string.IsNullOrWhiteSpace(txtTournament.Text))
                {
                    sql += " AND name LIKE '%" + txtTournament.Text + "%'";
                }
                DataTable dt = Library.DataAccessLayer.Instance.ExecuteQuery(sql);
                this.viewAll.DataSource = dt;
                viewAll.Columns["tournament_id"].Visible = false;
                viewAll.Columns["eng_start_date"].Visible = false;
                viewAll.Columns["eng_end_date"].Visible = false;
                viewAll.Columns["name"].HeaderText = "Tournament Name";
                viewAll.Columns["location"].HeaderText = "Location";
                viewAll.Columns["start_date"].HeaderText = "Start Date";
                viewAll.Columns["end_date"].HeaderText = "End Date";
                viewAll.Columns["first_price"].HeaderText = "First Prize";
                viewAll.Columns["second_price"].HeaderText = "Second Prize";

            }
            catch (Exception)
            {
                MessageBox.Show("Failed to load data.");
            }
        }

        private void txtTournament_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (viewAll.SelectedRows.Count == 0)
                return;
            EditTournament ed = new EditTournament();
            Int64 tournamentId = Convert.ToInt64(viewAll.SelectedRows[0].Cells["tournament_id"].Value);
            ed.tournamentId = tournamentId;
            ed.ShowDialog();
            loadData();
        }

        private void btnRanking_Click(object sender, EventArgs e)
        {
            if (viewAll.SelectedRows.Count == 0)
                return;
            Rankings ed = new Rankings();
            string tournamentId = viewAll.SelectedRows[0].Cells["tournament_id"].Value.ToString();
            ed.tournamentId = tournamentId;
            ed.ShowDialog();
        }
    }
}
