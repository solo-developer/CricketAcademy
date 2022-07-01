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
    public partial class View_Users : Form
    {
        public View_Users()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadUsers()
        {
            try
            {
                string sql = "SELECT user_id,full_name AS 'Person Name',username AS 'User Name' FROM users";
                DataTable dt = Library.DataAccessLayer.Instance.ExecuteQuery(sql);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["user_id"].Visible = false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void View_Users_Load(object sender, EventArgs e)
        {
            loadUsers();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUser u = new AddUser();
            u.ShowDialog();
            loadUsers();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;
            EditUser u = new EditUser();
            u.user_id = dataGridView1.SelectedRows[0].Cells["user_id"].Value.ToString();
            u.ShowDialog();
            loadUsers();
        }
    }
}
