using Autofac;
using E_commerce.Model;
using E_Commerce.Application.service;
using E_Commerce.DTO.Order;
using E_Commerce.DTO.OrderItem;

using E_Commerce.DTO.Category;
using E_Commerce.DTO.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace login
{
    public partial class Products : Form
    {
        private List<GetAllProductsDTO> cart;
        private int page = 1;
        Product ProductFrm;

        public int userid { get; set; }
        public Products()
        {
            InitializeComponent();

            cart = new List<GetAllProductsDTO>();
            container = AutoFac.Inject();
            orderService = container.Resolve<IOrderService>();
        }
        Autofac.IContainer container;
        IproductService productService;
        private void Products_Load(object sender, EventArgs e)
        {
            
            productService = container.Resolve<IproductService>();
            BindingList<GetAllProductsDTO> products = new BindingList<GetAllProductsDTO>(productService.GetAllPagination(10, page));
            dataGridView1.DataSource = products;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.RowHeadersVisible = false;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.ReadOnly = true;
            }

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn
            {
                HeaderText = "Image",
                Name = "Image",
                Width = 300,
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Height = 100;
            }
            dataGridView1.Columns.Add(imageColumn);
            for (int i = 0; i < products.Count; i++)
            {
                string prodImageURL = products[i].ImageURL;
                Image pic = imageURLToBitmap(prodImageURL);

                if (pic != null)
                {
                    dataGridView1.Rows[i].Cells["Image"].Value = pic;
                }
            }

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn
            {
                HeaderText = "Add To Cart",
                Name = "Cart",
                Text = "Add To Cart",
                UseColumnTextForButtonValue = true,
                Width = 150
            };
            dataGridView1.Columns.Add(buttonColumn);

            dataGridViewcart.DataSource = new BindingList<GetAllProductsDTO>(cart);

            DataGridViewTextBoxColumn numberColumn = new DataGridViewTextBoxColumn();
            numberColumn.Name = "NumberColumn";
            numberColumn.HeaderText = "Quentaty To Add";
            numberColumn.ValueType = typeof(int);
            numberColumn.Width = 100;

            dataGridView1.Columns.Add(numberColumn);
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["NumberColumn"].Value = 1;
            }
            DataGridViewButtonColumn ProductDetails = new DataGridViewButtonColumn
            {
                HeaderText = "Check Out This Product",
                Name = "Details",
                Text = "Details",
                UseColumnTextForButtonValue = true,
                Width = 150
            };
            dataGridView1.Columns.Add(ProductDetails);

            var container2 = AutoFac.Inject();
            ICategoryService categoryService = container2.Resolve<ICategoryService>();
            var Categs = categoryService.GetAllCategories().Select(p => p.Name).ToList();
            comboBoxCategory.DataSource = Categs;
            var listgetMasterOrderDTOs = orderService.GetOrdersByCustomer(Status.InCart , userid);

            dataGridView2.DataSource = listgetMasterOrderDTOs;
        }


        Bitmap imageURLToBitmap(string url)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    return new Bitmap(response.GetResponseStream());
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error fetching image: {ex.Message}");
                return null;
            }
        }

        CreateOrderMasterDTO orderMaster;
        CreateOrderDetailDTO OrderItem;
        GetMasterOrderDTO OrderMaster;
        GetAllProductsDTO selectedProduct ;
        IOrderService orderService;
        GetAllOrderDetailDTO newDetail;


        List<GetAllOrderDetailDTO> listOrderDetailDTOs = new List<GetAllOrderDetailDTO>();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dataGridView1.Columns["Cart"].Index && e.RowIndex >= 0)
            {
                var selectedProduct = dataGridView1.Rows[e.RowIndex].DataBoundItem as GetAllProductsDTO;
                if (selectedProduct != null)
                {
                    var container = AutoFac.Inject();
                    var orderService = container.Resolve<IOrderService>();

                    MessageBox.Show($"Added {selectedProduct.Name} to cart!");

                    string quantityText = dataGridView1.Rows[e.RowIndex].Cells["NumberColumn"].Value?.ToString();
                    if (int.TryParse(quantityText, out int quantity) && quantity > 0)
                    {
                        if (orderMaster == null)
                        {
                            orderMaster = new CreateOrderMasterDTO
                            {
                                OrderStatus = Status.InCart,
                                TotalPrice = selectedProduct.Price * quantity,
                                UserID = userid,
                            };
                            OrderMaster = orderService.CreateMasterOrder(orderMaster);
                        }
                        else
                        {
                            
                            OrderMaster.TotalPrice += selectedProduct.Price * quantity;

                        }
                        var orderDetail = new CreateOrderDetailDTO
                        {
                            ProductId = selectedProduct.Id,
                            Quantity = quantity,
                            UnitPrice = orderMaster.TotalPrice,
                            OrderID = OrderMaster.ID
                        };

                        orderService.CreateOrderDetail(orderDetail);

                        var existingDetail = listOrderDetailDTOs.FirstOrDefault(d => d.ProductName == selectedProduct.Name);
                        if (existingDetail != null)
                        {
                        
         
                        }
                        else
                        {
                            newDetail = new GetAllOrderDetailDTO
                            {
                                ProductName = selectedProduct.Name,
                                Quantity = quantity,
                                UnitPrice = selectedProduct.Price * quantity
                            };
                            listOrderDetailDTOs.Add(newDetail);
                        }

                        dataGridViewcart.DataSource = null; 
                        dataGridViewcart.DataSource = listOrderDetailDTOs;
                    }
                }
            }
            else if (e.ColumnIndex == dataGridView1.Columns["Details"].Index && e.RowIndex >= 0)
            {
                selectedProduct = dataGridView1.Rows[e.RowIndex].DataBoundItem as GetAllProductsDTO;
                if (selectedProduct != null)
                {
                    var container = AutoFac.Inject();
                    IproductService productService = container.Resolve<IproductService>();
                    ProductDetailsDTO productDetails = productService.GetProductDetails(selectedProduct);
                    ProductFrm = new Product();
                    ProductFrm.PName = productDetails.Name;
                    ProductFrm.PPrice = productDetails.Price;
                    //ProductFrm.PCategory = productDetails.Category.Name;
                    ProductFrm.PStock = productDetails.UnitsInStock;
                    ProductFrm.PDiscount = productDetails.Discount;
                    ProductFrm.PImage = imageURLToBitmap(productDetails.ImageURL);


                    ProductFrm.ShowDialog();
                }
            }
        }
        public List<GetMasterOrderDTO> ListgetMasterOrderDTOs;
        
        private void button1_Click(object sender, EventArgs e)
        {
            ListgetMasterOrderDTOs = orderService.GetAll( Status.InCart ,userid);

            foreach(var order in ListgetMasterOrderDTOs)
            {
                order.OrderStatus = Status.Processing;
                order.TotalPrice = newDetail.UnitPrice;
                orderService.Updated(order);
            }
            
            dataGridView2.DataSource = new BindingList<GetMasterOrderDTO>(ListgetMasterOrderDTOs);
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
      
            dataGridView2.Columns[5].Visible = false;
            dataGridView2.Columns[4].Visible = false;
            
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            page++;
            var container = AutoFac.Inject();
            IproductService productService = container.Resolve<IproductService>();
            BindingList<GetAllProductsDTO> products = new BindingList<GetAllProductsDTO>(productService.GetAllPagination(10, page));

            dataGridView1.DataSource = products;
            for (int i = 0; i < products.Count; i++)
            {
                string prodImageURL = products[i].ImageURL;
                Image pic = imageURLToBitmap(prodImageURL);
                if (pic != null)
                {
                    dataGridView1.Rows[i].Cells["Image"].Value = pic;
                }
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Height = 100;
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["NumberColumn"].Value = 1;
            }
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if (page > 1)
            {
                page--;
                var container = AutoFac.Inject();
                IproductService productService = container.Resolve<IproductService>();
                BindingList<GetAllProductsDTO> products = new BindingList<GetAllProductsDTO>(productService.GetAllPagination(10, page));

                dataGridView1.DataSource = products;
                for (int i = 0; i < products.Count; i++)
                {
                    string prodImageURL = products[i].ImageURL;
                    Image pic = imageURLToBitmap(prodImageURL);
                    if (pic != null)
                    {
                        dataGridView1.Rows[i].Cells["Image"].Value = pic;
                    }
                }
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Height = 100;
                }
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Cells["NumberColumn"].Value = 1;
                }
            }
        }

        private void buttonprice_Click(object sender, EventArgs e)
        {
            decimal Maxprice = numericPrice.Value;
            var container = AutoFac.Inject();
            IproductService productService = container.Resolve<IproductService>();
            BindingList<GetAllProductsDTO> products = new BindingList<GetAllProductsDTO>(productService.FilterByPrice(Maxprice, 10, page));
            dataGridView1.DataSource = products;
            for (int i = 0; i < products.Count; i++)
            {
                string prodImageURL = products[i].ImageURL;
                Image pic = imageURLToBitmap(prodImageURL);
                if (pic != null)
                {
                    dataGridView1.Rows[i].Cells["Image"].Value = pic;
                }
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Height = 100;
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["NumberColumn"].Value = 1;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string SelectedCategory = comboBoxCategory.Text;
            var container = AutoFac.Inject();
            IproductService productService = container.Resolve<IproductService>();
            BindingList<GetAllProductsDTO> products = new BindingList<GetAllProductsDTO>(productService.FilterByCategory(SelectedCategory, 10, page));
            dataGridView1.DataSource = products;
            for (int i = 0; i < products.Count; i++)
            {
                string prodImageURL = products[i].ImageURL;
                Image pic = imageURLToBitmap(prodImageURL);
                if (pic != null)
                {
                    dataGridView1.Rows[i].Cells["Image"].Value = pic;
                }
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Height = 100;
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["NumberColumn"].Value = 1;
            }
        }

        private void buttonsearch_Click(object sender, EventArgs e)
        {
            string SearchName = textBoxsearch.Text;

            var container = AutoFac.Inject();
            IproductService productService = container.Resolve<IproductService>();
            BindingList<GetAllProductsDTO> products = new BindingList<GetAllProductsDTO>(productService.Searh(SearchName));


            dataGridView1.DataSource = products;
            for (int i = 0; i < products.Count; i++)
            {
                string prodImageURL = products[i].ImageURL;
                Image pic = imageURLToBitmap(prodImageURL);
                if (pic != null)
                {
                    dataGridView1.Rows[i].Cells["Image"].Value = pic;
                }
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Height = 100;
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["NumberColumn"].Value = 1;
            }

        }

     
    }
}
