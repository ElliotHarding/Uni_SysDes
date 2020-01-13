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
                int itemsDown = (panel_products.Height / (productHeight + margin)) + margin;

                int posX = margin;
                int posY = margin;
                int across = 0;
                int down = 0;
                foreach (Product product in products)
                {
                    ProductDisplay productDisplay = new ProductDisplay(this, product);
                    productDisplay.SetBounds(posX, posY, productWidth, productHeight);

                    if(down > itemsDown)
                        productDisplay.Hide();

                    panel_products.Controls.Add(productDisplay);

                    //Next
                    across++;
                    if (across >= itemsAcross)
                    {
                        posX = margin;
                        posY += margin + productHeight;
                        down++;
                    }
                    else
                    {
                        posX += margin + productWidth;
                    }                    
                }
            }
        }
    }
}
