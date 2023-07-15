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
    public partial class accountList : Form
    {
        public accountList()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new adminMain().Show();
            this.Hide();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
