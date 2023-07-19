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
    public partial class userSalesReport : Form
    {
        private OleDbConnection myConn;
        public userSalesReport()
        {
            InitializeComponent();
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\quibi\\Documents\\Database1.accdb");
            printSales();
        }

        public void printSales()
        {
            try
            {
                myConn.Open();

                string selectDailyQuery = "SELECT TOP 1 daily_sales FROM sales_summary ORDER BY sales_id DESC";
                using (OleDbCommand dailySalesCommand = new OleDbCommand(selectDailyQuery, myConn))
                {
                    object dailySales = dailySalesCommand.ExecuteScalar();
                    if (dailySales != null && dailySales != DBNull.Value)
                    {
                        double daily = Convert.ToDouble(dailySales);
                        lblDaily.Text = daily.ToString("₱ 0.00");
                    }
                    else
                    {
                        lblDaily.Text = "0.00";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving the daily sales: " + ex.Message);
            }
            finally
            {
                myConn.Close();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            new orderForm().Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DateTime selectedDate = dateTimePicker1.Value;

                myConn.Open();

                // Retrieve the orders for the selected date from the Order table
                string selectOrderQuery = "SELECT added_on FROM [Orders] WHERE added_on = @OrderDate"; // Replace [Order] with the actual table name and added_on with the actual column name in your table
                using (OleDbCommand cmd = new OleDbCommand(selectOrderQuery, myConn))
                {
                    cmd.Parameters.AddWithValue("@OrderDate", selectedDate);

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                    {
                        DataTable orderTable = new DataTable();
                        adapter.Fill(orderTable);

                        // Bind the data to the dataGridView1 DataGridView
                        dataGridView1.DataSource = orderTable;
                    }
                }

                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving the order data: " + ex.Message);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

        }
           
        }
    }

