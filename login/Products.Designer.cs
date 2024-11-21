namespace login
{
    partial class Products
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            panel1 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            buttonsearch = new Button();
            textBoxsearch = new TextBox();
            buttonNext = new Button();
            buttonPrev = new Button();
            button2 = new Button();
            buttonprice = new Button();
            comboBoxCategory = new ComboBox();
            numericPrice = new NumericUpDown();
            tabPage2 = new TabPage();
            Submit = new Button();
            dataGridViewcart = new DataGridView();
            tabPage3 = new TabPage();
            dataGridView2 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericPrice).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewcart).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1402, 101);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(535, 23);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(172, 50);
            label1.TabIndex = 0;
            label1.Text = "Products";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.RosyBrown;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(449, 107);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(954, 697);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1416, 840);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.BackgroundImage = Properties.Resources.b2;
            tabPage1.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage1.Controls.Add(buttonsearch);
            tabPage1.Controls.Add(textBoxsearch);
            tabPage1.Controls.Add(buttonNext);
            tabPage1.Controls.Add(buttonPrev);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(buttonprice);
            tabPage1.Controls.Add(comboBoxCategory);
            tabPage1.Controls.Add(numericPrice);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(panel1);
            tabPage1.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1408, 807);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Products";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonsearch
            // 
            buttonsearch.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            buttonsearch.ForeColor = Color.IndianRed;
            buttonsearch.Location = new Point(123, 416);
            buttonsearch.Name = "buttonsearch";
            buttonsearch.Size = new Size(112, 34);
            buttonsearch.TabIndex = 9;
            buttonsearch.Text = "Search";
            buttonsearch.UseVisualStyleBackColor = true;
            buttonsearch.Click += buttonsearch_Click;
            // 
            // textBoxsearch
            // 
            textBoxsearch.Location = new Point(17, 338);
            textBoxsearch.Name = "textBoxsearch";
            textBoxsearch.PlaceholderText = "Enter Product Name";
            textBoxsearch.Size = new Size(355, 30);
            textBoxsearch.TabIndex = 8;
            // 
            // buttonNext
            // 
            buttonNext.Location = new Point(826, 851);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(180, 34);
            buttonNext.TabIndex = 7;
            buttonNext.Text = "Move Next >";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // buttonPrev
            // 
            buttonPrev.Location = new Point(498, 851);
            buttonPrev.Name = "buttonPrev";
            buttonPrev.Size = new Size(180, 34);
            buttonPrev.TabIndex = 6;
            buttonPrev.Text = "< Move Previous";
            buttonPrev.UseVisualStyleBackColor = true;
            buttonPrev.Click += buttonPrev_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            button2.ForeColor = Color.IndianRed;
            button2.Location = new Point(192, 254);
            button2.Name = "button2";
            button2.Size = new Size(180, 34);
            button2.TabIndex = 5;
            button2.Text = "Filter by Category";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // buttonprice
            // 
            buttonprice.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonprice.ForeColor = Color.IndianRed;
            buttonprice.Location = new Point(192, 163);
            buttonprice.Name = "buttonprice";
            buttonprice.Size = new Size(180, 34);
            buttonprice.TabIndex = 4;
            buttonprice.Text = "Filter By Price";
            buttonprice.UseVisualStyleBackColor = true;
            buttonprice.Click += buttonprice_Click;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(17, 254);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(163, 31);
            comboBoxCategory.TabIndex = 3;
            // 
            // numericPrice
            // 
            numericPrice.Location = new Point(17, 163);
            numericPrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericPrice.Name = "numericPrice";
            numericPrice.Size = new Size(163, 30);
            numericPrice.TabIndex = 2;
            // 
            // tabPage2
            // 
            tabPage2.BackgroundImage = Properties.Resources.b3;
            tabPage2.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage2.Controls.Add(Submit);
            tabPage2.Controls.Add(dataGridViewcart);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1408, 807);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Cart";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Submit
            // 
            Submit.Anchor = AnchorStyles.None;
            Submit.BackColor = Color.RosyBrown;
            Submit.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Submit.ForeColor = Color.FromArgb(64, 0, 0);
            Submit.Location = new Point(590, 541);
            Submit.Margin = new Padding(5);
            Submit.Name = "Submit";
            Submit.Padding = new Padding(10, 10, 15, 10);
            Submit.Size = new Size(217, 55);
            Submit.TabIndex = 1;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = false;
            Submit.Click += button1_Click;
            // 
            // dataGridViewcart
            // 
            dataGridViewcart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewcart.BackgroundColor = Color.RosyBrown;
            dataGridViewcart.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewcart.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewcart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle1.Font = new Font("Lucida Console", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(0, 0, 64);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewcart.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewcart.Location = new Point(201, 0);
            dataGridViewcart.Margin = new Padding(5);
            dataGridViewcart.Name = "dataGridViewcart";
            dataGridViewcart.RowHeadersWidth = 62;
            dataGridViewcart.Size = new Size(1054, 350);
            dataGridViewcart.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dataGridView2);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1408, 807);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Orders";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.RosyBrown;
            dataGridView2.ColumnHeadersHeight = 29;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 0, 64);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView2.GridColor = Color.White;
            dataGridView2.Location = new Point(3, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(1409, 698);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1416, 840);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Products";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Products";
            Load += Products_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericPrice).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewcart).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private DataGridView dataGridViewcart;
        private Button button2;
        private Button buttonprice;
        private ComboBox comboBoxCategory;
        private NumericUpDown numericPrice;
        private Button buttonNext;
        private Button buttonPrev;
        private Button buttonsearch;
        private TextBox textBoxsearch;
        private Button Submit;
        private TabPage tabPage3;
        private DataGridView dataGridView2;
    }
}