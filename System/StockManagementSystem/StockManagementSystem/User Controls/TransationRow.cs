using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystem.Pages;

namespace StockManagementSystem.User_Controls
{
    public partial class TransationRow : UserControl
    {
        Invoices m_invoicesPage;
        Transation m_transation;

        public TransationRow(Invoices invoicesPage, Transation transation)
        {
            InitializeComponent();
            m_invoicesPage = invoicesPage;
            m_transation = transation;

            txt_name.Text = transation.id;
            txt_nNumber.Text = transation.nNumber;
            txt_price.Text = transation.price + "£";
            txt_quantity.Text = transation.quantity;
            txt_productId.Text = transation.productId;
            DateTime dt;
            if(DateTime.TryParse(transation.date, out dt))
            {
                dateTime.Value = dt;
            }
        }

        private void Btn_remove_Click(object sender, EventArgs e)
        {
            m_invoicesPage.removeElement(this);
        }

        public Transation getTransation()
        {
            //todo validation of price ect...
            Transation t = new Transation(m_transation.id, dateTime.Text, txt_productId.Text, txt_quantity.Text, txt_nNumber.Text, m_transation.department, txt_price.Text, "false");
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
