using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            
        }
        public string PName;
        public decimal PPrice;
        public int PStock;
        public bool PDiscount;
        public string PImgURL;
        public string PCategory;
        public Image PImage;

        private void Product_Load(object sender, EventArgs e)
        {
            labelName.Text = PName;
            lablePrice.Text = PPrice.ToString();
            labelStock.Text = PStock.ToString();
            labelDiscount.Text = PDiscount.ToString();
            pictureBox1.Image = PImage;
        }
    }
}
