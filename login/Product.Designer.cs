namespace login
{
    partial class Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            labelName = new Label();
            lablePrice = new Label();
            labelStock = new Label();
            labelDiscount = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(161, 60);
            labelName.Margin = new Padding(2, 0, 2, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(50, 20);
            labelName.TabIndex = 0;
            labelName.Text = "label1";
            // 
            // lablePrice
            // 
            lablePrice.AutoSize = true;
            lablePrice.Location = new Point(161, 145);
            lablePrice.Margin = new Padding(2, 0, 2, 0);
            lablePrice.Name = "lablePrice";
            lablePrice.Size = new Size(50, 20);
            lablePrice.TabIndex = 2;
            lablePrice.Text = "label3";
            // 
            // labelStock
            // 
            labelStock.AutoSize = true;
            labelStock.Location = new Point(164, 230);
            labelStock.Margin = new Padding(2, 0, 2, 0);
            labelStock.Name = "labelStock";
            labelStock.Size = new Size(50, 20);
            labelStock.TabIndex = 3;
            labelStock.Text = "label4";
            // 
            // labelDiscount
            // 
            labelDiscount.AutoSize = true;
            labelDiscount.Location = new Point(161, 311);
            labelDiscount.Margin = new Padding(2, 0, 2, 0);
            labelDiscount.Name = "labelDiscount";
            labelDiscount.Size = new Size(50, 20);
            labelDiscount.TabIndex = 4;
            labelDiscount.Text = "label5";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Location = new Point(306, 43);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(297, 288);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(10, 60);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 23);
            label1.TabIndex = 6;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(10, 145);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(48, 23);
            label2.TabIndex = 7;
            label2.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            label4.ForeColor = Color.IndianRed;
            label4.Location = new Point(10, 230);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(119, 23);
            label4.TabIndex = 9;
            label4.Text = "Units In Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            label5.ForeColor = Color.IndianRed;
            label5.Location = new Point(10, 311);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(80, 23);
            label5.TabIndex = 10;
            label5.Text = "Discount";
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.b2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(640, 360);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(labelDiscount);
            Controls.Add(labelStock);
            Controls.Add(lablePrice);
            Controls.Add(labelName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Product";
            Text = "Product";
            Load += Product_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private Label lablePrice;
        private Label labelStock;
        private Label labelDiscount;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
    }
}