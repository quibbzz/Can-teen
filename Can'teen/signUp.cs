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
    public partial class signUp : Form
    {
        public signUp()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\quibi\\Documents\\Database1.accdb");

        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new LogIn().Show();
            this.Hide();
        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void signUpbtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string insertQuery = "INSERT INTO user_accounts ([user_name], [username], [password], [address], [age], [phone_num]) " +
                    "VALUES (@Name, @Username, @Password, @Address, @Age, @Phone)";

                using (OleDbCommand cmd = new OleDbCommand(insertQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Username", textUsername.Text);
                    cmd.Parameters.AddWithValue("@Password", textPassword.Text);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@Age", txtAge.Text);
                    cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Registration successful.");
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
