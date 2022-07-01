using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CricketAcademy.User
{
    public partial class EditUser : Form
    {
        public string user_id = "";
        public EditUser()
        {
            InitializeComponent();
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT * FROM users WHERE user_id='" + user_id + "'";
                DataTable dt = Library.DataAccessLayer.Instance.ExecuteQuery(sql);
                txtFullName.Text = dt.Rows[0]["full_name"].ToString();
                txtUsername.Text = dt.Rows[0]["username"].ToString();
                txtPass.Text=txtConfirmPass.Text = dt.Rows[0]["password"].ToString();
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
                if (txtConfirmPass.Text == "" || txtFullName.Text == "" || txtPass.Text == "" || txtUsername.Text == "")
                {
                    MessageBox.Show("Please enter all details.");
                    return;
                }
                if (txtPass.Text != txtConfirmPass.Text)
                {
                    MessageBox.Show("Passwords didn't match.");
                    return;
                }

                string sql = "UPDATE users SET full_name='"+ txtFullName.Text +"',username='"+ txtUsername.Text +"',password='"+ txtPass.Text +"' WHERE user_id='"+ user_id +"'";
                Library.DataAccessLayer.Instance.ExecuteNonQuery(sql);
                MessageBox.Show("User updated successfully.");
                this.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
