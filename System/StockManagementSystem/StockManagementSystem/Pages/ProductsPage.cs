using StockManagementSystem.Classes;
using StockManagementSystem.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem.Pages
{
    public partial class ProductsPage : BaseForm
    {
        public ProductsPage()
        {
            InitializeComponent();
            addNavBar();

            DatabaseComms.getProducts(productsCallback);
        }

        public void productsCallback(List<Product> products)
        {
            if (products != null && products.Count() > 0)
            {
                const int productWidth = 150;
                const int productHeight = 150;
                const int margin = 30;
                int itemsAcross = (panel_products.Width / (productWidth + margin)) + margin;
                int itemsUp = (panel_products.Height / (productHeight + margin)) + margin;
            }
        }
    }
}
