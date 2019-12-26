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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            lbl_error.Text = "";
            lbl_error.Visible = false;

            //Todo query database for departments & fill cb_department from callback
            cb_department.Items.Add("Department 1");
            cb_department.Items.Add("Department 2");
            cb_department.Items.Add("Department 3");
        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {
            string nNumber = txt_username.Text;
            string password = txt_password.Text;
            string department = cb_department.Text;
            string passwordHash = Tools.passwordHash(password);

            DatabaseComms.uploadUser(new User(nNumber, passwordHash, department, "user"), uploadUserCallback);
        }

        private void uploadUserCallback(bool uploaded)
        {
            if(uploaded)
            {
                ProductsPage productsPage = new ProductsPage();
                productsPage.Show();
                this.Close();
            }
            else
            {
                lbl_error.Text = "Failed to register details.";
                lbl_error.Visible = true;
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
