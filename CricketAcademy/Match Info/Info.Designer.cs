namespace CricketAcademy.Match_Info
{
    partial class Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCompetition = new System.Windows.Forms.ComboBox();
            this.txtTo = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStudent = new System.Windows.Forms.ComboBox();
            this.viewAll = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewAll)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmbCompetition);
            this.panel1.Controls.Add(this.txtTo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtFrom);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbStudent);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 87);
            this.panel1.TabIndex = 1;
            // 
            // btnLoad
            // 
            this.btnLoad.Image = global::CricketAcademy.Properties.Resources._14516142_update_icon_on_glossy_orange_round_button_copy;
            this.btnLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoad.Location = new System.Drawing.Point(708, 20);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(119, 53);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "            Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Competition";
            // 
            // cmbCompetition
            // 
            this.cmbCompetition.FormattingEnabled = true;
            this.cmbCompetition.Location = new System.Drawing.Point(169, 45);
            this.cmbCompetition.Name = "cmbCompetition";
            this.cmbCompetition.Size = new System.Drawing.Size(135, 32);
            this.cmbCompetition.TabIndex = 1;
            this.cmbCompetition.SelectedIndexChanged += new System.EventHandler(this.cmbCompetition_SelectedIndexChanged);
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(522, 45);
            this.txtTo.Mask = "00/00/0000";
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(133, 29);
            this.txtTo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(519, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Date to";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(331, 45);
            this.txtFrom.Mask = "00/00/0000";
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(133, 29);
            this.txtFrom.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Date from";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Student";
            // 
            // cmbStudent
            // 
            this.cmbStudent.FormattingEnabled = true;
            this.cmbStudent.Location = new System.Drawing.Point(17, 45);
            this.cmbStudent.Name = "cmbStudent";
            this.cmbStudent.Size = new System.Drawing.Size(135, 32);
            this.cmbStudent.TabIndex = 0;
            this.cmbStudent.SelectedIndexChanged += new System.EventHandler(this.cmbStudent_SelectedIndexChanged);
            // 
            // viewAll
            // 
            this.viewAll.AllowUserToAddRows = false;
            this.viewAll.AllowUserToDeleteRows = false;
            this.viewAll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewAll.Location = new System.Drawing.Point(3, 96);
            this.viewAll.Name = "viewAll";
            this.viewAll.ReadOnly = true;
            this.viewAll.RowHeadersWidth = 51;
            this.viewAll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewAll.Size = new System.Drawing.Size(942, 413);
            this.viewAll.TabIndex = 2;
            this.viewAll.TabStop = false;
            this.viewAll.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewAll_CellContentClick);
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 521);
            this.Controls.Add(this.viewAll);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Info";
            this.Load += new System.EventHandler(this.Info_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewAll)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCompetition;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView viewAll;
    }
}