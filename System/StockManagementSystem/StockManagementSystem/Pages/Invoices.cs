﻿using StockManagementSystem.User_Controls;
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
        }

        private void Btn_add_row_Click(object sender, EventArgs e)
        {
            TransationRow productRow = new TransationRow(this, new Transation("Custom invoice row", "", "", "", "", cmb_department.Text));
            productRow.Parent = pnl_invoice;
            productRow.Location = new Point(0, m_rowIndex * m_rowInc);
            m_rowIndex++;
        }

        private void Btn_create_from_log_Click(object sender, EventArgs e)
        {
            if(cmb_department.Text != null)
            {
                DatabaseComms.getTransations(transactionsCallback, "WHERE department = '" + cmb_department.Text + "'");
            }
            else
            {
                MessageBox.Show("No transactions found matching the deparment selected", "Warning");
            }            
        }

        private void transactionsCallback(List<Transation> transations)
        {
            if (transations == null || transations.Count == 0)
            {
                MessageBox.Show("No transactions found matching the deparment selected", "Warning");
            }
            else
            {
                foreach (Transation transation in transations)
                {
                    TransationRow productRow = new TransationRow(this, transation);
                    productRow.Location = new Point(0, m_rowIndex * m_rowInc);
                    pnl_invoice.Invoke((Action)delegate { productRow.Parent = pnl_invoice; });
                    m_rowIndex++;
                }
            }
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            clearElements();
        }

        void clearElements()
        {
            m_rowIndex = 0;
            pnl_invoice.Controls.Clear();
        }

        public void removeElement(TransationRow t)
        {
            List<TransationRow> transationRows = new List<TransationRow>();
            bool found = false;
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

            this.ResumeLayout();
        }
    }
}
