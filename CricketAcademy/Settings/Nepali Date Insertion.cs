using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CricketAcademy.Settings
{
    public partial class Nepali_Date_Insertion : Form
    {
        Library.DateConverter dc = new Library.DateConverter();
        public Nepali_Date_Insertion()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {

                string sql = "SELECT petty_cash_id,entered_date FROM PettyCashFund WHERE nep_entered_date IS NULL";
                DataTable dt = Library.DataAccessLayer.Instance.ExecuteQuery(sql);
                foreach(DataRow dr in dt.Rows)
                {
                    sql = "UPDATE PettyCashFund SET nep_entered_date='" + dc.ToBS(Convert.ToDateTime(dr["entered_date"])) + "' WHERE petty_cash_id='" + dr["petty_cash_id"] + "'";
                    Library.DataAccessLayer.Instance.ExecuteNonQuery(sql);
                }
                MessageBox.Show("Nepali date calculated and inserted successfully.");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Failed to insert nepali dates.");
            }
        }
    }
}
