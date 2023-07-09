using System.Data;
using System.Data.OleDb;
using System.Xml.Linq;

namespace Can_teen
{
    public partial class Form1 : Form
    {
        const double PriceSiomai = 8;
        const double PriceHam = 10;
        const double PricePancit = 15;
        const double PriceGinataan = 25;
        const double PriceTocino = 20;
        const double PriceLumpia = 5;
        const double PriceCoke = 20;
        const double PriceWater = 15;
        const double PriceSprite = 20;

        

            public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\quibi\\Documents\\Database1.accdb");
            //LoadDatabaseData();
            //LoadGridData();

            siombtn.Checked = false;
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.textBox1.AutoSize = true;
            this.textBox1.Height = 55;
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            RestTextBoxes();
            RestRadioBoxes();
        }
        private void RestTextBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox)
                    {
                        if (control == txtboxCustomername)
                        {
                            control.Text = string.Empty; // clear the text without attempting conversion
                        }
                        else
                        {
                            (control as TextBox).Text = "";
                        }
                    }
                    else
                    {
                        func(control.Controls);
                    }
                }
            };
            func(Controls);
        }

        private void RestRadioBoxes()
        {
            siomqty.Text = "";
            hamqty.Text = "";
            panqty.Text = "";
            ginataqty.Text = "";
            pizzqty.Text = "";
            lumpqty.Text = "";
            cokeqty.Text = "";
            waterqty.Text = "";
            spriteqty.Text = "";

            siombtn.Checked = false;
            hambtn.Checked = false;
            pancitbtn.Checked = false;
            ginabtn.Checked = false;
            pizzbtn.Checked = false;
            lumpbtn.Checked = false;
            cokebtn.Checked = false;
            waterbtn.Checked = false;
            spribtn.Checked = false;
        }


        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }



        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pancitbtn_CheckedChanged(object sender, EventArgs e)
        {
            panqty.Text = "0";
        }

        private void ginabtn_CheckedChanged(object sender, EventArgs e)
        {
            ginataqty.Text = "0";
        }

        private void pizzbtn_CheckedChanged(object sender, EventArgs e)
        {
            pizzqty.Text = "0";
        }

        private void lumpbtn_CheckedChanged(object sender, EventArgs e)
        {
            lumpqty.Text = "0";
        }

        private void cokebtn_CheckedChanged(object sender, EventArgs e)
        {
            cokeqty.Text = "0";
        }

        private void waterbtn_CheckedChanged(object sender, EventArgs e)
        {
            waterqty.Text = "0";
        }

        private void spribtn_CheckedChanged(object sender, EventArgs e)
        {
            spriteqty.Text = "0";
        }

        private void siombtn_CheckedChanged(object sender, EventArgs e)
        {
            siomqty.Text = "0";
        }

        private void hambtn_CheckedChanged(object sender, EventArgs e)
        {
            hamqty.Text = "0";
        }

        private void connectionbtn_Click(object sender, EventArgs e)
        {
            OleDbConnection myConn = new OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\quibi\\Documents\\Database1.accdb");
            ds = new DataSet();
            myConn.Open();
            System.Windows.Forms.MessageBox.Show("Connected successfully!");
            myConn.Close();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            {
                double totalAmount = 0;

                // Compute the total amount based on the selected items and quantities
                if (siombtn.Checked) // Siomai
                {
                    int siomaiQty = int.Parse(siomqty.Text);
                    totalAmount += siomaiQty * PriceSiomai;
                }
                if (hambtn.Checked) // Ham
                {
                    int hamQty = int.Parse(hamqty.Text);
                    totalAmount += hamQty * PriceHam;
                }
                if (pancitbtn.Checked) // Pancit
                {
                    int pancitQty = int.Parse(panqty.Text);
                    totalAmount += pancitQty * PricePancit;
                }
                if (ginabtn.Checked) // Ginataan
                {
                    int ginataanQty = int.Parse(ginataqty.Text);
                    totalAmount += ginataanQty * PriceGinataan;
                }
                if (pizzbtn.Checked) // Pizza
                {
                    int pizzaQty = int.Parse(pizzqty.Text);
                    totalAmount += pizzaQty * PriceTocino;
                }
                if (lumpbtn.Checked) // Lumpia
                {
                    int lumpiaQty = int.Parse(lumpqty.Text);
                    totalAmount += lumpiaQty * PriceLumpia;
                }
                if (cokebtn.Checked) // Coke
                {
                    int cokeQty = int.Parse(cokeqty.Text);
                    totalAmount += cokeQty * PriceCoke;
                }
                if (waterbtn.Checked) // Water
                {
                    int waterQty = int.Parse(waterqty.Text);
                    totalAmount += waterQty * PriceWater;
                }
                if (spribtn.Checked) // Sprite
                {
                    int spriteQty = int.Parse(spriteqty.Text);
                    totalAmount += spriteQty * PriceSprite;
                }

                string customerName = txtboxCustomername.Text;

                // Display the total amount and customer name
                MessageBox.Show($"Customer: {customerName}\nTotal Amount: ${totalAmount.ToString("0.00")}");

                try
                {
                    myConn.Open();

                    // Insert the order details into the Orders table
                    string insertOrderQuery = "Insert into Order (SELECT Customer.Customername, " +
                        "Order.siomaiqnty, Order.hamqnty, Order.pancitqnty, Order.ginataanqnty, " +
                        "Order.tocinoqnty, Order.lumpiaqnty, Order.cokeqnty, Order.waterqnty," +
                        " Order.spriteqnty\r\nFROM Customer INNER JOIN [Order] ON Customer.ID = " +
                        "Order.ID;\r\n VALUES (@CustomerName, @SiomaiQty, @HamQty, @PancitQty," +
                        " @GinataanQty, @TocinoQty, @LumpiaQty, @CokeQty, @WaterQty, @SpriteQty)";
                    using (OleDbCommand insertOrderCommand = new OleDbCommand(insertOrderQuery, myConn))
                    {
                        insertOrderCommand.Parameters.AddWithValue("@CustomerName", txtboxCustomername.Text);
                        insertOrderCommand.Parameters.AddWithValue("@SiomaiQty", siomqty.Text);
                        insertOrderCommand.Parameters.AddWithValue("@HamQty", hamqty.Text);
                        insertOrderCommand.Parameters.AddWithValue("@PancitQty", panqty.Text);
                        insertOrderCommand.Parameters.AddWithValue("@GinataanQty", ginataqty.Text);
                        insertOrderCommand.Parameters.AddWithValue("@TocinoQty", pizzqty.Text);
                        insertOrderCommand.Parameters.AddWithValue("@LumpiaQty", lumpqty.Text);
                        insertOrderCommand.Parameters.AddWithValue("@CokeQty", cokeqty.Text);
                        insertOrderCommand.Parameters.AddWithValue("@WaterQty", waterqty.Text);
                        insertOrderCommand.Parameters.AddWithValue("@SpriteQty", spriteqty.Text);

                        insertOrderCommand.ExecuteNonQuery();
                    }

                    MessageBox.Show("Order saved successfully.");

                    myConn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while saving the order: " + ex.Message);
                }
            }
        }

        private void gridOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
