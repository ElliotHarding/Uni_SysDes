using System;
using System.Collections.Generic;

namespace StockManagementSystem.Pages
{
    public partial class Inspection : BaseForm
    {
        public static List<Product> products = new List<Product>();
        public Inspection()
        {
            InitializeComponent();
            addNavBar();
            populatePanel();
        }
                
        private void populatePanel()
        {
            //int spacing = 0;
            //foreach(Product product in products)
            //{
            //    TransationRow productRow = new TransationRow();
            //    productRow.Parent = pnl_inspection;
            //    productRow.Location = new Point(0, spacing += 30);
            //}
        }

        private void Btn_sendToStores_Click(object sender, EventArgs e)
        {

        }
    }
}
