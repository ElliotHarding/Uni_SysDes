using StockManagementSystem.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem.Pages
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            lbl_error.Text = "";
            lbl_error.Visible = false;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string nNumber = txt_username.Text;
            string password = txt_password.Text;

            string passwordHash = Tools.passwordHash(password);

            DatabaseComms.getUsers(loginCallback, "nNumber = " + nNumber + " AND password = " + passwordHash);
        }

        private void loginCallback(List<User> users)
        {
            if(users == null)
            {
                setError("Network connection error. Check internet");
            }
            else if(users.Count > 0)
            {
                ProductsPage productsPage = new ProductsPage();
                productsPage.Show();
                this.Close();
            }
            else
            {
                setError("Inocrrect details.");
            }
        }

        private void setError(string errorStr)
        {
            lbl_error.Text = errorStr;
            if(!lbl_error.Visible)
                lbl_error.Visible = true;
        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }
    }
}
