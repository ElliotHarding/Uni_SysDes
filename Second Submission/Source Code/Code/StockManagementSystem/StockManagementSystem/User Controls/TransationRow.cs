using System;
using System.Windows.Forms;
using StockManagementSystem.Pages;

namespace StockManagementSystem.User_Controls
{
    public partial class TransactionRow : UserControl
    {
        Invoices m_invoicesPage;
        Transaction m_Transaction;

        public TransactionRow(Invoices invoicesPage, Transaction Transaction)
        {
            InitializeComponent();
            m_invoicesPage = invoicesPage;
            m_Transaction = Transaction;

            txt_name.Text = Transaction.id;
            txt_nNumber.Text = Transaction.nNumber;
            txt_price.Text = "£" + Transaction.price;
            txt_quantity.Text = Transaction.quantity;
            txt_productId.Text = Transaction.productId;
            DateTime dt;
            if(DateTime.TryParse(Transaction.date, out dt))
            {
                dateTime.Value = dt;
            }
        }

        private void Btn_remove_Click(object sender, EventArgs e)
        {
            m_invoicesPage.removeElement(this);
        }

        public Transaction getTransaction()
        {
            Transaction t = new Transaction(m_Transaction.id, dateTime.Text, txt_productId.Text, txt_quantity.Text, txt_nNumber.Text, m_Transaction.department, txt_price.Text, "false");
            return t;
        }

        public int getCharge()
        {
            int charge;
            if (Int32.TryParse(txt_price.Text.Replace("£",""), out charge))
                return charge;
            return 0;
        }

        private void txt_price_TextChanged(object sender, EventArgs e)
        {
            m_invoicesPage.calculateTotalCharge();
        }
    }
}
