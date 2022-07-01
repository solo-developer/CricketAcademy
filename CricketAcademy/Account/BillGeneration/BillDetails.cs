using System;
using System.Windows.Forms;

namespace CricketAcademy.Account.BillGeneration
{
    public partial class BillDetails : Form
    {
        public BillDetails()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtName1.Text) || string.IsNullOrEmpty(txtName2.Text) || string.IsNullOrEmpty(txtName3.Text))
            {
                MessageBox.Show("Student name cannot be empty.");
                return;
            }
            try
            {
                Bills bills = new Bills();
                bills.name1 = txtName1.Text;
                bills.name2 = txtName2.Text;
                bills.name3 = txtName3.Text;

                bills.amount1 = txtAmount1.Text;
                bills.amount2 = txtAmount2.Text;
                bills.amount3 = txtAmount3.Text;

                bills.due1 = txtDue1.Text;
                bills.due2 = txtDue2.Text;
                bills.due3 = txtDue3.Text;

                bills.particualrs2 = txtParticulars2.Text;
                bills.particulars1 = txtParticulars1.Text;
                bills.particulaars3 = txtParticulars3.Text;

                bills.month1 = txtMonth1.Text;
                bills.month2 = txtMonth2.Text;
                bills.month3 = txtMonth3.Text;

                bills.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtDue1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDecimal(txtDue1.Text);
            }
            catch (Exception)
            {

                txtDue1.Text = "0";
            }
        }

        private void txtAmount1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDecimal(txtAmount2.Text);
            }
            catch (Exception)
            {

                txtAmount2.Text = "0";
            }
        }

        private void txtDue2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDecimal(txtDue2.Text);
            }
            catch (Exception)
            {

                txtDue2.Text = "0";
            }
        }

        private void txtAmount2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDecimal(txtAmount2.Text);
            }
            catch (Exception)
            {

                txtAmount2.Text = "0";
            }
        }

        private void txtDue3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDecimal(txtDue3.Text);
            }
            catch (Exception)
            {

                txtDue3.Text = "0";
            }
        }

        private void txtAmount3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDecimal(txtAmount3.Text);
            }
            catch (Exception)
            {

                txtAmount3.Text = "0";
            }
        }
    }
}
