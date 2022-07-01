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

namespace CricketAcademy.Account.BillGeneration
{
    public partial class Bills : Form
    {
        public string name1, name2, name3;
        public string due1, due2, due3;
        public string month1, month2, month3;
        public string amount1, amount2, amount3;
        public string particulars1, particualrs2, particulaars3;
        
        public Bills()
        {
            InitializeComponent();
        }

        private void Bills_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            dsBills ds = new dsBills();
            try
            {
                ds.dtBills1.Rows.Add(name1, due1, amount1, (Convert.ToDecimal(due1) + Convert.ToDecimal(amount1)).ToString(), particulars1, month1, Library.NumberToWords.NumberToCurrencyText(Convert.ToDecimal(due1) + Convert.ToDecimal(amount1), MidpointRounding.AwayFromZero));
                ds.dtBills2.Rows.Add(name2, due2, amount2, (Convert.ToDecimal(due2) + Convert.ToDecimal(amount2)).ToString(), particualrs2, month2, Library.NumberToWords.NumberToCurrencyText(Convert.ToDecimal(due2) + Convert.ToDecimal(amount2), MidpointRounding.AwayFromZero));
                ds.dtBills3.Rows.Add(name3, due3, amount3, (Convert.ToDecimal(due3) + Convert.ToDecimal(amount3)).ToString(), particulaars3, month3, Library.NumberToWords.NumberToCurrencyText(Convert.ToDecimal(due3) + Convert.ToDecimal(amount3), MidpointRounding.AwayFromZero));

                Library.DateConverter dc = new Library.DateConverter();
                ds.dtExtras.Rows.Add(dc.ToBS(DateTime.Now));
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", (DataTable)ds.dtBills1));
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2", (DataTable)ds.dtBills2));
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet3", (DataTable)ds.dtBills3));
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet4", (DataTable)ds.dtExtras));
                this.reportViewer1.RefreshReport();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
