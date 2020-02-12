using StockManagementSystem.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StockManagementSystem.Pages
{
    public partial class SignUp : BaseForm
    {
        List<string> m_departments = new List<string>();

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
                        m_departments.Add(department);
                    }
                });
            }
            else
            {
                notifyUser("Network connection error.", "Warning");
            }
        }

        private User m_potentialNewUser = null;
        private void btn_signUp_Click(object sender, EventArgs e)
        {
            string nNumber = txt_username.Text;
            string password = txt_password.Text;
            string department = cb_department.Text;
            string passwordHash = Tools.passwordHash(password);

            if(password != txt_password1.Text)
            {
                notifyUser("Passwords do not match");
                return;
            }

            if (nNumber == "" || nNumber.Length > 10)
            {
                notifyUser("Please enter a valid N number");
                return;
            }

            bool lowerCase = false;
            bool upperCase = false;
            bool hasNum = false;
            for (int i = 1; i < nNumber.Length; i++)
            {
                if (!Char.IsDigit(nNumber.ElementAt(i)))
                {
                    notifyUser("Please enter a valid N number");
                    return;
                }
                else if (Char.IsUpper(password.ElementAt(i)))
                {
                    upperCase = true;
                }
                else if (Char.IsLower(password.ElementAt(i)))
                {
                    lowerCase = true;
                }
                else if (Char.IsDigit(password.ElementAt(i)))
                {
                    hasNum = true;
                }                
            }

            if (!lowerCase && !upperCase && !hasNum)
            {
                notifyUser("Sorry, your password must contain lowercase, uppercase and a number");
                return;
            }

            bool departmentFound = false;
            foreach(string validDepartment in m_departments)
            {
                if(validDepartment == department)
                    departmentFound = true;
            }

            if (!departmentFound)
            {
                notifyUser("Please choose a valid department.");
                return;
            }

            m_potentialNewUser = new User(nNumber, passwordHash, department, "user");
            
            //Check user dosent exist...
            DatabaseComms.getUsers(getUserCallback, "nNumber = '" + nNumber + "'");
        }

        private void getUserCallback(List<User> users)
        {
            if(users == null)
            {
                notifyUser("Error, check internet connection.");
            }
            else if(users.Count == 0)
            {
                DatabaseComms.uploadUser(m_potentialNewUser, uploadUserCallback);
            }
            else
            {
                notifyUser("That nNumber already exists!");
            }           
        }

        private void uploadUserCallback(bool uploaded)
        {
            if(uploaded)
            {
                this.Invoke((Action)delegate 
                {
                    m_currentUser = m_potentialNewUser;
                    Messages.checkMessages();
                    goToNextPage(SystemPage.ProductsPage);
                });
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
