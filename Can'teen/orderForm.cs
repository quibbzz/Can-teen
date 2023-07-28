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
            PrintStocks();
        }
       

        private void PrintStocks()
        {
            try
            {
                myConn.Open();

                // Siomai
                string siomaiStockQuery = "SELECT [num_stock] FROM stock WHERE [stock_id] = 1";
                using (OleDbCommand siomaiStockCommand = new OleDbCommand(siomaiStockQuery, myConn))
                {
                    object siomaiResult = siomaiStockCommand.ExecuteScalar();
                    if (siomaiResult != null && siomaiResult != DBNull.Value)
                    {
                        int siomaiStock = Convert.ToInt32(siomaiResult);
                        lblSiomaiStcks.Text = string.Format("{0}x", siomaiStock);

                    }
                    else
                    {
                        lblSiomaiStcks.Text = "OUT OF STOCK";
                    }
                }

                // Ham
                string hamStockQuery = "SELECT [num_stock] FROM stock WHERE [stock_id] = 2";
                using (OleDbCommand hamStockCommand = new OleDbCommand(hamStockQuery, myConn))
                {
                    object hamResult = hamStockCommand.ExecuteScalar();
                    if (hamResult != null && hamResult != DBNull.Value)
                    {
                        int hamStock = Convert.ToInt32(hamResult);
                        lblHamStcks.Text = string.Format("{0}x", hamStock);
                    }
                    else
                    {
                        lblHamStcks.Text = "OUT OF STOCK";
                    }
                }

                // Pancit
                string pancitStockQuery = "SELECT [num_stock] FROM stock WHERE [stock_id] = 3";
                using (OleDbCommand pancitStockCommand = new OleDbCommand(pancitStockQuery, myConn))
                {
                    object pancitResult = pancitStockCommand.ExecuteScalar();
                    if (pancitResult != null && pancitResult != DBNull.Value)
                    {
                        int pancitStock = Convert.ToInt32(pancitResult);
                        lblPancitStcks.Text = string.Format("{0}x", pancitStock);
                    }
                    else
                    {
                        lblPancitStcks.Text = "OUT OF STOCK";
                    }
                }

                // Ginataan
                string ginataanStockQuery = "SELECT [num_stock] FROM stock WHERE [stock_id] = 4";
                using (OleDbCommand ginataanStockCommand = new OleDbCommand(ginataanStockQuery, myConn))
                {
                    object ginataanResult = ginataanStockCommand.ExecuteScalar();
                    if (ginataanResult != null && ginataanResult != DBNull.Value)
                    {
                        int ginataanStock = Convert.ToInt32(ginataanResult);
                        lblGinataanStcks.Text = string.Format("{0}x", ginataanStock);
                    }
                    else
                    {
                        lblGinataanStcks.Text = "OUT OF STOCK";
                    }
                }

                // Tocino
                string tocinoStockQuery = "SELECT [num_stock] FROM stock WHERE [stock_id] = 5";
                using (OleDbCommand tocinoStockCommand = new OleDbCommand(tocinoStockQuery, myConn))
                {
                    object tocinoResult = tocinoStockCommand.ExecuteScalar();
                    if (tocinoResult != null && tocinoResult != DBNull.Value)
                    {
                        int tocinoStock = Convert.ToInt32(tocinoResult);
                        lblTocinoStcks.Text = string.Format("{0}x", tocinoStock);
                    }
                    else
                    {
                        lblTocinoStcks.Text = "OUT OF STOCK";
                    }
                }

                // Lumpia
                string lumpiaStockQuery = "SELECT [num_stock] FROM stock WHERE [stock_id] = 6";
                using (OleDbCommand lumpiaStockCommand = new OleDbCommand(lumpiaStockQuery, myConn))
                {
                    object lumpiaResult = lumpiaStockCommand.ExecuteScalar();
                    if (lumpiaResult != null && lumpiaResult != DBNull.Value)
                    {
                        int lumpiaStock = Convert.ToInt32(lumpiaResult);
                        lblLumpiaStcks.Text = string.Format("{0}x", lumpiaStock);
                    }
                    else
                    {
                        lblLumpiaStcks.Text = "OUT OF STOCK";
                    }
                }

                // Coke
                string cokeStockQuery = "SELECT [num_stock] FROM stock WHERE [stock_id] = 7";
                using (OleDbCommand cokeStockCommand = new OleDbCommand(cokeStockQuery, myConn))
                {
                    object cokeResult = cokeStockCommand.ExecuteScalar();
                    if (cokeResult != null && cokeResult != DBNull.Value)
                    {
                        int cokeStock = Convert.ToInt32(cokeResult);
                        lblCokeStcks.Text = string.Format("{0}x", cokeStock);
                    }
                    else
                    {
                        lblCokeStcks.Text = "OUT OF STOCK";
                    }
                }

                // Water
                string waterStockQuery = "SELECT [num_stock] FROM stock WHERE [stock_id] = 8";
                using (OleDbCommand waterStockCommand = new OleDbCommand(waterStockQuery, myConn))
                {
                    object waterResult = waterStockCommand.ExecuteScalar();
                    if (waterResult != null && waterResult != DBNull.Value)
                    {
                        int waterStock = Convert.ToInt32(waterResult);
                        lblWaterStcks.Text = string.Format("{0}x", waterStock);
                    }
                    else
                    {
                        lblWaterStcks.Text = "OUT OF STOCK";
                    }
                }

                // Sprite
                string spriteStockQuery = "SELECT [num_stock] FROM stock WHERE [stock_id] = 9";
                using (OleDbCommand spriteStockCommand = new OleDbCommand(spriteStockQuery, myConn))
                {
                    object spriteResult = spriteStockCommand.ExecuteScalar();
                    if (spriteResult != null && spriteResult != DBNull.Value)
                    {
                        int spriteStock = Convert.ToInt32(spriteResult);
                        lblSpriteStcks.Text = string.Format("{0}x", spriteStock);
                    }
                    else
                    {
                        lblSpriteStcks.Text = "OUT OF STOCK";
                    }
                }

                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving the stock data: " + ex.Message);
            }

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
                            control.Text = string.Empty; 
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
        public static double TotalAmount { get; set; }
        private void savebtn_Click(object sender, EventArgs e)
        {
            {

                double totalAmount = 0;

                TotalAmount= totalAmount;


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


                    // Siomai
                    string subtractSiomai = "UPDATE stock SET [num_stock] = [num_stock] - @siomaiQty WHERE [stock_id] = 1";
                    using (OleDbCommand insertSiomaiCommand = new OleDbCommand(subtractSiomai, myConn))
                    {
                        int siomaiQty;
                        if (int.TryParse(siomqty.Text, out siomaiQty))
                        {
                            insertSiomaiCommand.Parameters.AddWithValue("@siomaiQty", siomaiQty);
                            insertSiomaiCommand.ExecuteNonQuery();
                        }
                    }

                    // Ham
                    string subtractHam = "UPDATE stock SET [num_stock] = [num_stock] - @hamQty WHERE [stock_id] = 2";
                    using (OleDbCommand insertHamCommand = new OleDbCommand(subtractHam, myConn))
                    {
                        int hamQty;
                        if (int.TryParse(hamqty.Text, out hamQty))
                        {
                            insertHamCommand.Parameters.AddWithValue("@hamQty", hamQty);
                            insertHamCommand.ExecuteNonQuery();
                        }
                    }

                    // Pancit
                    string subtractPancit = "UPDATE stock SET [num_stock] = [num_stock] - @panQty WHERE [stock_id] = 3";
                    using (OleDbCommand insertPancitCommand = new OleDbCommand(subtractPancit, myConn))
                    {
                        int panQty;
                        if (int.TryParse(panqty.Text, out panQty))
                        {
                            insertPancitCommand.Parameters.AddWithValue("@panQty", panQty);
                            insertPancitCommand.ExecuteNonQuery();
                        }
                    }

                    // Ginataan
                    string subtractGinataan = "UPDATE stock SET [num_stock] = [num_stock] - @ginataQty WHERE [stock_id] = 4";
                    using (OleDbCommand insertGinataanCommand = new OleDbCommand(subtractGinataan, myConn))
                    {
                        int ginataQty;
                        if (int.TryParse(ginataqty.Text, out ginataQty))
                        {
                            insertGinataanCommand.Parameters.AddWithValue("@ginataQty", ginataQty);
                            insertGinataanCommand.ExecuteNonQuery();
                        }
                    }

                    // Tocino
                    string subtractTocino = "UPDATE stock SET [num_stock] = [num_stock] - @tocinoQty WHERE [stock_id] = 5";
                    using (OleDbCommand insertTocinoCommand = new OleDbCommand(subtractTocino, myConn))
                    {
                        int tocinoQty;
                        if (int.TryParse(pizzqty.Text, out tocinoQty))
                        {
                            insertTocinoCommand.Parameters.AddWithValue("@tocinoQty", tocinoQty);
                            insertTocinoCommand.ExecuteNonQuery();
                        }
                    }

                    // Lumpia
                    string subtractLumpia = "UPDATE stock SET [num_stock] = [num_stock] - @lumpiaQty WHERE [stock_id] = 6";
                    using (OleDbCommand insertLumpiaCommand = new OleDbCommand(subtractLumpia, myConn))
                    {
                        int lumpiaQty;
                        if (int.TryParse(lumpqty.Text, out lumpiaQty))
                        {
                            insertLumpiaCommand.Parameters.AddWithValue("@lumpiaQty", lumpiaQty);
                            insertLumpiaCommand.ExecuteNonQuery();
                        }
                    }

                    // Coke
                    string subtractCoke = "UPDATE stock SET [num_stock] = [num_stock] - @cokeQty WHERE [stock_id] = 7";
                    using (OleDbCommand insertCokeCommand = new OleDbCommand(subtractCoke, myConn))
                    {
                        int cokeQty;
                        if (int.TryParse(cokeqty.Text, out cokeQty))
                        {
                            insertCokeCommand.Parameters.AddWithValue("@cokeQty", cokeQty);
                            insertCokeCommand.ExecuteNonQuery();
                        }
                    }

                    // Water
                    string subtractWater = "UPDATE stock SET [num_stock] = [num_stock] - @waterQty WHERE [stock_id] = 8";
                    using (OleDbCommand insertWaterCommand = new OleDbCommand(subtractWater, myConn))
                    {
                        int waterQty;
                        if (int.TryParse(waterqty.Text, out waterQty))
                        {
                            insertWaterCommand.Parameters.AddWithValue("@waterQty", waterQty);
                            insertWaterCommand.ExecuteNonQuery();
                        }
                    }

                    // Sprite
                    string subtractSprite = "UPDATE stock SET [num_stock] = [num_stock] - @spriteQty WHERE [stock_id] = 9";
                    using (OleDbCommand insertSpriteCommand = new OleDbCommand(subtractSprite, myConn))
                    {
                        int spriteQty;
                        if (int.TryParse(spriteqty.Text, out spriteQty))
                        {
                            insertSpriteCommand.Parameters.AddWithValue("@spriteQty", spriteQty);
                            insertSpriteCommand.ExecuteNonQuery();
                        }
                    }

                   
                    string checkStocks = "SELECT [num_stock] FROM stock";
                    using (OleDbCommand selectStocksCommand = new OleDbCommand(checkStocks, myConn))
                    {
                        int stockQuantity = Convert.ToInt32(selectStocksCommand.ExecuteScalar());

                        if (stockQuantity <= 0)
                        {
                            MessageBox.Show("Out of stock");
                        }
                        else
                        {
                            
                        }
                    }
                    
                    myConn.Close();
                    this.Close();
                    orderForm of = new orderForm();
                    of.Show();
                    RestTextBoxes();
                    RestRadioBoxes();
                    LoadGridData();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while saving the order: " + ex.Message);
                }
            }

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

                string selectOrderQuery = "SELECT * FROM [Orders] ORDER BY ID DESC";
                
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
                myConn.Open();

                using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                {
                    DataTable orderTable = new DataTable();
                    adapter.Fill(orderTable);

                    gridOrders.DataSource = orderTable;
                }
               
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
        private void button2_Click(object sender, EventArgs e)
        {
            new productStocks().Show(); 
            this.Hide();    
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}