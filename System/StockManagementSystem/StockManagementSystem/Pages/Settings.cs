using StockManagementSystem.Classes;
using System;

namespace StockManagementSystem.Pages
{
    public partial class Settings : BaseForm
    {
        public Settings()
        {
            InitializeComponent();
            addNavBar();
        }

        private void btn_setPassword_Click(object sender, EventArgs e)
        {
            string newPassword1 = tb_newPassword1.Text;
            string newPassword2 = tb_newPassword2.Text;
            if(newPassword1 != null && newPassword2 != null)
            {
                if(newPassword1 == newPassword2)
                {
                    if(newPassword1.Length > 3)
                    {
                        m_currentUser.password = Tools.passwordHash(newPassword1);
                        DatabaseComms.updateUser(m_currentUser, updateUserCallback);
                    }
                    else
                    {
                        notifyUser("Password not long enough");
                    }
                }
                else
                {
                    notifyUser("New passwords are not the same.");
                }
            }
            else
            {
                notifyUser("Please enter your new password.");
            }
        }

        private void updateUserCallback(bool success)
        {
            if(success)
            {
                notifyUser("Updated password", "Success");
            }
            else
            {
                notifyUser("Failed to update password! Check network?");
            }
        }
    }
}
