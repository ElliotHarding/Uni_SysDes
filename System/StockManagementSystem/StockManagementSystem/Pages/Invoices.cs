using StockManagementSystem.Classes;
using StockManagementSystem.User_Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace StockManagementSystem.Pages
{
    public partial class Invoices : BaseForm
    {
        public Invoices()
        {
            InitializeComponent();
            setupGlobalControls(this);

            startProgressBar();
            DatabaseComms.getDepartments(getDepartmentsCallback);
        }

        private void getDepartmentsCallback(List<string> departments)
        {
            this.Invoke((Action)delegate { stopProgressBar(); });
            if (departments != null && departments.Count > 0)
            {
                cmb_department.Invoke((Action)delegate {

                    foreach(string department in departments)
                    {
                        cmb_department.Items.Add(department);
                    }
                    cmb_department.Items.Add("All");
                });
            }
            else
            {
                notifyUser("Network connection error.");
            }
        }

        const int m_rowInc = 30;
        int m_rowIndex = 0;

        private void addTransactions(List<Transaction> Transactions)
        {
            foreach (Transaction Transaction in Transactions)
            {
                TransactionRow productRow = new TransactionRow(this, Transaction);
                productRow.Parent = pnl_invoice;
                productRow.Location = new Point(0, m_rowIndex * m_rowInc);
                m_rowIndex++;
            }
        }

        private void Btn_send_invoice_Click(object sender, EventArgs e)
        {
            int charge = 0;
            string fileContents = "Item, ProductId, N-Number, Date, Quantity, Charge (£)" + Environment.NewLine;
            foreach (TransactionRow tr in pnl_invoice.Controls)
            {
                Transaction t = tr.getTransaction();
                fileContents += t.id + "," + t.productId + "," + t.nNumber + "," + t.date + "," + t.quantity + "," + t.price.Replace("£", "") + Environment.NewLine;
                charge += tr.getCharge();
            }
            fileContents += "Total charge : £" + charge.ToString();

            File.WriteAllText("Invocies.csv", fileContents);

            notifyUser("Created invoices.csv", "Success");
        }

        private void Btn_add_row_Click(object sender, EventArgs e)
        {
            TransactionRow productRow = new TransactionRow(this, new Transaction("", "", "", "", "", cmb_department.Text, "0", ""));
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
                    startProgressBar();
                    if (cmb_department.Text == "All" || cmb_department.Text == "")
                        DatabaseComms.getTransactions(transactionsCallback, "date > '" + fromDate.ToString("yyyy-MM-dd") + "' AND date < '" + toDate.ToString("yyyy-MM-dd") + "' AND isReturn = 'false'");
                    else
                        DatabaseComms.getTransactions(transactionsCallback, "department = '" + cmb_department.Text + "' AND date > '" + fromDate.ToString("yyyy-MM-dd") + "' AND date < '" + toDate.ToString("yyyy-MM-dd") + "' AND isReturn = 'false'");
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

        private void transactionsCallback(List<Transaction> Transactions)
        {
            this.Invoke((Action)delegate { stopProgressBar(); });
            if (Transactions == null || Transactions.Count == 0)
            {
                notifyUser("No transactions found matching the deparment selected", "Warning");
            }
            else
            {
                this.Invoke((Action)delegate 
                {
                    foreach (Transaction Transaction in Transactions)
                    {
                        TransactionRow productRow = new TransactionRow(this, Transaction);
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
            foreach (TransactionRow tr in pnl_invoice.Controls)
            {
                charge += tr.getCharge();
            }
            lbl_total.Text = "Total Charge : £" + charge.ToString();
        }

        public void removeElement(TransactionRow t)
        {
            List<TransactionRow> TransactionRows = new List<TransactionRow>();
            foreach(TransactionRow tr in pnl_invoice.Controls)
            {
                if(t != tr)
                {
                    TransactionRows.Add(tr);
                }
            }

            this.SuspendLayout();

            clearElements();

            foreach (TransactionRow TransactionRow in TransactionRows)
            {
                TransactionRow.Parent = pnl_invoice;
                TransactionRow.Location = new Point(0, m_rowIndex * m_rowInc);
                m_rowIndex++;
            }

            calculateTotalCharge();

            this.ResumeLayout();
        }
    }
}
