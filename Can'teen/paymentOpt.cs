using System;
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
    public partial class paymentOpt : Form
    {
        public paymentOpt()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new gcashPayment().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new orderForm().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new cashPayment().Show();
            this.Hide();
        }

        private void mayaOpt_Click(object sender, EventArgs e)
        {
            new mayaPayment().Show();
            this.Hide();
        }
    }
}
