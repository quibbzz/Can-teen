using System.Data;
using System.Data.OleDb;
using System.Xml.Linq;

namespace Can_teen
{
    public partial class orderForm : Form
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



        public orderForm()
        {
            InitializeComponent();
            myConn = new OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\quibi\\Documents\\Database1.accdb");
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
            LoadGridData();

            RestTextBoxes();
            RestRadioBoxes();
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
            new LogIn().Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pancitbtn_CheckedChanged(object sender, EventArgs e)
        {
            panqty.Text = "";
        }

        private void ginabtn_CheckedChanged(object sender, EventArgs e)
        {
            ginataqty.Text = "";
        }

        private void pizzbtn_CheckedChanged(object sender, EventArgs e)
        {
            pizzqty.Text = "";
        }

        private void lumpbtn_CheckedChanged(object sender, EventArgs e)
        {
            lumpqty.Text = "";
        }

        private void cokebtn_CheckedChanged(object sender, EventArgs e)
        {
            cokeqty.Text = "";
        }

        private void waterbtn_CheckedChanged(object sender, EventArgs e)
        {
            waterqty.Text = "";
        }

        private void spribtn_CheckedChanged(object sender, EventArgs e)
        {
            spriteqty.Text = "";
        }

        private void siombtn_CheckedChanged(object sender, EventArgs e)
        {
            siomqty.Text = "";
        }

        private void hambtn_CheckedChanged(object sender, EventArgs e)
        {
            hamqty.Text = "";
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

                double totalAmount = CalculateTotalAmount();

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

                textBox1.Text = totalAmount.ToString("P 0.00");


                try
                {
                    myConn.Open();

                    // Insert the order details into the Orders table
                    string insertOrderQuery = "INSERT INTO [Orders] (customer_name, siomaiqnty, hamqnty, pancitqnty, ginataanqnty, " +
                        "tocinoqnty, lumpiaqnty, cokeqnty, waterqnty, spriteqnty, total_amount, added_on) VALUES (@CustomerName, @SiomaiQty, " +
                        "@HamQty, @PancitQty, @GinataanQty, @TocinoQty, @LumpiaQty, @CokeQty, @WaterQty, @SpriteQty, @totalAmount, @AddedOn)";

                    using (OleDbCommand insertOrderCommand = new OleDbCommand(insertOrderQuery, myConn))
                    {
                        insertOrderCommand.Parameters.AddWithValue("@CustomerName", customerName);
                        insertOrderCommand.Parameters.AddWithValue("@SiomaiQty", siomqty.Text);
                        insertOrderCommand.Parameters.AddWithValue("@HamQty", hamqty.Text);
                        insertOrderCommand.Parameters.AddWithValue("@PancitQty", panqty.Text);
                        insertOrderCommand.Parameters.AddWithValue("@GinataanQty", ginataqty.Text);
                        insertOrderCommand.Parameters.AddWithValue("@TocinoQty", pizzqty.Text);
                        insertOrderCommand.Parameters.AddWithValue("@LumpiaQty", lumpqty.Text);
                        insertOrderCommand.Parameters.AddWithValue("@CokeQty", cokeqty.Text);
                        insertOrderCommand.Parameters.AddWithValue("@WaterQty", waterqty.Text);
                        insertOrderCommand.Parameters.AddWithValue("@SpriteQty", spriteqty.Text);
                        insertOrderCommand.Parameters.AddWithValue("@TotalAmount", totalAmount);
                        insertOrderCommand.Parameters.AddWithValue("@AddedOn", DateTime.Now.ToString("MM/dd/yyyy"));


                        insertOrderCommand.ExecuteNonQuery();
                    }

                    MessageBox.Show("Order saved successfully.");

                    myConn.Close();
                    LoadGridData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while saving the order: " + ex.Message);
                }
            }

        }
        private double CalculateTotalAmount()
        {
            double totalAmount = 0;

            totalAmount += GetQuantity(siomqty.Text) * PriceSiomai;
            totalAmount += GetQuantity(hamqty.Text) * PriceHam;
            totalAmount += GetQuantity(panqty.Text) * PricePancit;
            totalAmount += GetQuantity(ginataqty.Text) * PriceGinataan;
            totalAmount += GetQuantity(pizzqty.Text) * PriceTocino;
            totalAmount += GetQuantity(lumpqty.Text) * PriceLumpia;
            totalAmount += GetQuantity(cokeqty.Text) * PriceCoke;
            totalAmount += GetQuantity(waterqty.Text) * PriceWater;
            totalAmount += GetQuantity(spriteqty.Text) * PriceSprite;

            return totalAmount;
        }

        private int GetQuantity(string quantityText)
        {
            int quantity = 0;
            int.TryParse(quantityText, out quantity);
            return quantity;
        }

        private void LoadGridData()
            {
                try
                {
                    myConn.Open();

                    string selectOrderQuery = "SELECT * FROM [Orders]";
                    da = new OleDbDataAdapter(selectOrderQuery, myConn);
                    ds = new DataSet();
                    da.Fill(ds, "Orders");
                    gridOrders.DataSource = ds.Tables["Orders"];

                    myConn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading the order data: " + ex.Message);
                }
            }

            private void gridOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                try
                {
                    //string selectedDate = dateTimePicker1.Value.ToShortDateString();
                    myConn.Open();

                // Retrieve the orders for the selected date from the Order table
                //string selectOrderQuery = "SELECT * FROM [Order] WHERE added_on = @OrderDate"; // Replace YourDateColumnName with the actual column name in your table
                //using (OleDbCommand cmd = new OleDbCommand(selectOrdersQuery, myConn))
                //{
                //cmd.Parameters.AddWithValue("@orderdatee", added_on);

                using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            DataTable orderTable = new DataTable();
                            adapter.Fill(orderTable);

                            // Bind the data to the gridOrders DataGridView
                            gridOrders.DataSource = orderTable;
                        }
                    //}

                    myConn.Close();
                }
                catch (Exception ex)
                {
                MessageBox.Show("An error occurred while retrieving the order data: " + ex.Message);
                }
            }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            new paymentOpt().Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new userSalesReport().Show();
            this.Hide();
        }
    }
}
