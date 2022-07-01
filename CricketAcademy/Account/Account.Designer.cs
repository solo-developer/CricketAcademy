namespace CricketAcademy.Account
{
    partial class Account
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account));
            this.dtDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsAccount = new CricketAcademy.Account.dsAccount();
            this.dtExtrasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dtDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtExtrasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtDetailsBindingSource
            // 
            this.dtDetailsBindingSource.DataMember = "dtDetails";
            this.dtDetailsBindingSource.DataSource = this.dsAccount;
            // 
            // dsAccount
            // 
            this.dsAccount.DataSetName = "dsAccount";
            this.dsAccount.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtExtrasBindingSource
            // 
            this.dtExtrasBindingSource.DataMember = "dtExtras";
            this.dtExtrasBindingSource.DataSource = this.dsAccount;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dtDetailsBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.dtExtrasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CricketAcademy.Account.Report2.rdlc";
            this.reportViewer1.LocalReport.ReportPath = "Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1067, 554);
            this.reportViewer1.TabIndex = 0;
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Account";
            this.Text = "Account";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Account_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtExtrasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dtDetailsBindingSource;
        private dsAccount dsAccount;
        private System.Windows.Forms.BindingSource dtExtrasBindingSource;
    }
}