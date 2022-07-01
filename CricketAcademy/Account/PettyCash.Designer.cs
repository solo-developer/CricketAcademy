namespace CricketAcademy.Account
{
    partial class PettyCash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PettyCash));
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.viewAll = new System.Windows.Forms.DataGridView();
            this.petty_cash_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entered_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.narration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.income = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUsageSave = new System.Windows.Forms.Button();
            this.txtUsageNarration = new System.Windows.Forms.TextBox();
            this.txtUsageAmount = new System.Windows.Forms.TextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.DateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.cmbFormat = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.txtIssueNarration = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtIssueAmount = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIssueSave = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.viewAll)).BeginInit();
            this.GroupBox2.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(6, 30);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(86, 24);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Na&rration";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(7, 77);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(76, 24);
            this.Label4.TabIndex = 2;
            this.Label4.Text = "A&mount";
            // 
            // viewAll
            // 
            this.viewAll.AllowUserToAddRows = false;
            this.viewAll.AllowUserToDeleteRows = false;
            this.viewAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewAll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.petty_cash_id,
            this.entered_date,
            this.narration,
            this.income,
            this.expenses,
            this.balance});
            this.viewAll.Location = new System.Drawing.Point(3, 71);
            this.viewAll.Name = "viewAll";
            this.viewAll.RowHeadersWidth = 51;
            this.viewAll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewAll.Size = new System.Drawing.Size(1027, 379);
            this.viewAll.TabIndex = 1;
            this.viewAll.TabStop = false;
            this.viewAll.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewAll_CellContentClick);
            this.viewAll.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewAll_CellContentDoubleClick);
            this.viewAll.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewAll_CellEndEdit);
            // 
            // petty_cash_id
            // 
            this.petty_cash_id.HeaderText = "petty_cash_id";
            this.petty_cash_id.MinimumWidth = 6;
            this.petty_cash_id.Name = "petty_cash_id";
            this.petty_cash_id.Visible = false;
            this.petty_cash_id.Width = 150;
            // 
            // entered_date
            // 
            this.entered_date.HeaderText = "Date";
            this.entered_date.MinimumWidth = 6;
            this.entered_date.Name = "entered_date";
            this.entered_date.Width = 150;
            // 
            // narration
            // 
            this.narration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.narration.HeaderText = "Narration";
            this.narration.MinimumWidth = 6;
            this.narration.Name = "narration";
            // 
            // income
            // 
            this.income.HeaderText = "Income";
            this.income.MinimumWidth = 6;
            this.income.Name = "income";
            this.income.Width = 150;
            // 
            // expenses
            // 
            this.expenses.HeaderText = "Expenses";
            this.expenses.MinimumWidth = 6;
            this.expenses.Name = "expenses";
            this.expenses.Width = 150;
            // 
            // balance
            // 
            this.balance.HeaderText = "Balance";
            this.balance.MinimumWidth = 6;
            this.balance.Name = "balance";
            this.balance.Width = 150;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.btnUsageSave);
            this.GroupBox2.Controls.Add(this.txtUsageNarration);
            this.GroupBox2.Controls.Add(this.Label3);
            this.GroupBox2.Controls.Add(this.txtUsageAmount);
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Location = new System.Drawing.Point(507, 6);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(521, 119);
            this.GroupBox2.TabIndex = 5;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Expenses";
            // 
            // btnUsageSave
            // 
            this.btnUsageSave.BackColor = System.Drawing.Color.Transparent;
            this.btnUsageSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsageSave.Image = global::CricketAcademy.Properties.Resources.floppy_disc_green_copy;
            this.btnUsageSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsageSave.Location = new System.Drawing.Point(372, 62);
            this.btnUsageSave.Name = "btnUsageSave";
            this.btnUsageSave.Size = new System.Drawing.Size(121, 43);
            this.btnUsageSave.TabIndex = 5;
            this.btnUsageSave.Text = "    Sa&ve";
            this.btnUsageSave.UseVisualStyleBackColor = false;
            this.btnUsageSave.Click += new System.EventHandler(this.btnUsageSave_Click);
            // 
            // txtUsageNarration
            // 
            this.txtUsageNarration.Location = new System.Drawing.Point(82, 17);
            this.txtUsageNarration.Multiline = true;
            this.txtUsageNarration.Name = "txtUsageNarration";
            this.txtUsageNarration.Size = new System.Drawing.Size(412, 36);
            this.txtUsageNarration.TabIndex = 3;
            // 
            // txtUsageAmount
            // 
            this.txtUsageAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsageAmount.Location = new System.Drawing.Point(82, 75);
            this.txtUsageAmount.Name = "txtUsageAmount";
            this.txtUsageAmount.Size = new System.Drawing.Size(248, 30);
            this.txtUsageAmount.TabIndex = 4;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "All",
            "Expenses",
            "Income"});
            this.cmbType.Location = new System.Drawing.Point(9, 25);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(141, 32);
            this.cmbType.TabIndex = 6;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(6, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(58, 24);
            this.Label7.TabIndex = 24;
            this.Label7.Text = "Type:";
            // 
            // DateTimePicker2
            // 
            this.DateTimePicker2.Location = new System.Drawing.Point(566, 26);
            this.DateTimePicker2.Name = "DateTimePicker2";
            this.DateTimePicker2.Size = new System.Drawing.Size(198, 29);
            this.DateTimePicker2.TabIndex = 8;
            this.DateTimePicker2.ValueChanged += new System.EventHandler(this.DateTimePicker2_ValueChanged);
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Location = new System.Drawing.Point(349, 26);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(199, 29);
            this.DateTimePicker1.TabIndex = 7;
            this.DateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(563, -1);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(73, 24);
            this.Label6.TabIndex = 4;
            this.Label6.Text = "Date  to";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(343, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(90, 24);
            this.Label5.TabIndex = 3;
            this.Label5.Text = "Date from";
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.cmbFormat);
            this.Panel2.Controls.Add(this.button1);
            this.Panel2.Controls.Add(this.txtSearch);
            this.Panel2.Controls.Add(this.label8);
            this.Panel2.Controls.Add(this.cmbType);
            this.Panel2.Controls.Add(this.Label7);
            this.Panel2.Controls.Add(this.DateTimePicker2);
            this.Panel2.Controls.Add(this.DateTimePicker1);
            this.Panel2.Controls.Add(this.Label6);
            this.Panel2.Controls.Add(this.Label5);
            this.Panel2.Location = new System.Drawing.Point(3, -3);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(1021, 68);
            this.Panel2.TabIndex = 0;
            // 
            // cmbFormat
            // 
            this.cmbFormat.FormattingEnabled = true;
            this.cmbFormat.Items.AddRange(new object[] {
            "English",
            "Nepali"});
            this.cmbFormat.Location = new System.Drawing.Point(770, 24);
            this.cmbFormat.Name = "cmbFormat";
            this.cmbFormat.Size = new System.Drawing.Size(133, 32);
            this.cmbFormat.TabIndex = 9;
            this.cmbFormat.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::CricketAcademy.Properties.Resources.Layer_7_01_128_copy1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(909, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 43);
            this.button1.TabIndex = 10;
            this.button1.Text = "      Print";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(171, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(155, 30);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(174, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 24);
            this.label8.TabIndex = 25;
            this.label8.Text = "Search";
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.viewAll);
            this.Panel1.Controls.Add(this.Panel2);
            this.Panel1.Location = new System.Drawing.Point(3, 131);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1033, 459);
            this.Panel1.TabIndex = 6;
            // 
            // txtIssueNarration
            // 
            this.txtIssueNarration.Location = new System.Drawing.Point(82, 17);
            this.txtIssueNarration.Multiline = true;
            this.txtIssueNarration.Name = "txtIssueNarration";
            this.txtIssueNarration.Size = new System.Drawing.Size(383, 36);
            this.txtIssueNarration.TabIndex = 0;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(6, 30);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(86, 24);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "&Narration";
            // 
            // txtIssueAmount
            // 
            this.txtIssueAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIssueAmount.Location = new System.Drawing.Point(82, 75);
            this.txtIssueAmount.Name = "txtIssueAmount";
            this.txtIssueAmount.Size = new System.Drawing.Size(220, 30);
            this.txtIssueAmount.TabIndex = 1;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(7, 77);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(76, 24);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "&Amount";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btnIssueSave);
            this.GroupBox1.Controls.Add(this.txtIssueNarration);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.txtIssueAmount);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Location = new System.Drawing.Point(3, 6);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(475, 119);
            this.GroupBox1.TabIndex = 4;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Income";
            // 
            // btnIssueSave
            // 
            this.btnIssueSave.BackColor = System.Drawing.Color.Transparent;
            this.btnIssueSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssueSave.Image = global::CricketAcademy.Properties.Resources.floppy_disc_green_copy;
            this.btnIssueSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssueSave.Location = new System.Drawing.Point(323, 62);
            this.btnIssueSave.Name = "btnIssueSave";
            this.btnIssueSave.Size = new System.Drawing.Size(142, 43);
            this.btnIssueSave.TabIndex = 2;
            this.btnIssueSave.Text = "    &Save";
            this.btnIssueSave.UseVisualStyleBackColor = false;
            this.btnIssueSave.Click += new System.EventHandler(this.btnIssueSave_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(773, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 24);
            this.label9.TabIndex = 28;
            this.label9.Text = "Date  format";
            // 
            // PettyCash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 597);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.GroupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PettyCash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PettyCash";
            this.Load += new System.EventHandler(this.PettyCash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewAll)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.DataGridView viewAll;
        private System.Windows.Forms.Button btnUsageSave;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.TextBox txtUsageNarration;
        internal System.Windows.Forms.TextBox txtUsageAmount;
        internal System.Windows.Forms.ComboBox cmbType;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.DateTimePicker DateTimePicker2;
        internal System.Windows.Forms.DateTimePicker DateTimePicker1;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Button btnIssueSave;
        internal System.Windows.Forms.TextBox txtIssueNarration;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtIssueAmount;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn petty_cash_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn entered_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn narration;
        private System.Windows.Forms.DataGridViewTextBoxColumn income;
        private System.Windows.Forms.DataGridViewTextBoxColumn expenses;
        private System.Windows.Forms.DataGridViewTextBoxColumn balance;
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.ComboBox cmbFormat;
        internal System.Windows.Forms.Label label9;
    }
}