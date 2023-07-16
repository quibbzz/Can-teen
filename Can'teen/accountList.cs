using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Can_teen
{
    public partial class accountList : Form
    {
        public accountList()
        {
            InitializeComponent();
            LoadAccountData();
        }
        OleDbConnection con = new OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\quibi\\Documents\\Database1.accdb");

        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void LoadAccountData()
        {
            try
            {
                con.Open();

                string selectQuery = "SELECT * FROM user_accounts";

                da = new OleDbDataAdapter(selectQuery, con);
                ds = new DataSet();
                da.Fill(ds, "Accounts");

                dataGridView1.DataSource = ds.Tables["Accounts"];



                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading account data: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new adminMain().Show();
            this.Hide();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtUsername.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtPassword.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtAddress.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtAge.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtPhone.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "UPDATE user_accounts SET [user_name]= @User_Name, [username] = @Username, [password] = @Password , [address] = @Address, [age] = @Age, [phone_num] = @PhoneNum WHERE [account_id] = @Id";
            cmd = new OleDbCommand(query, con);

            cmd.Parameters.AddWithValue("@User_Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@Age", txtAge.Text);
            cmd.Parameters.AddWithValue("@PhoneNum", txtPhone.Text);
            cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(txtID.Text));

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("updated successfully");
            //showStud();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM user_accounts WHERE account_id = @Id";
            cmd = new OleDbCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(txtID.Text));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("deleted successfully");
            //showStud();
        }
    }
}
