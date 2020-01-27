using StockManagementSystem.User_Controls;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace StockManagementSystem.Pages
{
    public partial class Invoices : BaseForm
    {
        public Invoices()
        {
            InitializeComponent();
            addNavBar();
        }        

        private void Btn_add_row_Click(object sender, EventArgs e)
        {
            
        }

        private void populateInvoices(List<Transation> transations)
        {
            int spacing = 0;
            foreach(Transation product in transations)
            {
                ProductRow productRow = new ProductRow();
                productRow.Parent = pnl_invoice;
                productRow.Location = new Point(0, spacing += 30);
            }
        }
    }
}
