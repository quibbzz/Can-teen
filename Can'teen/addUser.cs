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
    public partial class addUser : Form
    {
        public addUser()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\quibi\\Documents\\Database1.accdb");

        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new adminMain().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string insertQuery = "INSERT INTO user_accounts ([user_name], [username], [password], [address], [age], [phone_num]) " +
                    "VALUES (@Name, @Username, @Password, @Address, @Age, @Phone)";

                using (OleDbCommand cmd = new OleDbCommand(insertQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@Age", txtAge.Text);
                    cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("NEW CASHIER CREATED.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
