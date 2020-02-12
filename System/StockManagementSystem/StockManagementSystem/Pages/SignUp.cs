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

            //Todo query database for departments & fill cb_department from callback
            cb_department.Items.Add("Department 1");
            cb_department.Items.Add("Department 2");
            cb_department.Items.Add("Department 3");
        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {
            lbl_error.Visible = false;
            string nNumber = txt_username.Text;
            string password = txt_password.Text;
            string department = cb_department.Text;
            string passwordHash = Tools.passwordHash(password);

            bool lowerCase = false;
            bool upperCase = false;
            bool hasNum = false;

            if(nNumber == "" || nNumber.Length!=8 || nNumber.ElementAt(0)!='N' || nNumber.ElementAt(0)!='T')
            {
                notifyUser("Please enter a valid N number");
                return;
            }
            for(int i = 1; i<nNumber.Length; i++)
            {
                if (!Char.IsDigit(nNumber.ElementAt(i))
                   {
                    notifyUser("Please enter a valid N number");
                    return;
                   } 
                if(Char.IsUpper(password.ElementAt(i)))
                {
                    upperCase = true;
                }
                if (Char.IsLower(password.ElementAt(i)))
                {
                    lowerCase = true;
                }
                if(Char.IsDigit(password.ElementAt(i))
                    {
                    hasNum = true;
                }
                if (lowerCase == false || upperCase == false || hasNum == false)
                {
                    notifyUser("Sorry, your password must contain lowercase, uppercase and a number");
                    return;
                }
            }



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
