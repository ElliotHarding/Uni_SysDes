using StockManagementSystem.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StockManagementSystem.Pages
{
    public partial class Login : BaseForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string nNumber = txt_username.Text;
            string password = txt_password.Text;

            string passwordHash = Tools.passwordHash(password);

            DatabaseComms.getUsers(loginCallback, "nNumber = '" + nNumber + "' AND password = '" + passwordHash + "'") ;
        }

        private void loginCallback(List<User> users)
        {
            if(users == null)
            {
                notifyUser("Network connection error. Check internet");
            }
            else if(users.Count > 0)
            {
                m_currentUser = users[0];
                Messages.checkMessages();
                this.Invoke((Action)delegate { goToNextPage(SystemPage.ProductsPage); });               
            }
            else
            {
                notifyUser("Inocrrect details.");
            }
        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {
            goToNextPage(SystemPage.SignUp);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string passwordHash = Tools.passwordHash("password");
            DatabaseComms.getUsers(loginCallback, "nNumber = 'n0688119' AND password = '" + passwordHash + "'");
        }

        private void btn_forgottenDetails_Click(object sender, EventArgs e)
        {
            UserInputStringDialog nNumberDialog = new UserInputStringDialog("Enter your nNumber");
            DialogResult dialogResult = nNumberDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
                DatabaseComms.getUsers(forgottenPassowrdCallback, "nNumber = '" + nNumberDialog.result + "'");
        }

        private void forgottenPassowrdCallback(List<User> users)
        {
            if (users == null)
            {
                notifyUser("Failed to send email. Check internet?");
            }
            else if (users.Count > 0)
            {
                string[] contents = { "Dear, " + users[0].nNumber, "Your password for ntu stores is: " + users[0].password };
                if (Tools.sendEmail(users[0].nNumber + "@my.ntu.ac.uk", contents))
                {
                    notifyUser("Password sent to corresponding email.", "Message");
                }
                else
                {
                    notifyUser("Failed to send email. Check internet?");
                }
            }
            else
            {
                notifyUser("Inocrrect details.");
            }
        }
    }
}
