using Autofac;
using E_commerce.Model;
using E_Commerce.Application.service;
using E_Commerce.Context;
using E_Commerce.DTO.user;
using E_Commerce.Infrastructure;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace login
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            var container = AutoFac.Inject();
            IUserService userService = container.Resolve<IUserService>();


        }




        private void btnlogin_Click(object sender, EventArgs e)
        {
            var container = AutoFac.Inject();
            IUserService userService = container.Resolve<IUserService>();

            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Please enter a username.");
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please enter a password.");
                return;
            }
            var userDto = userService.AuthenticateUser(txtUsername.Text, txtPassword.Text);

           


            if (userDto != null)
            {
                if (userDto.Role != Flag.Customer)
                {
                    adminDashbord adminDashboard = new adminDashbord();
                    adminDashboard.Show();
                }
                else
                {
                    Products productsForm = new Products();
                    productsForm.userid = userDto.UserId;
                    productsForm.Show();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }

        }



        

     
    }
}
