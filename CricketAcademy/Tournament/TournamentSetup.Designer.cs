namespace CricketAcademy.Tournament
{
    partial class TournamentSetup
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
            this.txtStartDate = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTournamentName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEndDate = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numFirst = new System.Windows.Forms.TextBox();
            this.numSecond = new System.Windows.Forms.TextBox();
            this.txtOvers = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(192, 126);
            this.txtStartDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtStartDate.Mask = "00/00/0000";
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(257, 22);
            this.txtStartDate.TabIndex = 3;
            this.txtStartDate.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtStartDate_MaskInputRejected);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 126);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 16);
            this.label6.TabIndex = 83;
            this.label6.Text = "Start date(mm/dd/yyyy)";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtTournamentName
            // 
            this.txtTournamentName.Location = new System.Drawing.Point(192, 28);
            this.txtTournamentName.Margin = new System.Windows.Forms.Padding(4);
            this.txtTournamentName.Name = "txtTournamentName";
            this.txtTournamentName.Size = new System.Drawing.Size(257, 22);
            this.txtTournamentName.TabIndex = 1;
            this.txtTournamentName.TextChanged += new System.EventHandler(this.txtTournamentName_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 28);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 16);
            this.label12.TabIndex = 82;
            this.label12.Text = "Competition name";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(192, 77);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(4);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(257, 22);
            this.txtLocation.TabIndex = 2;
            this.txtLocation.TextChanged += new System.EventHandler(this.txtLocation_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 81;
            this.label2.Text = "Match location";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(192, 175);
            this.txtEndDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtEndDate.Mask = "00/00/0000";
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(257, 22);
            this.txtEndDate.TabIndex = 4;
            this.txtEndDate.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtEndDate_MaskInputRejected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 85;
            this.label1.Text = "End date(mm/dd/yyyy)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::CricketAcademy.Properties.Resources.floppy_disc_green_copy;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(293, 369);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(156, 47);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "    &Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::CricketAcademy.Properties.Resources.Actions_edit_delete_icon_copy;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(23, 369);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(145, 47);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "    &Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 224);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 90;
            this.label3.Text = "Prize(First)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 273);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 92;
            this.label4.Text = "Prize(Second)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // numFirst
            // 
            this.numFirst.Location = new System.Drawing.Point(192, 224);
            this.numFirst.Margin = new System.Windows.Forms.Padding(4);
            this.numFirst.Name = "numFirst";
            this.numFirst.Size = new System.Drawing.Size(257, 22);
            this.numFirst.TabIndex = 5;
            this.numFirst.Text = "0";
            this.numFirst.TextChanged += new System.EventHandler(this.numFirst_TextChanged);
            // 
            // numSecond
            // 
            this.numSecond.Location = new System.Drawing.Point(192, 273);
            this.numSecond.Margin = new System.Windows.Forms.Padding(4);
            this.numSecond.Name = "numSecond";
            this.numSecond.Size = new System.Drawing.Size(257, 22);
            this.numSecond.TabIndex = 6;
            this.numSecond.Text = "0";
            this.numSecond.TextChanged += new System.EventHandler(this.numSecond_TextChanged);
            // 
            // txtOvers
            // 
            this.txtOvers.Location = new System.Drawing.Point(193, 321);
            this.txtOvers.Margin = new System.Windows.Forms.Padding(4);
            this.txtOvers.Name = "txtOvers";
            this.txtOvers.Size = new System.Drawing.Size(257, 22);
            this.txtOvers.TabIndex = 7;
            this.txtOvers.Text = "20";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 321);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 94;
            this.label5.Text = "Overs";
            // 
            // TournamentSetup
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(469, 430);
            this.Controls.Add(this.txtOvers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numFirst);
            this.Controls.Add(this.numSecond);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTournamentName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TournamentSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tournament Setup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox txtStartDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTournamentName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtEndDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox numFirst;
        private System.Windows.Forms.TextBox numSecond;
        private System.Windows.Forms.TextBox txtOvers;
        private System.Windows.Forms.Label label5;
    }
}