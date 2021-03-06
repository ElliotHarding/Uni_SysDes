﻿using StockManagementSystem.Classes;
using StockManagementSystem.User_Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace StockManagementSystem.Pages
{
    public partial class Invoices : BaseForm
    {
        public Invoices()
        {
            InitializeComponent();
            addNavBar();

            DatabaseComms.getDepartments(getDepartmentsCallback);
        }

        private void getDepartmentsCallback(List<string> departments)
        {
            if(departments != null && departments.Count > 0)
            {
                cmb_department.Invoke((Action)delegate {

                    foreach(string department in departments)
                    {
                        cmb_department.Items.Add(department);
                    }                    
                });
            }
            else
            {
                notifyUser("Network connection error.");
            }
        }

        const int m_rowInc = 30;
        int m_rowIndex = 0;

        private void addTransactions(List<Transation> transations)
        {
            foreach (Transation transation in transations)
            {
                TransationRow productRow = new TransationRow(this, transation);
                productRow.Parent = pnl_invoice;
                productRow.Location = new Point(0, m_rowIndex * m_rowInc);
                m_rowIndex++;
            }
        }

        private void Btn_send_invoice_Click(object sender, EventArgs e)
        {
            //Todo
            //new Tools() tools
            //Tools.sendEmail("", );
        }

        private void Btn_add_row_Click(object sender, EventArgs e)
        {
            TransationRow productRow = new TransationRow(this, new Transation("Custom invoice row", "", "", "", "", cmb_department.Text, "0", ""));
            productRow.Parent = pnl_invoice;
            productRow.Location = new Point(0, m_rowIndex * m_rowInc);
            m_rowIndex++;
        }

        private void Btn_create_from_log_Click(object sender, EventArgs e)
        {
            clearElements();
            if (cmb_department.Text != null)
            {
                DateTime fromDate = dateFrom.Value;
                DateTime toDate = dateTo.Value;

                if (fromDate != null && toDate != null)
                {                
                    DatabaseComms.getTransations(transactionsCallback, "department = '" + cmb_department.Text + "' AND date > '" + fromDate.ToString("yyyy-MM-dd") + "' AND date < '" + toDate.ToString("yyyy-MM-dd") + "' AND isReturn = 'false'");
                }
                else
                {
                    notifyUser("Please make sure dates are correct.", "Warning");
                }               
            }
            else
            {
                notifyUser("No transactions found matching the requirements selected", "Warning");
            }            
        }

        private void transactionsCallback(List<Transation> transations)
        {
            if (transations == null || transations.Count == 0)
            {
                notifyUser("No transactions found matching the deparment selected", "Warning");
            }
            else
            {
                this.Invoke((Action)delegate 
                {
                    foreach (Transation transation in transations)
                    {
                        TransationRow productRow = new TransationRow(this, transation);
                        productRow.Location = new Point(0, m_rowIndex * m_rowInc);
                        pnl_invoice.Invoke((Action)delegate { productRow.Parent = pnl_invoice; });
                        m_rowIndex++;
                    }
                });                
            }
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            clearElements();
        }

        private void clearElements()
        {
            m_rowIndex = 0;
            pnl_invoice.Controls.Clear();
        }

        public void calculateTotalCharge()
        {
            int charge = 0;
            foreach (TransationRow tr in pnl_invoice.Controls)
            {
                charge += tr.getCharge();
            }
            lbl_total.Text = "Total Charge : £" + charge.ToString();
        }

        public void removeElement(TransationRow t)
        {
            List<TransationRow> transationRows = new List<TransationRow>();
            foreach(TransationRow tr in pnl_invoice.Controls)
            {
                if(t != tr)
                {
                    transationRows.Add(tr);
                }
            }

            this.SuspendLayout();

            clearElements();

            foreach (TransationRow transationRow in transationRows)
            {
                transationRow.Parent = pnl_invoice;
                transationRow.Location = new Point(0, m_rowIndex * m_rowInc);
                m_rowIndex++;
            }

            calculateTotalCharge();

            this.ResumeLayout();
        }
    }
}
