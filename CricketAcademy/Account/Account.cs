using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CricketAcademy.Account
{
    public partial class Account : Form
    {
        public DataGridView dgv = null;
        public string date_from = "";
        public string date_to = "";
        public Account()
        {
            InitializeComponent();
        }

        private void Account_Load(object sender, EventArgs e)
        {
            try
            {
                reportViewer1.LocalReport.DataSources.Clear();
                dsAccount ds = new dsAccount();
                foreach (DataGridViewRow dr in dgv.Rows)
                {
                    ds.dtDetails.Rows.Add(dr.Cells["entered_date"].Value, dr.Cells["narration"].Value, dr.Cells["income"].Value, dr.Cells["expenses"].Value, dr.Cells["balance"].Value);
                }

                ds.dtExtras.Rows.Add(Convert.ToDateTime(date_from).ToString("d"),Convert.ToDateTime(date_to).ToString("d"));
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", (DataTable)ds.dtDetails));
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2", (DataTable)ds.dtExtras));
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
