using StockManagementSystem.Classes;
using System;
using System.Collections.Generic;

namespace StockManagementSystem.Pages
{
    public partial class SignUp : BaseForm
    {
        public SignUp()
        {
            InitializeComponent();

            DatabaseComms.getDepartments(getDepartmentsCallback);
        }

        private void getDepartmentsCallback(List<string> departments)
        {
            if (departments != null && departments.Count > 0)
            {
                cb_department.Invoke((Action)delegate {

                    foreach (string department in departments)
                    {
                        cb_department.Items.Add(department);
                    }
                });
            }
            else
            {
                notifyUser("Network connection error.", "Warning");
            }
        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {
            string nNumber = txt_username.Text;
            string password = txt_password.Text;
            string department = cb_department.Text;
            string passwordHash = Tools.passwordHash(password);

            //todo validate...

            DatabaseComms.uploadUser(new User(nNumber, passwordHash, department, "user"), uploadUserCallback);
        }

        private void uploadUserCallback(bool uploaded)
        {
            if(uploaded)
            {
                this.Invoke((Action)delegate { goToNextPage(SystemPage.ProductsPage); });
            }
            else
            {
                notifyUser("Failed to register details");
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            goToNextPage(SystemPage.Login);
        }
    }
}
