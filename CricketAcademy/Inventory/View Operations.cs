using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CricketAcademy.Inventory
{
    public partial class View_Operations : Form
    {
        Library.DateConverter dc = new Library.DateConverter();
        public View_Operations()
        {
            InitializeComponent();
        }

        private void loadStock()
        {
            try
            {
                string sql = "SELECT stock_id,stock_name FROM stock";
                DataTable dt = Library.DataAccessLayer.Instance.ExecuteQuery(sql);
                DataRow dr = dt.NewRow();
                dr[1] = "---Select All---";
                dr[0] = "0";
                dt.Rows.InsertAt(dr, 0);
                cmbItem.DataSource = dt;
                cmbItem.DisplayMember = "stock_name";
                cmbItem.ValueMember = "stock_id";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void View_Operations_Load(object sender, EventArgs e)
        {
            
            txtFrom.Text = txtTo.Text = dc.ToBS(DateTime.Now);
            this.cmbOperation.SelectedIndexChanged -= new System.EventHandler(this.cmbOperation_SelectedIndexChanged);
            this.cmbItem.SelectedIndexChanged -= new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            loadStock();
            this.cmbItem.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cmbOperation.SelectedIndexChanged += new System.EventHandler(this.cmbOperation_SelectedIndexChanged);
            loadData();
            cmbOperation.SelectedIndex = 0;

        }

        private void loadData()
        {
            DateTime from=DateTime.Now;
            DateTime to=DateTime.Now;
            try
            {
                from = dc.ToAD(txtFrom.Text);
                to = dc.ToAD(txtTo.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid date in valid format.");
                return;
            }

            try
            {


                string sql = @"SELECT stock.stock_name as 'Stock Item',
(CASE WHEN manipulation_type=0 THEN 'Purchased'
     WHEN manipulation_type=1 THEN 'Sold' end) as 'Operation Type',
nep_date as 'Date',
stock_manipulation.description as 'Description',
stock_manipulation.qty AS 'Qty' FROM stock_manipulation INNER JOIN stock ON stock.stock_id=stock_manipulation.stock_id WHERE 1=1
";
                if (cmbOperation.SelectedIndex != 0)
                    sql += " AND manipulation_type=" + cmbOperation.SelectedIndex + "-1 ";
                if (cmbItem.SelectedIndex > 0)
                    sql += " AND stock_manipulation.stock_id='" + cmbItem.SelectedValue + "'";

                sql += " AND stock_manipulation.manipulated_date BETWEEN '" + from.AddDays(-1) + "' AND '" + to.AddDays(1) + "'";

                DataTable dt = Library.DataAccessLayer.Instance.ExecuteQuery(sql);
                viewAll.DataSource = dt;
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
