using StockManagementSystem.User_Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace StockManagementSystem.Pages
{
    public partial class AdminSettings : BaseForm
    {
        //Public member accessed in ViewProducts, set when application starts, result from sql server
        public static Bitmap FloorMap = null;

        private const int c_rowInc = 26;
        private int m_rowIndex = 0;
        private bool m_bGettingDepartments = true;

        public AdminSettings()
        {
            InitializeComponent();
            addNavBar();
            pictureBoxMap.Image = FloorMap;
            DatabaseComms.getDepartments(getDepartmentsCallback);
        }

        private void getDepartmentsCallback(List<string> departments)
        {
            if (departments != null && departments.Count > 0)
            {
                pnl_departments.Invoke((Action)delegate 
                {
                    foreach(string department in departments)
                    {
                        TextfieldRow tfr = new TextfieldRow(this, department);
                        tfr.Parent = pnl_departments;
                        tfr.Location = new Point(0, m_rowIndex * c_rowInc);
                        pnl_departments.Controls.Add(tfr);
                        m_rowIndex++;
                    }
                });
            }
            else if(departments == null)
            {
                notifyUser("Network connection error.");                
            }
            else
            {
                pnl_departments.Invoke((Action)delegate
                {
                    addNewDepartmentRow();
                });                
            }
            m_bGettingDepartments = false;
        }

        internal void remove(TextfieldRow textfieldRow)
        {
            List<TextfieldRow> textfieldRows = new List<TextfieldRow>();
            foreach (TextfieldRow tfr in pnl_departments.Controls)
            {
                if (textfieldRow != tfr)
                {
                    textfieldRows.Add(tfr);
                }
            }

            this.SuspendLayout();
            
            pnl_departments.Controls.Clear();
            m_rowIndex = 0;

            foreach (TextfieldRow tfr in textfieldRows)
            {
                tfr.Parent = pnl_departments;
                tfr.Location = new Point(0, m_rowIndex * c_rowInc);
                m_rowIndex++;
            }

            this.ResumeLayout();
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
                        notifyUser("Please select a privilege for the user.");
                    }
                }
                else
                {
                    notifyUser("Invalid password ~ must be at least 4 characters long");
                }
            }   
            else
            {
                notifyUser("Missing username");
            }
        }

        private void uploadCallback(bool success)
        {
            if(success)
            {
                notifyUser("User created.", "Success");
            }
            else
            {
                notifyUser("Creating new user: failed to connect to the server. Check internet.", "Warning");
            }
        }

        private void Btn_updateDepartments_Click(object sender, EventArgs e)
        {
            List<string> departments = new List<string>();
            foreach (TextfieldRow tfr in pnl_departments.Controls)
            {
                departments.Add(tfr.getValue());
            }
           
            if(departments == null || departments.Count == 0)
            {
                notifyUser("No departments set.", "Warning");
            }
            else
            {
                DatabaseComms.setDepartments(departments, uploadDepartmentsCallback);
            }            
        }

        private void uploadDepartmentsCallback(bool success)
        {
            if (success)
            {
                notifyUser("Departments set.", "Success");
            }
            else
            {
                notifyUser("Uploading new departments: failed to connect to the server. Check internet.");
            }
        }

        private void Btn_addDepartment_Click(object sender, EventArgs e)
        {
            if(!m_bGettingDepartments)
                addNewDepartmentRow();
        }

        private void addNewDepartmentRow()
        {
            TextfieldRow tfr = new TextfieldRow(this);
            tfr.Parent = pnl_departments;
            tfr.Location = new Point(0, m_rowIndex * c_rowInc);
            m_rowIndex++;
        }

        private void btn_setPassword_Click(object sender, EventArgs e)
        {
            string newPassword1 = tb_newPassword1.Text;
            string newPassword2 = tb_newPassword2.Text;
            if (newPassword1 != null && newPassword2 != null)
            {
                if (newPassword1 == newPassword2)
                {
                    if (newPassword1.Length > 3)
                    {
                        m_currentUser.password = Classes.Tools.passwordHash(newPassword1);
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
            if (success)
            {
                notifyUser("Updated password", "Success");
            }
            else
            {
                notifyUser("Failed to update password! Check network?");
            }
        }

        private void pictureBoxMap_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Bitmap bmp = new Bitmap(dlg.FileName);
                        pictureBoxMap.Image = bmp;
                        FloorMap = bmp;
                        DatabaseComms.uploadItemsMap(new Bitmap(bmp), uploadNewMapCallback);
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                }
            }
        }

        private void uploadNewMapCallback(bool success)
        {
            if(success)
            {
                notifyUser("Saved new map.", "Success");
            }
            else
            {
                notifyUser("Failed to save new map. Check internet.");
            }
        }

        private void btn_stopSystem_Click(object sender, EventArgs e)
        {
            goToNextPage(SystemPage.EndPage);
        }
    }
}
