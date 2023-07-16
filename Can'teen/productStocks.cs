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
using System.Xml.Linq;

namespace Can_teen
{
    public partial class productStocks : Form
    {
        public productStocks()
        {
            InitializeComponent();
            LoadStockData();
        }
        OleDbConnection con = new OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\quibi\\Documents\\Database1.accdb");

        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;

        private void LoadStockData()
        {
            try
            {
                con.Open();

                string selectQuery = "SELECT * FROM stock"; 

                da = new OleDbDataAdapter(selectQuery, con);
                ds = new DataSet();
                da.Fill(ds, "stocks");

                dataGridView1.DataSource = ds.Tables["stocks"];

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading account data: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtStocks.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            lblProdName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            lblProdPrice.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            lblProdId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            new orderForm().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //updATE
            string query = "UPDATE stock SET [num_stock] = [num_stock] + @stockNum WHERE [stock_id] = @Id";
            cmd = new OleDbCommand(query, con);


            cmd.Parameters.AddWithValue("@stockNum", Convert.ToInt32(txtStocks.Text));
            cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(lblProdId.Text));

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("updated successfully");
            LoadStockData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            //DELETE
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string query = "UPDATE stock SET [num_stock] = [num_stock] - @stockNum WHERE [stock_id] = @Id";
            cmd = new OleDbCommand(query, con);

            cmd.Parameters.AddWithValue("@stockNum", Convert.ToInt32(txtStocks.Text));
            cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(lblProdId.Text));

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("updated successfully");
            LoadStockData();
        }
    }
}
