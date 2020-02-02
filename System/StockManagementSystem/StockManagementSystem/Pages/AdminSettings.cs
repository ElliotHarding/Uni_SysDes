﻿using StockManagementSystem.User_Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace StockManagementSystem.Pages
{
    public partial class AdminSettings : BaseForm
    {
        private const int c_rowInc = 26;
        private int m_rowIndex = 0;
        private bool m_bGettingDepartments = true;

        public AdminSettings()
        {
            InitializeComponent();
            addNavBar();
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
    }
}