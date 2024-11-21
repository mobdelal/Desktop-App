using E_Commerce.Application.service;
using E_Commerce.DTO.user;
using E_commerce.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using E_Commerce.Context;
using E_Commerce.Infrastructure;
using login;
using Autofac;

namespace login
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            var container = AutoFac.Inject();
            IUserService userService=container.Resolve<IUserService>();

        }



        private void btnregiser_Click(object sender, EventArgs e)
        {
            var container = AutoFac.Inject();
            IUserService userService = container.Resolve<IUserService>();
            try
            {
                var userDto = new UserDTO
                {
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                    PhoneNumber = txtPhone.Text,
                    Email = txtEmail.Text,
                    Role = Flag.Customer
                };


                userService.CreateUser(userDto);
                MessageBox.Show("Registration successful!");
                this.Hide();
                Form1 login = new Form1();

                login.Show();





            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to register. Error: {ex.Message}");
            }

        }

      
    }
}

//if (userDto != null)
//{
//    if (userDTO.UserId == 1)
//    {
//        userDTO.Role = Flag.Admin;
//        adminDashbord adminDashboard = new adminDashbord(userService);
//        adminDashboard.Show();


//    }
//    else
//    {
//        userDTO.Role = Flag.Customer;
//        Products productsForm = new Products(userService);
//        productsForm.Show();

//    }
//    if (userDTO.Role == Flag.Admin)
//    {
//        adminDashbord adminDashboard = new adminDashbord(userService);
//        adminDashboard.Show();
//    }
//    else
//    {
//        Products productsForm = new Products(userService);
//        productsForm.Show();
//    }
//    this.Hide();
//}
//else
//{
//    MessageBox.Show("Invalid username or password.");
//}
//        }