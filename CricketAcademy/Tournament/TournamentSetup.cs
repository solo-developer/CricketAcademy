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
    public partial class TournamentSetup : Form
    {
        Library.DateConverter dc = new Library.DateConverter();
        public TournamentSetup()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Are you sure to add tournament? Please make sure before proceeding.","Confirm!!",MessageBoxButtons.YesNo);
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

                #region insertion
                string sql = "INSERT INTO tournament(name,location,start_date,end_date,eng_start_date,eng_end_date,first_price,second_price,overs) VALUES ('" + txtTournamentName.Text + "','" + txtLocation.Text + "','" + txtStartDate.Text + "','" + txtEndDate.Text + "','" + startDate + "','" + endDate + "','" + numFirst.Text + "','" + numSecond.Text + "','"+ txtOvers.Text +"')";
                Library.DataAccessLayer.Instance.ExecuteNonQuery(sql);

                #endregion
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtTournamentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtEndDate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtStartDate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void numFirst_TextChanged(object sender, EventArgs e)
        {

        }

        private void numSecond_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
