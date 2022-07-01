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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtConfirmPass.Text=="" || txtFullName.Text=="" || txtPass.Text=="" || txtUsername.Text == "")
                {
                    MessageBox.Show("Please enter all details.");
                    return;
                }
                if (txtPass.Text != txtConfirmPass.Text)
                {
                    MessageBox.Show("Passwords didn't match.");
                    return;
                }

                string sql = "INSERT INTO users(full_name,username,password) VALUES ('" + txtFullName.Text + "','" + txtUsername.Text + "','" + txtPass.Text + "')";
                Library.DataAccessLayer.Instance.ExecuteNonQuery(sql);
                MessageBox.Show("User inserted successfully.");
                txtPass.Text = txtUsername.Text = txtFullName.Text = txtConfirmPass.Text = "";
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
