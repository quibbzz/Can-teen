using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            //SalesSummary();
            GetTotalOrders();
            getPaymentTotal();
        }

        OleDbConnection? cn;
        OleDbCommand? cm;

        public void Connection()
        {
            cn = new OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\quibi\\Documents\\Database1.accdb");
        }

        public void loadGridData()
        {
            cn.Open();

            DateTime selectedDateFrom = dateFrom.Value.Date; // Set to the beginning of the selected day (12 AM)
            DateTime selectedDateTo = dateTo.Value.Date.AddDays(1).AddSeconds(-1); // Set to the end of the selected day (11:59 PM)


            string selectOrdersTimeFrame = "SELECT * FROM Orders WHERE added_on BETWEEN @StartDate AND @EndDate";
            using (OleDbCommand cmd = new OleDbCommand(selectOrdersTimeFrame, cn))
            {

                cmd.Parameters.AddWithValue("@DateTo", selectedDateFrom);
                cmd.Parameters.AddWithValue("@DateTo", selectedDateTo);

                using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                {
                    DataTable orderTable = new DataTable();
                    adapter.Fill(orderTable);

                    // Bind the data to the dataGridView1 DataGridView
                    DataGridTable.DataSource = orderTable;
                }
            }
        }

        public void GetTotalOrders()
        {
            try
            {
                cn.Open();

                string countOrders = "SELECT COUNT(ID) FROM Orders";
                using (OleDbCommand cmd = new OleDbCommand(countOrders, cn))
                {
                    int totalOrdersCount = (int)cmd.ExecuteScalar();
                    lblOrders.Text = totalOrdersCount.ToString();
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
        }

        public void getPaymentTotal()
        {
            try
            {
                cn.Open();

                string totalAmountGcash = "SELECT SUM(total_amount) FROM payment WHERE payment_method = 'GCASH'";
                using (OleDbCommand cmd = new OleDbCommand(totalAmountGcash, cn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        
                        decimal gcashTotal = Convert.ToDecimal(result);
                        
                        lblGcash.Text = gcashTotal.ToString("#,##0.00");
                    }
                    else
                    {
                        
                        lblGcash.Text = "0.00";
                    }
                }
                string totalAmountCash = "SELECT SUM(total_amount) FROM payment WHERE payment_method = 'CASH'";
                using (OleDbCommand cmd = new OleDbCommand(totalAmountCash, cn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        
                        decimal gcashTotal = Convert.ToDecimal(result);

                        lblCash.Text = gcashTotal.ToString("#,##0.00");
                    }
                    else
                    {
                        lblCash.Text = "0.00";
                    }
                }
                string totalAmountMaya = "SELECT SUM(total_amount) FROM payment WHERE payment_method = 'MAYA'";
                using (OleDbCommand cmd = new OleDbCommand(totalAmountMaya, cn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        
                        decimal gcashTotal = Convert.ToDecimal(result);

                        lblMaya.Text = gcashTotal.ToString("#,##0.00");
                    }
                    else
                    {
                        lblMaya.Text = "0.00";
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
                        double Yearlytotal = 0.00;
                        double.TryParse(totalAmount.ToString(), out Yearlytotal);
                        lblYearly.Text = Yearlytotal.ToString("#,##0.00");
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

        private void SalesSummary()
        {
            try
            {
                cn.Open();

                double DailySales = 0;
                double WeeklySales = 0;
                double MonthlySales = 0;
                double YearlySales = 0;
                DateTime today = DateTime.Today;

                string insertSalesQuery = "INSERT INTO sales_summary (daily_sales, weekly_sales, monthly_sales, yearly_sales, sales_date) " +
                                       "VALUES (@DailySales, @WeeklySales, @MonthlySales, @YearlySales, @SalesDate)";
                using (OleDbCommand insertSalesCommand = new OleDbCommand(insertSalesQuery, cn))
                {
                    Double.TryParse(lblDaily.Text, out DailySales);
                    Double.TryParse(lblWeekly.Text, out WeeklySales);
                    Double.TryParse(lblMonthly.Text, out MonthlySales);
                    Double.TryParse(lblYearly.Text, out YearlySales);
                    insertSalesCommand.Parameters.AddWithValue("@DailySales",DailySales);
                    insertSalesCommand.Parameters.AddWithValue("@WeeklySales", WeeklySales);
                    insertSalesCommand.Parameters.AddWithValue("@MonthlySales", MonthlySales);
                    insertSalesCommand.Parameters.AddWithValue("@YearlySales", YearlySales);
                    insertSalesCommand.Parameters.AddWithValue("@SalesDate", today);

                    insertSalesCommand.ExecuteNonQuery();
                }
                
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating sales summary: " + ex.Message);
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

        private void timer_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now.TimeOfDay >= new TimeSpan(23, 59, 0))
            {
                SalesSummary();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadGridData();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void adminSalesReport_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
