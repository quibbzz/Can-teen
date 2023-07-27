﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Can_teen
{
    public partial class adminMain : Form
    {
        public adminMain()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new LogIn().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new addUser().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new accountList().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new adminSalesReport().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new adminProductStocks().Show();
            this.Hide();
        }
    }
}
