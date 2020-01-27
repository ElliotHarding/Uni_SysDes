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
    public partial class AdminSettings : BaseForm
    {
        public AdminSettings()
        {
            InitializeComponent();
            addNavBar();
        }

        private void Btn_addUser_Click(object sender, EventArgs e)
        {
            if (txt_username.Text.Length > 0)
            {
                if(txt_password.Text.Length > 3)
                {
                    if(cb_privilege.Text.Length > 0)
                    {
                        User newUser = new User(txt_username.Text, txt_password.Text, "StoreStaff", cb_privilege.Text);
                        DatabaseComms.uploadUser(newUser, uploadCallback);
                    }
                    else
                    {
                        MessageBox.Show("Please select a privilege for the user.", "Warning");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid password ~ must be at least 4 characters long", "Warning");
                }
            }   
            else
            {
                MessageBox.Show("Missing username", "Warning");
            }
        }

        private void uploadCallback(bool success)
        {
            if(success)
            {
                MessageBox.Show("User created.", "Success");
            }
            else
            {
                MessageBox.Show("Creating new user: failed to connect to the server. Check internet.", "Warning");
            }
        }
    }
}
