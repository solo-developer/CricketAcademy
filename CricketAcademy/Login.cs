using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CricketAcademy
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text == "")
                {
                    MessageBox.Show("Please enter username.");
                    return;
                }
                if (txtPass.Text == "")
                {
                    MessageBox.Show("Please enter password.");
                    return;
                }

                string sql = "SELECT user_id FROM users WHERE username='" + txtUsername.Text + "' AND password='" + txtPass.Text + "'";
                if (Library.DataAccessLayer.Instance.ExecuteQuery(sql).Rows.Count > 0)
                {
                    MainForm f = new MainForm();
                    f.ShowDialog();
                    this.Hide();
                }
                else{
                    MessageBox.Show("Username and passwords didn't match.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
