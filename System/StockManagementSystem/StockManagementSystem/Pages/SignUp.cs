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
    public partial class SignUp : BaseForm
    {
        public SignUp()
        {
            InitializeComponent();
            lbl_error.Text = "";
            lbl_error.Visible = false;

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
                MessageBox.Show("Network connection error.", "Warning");
            }
        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {
            lbl_error.Visible = false;
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
                this.Invoke((Action)delegate { goToNextPage(SystemPage.ProductsPage); });
            }
            else
            {
                //Need to invoke since properties of GUI thread items are changed in callback function
                lbl_error.Invoke((Action)delegate { lbl_error.Text = "Failed to register details."; });
                lbl_error.Invoke((Action)delegate { lbl_error.Visible = true; });
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            goToNextPage(SystemPage.Login);
        }
    }
}
