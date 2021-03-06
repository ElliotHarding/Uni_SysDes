﻿using StockManagementSystem.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StockManagementSystem.Pages
{
    public partial class Login : BaseForm
    {
        public Login()
        {
            InitializeComponent();
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

        private static Random random = new Random();
        private string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private string m_newPassowrdString = null;
        private string m_resetUserNnumber = null;
        private void btn_forgottenDetails_Click(object sender, EventArgs e)
        {
            UserInputStringDialog nNumberDialog = new UserInputStringDialog("Enter your nNumber");
            DialogResult dialogResult = nNumberDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                m_newPassowrdString = RandomString(10);
                string newPasswordHash = Tools.passwordHash(m_newPassowrdString);
                m_resetUserNnumber = nNumberDialog.result;
                DatabaseComms.resetUserPassword(forgottenPassowrdCallback, m_resetUserNnumber, newPasswordHash);
            }                  
        }

        private void forgottenPassowrdCallback(bool success)
        {
            if(!success)
            {
                notifyUser("Inocrrect details. Or check internet?");
            }
            else
            {
                string[] contents = { "Dear, " + m_resetUserNnumber, "Your password for ntu stores is: " + m_newPassowrdString };
                Tools emailSender = new Tools();
                if (emailSender.sendEmail(m_resetUserNnumber + "@my.ntu.ac.uk", "Password reset", contents))
                {
                    notifyUser("Password sent to corresponding email.", "Message");
                }
                else
                {
                    notifyUser("Failed to send email. Check internet?");
                }
            }            
        }
    }
}
