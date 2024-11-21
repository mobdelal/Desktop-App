using Autofac;
using AutoMapper;
using E_commerce.Model;
using E_Commerce.Application.Contract;
using E_Commerce.Application.service;
using E_Commerce.Context;
using E_Commerce.Context.Migrations;
using E_Commerce.DTO.Category;
using E_Commerce.DTO.Order;
using E_Commerce.DTO.Product;

using E_Commerce.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace login
{
    public partial class adminDashbord : Form
    {

        //private ICategoryService catService = new CategoryService(new CategoryRepository(new EContext()));
        //private IproductService productservice = new ProductService(new ProductRepository(new EContext()));
        public adminDashbord()
        {
            InitializeComponent();
            loaduser();
            loadProductsGrid();
            loadOrderdetail();

            dataGridView1.CurrentCellChanged += new EventHandler(dataGridView1_CurrentCellChanged);


        }
        EContext context = new EContext();
        DataGridViewComboBoxColumn Column;

        private void adminDashbord_Load(object sender, EventArgs e)
        {
            Combostates.DataSource = Enum.GetValues(typeof(Status));

        }
        private void Combostates_SelectedIndexChanged(object sender, EventArgs e)
        {
            Status selectedStatus = (Status)Combostates.SelectedItem;

        }

        private void loaduser()
        {
            var container = AutoFac.Inject();

            ICategoryService categoryService = container.Resolve<ICategoryService>();
            IproductService productService = container.Resolve<IproductService>();


            var categories = context.Ctegories.ToList();
            var products = (from product in context.Products
                            join category in context.Ctegories
                            on product.CategoryID equals category.CategoryID
                            select new { product.ProductID, product.Name }).ToList();


            dataGridView1.DataSource = categories;

            dataGridView1.Columns["Products"].Visible = false;
            dataGridView1.Columns["CategoryID"].ReadOnly = true;



            if (dataGridView1.Columns["omar"] == null)
            {
                Column = new DataGridViewComboBoxColumn
                {
                    HeaderText = "Products",
                    Name = "omar",
                    DataSource = products,
                    DisplayMember = "Name",
                    ValueMember = "ProductID"
                };

                dataGridView1.Columns.Add(Column);

                dataGridView1.Columns["omar"].DisplayIndex = 3;
            }
            else
            {
                dataGridView1.Columns["omar"].DataPropertyName = "ProductID";
            }


        }


        private void loadProductsGrid()
        {

            var products = context.Products.ToList();
            dataGridproduct.DataSource = products;
            dataGridproduct.Columns["Category"].Visible = false;
            dataGridproduct.Columns["ProductID"].ReadOnly = true;


        }

        private void loadOrderdetail()
        {
            var orders = context.Orders.ToList();
            GridOrderDetail.DataSource = orders;

        }





        private void btn_cat_Click(object sender, EventArgs e)
        {
            var container = AutoFac.Inject();
            ICategoryService categoryService = container.Resolve<ICategoryService>();
            var cat = new CategoryDTO
            {
                Name = txtcatname.Text,
                Description = txtdesc.Text


            };
            categoryService.CreateCategory(cat);
            context.SaveChanges();
            loaduser();


        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            var container = AutoFac.Inject();
            ICategoryService categoryService = container.Resolve<ICategoryService>();
            var cat = new CategoryDTO
            {
                Name = txtcatname.Text,
                Description = txtdesc.Text
            };
            categoryService.UpdateCategory(cat);
            context.SaveChanges();
            loaduser();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var container = AutoFac.Inject();
            ICategoryService categoryService = container.Resolve<ICategoryService>();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = (int)dataGridView1.SelectedRows[0].Cells["CategoryID"].Value;
                categoryService.DeleteCategory(id);
                loaduser();
            }

        }



        private void button1_Click(object sender, EventArgs e)
        {
            var container = AutoFac.Inject();
            IproductService productService = container.Resolve<IproductService>();
            

            var product = new CreateProductDTO
            {
                CategoryID = (int)numericUpDown2.Value,
                Name = txtproname.Text,
                Price = numericUpDown1.Value,
                ImageURL = textBox1.Text,
                UnitsInStock = (int)numericUpDown3.Value,

            };

            productService.AddProduct(product);

            loadProductsGrid();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            var container = AutoFac.Inject();
            IproductService productService = container.Resolve<IproductService>();

            if (dataGridproduct.SelectedRows.Count > 0)
            {
                int id = (int)dataGridproduct.SelectedRows[0].Cells["ProductID"].Value;
                productService.Deleteproduct(id);
                context.SaveChanges();
                loadProductsGrid();
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            
            var container = AutoFac.Inject();
            IproductService productService = container.Resolve<IproductService>();

            if (dataGridproduct.SelectedRows.Count > 0)
            {
                var product = new ProductDetailsDTO
                {
                    Id = (int)dataGridproduct.SelectedRows[0].Cells[0].Value, 
                    Name = txtproname.Text,
                    Price = numericUpDown1.Value,
                    CategoryID = (int)numericUpDown2.Value,
                    ImageURL = textBox1.Text,
                };
                productService.UpdateProducts(product);
                loadProductsGrid();
            }
        }
        private void Updatastatus_Click(object sender, EventArgs e)
        {
            var container = AutoFac.Inject();
            IOrderService orderService = container.Resolve<IOrderService>();

            int orderId = (int)Order.Value;
            Status selectedStatus = (Status)Combostates.SelectedItem;  

            var orderToUpdate = new CreateOrderMasterDTO
            {
                
                OrderID = orderId,
                OrderStatus = selectedStatus
            };

            orderService.UpdateOrder(orderToUpdate);

            loadOrderdetail();


        }

      


        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int rowIndex = dataGridView1.CurrentRow.Index;
                if (rowIndex >= 0 && dataGridView1.Rows[rowIndex].Cells["CategoryID"].Value != null)
                {
                    int categoryId = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["CategoryID"].Value);
                    UpdateProductComboBox(categoryId);
                }
            }
        }

        private void UpdateProductComboBox(int categoryId)
        {
            var filteredProducts = context.Products
                                          .Where(product => product.CategoryID == categoryId)
                                          .Select(product => new { product.ProductID, product.Name })
                                          .ToList();

            Column.DataSource = filteredProducts;
            dataGridView1.Refresh();
        }

      
    }

}

