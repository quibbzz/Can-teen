using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Can_teen
{
    public partial class adminSalesReport : Form
    {
        public adminSalesReport()
        {
            InitializeComponent();
            Connection();
            Daily();
            Weekly();
            Monthly();
            Yearly();
        }

        OleDbConnection? cn;
        OleDbCommand? cm;

        public void Connection()
        {
            cn = new OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\quibi\\Documents\\Database1.accdb");
        }

        public double GetTotal(string acc)
        {
            double total = 0.00;
            try
            {
                cn.Open();
                using (OleDbCommand cm = new OleDbCommand(acc, cn))
                {
                    object result = cm.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        double.TryParse(result.ToString(), out total);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                cn.Close();
            }
            return total;
        }
    
        public void Daily()
        {
            try
            {
                cn.Open();

                string selectTotalAmountQuery = "SELECT sum(total_amount) FROM Orders WHERE added_on = @OrderDate";
                using (OleDbCommand cmd = new OleDbCommand(selectTotalAmountQuery, cn))
                {
                    cmd.Parameters.AddWithValue("@OrderDate", DateTime.Now.Date);

                    object totalAmount = cmd.ExecuteScalar();
                    if (totalAmount != null && totalAmount != DBNull.Value)
                    {
                        double total = 0.00;
                        double.TryParse(totalAmount.ToString(), out total);
                        lblDaily.Text = total.ToString("#,##0.00");
                    }
                    else
                    {
                        lblDaily.Text = "0.00";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving the total amount: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public void Weekly()
        {
            try
            {
                cn.Open();

                DateTime startDate = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek);
                DateTime endDate = startDate.AddDays(6);

                
                string selectTotalAmountQuery = "SELECT SUM(total_amount) FROM Orders WHERE added_on BETWEEN @StartDate AND @EndDate";
                using (OleDbCommand cmd = new OleDbCommand(selectTotalAmountQuery, cn))
                {
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);

                    object totalAmount = cmd.ExecuteScalar();
                    if (totalAmount != null && totalAmount != DBNull.Value)
                    {
                        double total = 0.00;
                        double.TryParse(totalAmount.ToString(), out total);
                        lblWeekly.Text = total.ToString("#,##0.00");
                    }
                    else
                    {
                        lblDaily.Text = "0.00";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving the total amount: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public void Monthly()
        {
            try
            {
                cn.Open();

                DateTime startDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                DateTime endDate = startDate.AddMonths(1).AddDays(-1);

                string selectTotalAmountQuery = "SELECT SUM(total_amount) FROM Orders WHERE added_on BETWEEN @StartDate AND @EndDate";
                using (OleDbCommand cmd = new OleDbCommand(selectTotalAmountQuery, cn))
                {
                    
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);

                    object totalAmount = cmd.ExecuteScalar();
                    if (totalAmount != null && totalAmount != DBNull.Value)
                    {
                        double total = 0.00;
                        double.TryParse(totalAmount.ToString(), out total);
                        lblMonthly.Text = total.ToString("#,##0.00");
                    }
                    else
                    {
                        lblDaily.Text = "0.00";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving the total amount: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public void Yearly()
        {
            try
            {
                cn.Open();

                
                DateTime startDate = new DateTime(DateTime.Today.Year, 1, 1);
                DateTime endDate = startDate.AddYears(1).AddDays(-1);

                
                string selectTotalAmountQuery = "SELECT SUM(total_amount) FROM Orders WHERE added_on BETWEEN @StartDate AND @EndDate";
                using (OleDbCommand cmd = new OleDbCommand(selectTotalAmountQuery, cn))
                {
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);

                    object totalAmount = cmd.ExecuteScalar();
                    if (totalAmount != null && totalAmount != DBNull.Value)
                    {
                        double total = 0.00;
                        double.TryParse(totalAmount.ToString(), out total);
                        lblYearly.Text = total.ToString("#,##0.00");
                    }
                    else
                    {
                        lblDaily.Text = "0.00";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving the total amount: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new adminMain().Show();
            this.Hide();
        }

        private void lblDaily_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
