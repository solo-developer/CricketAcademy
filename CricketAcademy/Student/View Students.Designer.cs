namespace CricketAcademy.Student
{
    partial class View_Students
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Students));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbSkills = new System.Windows.Forms.ComboBox();
            this.btnAge = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnForm = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.viewAll = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewAll)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cmbSkills);
            this.panel1.Controls.Add(this.btnAge);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnForm);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.cmbType);
            this.panel1.Location = new System.Drawing.Point(9, 7);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(953, 87);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(823, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "Profile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbSkills
            // 
            this.cmbSkills.FormattingEnabled = true;
            this.cmbSkills.Items.AddRange(new object[] {
            "All",
            "Active",
            "InActive"});
            this.cmbSkills.Location = new System.Drawing.Point(146, 32);
            this.cmbSkills.Name = "cmbSkills";
            this.cmbSkills.Size = new System.Drawing.Size(123, 32);
            this.cmbSkills.TabIndex = 4;
            this.cmbSkills.SelectedIndexChanged += new System.EventHandler(this.cmbSkills_SelectedIndexChanged);
            // 
            // btnAge
            // 
            this.btnAge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAge.Location = new System.Drawing.Point(698, 24);
            this.btnAge.Name = "btnAge";
            this.btnAge.Size = new System.Drawing.Size(110, 44);
            this.btnAge.TabIndex = 3;
            this.btnAge.Text = "Get Age";
            this.btnAge.UseVisualStyleBackColor = true;
            this.btnAge.Click += new System.EventHandler(this.btnAge_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(282, 34);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(139, 29);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnForm
            // 
            this.btnForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForm.Location = new System.Drawing.Point(545, 24);
            this.btnForm.Name = "btnForm";
            this.btnForm.Size = new System.Drawing.Size(133, 44);
            this.btnForm.TabIndex = 2;
            this.btnForm.Text = "Generate Form";
            this.btnForm.UseVisualStyleBackColor = true;
            this.btnForm.Click += new System.EventHandler(this.btnForm_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(438, 24);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(101, 44);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "All",
            "Active",
            "InActive"});
            this.cmbType.Location = new System.Drawing.Point(17, 32);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(123, 32);
            this.cmbType.TabIndex = 0;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // viewAll
            // 
            this.viewAll.AllowUserToAddRows = false;
            this.viewAll.AllowUserToDeleteRows = false;
            this.viewAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewAll.Location = new System.Drawing.Point(4, 102);
            this.viewAll.Margin = new System.Windows.Forms.Padding(4);
            this.viewAll.Name = "viewAll";
            this.viewAll.ReadOnly = true;
            this.viewAll.RowHeadersWidth = 51;
            this.viewAll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewAll.Size = new System.Drawing.Size(958, 433);
            this.viewAll.TabIndex = 1;
            this.viewAll.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewAll_CellContentDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 550);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Double click on DataGridRow to view student image";
            // 
            // View_Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 577);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewAll);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "View_Students";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Students";
            this.Load += new System.EventHandler(this.View_Students_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewAll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView viewAll;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnForm;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAge;
        private System.Windows.Forms.ComboBox cmbSkills;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}