namespace Can_teen
{
    partial class paymentOpt
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cashOpt = new System.Windows.Forms.Button();
            this.gcashOpt = new System.Windows.Forms.Button();
            this.mayaOpt = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monument Extended", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(17, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "PAYMENT OPTIONS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Can_teen.Properties.Resources.smallLogo;
            this.pictureBox1.Location = new System.Drawing.Point(50, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(390, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // cashOpt
            // 
            this.cashOpt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(14)))));
            this.cashOpt.Font = new System.Drawing.Font("Monument Extended", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cashOpt.ForeColor = System.Drawing.Color.White;
            this.cashOpt.Location = new System.Drawing.Point(27, 229);
            this.cashOpt.Name = "cashOpt";
            this.cashOpt.Size = new System.Drawing.Size(447, 65);
            this.cashOpt.TabIndex = 2;
            this.cashOpt.Text = "CASH";
            this.cashOpt.UseVisualStyleBackColor = false;
            this.cashOpt.Click += new System.EventHandler(this.button1_Click);
            // 
            // gcashOpt
            // 
            this.gcashOpt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(14)))));
            this.gcashOpt.Font = new System.Drawing.Font("Monument Extended", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gcashOpt.ForeColor = System.Drawing.Color.White;
            this.gcashOpt.Location = new System.Drawing.Point(27, 318);
            this.gcashOpt.Name = "gcashOpt";
            this.gcashOpt.Size = new System.Drawing.Size(447, 65);
            this.gcashOpt.TabIndex = 3;
            this.gcashOpt.Text = "GCASH";
            this.gcashOpt.UseVisualStyleBackColor = false;
            this.gcashOpt.Click += new System.EventHandler(this.button2_Click);
            // 
            // mayaOpt
            // 
            this.mayaOpt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(14)))));
            this.mayaOpt.Font = new System.Drawing.Font("Monument Extended", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mayaOpt.ForeColor = System.Drawing.Color.White;
            this.mayaOpt.Location = new System.Drawing.Point(27, 405);
            this.mayaOpt.Name = "mayaOpt";
            this.mayaOpt.Size = new System.Drawing.Size(447, 65);
            this.mayaOpt.TabIndex = 5;
            this.mayaOpt.Text = "MAYA";
            this.mayaOpt.UseVisualStyleBackColor = false;
            this.mayaOpt.Click += new System.EventHandler(this.mayaOpt_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(188, 541);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(124, 38);
            this.button5.TabIndex = 6;
            this.button5.Text = "BACK";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // paymentOpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(97)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(496, 602);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.mayaOpt);
            this.Controls.Add(this.gcashOpt);
            this.Controls.Add(this.cashOpt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "paymentOpt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment Options";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button cashOpt;
        private Button gcashOpt;
        private Button mayaOpt;
        private Button button5;
    }
}