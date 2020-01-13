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
                const int numBoxesAcross = 4;
                int margin = (panel_products.Width - productWidth * numBoxesAcross) / (numBoxesAcross + 1);

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

                    if(posY > panel_products.Height - (productHeight / 2))
                        productDisplay.Hide();

                    panel_products.Invoke((Action)delegate { panel_products.Controls.Add(productDisplay); });

                    //Next
                    posX += productWidth + margin;                    
                }
            }
        }
    }
}
