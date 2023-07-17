﻿using System;
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
    public partial class cashPayment : Form
    {
        public cashPayment()
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
                        txtAmount.Text = totalAmount.ToString("P 0.00");

                    }
                    else
                    {
                        txtAmount.Text = "0";
                    }
                }

                myConn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving the total amount: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new orderForm().Show();
            this.Hide();
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double cash = 0.0;
            if (double.TryParse(txtCash.Text, out cash))
            {
                double totalAmount = 0.0;
                if (double.TryParse(txtAmount.Text.Replace("P", "").Trim(), out totalAmount))
                {
                    double change = cash - totalAmount;
                    txtChange.Text = change.ToString("P 0.00");
                }
                else
                {
                    txtChange.Text = "Invalid total amount";
                }
            }
            else
            {
                txtChange.Text = "Invalid cash amount";
            }
        }
    }
}
