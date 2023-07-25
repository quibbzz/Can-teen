namespace Can_teen
{
    partial class adminSalesReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridTable = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblYearly = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMonthly = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblWeekly = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblDaily = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblOrders = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblMaya = new System.Windows.Forms.Label();
            this.lblGcash = new System.Windows.Forms.Label();
            this.lblCash = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monument Extended", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(674, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "SALES REPORT";
            // 
            // DataGridTable
            // 
            this.DataGridTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridTable.Location = new System.Drawing.Point(17, 507);
            this.DataGridTable.Name = "DataGridTable";
            this.DataGridTable.RowHeadersWidth = 51;
            this.DataGridTable.RowTemplate.Height = 29;
            this.DataGridTable.Size = new System.Drawing.Size(1225, 382);
            this.DataGridTable.TabIndex = 1;
            this.DataGridTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblYearly);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(980, 309);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 128);
            this.panel1.TabIndex = 2;
            // 
            // lblYearly
            // 
            this.lblYearly.AutoSize = true;
            this.lblYearly.BackColor = System.Drawing.SystemColors.Window;
            this.lblYearly.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblYearly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblYearly.Location = new System.Drawing.Point(97, 71);
            this.lblYearly.Name = "lblYearly";
            this.lblYearly.Size = new System.Drawing.Size(165, 44);
            this.lblYearly.TabIndex = 1;
            this.lblYearly.Text = "3,000.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monument Extended", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(14)))));
            this.label2.Location = new System.Drawing.Point(14, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "YEARLY";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblMonthly);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(658, 309);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(301, 128);
            this.panel2.TabIndex = 3;
            // 
            // lblMonthly
            // 
            this.lblMonthly.AutoSize = true;
            this.lblMonthly.BackColor = System.Drawing.SystemColors.Window;
            this.lblMonthly.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMonthly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblMonthly.Location = new System.Drawing.Point(104, 71);
            this.lblMonthly.Name = "lblMonthly";
            this.lblMonthly.Size = new System.Drawing.Size(191, 44);
            this.lblMonthly.TabIndex = 2;
            this.lblMonthly.Text = "₱2,300.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monument Extended", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(14)))));
            this.label3.Location = new System.Drawing.Point(14, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 36);
            this.label3.TabIndex = 1;
            this.label3.Text = "MONTHLY";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblWeekly);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(337, 309);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(301, 128);
            this.panel3.TabIndex = 3;
            // 
            // lblWeekly
            // 
            this.lblWeekly.AutoSize = true;
            this.lblWeekly.BackColor = System.Drawing.SystemColors.Window;
            this.lblWeekly.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWeekly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblWeekly.Location = new System.Drawing.Point(124, 71);
            this.lblWeekly.Name = "lblWeekly";
            this.lblWeekly.Size = new System.Drawing.Size(165, 44);
            this.lblWeekly.TabIndex = 3;
            this.lblWeekly.Text = "3,000.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monument Extended", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(14)))));
            this.label4.Location = new System.Drawing.Point(17, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 36);
            this.label4.TabIndex = 2;
            this.label4.Text = "WEEKLY";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.lblDaily);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(23, 309);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(299, 128);
            this.panel4.TabIndex = 4;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // lblDaily
            // 
            this.lblDaily.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblDaily.AutoSize = true;
            this.lblDaily.BackColor = System.Drawing.SystemColors.Window;
            this.lblDaily.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDaily.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblDaily.Location = new System.Drawing.Point(162, 71);
            this.lblDaily.Name = "lblDaily";
            this.lblDaily.Size = new System.Drawing.Size(134, 44);
            this.lblDaily.TabIndex = 4;
            this.lblDaily.Text = "100.00";
            this.lblDaily.Click += new System.EventHandler(this.lblDaily_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monument Extended", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(14)))));
            this.label5.Location = new System.Drawing.Point(17, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 36);
            this.label5.TabIndex = 3;
            this.label5.Text = "DAILY";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // dateFrom
            // 
            this.dateFrom.Location = new System.Drawing.Point(117, 465);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(262, 27);
            this.dateFrom.TabIndex = 6;
            // 
            // dateTo
            // 
            this.dateTo.Location = new System.Drawing.Point(436, 464);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(262, 27);
            this.dateTo.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(33, 466);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 28);
            this.label6.TabIndex = 8;
            this.label6.Text = "FROM:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(385, 463);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 28);
            this.label7.TabIndex = 9;
            this.label7.Text = "TO:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(1066, 457);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 34);
            this.button2.TabIndex = 10;
            this.button2.Text = "SELECT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.lblOrders);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Location = new System.Drawing.Point(20, 134);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(302, 153);
            this.panel7.TabIndex = 5;
            // 
            // lblOrders
            // 
            this.lblOrders.AutoSize = true;
            this.lblOrders.BackColor = System.Drawing.SystemColors.Window;
            this.lblOrders.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblOrders.Location = new System.Drawing.Point(79, 16);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(130, 93);
            this.lblOrders.TabIndex = 1;
            this.lblOrders.Text = "52";
            this.lblOrders.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Monument Extended", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(14)))));
            this.label12.Location = new System.Drawing.Point(20, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(255, 28);
            this.label12.TabIndex = 0;
            this.label12.Text = "TOTAL ORDERS";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Can_teen.Properties.Resources.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(268, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(658, 13);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(10, 101);
            this.panel9.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.lblMaya);
            this.panel5.Controls.Add(this.lblGcash);
            this.panel5.Controls.Add(this.lblCash);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Location = new System.Drawing.Point(337, 134);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(918, 153);
            this.panel5.TabIndex = 13;
            // 
            // lblMaya
            // 
            this.lblMaya.AutoSize = true;
            this.lblMaya.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMaya.ForeColor = System.Drawing.Color.Brown;
            this.lblMaya.Location = new System.Drawing.Point(716, 35);
            this.lblMaya.Name = "lblMaya";
            this.lblMaya.Size = new System.Drawing.Size(90, 54);
            this.lblMaya.TabIndex = 5;
            this.lblMaya.Text = "100";
            // 
            // lblGcash
            // 
            this.lblGcash.AutoSize = true;
            this.lblGcash.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGcash.ForeColor = System.Drawing.Color.Brown;
            this.lblGcash.Location = new System.Drawing.Point(415, 35);
            this.lblGcash.Name = "lblGcash";
            this.lblGcash.Size = new System.Drawing.Size(90, 54);
            this.lblGcash.TabIndex = 4;
            this.lblGcash.Text = "100";
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCash.ForeColor = System.Drawing.Color.Brown;
            this.lblCash.Location = new System.Drawing.Point(99, 35);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(90, 54);
            this.lblCash.TabIndex = 3;
            this.lblCash.Text = "100";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(99, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 38);
            this.label8.TabIndex = 2;
            this.label8.Text = "CASH";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Can_teen.Properties.Resources.mayaLogoSmall;
            this.pictureBox3.Location = new System.Drawing.Point(729, 107);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(111, 30);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Can_teen.Properties.Resources.gcashLogoSmall1;
            this.pictureBox2.Location = new System.Drawing.Point(400, 107);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 35);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // adminSalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1275, 928);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DataGridTable);
            this.Controls.Add(this.label1);
            this.Name = "adminSalesReport";
            this.Text = "adminSalesReport";
            this.Load += new System.EventHandler(this.adminSalesReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView DataGridTable;
        private Panel panel1;
        private Label lblYearly;
        private Label label2;
        private Panel panel2;
        private Label lblMonthly;
        private Label label3;
        private Panel panel3;
        private Label lblWeekly;
        private Label label4;
        private Panel panel4;
        private Label lblDaily;
        private Label label5;
        private Button button1;
        private System.Windows.Forms.Timer timer;
        private DateTimePicker dateFrom;
        private DateTimePicker dateTo;
        private Label label6;
        private Label label7;
        private Button button2;
        private Panel panel7;
        private Label lblOrders;
        private Label label12;
        private PictureBox pictureBox1;
        private Panel panel9;
        private Panel panel5;
        private Label lblMaya;
        private Label lblGcash;
        private Label lblCash;
        private Label label8;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
    }
}