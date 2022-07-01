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
    public partial class EditTournament : Form
    {
        public Int64 tournamentId;
        Library.DateConverter dc = new Library.DateConverter();
        public EditTournament()
        {
            InitializeComponent();
        }

        private void EditTournament_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT * FROM tournament WHERE tournament_id='" + tournamentId + "'";
                DataTable dt = Library.DataAccessLayer.Instance.ExecuteQuery(sql);

                txtTournamentName.Text = dt.Rows[0]["name"].ToString();
                txtLocation.Text = dt.Rows[0]["location"].ToString();

                txtStartDate.Text = dt.Rows[0]["start_date"].ToString();
                txtEndDate.Text = dt.Rows[0]["end_date"].ToString();

                numFirst.Text = dt.Rows[0]["first_price"].ToString();
                numSecond.Text = dt.Rows[0]["second_price"].ToString();
                txtOvers.Text = dt.Rows[0]["overs"].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to load datas.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Are you sure to edit tournament? Please make sure before proceeding.", "Confirm!!", MessageBoxButtons.YesNo);
                if (dr == DialogResult.No)
                    return;
                DateTime startDate = DateTime.Now;
                DateTime endDate = DateTime.Now;
                #region  validation
                if (string.IsNullOrWhiteSpace(txtTournamentName.Text))
                {
                    MessageBox.Show("Please enter tournament name.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtLocation.Text))
                {
                    MessageBox.Show("Tournament location is required.");
                    return;
                }
                try
                {
                    startDate = dc.ToAD(txtStartDate.Text);
                    endDate = dc.ToAD(txtEndDate.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter valid dates.");
                    return;
                }
                try
                {
                    Convert.ToDecimal(numFirst.Text);
                    Convert.ToDecimal(numSecond.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter valid prize.");
                    return;
                }
                try
                {
                    Convert.ToDecimal(txtOvers.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter valid overs.");
                    return;
                }

                #endregion

                #region update
                string sql = "UPDATE tournament SET name='" + txtTournamentName.Text + "',location='" + txtLocation.Text + "',start_date='" + txtStartDate.Text + "',end_date='" + txtEndDate.Text + "',eng_start_date='" + startDate + "',eng_end_date='" + endDate + "',first_price='" + numFirst.Text + "',second_price='" + numSecond.Text + "',overs='"+txtOvers.Text+"' WHERE tournament_id='" + tournamentId + "'";
                Library.DataAccessLayer.Instance.ExecuteNonQuery(sql);

                #endregion
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
