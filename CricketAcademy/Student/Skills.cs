using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CricketAcademy.Student
{
    public partial class Skills : Form
    {
        private bool is_skill_edit_enabled = false;
        private bool is_type_edit_enabled = false;
        private int skill_edit_id = 0;
        private int type_edit_id = 0;
        public Skills()
        {
            InitializeComponent();
        }

        private void btnSkillSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSkill.Text == "")
                {
                    MessageBox.Show("Name cannot be empty.");
                    return;
                }

                if (isSkillWithTheNameExists(txtSkill.Text))
                {
                    MessageBox.Show("Skill with the same name already exists.");
                    return;
                }
                string sql = "";
                if (skill_edit_id == 0)
                {
                    sql = "INSERT INTO skill(skill_name) VALUES ('" + txtSkill.Text + "')";
                }
                else
                    sql = "UPDATE skill SET skill_name='"+ txtSkill.Text +"' WHERE skill_id='"+ skill_edit_id +"'";
                Library.DataAccessLayer.Instance.ExecuteNonQuery(sql);
                MessageBox.Show("Operation performed successfully");
                txtSkill.Text = "";
                loadSkills();
                loadComboBox();
                skill_edit_id = 0;
                btnSkillSave.Text = "Save";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool isSkillWithTheNameExists(string name = "")
        {
            try
            {
                string sql = "SELECT * FROM skill where skill_name='" + name + "'";
                DataTable dt = Library.DataAccessLayer.Instance.ExecuteQuery(sql);
                if (dt.Rows.Count > 0)
                    return true;
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnSkillTypeSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbSkill.SelectedIndex == -1)
                {
                    MessageBox.Show("Please choose a skill.");
                    return;
                }

                if(txtSkillType.Text == "")
                {
                    MessageBox.Show("Name cannot be empty.");
                    return;
                }
                if (isSkillTypeWithSameNameExists(txtSkillType.Text,Convert.ToInt32(cmbSkill.SelectedValue)))
                {
                    MessageBox.Show("Skill type with the same name already exists.");
                    return;
                }
                string sql = "";
                if (type_edit_id==0)
                {
                    sql = "INSERT INTO skill_type(skill_type_name,skill_id) VALUES ('" + txtSkillType.Text + "','" + cmbSkill.SelectedValue + "')";
                }

                else
                {
                    sql = "UPDATE skill_type SET skill_type_name='" + txtSkillType.Text + "',skill_id='" + cmbSkill.SelectedValue + "' WHERE skill_type_id='" + type_edit_id + "'";
                }
                Library.DataAccessLayer.Instance.ExecuteNonQuery(sql);
                MessageBox.Show("Operation performed successfully");
                txtSkillType.Text = "";
                loadSkillTypes();
                btnSkillTypeSave.Text = "Save";
                type_edit_id = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool isSkillTypeWithSameNameExists(string skill_type_name,int skill_id)
        {
            try
            {
                string sql = "SELECT * FROM skill_type where skill_type_name='" + skill_type_name + "' AND skill_id='"+ skill_id +"'";
                DataTable dt = Library.DataAccessLayer.Instance.ExecuteQuery(sql);
                if (dt.Rows.Count > 0)
                    return true;
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Skills_Load(object sender, EventArgs e)
        {
            try
            {
                loadSkills();
                loadSkillTypes();
                loadComboBox();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadComboBox()
        {
            string sql = "SELECT * FROM skill";
            DataTable dt = Library.DataAccessLayer.Instance.ExecuteQuery(sql);
            cmbSkill.DataSource = dt;
            cmbSkill.DisplayMember = "skill_name";
            cmbSkill.ValueMember = "skill_id";
        }

        private void loadSkills(string filter="")
        {
            try
            {
                string sql = "SELECT * from skill WHERE 1=1";
                if (filter != "")
                    sql += " AND skill_name LIKE '" + filter + "%'";

                DataTable dt = Library.DataAccessLayer.Instance.ExecuteQuery(sql);
                viewSkill.DataSource = dt;
                viewSkill.Columns["skill_id"].Visible = false;
                viewSkill.Columns["skill_name"].HeaderText = "Skill Name";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadSkillTypes(string filter = "")
        {
            try
            {
                string sql = "SELECT skill_type_id,skill_type.skill_id,skill_type_name,skill_name from skill_type INNER JOIN skill ON skill.skill_id=skill_type.skill_id WHERE 1=1";
                if (filter != "")
                    sql += " AND skill_type_name LIKE '" + filter + "%'";

                DataTable dt = Library.DataAccessLayer.Instance.ExecuteQuery(sql);
                viewType.DataSource = dt;
                viewType.Columns["skill_id"].Visible = false;
                viewType.Columns["skill_type_id"].Visible = false;
                viewType.Columns["skill_name"].HeaderText = "Skill Name";
                viewType.Columns["skill_type_name"].HeaderText = "Skill Type";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSkillEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (viewSkill.SelectedRows.Count == 0)
                    return;
                is_skill_edit_enabled = true;
                skill_edit_id = Convert.ToInt32(viewSkill.SelectedRows[0].Cells["skill_id"].Value);
                txtSkill.Text = viewSkill.SelectedRows[0].Cells["skill_name"].Value.ToString();
                btnSkillSave.Text = "Update";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSkillDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (viewSkill.SelectedRows.Count == 0)
                    return;
                string sql = "SELECT skill_id FROM skill_type WHERE skill_id='" + viewSkill.SelectedRows[0].Cells["skill_id"].Value + "'";
                if(Library.DataAccessLayer.Instance.ExecuteQuery(sql).Rows.Count>0)
                {
                    MessageBox.Show("This skill has skill type in it. Please delete all the types in this skill in order to delete this skill.");
                    return;
                }
                sql = "DELETE FROM skill WHERE skill_id='" + viewSkill.SelectedRows[0].Cells["skill_id"].Value + "'";
                Library.DataAccessLayer.Instance.ExecuteNonQuery(sql);
                MessageBox.Show("Skill deleted successfully.");
                loadSkills();
                loadComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTypeEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (viewType.SelectedRows.Count == 0)
                    return;

                is_type_edit_enabled = true;
                type_edit_id = Convert.ToInt32(viewType.SelectedRows[0].Cells["skill_type_id"].Value);
                txtSkillType.Text = viewType.SelectedRows[0].Cells["skill_type_name"].Value.ToString();
                cmbSkill.SelectedValue = Convert.ToInt32(viewType.SelectedRows[0].Cells["skill_id"].Value);
                btnSkillTypeSave.Text = "Update";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTypeDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (viewType.SelectedRows.Count == 0)
                    return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
