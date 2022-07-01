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
    public partial class Stock : Form
    {
        private int update_id = 0;
        public Stock()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtName.Text))
                {
                    MessageBox.Show("Please enter stock name.");
                    return;
                }
                string sql = "SELECT stock_id FROM stock WHERE stock_name='" + txtName.Text + "'";
                if (Library.DataAccessLayer.Instance.ExecuteQuery(sql).Rows.Count > 0)
                {
                    MessageBox.Show("Stock item with same name already exists.");
                    return;
                }

                if (update_id == 0)
                    sql = "INSERT INTO stock(stock_name,description,qty) VALUES ('" + txtName.Text + "','" + txtDescription.Text + "','"+ txtQty.Text +"')";
                else
                    sql = "UPDATE stock SET stock_name='"+ txtName.Text +"',description='"+ txtDescription.Text +"' WHERE stock_id='"+ update_id +"'";

                Library.DataAccessLayer.Instance.ExecuteNonQuery(sql);
                MessageBox.Show("Stock item manipulated successfully.");
                txtName.Text = "";
                txtDescription.Text = "";
                txtQty.Text = "0";
                txtQty.ReadOnly = false;

                loadData();
                update_id = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddStock_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            try
            {
                string sql = "SELECT * FROM stock";
                DataTable dt = Library.DataAccessLayer.Instance.ExecuteQuery(sql);
                viewAll.DataSource = dt;
                viewAll.Columns["stock_id"].Visible = false;
                viewAll.Columns["stock_name"].HeaderText = "Stock Item";
                viewAll.Columns["description"].HeaderText = "Description";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (viewAll.SelectedRows.Count == 0)
                return;
            btnSave.Text = "Update";
            update_id = Convert.ToInt32(viewAll.SelectedRows[0].Cells["stock_id"].Value);
            txtName.Text = viewAll.SelectedRows[0].Cells["stock_name"].Value.ToString();
            txtDescription.Text = viewAll.SelectedRows[0].Cells["description"].Value.ToString();
            txtQty.ReadOnly = true;
        }
    }
}
