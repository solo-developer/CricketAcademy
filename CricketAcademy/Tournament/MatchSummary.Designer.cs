namespace CricketAcademy.Tournament
{
    partial class MatchSummary
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMatchDate = new System.Windows.Forms.MaskedTextBox();
            this.cmbToss = new System.Windows.Forms.ComboBox();
            this.cmbChoice = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbOpposition = new System.Windows.Forms.ComboBox();
            this.cmbWinner = new System.Windows.Forms.ComboBox();
            this.cmbTeam = new System.Windows.Forms.ComboBox();
            this.cmbTournament = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numRunsScored = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.numWicketsLost = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numBallsBatted = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numOversBatted = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numRunsConceeded = new System.Windows.Forms.NumericUpDown();
            this.numWicketsTaken = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numBallsBowled = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numOversBowled = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRunsScored)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWicketsLost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBallsBatted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOversBatted)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRunsConceeded)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWicketsTaken)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBallsBowled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOversBowled)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMatchDate);
            this.groupBox1.Controls.Add(this.cmbToss);
            this.groupBox1.Controls.Add(this.cmbChoice);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cmbOpposition);
            this.groupBox1.Controls.Add(this.cmbWinner);
            this.groupBox1.Controls.Add(this.cmbTeam);
            this.groupBox1.Controls.Add(this.cmbTournament);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Match Detail";
            // 
            // txtMatchDate
            // 
            this.txtMatchDate.Location = new System.Drawing.Point(316, 39);
            this.txtMatchDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatchDate.Mask = "00/00/0000";
            this.txtMatchDate.Name = "txtMatchDate";
            this.txtMatchDate.Size = new System.Drawing.Size(234, 22);
            this.txtMatchDate.TabIndex = 2;
            // 
            // cmbToss
            // 
            this.cmbToss.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbToss.FormattingEnabled = true;
            this.cmbToss.Items.AddRange(new object[] {
            "Team",
            "Opposition"});
            this.cmbToss.Location = new System.Drawing.Point(316, 151);
            this.cmbToss.Name = "cmbToss";
            this.cmbToss.Size = new System.Drawing.Size(234, 24);
            this.cmbToss.TabIndex = 6;
            // 
            // cmbChoice
            // 
            this.cmbChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChoice.FormattingEnabled = true;
            this.cmbChoice.Items.AddRange(new object[] {
            "Bat",
            "Bowl"});
            this.cmbChoice.Location = new System.Drawing.Point(12, 201);
            this.cmbChoice.Name = "cmbChoice";
            this.cmbChoice.Size = new System.Drawing.Size(232, 24);
            this.cmbChoice.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(313, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 16);
            this.label11.TabIndex = 3;
            this.label11.Text = "Toss";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 182);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 16);
            this.label12.TabIndex = 4;
            this.label12.Text = "Toss Choice";
            // 
            // cmbOpposition
            // 
            this.cmbOpposition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOpposition.FormattingEnabled = true;
            this.cmbOpposition.Location = new System.Drawing.Point(318, 97);
            this.cmbOpposition.Name = "cmbOpposition";
            this.cmbOpposition.Size = new System.Drawing.Size(232, 24);
            this.cmbOpposition.TabIndex = 4;
            // 
            // cmbWinner
            // 
            this.cmbWinner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWinner.FormattingEnabled = true;
            this.cmbWinner.Items.AddRange(new object[] {
            "Team",
            "Opposition",
            "Draw"});
            this.cmbWinner.Location = new System.Drawing.Point(12, 151);
            this.cmbWinner.Name = "cmbWinner";
            this.cmbWinner.Size = new System.Drawing.Size(232, 24);
            this.cmbWinner.TabIndex = 5;
            // 
            // cmbTeam
            // 
            this.cmbTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeam.FormattingEnabled = true;
            this.cmbTeam.Location = new System.Drawing.Point(12, 97);
            this.cmbTeam.Name = "cmbTeam";
            this.cmbTeam.Size = new System.Drawing.Size(232, 24);
            this.cmbTeam.TabIndex = 3;
            // 
            // cmbTournament
            // 
            this.cmbTournament.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTournament.FormattingEnabled = true;
            this.cmbTournament.Location = new System.Drawing.Point(12, 37);
            this.cmbTournament.Name = "cmbTournament";
            this.cmbTournament.Size = new System.Drawing.Size(232, 24);
            this.cmbTournament.TabIndex = 1;
            this.cmbTournament.SelectedIndexChanged += new System.EventHandler(this.cmbTournament_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Opposition";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Winner";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Team";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(313, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Match Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tournament";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numRunsScored);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.numWicketsLost);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.numBallsBatted);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.numOversBatted);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(3, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(568, 97);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Winner Batting Summary";
            // 
            // numRunsScored
            // 
            this.numRunsScored.Location = new System.Drawing.Point(424, 53);
            this.numRunsScored.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numRunsScored.Name = "numRunsScored";
            this.numRunsScored.Size = new System.Drawing.Size(120, 22);
            this.numRunsScored.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(421, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 16);
            this.label14.TabIndex = 7;
            this.label14.Text = "Runs Scored";
            // 
            // numWicketsLost
            // 
            this.numWicketsLost.Location = new System.Drawing.Point(290, 53);
            this.numWicketsLost.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numWicketsLost.Name = "numWicketsLost";
            this.numWicketsLost.Size = new System.Drawing.Size(120, 22);
            this.numWicketsLost.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Wickets Lost";
            // 
            // numBallsBatted
            // 
            this.numBallsBatted.Location = new System.Drawing.Point(155, 53);
            this.numBallsBatted.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numBallsBatted.Name = "numBallsBatted";
            this.numBallsBatted.Size = new System.Drawing.Size(120, 22);
            this.numBallsBatted.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Balls Batted";
            // 
            // numOversBatted
            // 
            this.numOversBatted.Location = new System.Drawing.Point(12, 53);
            this.numOversBatted.Name = "numOversBatted";
            this.numOversBatted.Size = new System.Drawing.Size(120, 22);
            this.numOversBatted.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Overs Batted";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numRunsConceeded);
            this.groupBox3.Controls.Add(this.numWicketsTaken);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.numBallsBowled);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.numOversBowled);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(3, 346);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(568, 96);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Winner Bowling Summary";
            // 
            // numRunsConceeded
            // 
            this.numRunsConceeded.Location = new System.Drawing.Point(424, 54);
            this.numRunsConceeded.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numRunsConceeded.Name = "numRunsConceeded";
            this.numRunsConceeded.Size = new System.Drawing.Size(120, 22);
            this.numRunsConceeded.TabIndex = 6;
            // 
            // numWicketsTaken
            // 
            this.numWicketsTaken.Location = new System.Drawing.Point(290, 54);
            this.numWicketsTaken.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numWicketsTaken.Name = "numWicketsTaken";
            this.numWicketsTaken.Size = new System.Drawing.Size(120, 22);
            this.numWicketsTaken.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(421, 33);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 16);
            this.label15.TabIndex = 7;
            this.label15.Text = "Runs Conceeded";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(287, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Wickets Taken";
            // 
            // numBallsBowled
            // 
            this.numBallsBowled.Location = new System.Drawing.Point(155, 54);
            this.numBallsBowled.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numBallsBowled.Name = "numBallsBowled";
            this.numBallsBowled.Size = new System.Drawing.Size(120, 22);
            this.numBallsBowled.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(152, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Balls Bowled";
            // 
            // numOversBowled
            // 
            this.numOversBowled.Location = new System.Drawing.Point(17, 54);
            this.numOversBowled.Name = "numOversBowled";
            this.numOversBowled.Size = new System.Drawing.Size(120, 22);
            this.numOversBowled.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 16);
            this.label10.TabIndex = 7;
            this.label10.Text = "Overs Bowled";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::CricketAcademy.Properties.Resources.floppy_disc_green_copy;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(352, 455);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(156, 47);
            this.btnSave.TabIndex = 11;
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
            this.btnClose.Location = new System.Drawing.Point(82, 455);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(145, 47);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "    &Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MatchSummary
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(583, 507);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MatchSummary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Match Summary";
            this.Load += new System.EventHandler(this.MatchSummary_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRunsScored)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWicketsLost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBallsBatted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOversBatted)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRunsConceeded)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWicketsTaken)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBallsBowled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOversBowled)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cmbTournament;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numOversBatted;
        private System.Windows.Forms.ComboBox cmbOpposition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbWinner;
        private System.Windows.Forms.ComboBox cmbTeam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numWicketsLost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numBallsBatted;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numWicketsTaken;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numBallsBowled;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numOversBowled;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbToss;
        private System.Windows.Forms.ComboBox cmbChoice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox txtMatchDate;
        private System.Windows.Forms.NumericUpDown numRunsScored;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numRunsConceeded;
        private System.Windows.Forms.Label label15;
    }
}