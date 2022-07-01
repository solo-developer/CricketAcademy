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
    public partial class Stock_Manipulation : Form
    {
        public Stock_Manipulation()
        {
            InitializeComponent();
        }

        private void Stock_Manipulation_Load(object sender, EventArgs e)
        {
            loadStock();
        }

        private void loadStock()
        {
            try
            {
                string sql = "SELECT * FROM stock";
                DataTable dt = Library.DataAccessLayer.Instance.ExecuteQuery(sql);
                cmbItem.DataSource = dt;
                cmbItem.DisplayMember = "stock_name";
                cmbItem.ValueMember = "stock_id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbItem.SelectedIndex == -1)
                {
                    MessageBox.Show("Please choose a stock item.");
                    return;
                }
                if(cmbOperation.SelectedIndex==-1)
                {
                    MessageBox.Show("Please choose a operation type.");
                    return;
                }
                if (Convert.ToDecimal(txtQty.Text) <= 0)
                {
                    MessageBox.Show("Quantity cannot be less than or equal to zero.");
                    return;
                }
                Library.DataAccessLayer.Instance.BeginTransaction();
                Library.DateConverter dc = new Library.DateConverter();
                string sql = "INSERT INTO stock_manipulation(stock_id,qty,manipulated_date,nep_date,description,manipulation_type) VALUES ('" + cmbItem.SelectedValue + "','" + txtQty.Text + "','" + DateTime.Now + "','" + dc.ToBS(DateTime.Now) + "','" + txtDescription.Text + "','" + cmbOperation.SelectedIndex + "')";
                Library.DataAccessLayer.Instance.ExecuteNonQuery(sql);

                //update stock item
                if (cmbOperation.SelectedIndex == 0)
                    sql = "UPDATE stock SET qty=qty+" + txtQty.Text + " WHERE stock_id='" + cmbItem.SelectedValue + "'";
                else
                    sql = "UPDATE stock SET qty=qty-" + txtQty.Text + " WHERE stock_id='" + cmbItem.SelectedValue + "'";

                Library.DataAccessLayer.Instance.ExecuteNonQuery(sql);
                MessageBox.Show("Stock manipulated successfully");
                cmbOperation.SelectedIndex = -1;
                cmbItem.SelectedIndex = -1;
                txtDescription.Text = "";
                txtQty.Text = "0";
                Library.DataAccessLayer.Instance.CommitTransaction();
            }
            catch (Exception ex)
            {
                Library.DataAccessLayer.Instance.RollbackTransaction();
                MessageBox.Show(ex.Message);
               
            }
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDecimal(txtQty.Text);
            }
            catch (Exception)
            {

                txtQty.Text = "0";
            }
        }
    }
}
