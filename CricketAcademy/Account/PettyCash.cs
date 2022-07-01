using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CricketAcademy.Account
{
    public partial class PettyCash : Form
    {
        Library.DateConverter dc = new Library.DateConverter();
        public PettyCash()
        {
            InitializeComponent();
        }

        private void btnIssueSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to make the transaction?", "Confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    return;
                }
                if (Convert.ToDecimal(txtIssueAmount.Text) <= 0)
                {
                    MessageBox.Show("Issued Amount must be more than zero.");
                    return;
                }

                decimal balance = getBalance();
                balance += Convert.ToDecimal(txtIssueAmount.Text);
                string sql = "INSERT INTO PettyCashFund(entered_date,issued_amount,narration,used_amount,balance,nep_entered_date) VALUES ('" + DateTime.Now + "','" + txtIssueAmount.Text + "','" + txtIssueNarration.Text + "',0,'" + balance + "','"+ dc.ToBS(DateTime.Now) +"')";
                Library.DataAccessLayer.Instance.ExecuteNonQuery(sql);
                MessageBox.Show("Transaction recorded successfully.");
                clear();
                loadData();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private decimal getBalance()
        {
            string sql = "SELECT balance FROM PettyCashFund WHERE petty_cash_id=(SELECT MAX(petty_cash_id) FROM PettyCashFund)";
            decimal balance = 0;
            DataTable dt = Library.DataAccessLayer.Instance.ExecuteQuery(sql);
            if (dt.Rows.Count > 0)
                balance = Convert.ToDecimal(dt.Rows[0]["balance"]);
            return balance;
        }


        private void loadData(int cmbType = 0)
        {
            try
            {
                viewAll.Columns["entered_date"].ReadOnly = true;
                viewAll.Columns["income"].ReadOnly = true;
                viewAll.Columns["expenses"].ReadOnly = true;
                viewAll.Columns["balance"].ReadOnly = true;
                viewAll.Rows.Clear();
                string cmdd = "SELECT * FROM PettyCashFund WHERE entered_date BETWEEN '" + DateTimePicker1.Value.Date + "' AND '" + DateTimePicker2.Value.Date.AddDays(1) + "'";
                if (cmbType == 2)
                {
                    cmdd += " AND used_amount=0";
                }

                if (cmbType == 1)
                {
                    cmdd += " AND issued_amount=0";
                }

                if (txtSearch.Text != "")
                    cmdd += " AND narration LIKE '%" + txtSearch.Text + "%'";

                cmdd += "  ORDER BY petty_cash_id ASC";

                DataTable OrderDataTable = Library.DataAccessLayer.Instance.ExecuteQuery(cmdd);
                decimal opening_bal = 0;
                if ((OrderDataTable.Rows.Count > 0))
                {
                    opening_bal = (Convert.ToDecimal(OrderDataTable.Rows[0]["balance"]) - (Convert.ToDecimal(OrderDataTable.Rows[0]["issued_amount"]) - Convert.ToDecimal(OrderDataTable.Rows[0]["used_amount"])));
                }

                if (OrderDataTable.Rows.Count > 0)
                {
                    viewAll.Rows.Add("", "", "Opening balance", "", "", opening_bal);
                }

                decimal total_issued = 0;
                decimal total_used = 0;
                foreach (DataRow dr in OrderDataTable.Rows)
                {
                    string issued_amt = "";
                    string used_amt = "";
                    if (dr["issued_amount"].ToString() != "0.00")
                    {
                        issued_amt = dr["issued_amount"].ToString();
                    }

                    if (dr["used_amount"].ToString() != "0.00")
                    {
                        used_amt = dr["used_amount"].ToString();
                    }

                    if (cmbFormat.SelectedIndex == 0 || cmbFormat.SelectedIndex == -1)
                    {
                        viewAll.Rows.Add(dr["petty_cash_id"], Convert.ToDateTime(dr["entered_date"]).Date.ToString("d"), dr["narration"], issued_amt, used_amt, dr["balance"]);
                    }
                    else
                    {
                        viewAll.Rows.Add(dr["petty_cash_id"], dr["nep_entered_date"].ToString(), dr["narration"], issued_amt, used_amt, dr["balance"]);
                    }

                    total_issued += Convert.ToDecimal(dr["issued_amount"]);
                    total_used += Convert.ToDecimal(dr["used_amount"]);
                }

                if (OrderDataTable.Rows.Count > 0)
                {
                    viewAll.Rows.Add("", "", "Total", total_issued, total_used, "");
                    viewAll.Rows[viewAll.Rows.Count - 1].DefaultCellStyle.Font = new Font(viewAll.DefaultCellStyle.Font.FontFamily, 12, FontStyle.Bold);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load petty cash fund datas.");
            }
        }

        private void PettyCash_Load(object sender, EventArgs e)
        {
            cmbType.SelectedIndex = 0;
            cmbFormat.SelectedIndex = 0;
            loadData();
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData(cmbType.SelectedIndex);
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            cmbType.SelectedIndex = 0;
            loadData();
        }

        private void btnUsageSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to make the transaction?", "Confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    return;
                }
                if (Convert.ToDecimal(txtUsageAmount.Text) <= 0)
                {
                    MessageBox.Show("Issued Amount must be more than zero.");
                    return;
                }

                decimal balance = getBalance();
                balance -= Convert.ToDecimal(txtUsageAmount.Text);
                string sql = "INSERT INTO PettyCashFund(entered_date,issued_amount,narration,used_amount,balance,nep_entered_date) VALUES ('" + DateTime.Now + "',0,'" + txtUsageNarration.Text + "','" + txtUsageAmount.Text + "','" + balance + "','"+ dc.ToBS(DateTime.Now) +"')";
                Library.DataAccessLayer.Instance.ExecuteNonQuery(sql);
                MessageBox.Show("Transaction recorded successfully.");
                clear();
                loadData();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clear()
        {
            txtIssueAmount.Text = "0";
            txtIssueNarration.Text = "";
            txtUsageAmount.Text = "0";
            txtUsageNarration.Text = "";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void viewAll_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Account a = new Account();
            a.dgv = viewAll;
            a.date_from = DateTimePicker1.Value.ToString();
            a.date_to = DateTimePicker2.Value.ToString();
            a.ShowDialog();
        }

        private void viewAll_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void viewAll_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string sql = "UPDATE PettyCashFund SET narration='" + viewAll.SelectedRows[0].Cells["narration"].Value + "' WHERE petty_cash_id='" + viewAll.SelectedRows[0].Cells["petty_cash_id"].Value + "'";
                Library.DataAccessLayer.Instance.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData(cmbType.SelectedIndex);
        }
    }
}
