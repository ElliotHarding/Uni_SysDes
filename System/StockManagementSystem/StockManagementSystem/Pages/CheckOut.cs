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
    public partial class CheckOut : BaseForm
    {
        
        public static List<Product> products = new List<Product>();
        public CheckOut()
        {
            InitializeComponent();
            addNavBar();
            Product product = new Product("test", "test", "test", "test", "test", "test", "test", "test", "test", "test", "test", "test", "test");
            Product jack = new Product("jack", "jack", "jack", "jack", "jack", "jack", "jack", "jack", "jack", "jack", "jack", "jack", "jack");
            Product bomb = new Product("bomb", "bomb", "bomb", "bomb", "bomb", "bomb", "bomb", "bomb", "bomb", "bomb", "bomb", "bomb", "bomb");
            
            
            products.Add(product);
            products.Add(product);
            products.Add(bomb);
            products.Add(jack);
            populate();


        }
   
        private void populate()
        {
            if (products != null && products.Count() > 0)
            {
                
                foreach (Product product in products)
                {
                    CheckoutItem checkout = new CheckoutItem(product, this);
                    
                    if (cOutBox.Controls.Count < 0)
                    {
                        cOutBox.Controls.Clear();
                    }
                    else
                    {
                        cOutBox.Controls.Add(checkout);
                        
                    }

                    
                }
            }
        }

        public void removeItem(Product slctdProduct)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].name == slctdProduct.name)
                {
                    products.RemoveAt(i);
                }
            }

            cOutBox.Controls.Clear();
            populate();
        }

    }
}
