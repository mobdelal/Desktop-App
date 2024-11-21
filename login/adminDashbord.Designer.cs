namespace login
{
    partial class adminDashbord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminDashbord));
            txtcatname = new TextBox();
            txtdesc = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            btn_cat = new Button();
            txtproname = new TextBox();
            product = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            numericUpDown1 = new NumericUpDown();
            textBox1 = new TextBox();
            numericUpDown2 = new NumericUpDown();
            label5 = new Label();
            dataGridproduct = new DataGridView();
            btnupdate = new Button();
            btnDelete = new Button();
            button3 = new Button();
            numericUpDown3 = new NumericUpDown();
            label6 = new Label();
            GridOrderDetail = new DataGridView();
            Combostates = new ComboBox();
            label7 = new Label();
            Updatastatus = new Button();
            Order = new NumericUpDown();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridproduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GridOrderDetail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Order).BeginInit();
            SuspendLayout();
            // 
            // txtcatname
            // 
            txtcatname.Location = new Point(143, 22);
            txtcatname.Name = "txtcatname";
            txtcatname.Size = new Size(125, 27);
            txtcatname.TabIndex = 0;
            // 
            // txtdesc
            // 
            txtdesc.Location = new Point(143, 68);
            txtdesc.Name = "txtdesc";
            txtdesc.Size = new Size(125, 27);
            txtdesc.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(33, 26);
            label1.Name = "label1";
            label1.Size = new Size(83, 23);
            label1.TabIndex = 3;
            label1.Text = "CatName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(33, 69);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 4;
            label2.Text = "Description";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.RosyBrown;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(408, 20);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(569, 175);
            dataGridView1.TabIndex = 6;
            // 
            // btn_cat
            // 
            btn_cat.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            btn_cat.ForeColor = Color.IndianRed;
            btn_cat.Location = new Point(12, 126);
            btn_cat.Name = "btn_cat";
            btn_cat.Size = new Size(84, 29);
            btn_cat.TabIndex = 7;
            btn_cat.Text = "Add Cat";
            btn_cat.UseVisualStyleBackColor = true;
            btn_cat.Click += btn_cat_Click;
            // 
            // txtproname
            // 
            txtproname.Location = new Point(143, 244);
            txtproname.Name = "txtproname";
            txtproname.Size = new Size(125, 27);
            txtproname.TabIndex = 8;
            // 
            // product
            // 
            product.AutoSize = true;
            product.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            product.ForeColor = Color.IndianRed;
            product.Location = new Point(33, 248);
            product.Name = "product";
            product.Size = new Size(70, 23);
            product.TabIndex = 12;
            product.Text = "Product";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.IndianRed;
            label3.Location = new Point(33, 286);
            label3.Name = "label3";
            label3.Size = new Size(48, 23);
            label3.TabIndex = 13;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            label4.ForeColor = Color.IndianRed;
            label4.Location = new Point(33, 330);
            label4.Name = "label4";
            label4.Size = new Size(57, 23);
            label4.TabIndex = 14;
            label4.Text = "Image";
            // 
            // button1
            // 
            button1.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            button1.ForeColor = Color.IndianRed;
            button1.Location = new Point(47, 436);
            button1.Name = "button1";
            button1.Size = new Size(69, 29);
            button1.TabIndex = 15;
            button1.Text = "Add product ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            button2.ForeColor = Color.IndianRed;
            button2.Location = new Point(227, 436);
            button2.Name = "button2";
            button2.Size = new Size(75, 29);
            button2.TabIndex = 16;
            button2.Text = "Delete ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(143, 282);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 27);
            numericUpDown1.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(143, 326);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 18;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(178, 205);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(46, 27);
            numericUpDown2.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            label5.ForeColor = Color.IndianRed;
            label5.Location = new Point(33, 209);
            label5.Name = "label5";
            label5.Size = new Size(95, 23);
            label5.TabIndex = 20;
            label5.Text = "categoryID";
            // 
            // dataGridproduct
            // 
            dataGridproduct.BackgroundColor = Color.RosyBrown;
            dataGridproduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridproduct.Location = new Point(408, 226);
            dataGridproduct.Name = "dataGridproduct";
            dataGridproduct.RowHeadersWidth = 51;
            dataGridproduct.Size = new Size(776, 199);
            dataGridproduct.TabIndex = 21;
            // 
            // btnupdate
            // 
            btnupdate.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            btnupdate.ForeColor = Color.IndianRed;
            btnupdate.Location = new Point(126, 126);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(85, 29);
            btnupdate.TabIndex = 22;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = true;
            btnupdate.Click += btnupdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            btnDelete.ForeColor = Color.IndianRed;
            btnDelete.Location = new Point(227, 126);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 29);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            button3.ForeColor = Color.IndianRed;
            button3.Location = new Point(126, 436);
            button3.Name = "button3";
            button3.Size = new Size(85, 29);
            button3.TabIndex = 24;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(150, 381);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(67, 27);
            numericUpDown3.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            label6.ForeColor = Color.IndianRed;
            label6.Location = new Point(29, 381);
            label6.Name = "label6";
            label6.Size = new Size(87, 23);
            label6.TabIndex = 26;
            label6.Text = "UnitStock";
            // 
            // GridOrderDetail
            // 
            GridOrderDetail.BackgroundColor = Color.RosyBrown;
            GridOrderDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridOrderDetail.Location = new Point(408, 471);
            GridOrderDetail.Name = "GridOrderDetail";
            GridOrderDetail.RowHeadersWidth = 51;
            GridOrderDetail.Size = new Size(594, 188);
            GridOrderDetail.TabIndex = 27;
            // 
            // Combostates
            // 
            Combostates.FormattingEnabled = true;
            Combostates.Location = new Point(178, 551);
            Combostates.Name = "Combostates";
            Combostates.Size = new Size(151, 28);
            Combostates.TabIndex = 28;
            Combostates.SelectedIndexChanged += Combostates_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            label7.ForeColor = Color.IndianRed;
            label7.Location = new Point(29, 552);
            label7.Name = "label7";
            label7.Size = new Size(129, 23);
            label7.TabIndex = 29;
            label7.Text = "Order Tracking";
            // 
            // Updatastatus
            // 
            Updatastatus.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            Updatastatus.ForeColor = Color.IndianRed;
            Updatastatus.Location = new Point(29, 597);
            Updatastatus.Name = "Updatastatus";
            Updatastatus.Size = new Size(85, 29);
            Updatastatus.TabIndex = 30;
            Updatastatus.Text = "Update";
            Updatastatus.UseVisualStyleBackColor = true;
            Updatastatus.Click += Updatastatus_Click;
            // 
            // Order
            // 
            Order.Location = new Point(178, 518);
            Order.Name = "Order";
            Order.Size = new Size(46, 27);
            Order.TabIndex = 31;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            label8.ForeColor = Color.IndianRed;
            label8.Location = new Point(29, 518);
            label8.Name = "label8";
            label8.Size = new Size(76, 23);
            label8.TabIndex = 32;
            label8.Text = "OrderID";
            // 
            // adminDashbord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.b3;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1284, 713);
            Controls.Add(label8);
            Controls.Add(Order);
            Controls.Add(Updatastatus);
            Controls.Add(label7);
            Controls.Add(Combostates);
            Controls.Add(GridOrderDetail);
            Controls.Add(label6);
            Controls.Add(numericUpDown3);
            Controls.Add(button3);
            Controls.Add(btnDelete);
            Controls.Add(btnupdate);
            Controls.Add(dataGridproduct);
            Controls.Add(label5);
            Controls.Add(numericUpDown2);
            Controls.Add(textBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(product);
            Controls.Add(txtproname);
            Controls.Add(btn_cat);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtdesc);
            Controls.Add(txtcatname);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "adminDashbord";
            Text = "adminDashbord";
            Load += adminDashbord_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridproduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)GridOrderDetail).EndInit();
            ((System.ComponentModel.ISupportInitialize)Order).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtcatname;
        private TextBox txtdesc;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private Button btn_cat;
        private TextBox txtproname;
        private Label product;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private NumericUpDown numericUpDown1;
        private TextBox textBox1;
        private NumericUpDown numericUpDown2;
        private Label label5;
        private DataGridView dataGridproduct;
        private Button btnupdate;
        private Button btnDelete;
        private Button button3;
        private NumericUpDown numericUpDown3;
        private Label label6;
        private DataGridView GridOrderDetail;
        private ComboBox Combostates;
        private Label label7;
        private Button Updatastatus;
        private NumericUpDown Order;
        private Label label8;
    }
}