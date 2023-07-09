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

    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\quibi\\Documents\\Database1.accdb");

        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        private void loginbtn_Click(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            con.Open();
            string login = "SELECT * FROM userAcc WHERE username= @username and password= @password";
            cmd = new OleDbCommand(login, con);
            cmd.Parameters.AddWithValue("@username", txtUser.Text);
            cmd.Parameters.AddWithValue("@password", txtpass.Text);

            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(ds);

            while (true)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    if (txtUser.Text == "admin")
                    {
                        new adminMain().Show();
                        this.Hide();
                        break;
                    }
                    else
                    {
                        new orderForm().Show();
                        this.Hide();
                        break; 
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password, Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtpass.Text = "";
                    txtpass.Text = "";
                    txtUser.Focus();
                    break;
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (togglePass.Checked)
            {
                txtpass.PasswordChar = '\0';
            }
            else
            {
                txtpass.PasswordChar = '*';
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new signUp().Show();
            this.Hide();
        }
    }
}
            
        

