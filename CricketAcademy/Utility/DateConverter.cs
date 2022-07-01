using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CricketAcademy.Utility
{
    public partial class DateConverter : Form
    {
        public DateConverter()
        {
            InitializeComponent();
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEnglish.Text == "  /  /" && txtNepali.Text == "  /  /")
                    return;
                if (txtEnglish.Text != "  /  /" && txtNepali.Text != "  /  /")
                {
                    MessageBox.Show("What are you trying to convert? To AD ? Or ToBS? Fucking crazy.");
                    return;
                }
                    

                if (txtEnglish.Text != "  /  /")
                    toBS(txtEnglish.Text);
                if (txtNepali.Text != "  /  /")
                    toAD(txtNepali.Text);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void toAD(string text)
        {
            try
            {
                Library.DateConverter dc = new Library.DateConverter();
                System.String[] userDateParts = dc.ToAD(text).ToString("d").Split(new[] { "/" }, System.StringSplitOptions.None);
                string Month = userDateParts[0];
                string Day = userDateParts[1];
                string Year = userDateParts[2];
                if (Month.Length == 1)
                    Month = "0" + Month;
                if (Day.Length == 1)
                    Day = "0" + Day;
                txtEnglish.Text = Month + Day + Year;


                string sql = @"DECLARE @date datetime, @tmpdate datetime, @years int, @months int, @days int
SELECT @date = '" + new DateTime(Convert.ToInt32(Year), Convert.ToInt32(Month), Convert.ToInt32(Day)) + "' SELECT @tmpdate = @date SELECT @years = DATEDIFF(yy, @tmpdate, GETDATE()) - CASE WHEN (MONTH(@date) > MONTH(GETDATE())) OR (MONTH(@date) = MONTH(GETDATE()) AND DAY(@date) > DAY(GETDATE())) THEN 1 ELSE 0 END SELECT @tmpdate = DATEADD(yy, @years, @tmpdate) SELECT @months = DATEDIFF(m, @tmpdate, GETDATE()) - CASE WHEN DAY(@date) > DAY(GETDATE()) THEN 1 ELSE 0 END SELECT @tmpdate = DATEADD(m, @months, @tmpdate) SELECT @days = DATEDIFF(d, @tmpdate, GETDATE()) SELECT CAST(@years as nvarchar(50))+' years '+CAST(@months as nvarchar(50))+' months '+CAST(@days as nvarchar(50))+' days'";

                lblAge.Text = Library.DataAccessLayer.Instance.ExecuteScalar(sql);

              
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void toBS(string text)
        {
            try
            {
                System.String[] userDateParts = text.Split(new[] { "/" }, System.StringSplitOptions.None);
                int Month = int.Parse(userDateParts[0]);
                int Day = int.Parse(userDateParts[1]);
                int Year = int.Parse(userDateParts[2]);

                Library.DateConverter dc = new Library.DateConverter();
                txtNepali.Text = dc.ToBS(new DateTime(Year, Month, Day));

                string sql = @"DECLARE @date datetime, @tmpdate datetime, @years int, @months int, @days int
SELECT @date = '" + new DateTime(Year, Month, Day) + "' SELECT @tmpdate = @date SELECT @years = DATEDIFF(yy, @tmpdate, GETDATE()) - CASE WHEN (MONTH(@date) > MONTH(GETDATE())) OR (MONTH(@date) = MONTH(GETDATE()) AND DAY(@date) > DAY(GETDATE())) THEN 1 ELSE 0 END SELECT @tmpdate = DATEADD(yy, @years, @tmpdate) SELECT @months = DATEDIFF(m, @tmpdate, GETDATE()) - CASE WHEN DAY(@date) > DAY(GETDATE()) THEN 1 ELSE 0 END SELECT @tmpdate = DATEADD(m, @months, @tmpdate) SELECT @days = DATEDIFF(d, @tmpdate, GETDATE()) SELECT CAST(@years as nvarchar(50))+' years '+CAST(@months as nvarchar(50))+' months '+CAST(@days as nvarchar(50))+' days'";

                lblAge.Text = Library.DataAccessLayer.Instance.ExecuteScalar(sql);
               
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
