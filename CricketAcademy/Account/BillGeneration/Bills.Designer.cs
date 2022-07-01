namespace CricketAcademy.Account.BillGeneration
{
    partial class Bills
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bills));
            this.dtBills1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBills = new CricketAcademy.Account.BillGeneration.dsBills();
            this.dtBills2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtBills3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtExtrasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dtBills1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBills2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBills3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtExtrasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtBills1BindingSource
            // 
            this.dtBills1BindingSource.DataMember = "dtBills1";
            this.dtBills1BindingSource.DataSource = this.dsBills;
            // 
            // dsBills
            // 
            this.dsBills.DataSetName = "dsBills";
            this.dsBills.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtBills2BindingSource
            // 
            this.dtBills2BindingSource.DataMember = "dtBills2";
            this.dtBills2BindingSource.DataSource = this.dsBills;
            // 
            // dtBills3BindingSource
            // 
            this.dtBills3BindingSource.DataMember = "dtBills3";
            this.dtBills3BindingSource.DataSource = this.dsBills;
            // 
            // dtExtrasBindingSource
            // 
            this.dtExtrasBindingSource.DataMember = "dtExtras";
            this.dtExtrasBindingSource.DataSource = this.dsBills;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dtBills1BindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.dtBills2BindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.dtBills3BindingSource;
            reportDataSource4.Name = "DataSet4";
            reportDataSource4.Value = this.dtExtrasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CricketAcademy.Account.BillGeneration.Bills.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1067, 554);
            this.reportViewer1.TabIndex = 0;
            // 
            // Bills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Bills";
            this.Text = "Bills";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Bills_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtBills1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBills2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBills3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtExtrasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dtBills1BindingSource;
        private dsBills dsBills;
        private System.Windows.Forms.BindingSource dtBills2BindingSource;
        private System.Windows.Forms.BindingSource dtBills3BindingSource;
        private System.Windows.Forms.BindingSource dtExtrasBindingSource;
    }
}