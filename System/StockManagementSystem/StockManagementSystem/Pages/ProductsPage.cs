using StockManagementSystem.User_Controls;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StockManagementSystem.Pages
{
    public partial class ProductsPage : BaseForm
    {
        public ProductsPage()
        {
            InitializeComponent();
            addNavBar();
            panel_products.AutoScroll = true;

            DatabaseComms.getProducts(productsCallback);
        }

        //Populate panel_products with products
        public void productsCallback(List<Product> products)
        {
            if (products != null && products.Count() > 0)
            {
                const int productWidth = 150;
                const int productHeight = 150;
                const int numBoxesAcross = 4;
                int margin = (panel_products.Width - 10 - productWidth * numBoxesAcross) / (numBoxesAcross + 1);

                int posX = margin;
                int posY = margin;
                foreach (Product product in products)
                {
                    if (posX >= panel_products.Width - (productWidth/2))
                    {
                        posX = margin;
                        posY += margin + productHeight;
                    }

                    ProductDisplay productDisplay = new ProductDisplay(this, product);
                    productDisplay.SetBounds(posX, posY, productWidth, productHeight);

                    panel_products.Invoke((Action)delegate { panel_products.Controls.Add(productDisplay); });

                    //Next
                    posX += productWidth + margin;                    
                }
            }
        }
    }
}
