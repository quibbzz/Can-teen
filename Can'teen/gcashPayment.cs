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
    public partial class gcashPayment : Form
    {
        public gcashPayment()
        {
            InitializeComponent();
            myConn = new OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\quibi\\Documents\\Database1.accdb");
            displayTotal();
        }

        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;

        public void displayTotal()
        {
            try
            {
                
                myConn.Open();

                string selectTotalQuery = "SELECT TOP 1 total_amount FROM Orders ORDER BY ID DESC";

                using (OleDbCommand selectTotalCommand = new OleDbCommand(selectTotalQuery, myConn))
                {
                        object result = selectTotalCommand.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            double totalAmount = Convert.ToDouble(result);
                            lblamount.Text = totalAmount.ToString("P 0.00");
                        }
                        else
                        {
                            lblamount.Text = "No orders found.";
                        }
                }

                    myConn.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving the total amount: " + ex.Message);
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new orderForm().Show();
            this.Hide();
        }
    }
}
