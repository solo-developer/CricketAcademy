namespace CricketAcademy.Student
{
    partial class Skills
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Skills));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSkillSave = new System.Windows.Forms.Button();
            this.txtSkill = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSkill = new System.Windows.Forms.ComboBox();
            this.btnSkillTypeSave = new System.Windows.Forms.Button();
            this.txtSkillType = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSkillEdit = new System.Windows.Forms.Button();
            this.btnSkillDelete = new System.Windows.Forms.Button();
            this.viewSkill = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnTypeEdit = new System.Windows.Forms.Button();
            this.btnTypeDelete = new System.Windows.Forms.Button();
            this.viewType = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewSkill)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewType)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(260, 431);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(260, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(486, 431);
            this.splitter2.TabIndex = 1;
            this.splitter2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSkillSave);
            this.groupBox1.Controls.Add(this.txtSkill);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 168);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Skill";
            // 
            // btnSkillSave
            // 
            this.btnSkillSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSkillSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkillSave.Image = global::CricketAcademy.Properties.Resources.floppy_disc_green_copy;
            this.btnSkillSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSkillSave.Location = new System.Drawing.Point(65, 80);
            this.btnSkillSave.Name = "btnSkillSave";
            this.btnSkillSave.Size = new System.Drawing.Size(135, 43);
            this.btnSkillSave.TabIndex = 4;
            this.btnSkillSave.Text = "    &Save";
            this.btnSkillSave.UseVisualStyleBackColor = false;
            this.btnSkillSave.Click += new System.EventHandler(this.btnSkillSave_Click);
            // 
            // txtSkill
            // 
            this.txtSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSkill.Location = new System.Drawing.Point(5, 33);
            this.txtSkill.Name = "txtSkill";
            this.txtSkill.Size = new System.Drawing.Size(236, 30);
            this.txtSkill.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbSkill);
            this.groupBox2.Controls.Add(this.btnSkillTypeSave);
            this.groupBox2.Controls.Add(this.txtSkillType);
            this.groupBox2.Location = new System.Drawing.Point(7, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 238);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Skill type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Skill";
            // 
            // cmbSkill
            // 
            this.cmbSkill.FormattingEnabled = true;
            this.cmbSkill.Location = new System.Drawing.Point(14, 54);
            this.cmbSkill.Name = "cmbSkill";
            this.cmbSkill.Size = new System.Drawing.Size(227, 32);
            this.cmbSkill.TabIndex = 4;
            // 
            // btnSkillTypeSave
            // 
            this.btnSkillTypeSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSkillTypeSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkillTypeSave.Image = global::CricketAcademy.Properties.Resources.floppy_disc_green_copy;
            this.btnSkillTypeSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSkillTypeSave.Location = new System.Drawing.Point(74, 157);
            this.btnSkillTypeSave.Name = "btnSkillTypeSave";
            this.btnSkillTypeSave.Size = new System.Drawing.Size(135, 43);
            this.btnSkillTypeSave.TabIndex = 6;
            this.btnSkillTypeSave.Text = "    &Save";
            this.btnSkillTypeSave.UseVisualStyleBackColor = false;
            this.btnSkillTypeSave.Click += new System.EventHandler(this.btnSkillTypeSave_Click);
            // 
            // txtSkillType
            // 
            this.txtSkillType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSkillType.Location = new System.Drawing.Point(14, 125);
            this.txtSkillType.Name = "txtSkillType";
            this.txtSkillType.Size = new System.Drawing.Size(227, 30);
            this.txtSkillType.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSkillEdit);
            this.groupBox3.Controls.Add(this.btnSkillDelete);
            this.groupBox3.Controls.Add(this.viewSkill);
            this.groupBox3.Location = new System.Drawing.Point(266, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(480, 168);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Skill";
            // 
            // btnSkillEdit
            // 
            this.btnSkillEdit.Image = global::CricketAcademy.Properties.Resources.file_edit21;
            this.btnSkillEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSkillEdit.Location = new System.Drawing.Point(241, 9);
            this.btnSkillEdit.Name = "btnSkillEdit";
            this.btnSkillEdit.Size = new System.Drawing.Size(108, 38);
            this.btnSkillEdit.TabIndex = 3;
            this.btnSkillEdit.Text = "            Edit";
            this.btnSkillEdit.UseVisualStyleBackColor = true;
            this.btnSkillEdit.Click += new System.EventHandler(this.btnSkillEdit_Click);
            // 
            // btnSkillDelete
            // 
            this.btnSkillDelete.Image = global::CricketAcademy.Properties.Resources.delete_icon;
            this.btnSkillDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSkillDelete.Location = new System.Drawing.Point(366, 9);
            this.btnSkillDelete.Name = "btnSkillDelete";
            this.btnSkillDelete.Size = new System.Drawing.Size(108, 38);
            this.btnSkillDelete.TabIndex = 2;
            this.btnSkillDelete.Text = "         Delete";
            this.btnSkillDelete.UseVisualStyleBackColor = true;
            this.btnSkillDelete.Click += new System.EventHandler(this.btnSkillDelete_Click);
            // 
            // viewSkill
            // 
            this.viewSkill.AllowUserToAddRows = false;
            this.viewSkill.AllowUserToDeleteRows = false;
            this.viewSkill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewSkill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewSkill.Location = new System.Drawing.Point(6, 49);
            this.viewSkill.Name = "viewSkill";
            this.viewSkill.ReadOnly = true;
            this.viewSkill.RowHeadersWidth = 51;
            this.viewSkill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewSkill.Size = new System.Drawing.Size(468, 113);
            this.viewSkill.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnTypeEdit);
            this.groupBox4.Controls.Add(this.btnTypeDelete);
            this.groupBox4.Controls.Add(this.viewType);
            this.groupBox4.Location = new System.Drawing.Point(266, 181);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(480, 250);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Skill type";
            // 
            // btnTypeEdit
            // 
            this.btnTypeEdit.Image = global::CricketAcademy.Properties.Resources.file_edit21;
            this.btnTypeEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTypeEdit.Location = new System.Drawing.Point(241, 10);
            this.btnTypeEdit.Name = "btnTypeEdit";
            this.btnTypeEdit.Size = new System.Drawing.Size(108, 38);
            this.btnTypeEdit.TabIndex = 5;
            this.btnTypeEdit.Text = "             Edit";
            this.btnTypeEdit.UseVisualStyleBackColor = true;
            this.btnTypeEdit.Click += new System.EventHandler(this.btnTypeEdit_Click);
            // 
            // btnTypeDelete
            // 
            this.btnTypeDelete.Image = global::CricketAcademy.Properties.Resources.delete_icon;
            this.btnTypeDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTypeDelete.Location = new System.Drawing.Point(366, 10);
            this.btnTypeDelete.Name = "btnTypeDelete";
            this.btnTypeDelete.Size = new System.Drawing.Size(108, 38);
            this.btnTypeDelete.TabIndex = 4;
            this.btnTypeDelete.Text = "          Delete";
            this.btnTypeDelete.UseVisualStyleBackColor = true;
            this.btnTypeDelete.Click += new System.EventHandler(this.btnTypeDelete_Click);
            // 
            // viewType
            // 
            this.viewType.AllowUserToAddRows = false;
            this.viewType.AllowUserToDeleteRows = false;
            this.viewType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewType.Location = new System.Drawing.Point(6, 54);
            this.viewType.Name = "viewType";
            this.viewType.ReadOnly = true;
            this.viewType.RowHeadersWidth = 51;
            this.viewType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewType.Size = new System.Drawing.Size(468, 190);
            this.viewType.TabIndex = 0;
            // 
            // Skills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 431);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Skills";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skills";
            this.Load += new System.EventHandler(this.Skills_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewSkill)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.TextBox txtSkill;
        private System.Windows.Forms.Button btnSkillSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSkill;
        private System.Windows.Forms.Button btnSkillTypeSave;
        internal System.Windows.Forms.TextBox txtSkillType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView viewSkill;
        private System.Windows.Forms.DataGridView viewType;
        private System.Windows.Forms.Button btnSkillEdit;
        private System.Windows.Forms.Button btnSkillDelete;
        private System.Windows.Forms.Button btnTypeEdit;
        private System.Windows.Forms.Button btnTypeDelete;
    }
}