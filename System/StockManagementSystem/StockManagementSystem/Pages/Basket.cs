﻿using System;
using System.Collections.Generic;
using System.Drawing;
using StockManagementSystem.User_Controls;

namespace StockManagementSystem.Pages
{
    public partial class Basket : BaseForm
    {
        private static List<Product> m_products = new List<Product>();

        public static void addToBasket(Product product)
        {
            bool bAlreadyInBasket = false;
            foreach (Product p in m_products)
            {
                if (p.id == product.id)
                {
                    p.requestedQuantitiy += product.requestedQuantitiy;
                    bAlreadyInBasket = true;
                }
            }

            if (!bAlreadyInBasket)
                m_products.Add(product);
        }

        private int m_iRowIndex = 0;

        public Basket()
        {
            InitializeComponent();
            addNavBar();

            foreach(Product p in m_products)
            {
                addRow(new BasketRow(p, this));
            }

            if (m_products.Count > 0)
                lbl_noProducts.Hide();
        }

        private void addRow(BasketRow productRow)
        {
            productRow.Parent = pnl_products;
            productRow.Location = new Point(0, m_iRowIndex * (productRow.Height + 10));
            m_iRowIndex++;
        }

        internal void removeRow(BasketRow basketRow)
        {
            List<BasketRow> products = new List<BasketRow>();
            foreach (BasketRow bRow in pnl_products.Controls)
            {
                if (basketRow != bRow)
                {
                    products.Add(bRow);
                }
            }

            this.SuspendLayout();

            m_iRowIndex = 0;
            pnl_products.Controls.Clear();

            foreach (BasketRow bRow in products)
            {
                addRow(bRow);
            }

            this.ResumeLayout();
        }

        private void btn_returnItems_Click(object sender, EventArgs e)
        {
            List<Product> products = new List<Product>();
            List<Transation> transations = new List<Transation>();
            foreach (BasketRow npr in pnl_products.Controls)
            {
                Product p = npr.GetProduct();

                transations.Add(new Transation("", DateTime.Now.ToString("yyyy-MM-dd"), p.id, p.requestedQuantitiy.ToString(), m_currentUser.nNumber, m_currentUser.department, p.price, "true"));

                int currentQuantiy = 0;
                if (Int32.TryParse(p.quantity, out currentQuantiy))
                {
                    currentQuantiy += p.requestedQuantitiy;
                    p.quantity = currentQuantiy.ToString();
                    products.Add(p);
                }                
            }

            DatabaseComms.updateProductQuantities(returnItemsCallback, products, transations);
        }

        private void returnItemsCallback(bool success)
        {
            if (success)
            {
                this.Invoke((Action)delegate { clearAll(); });                
            }
            else
            {
                notifyUser("Failed to return products.");
            }
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            List<Product> notEnough = new List<Product>();
            List<Product> products = new List<Product>();
            List<Transation> transations = new List<Transation>();
            foreach (BasketRow npr in pnl_products.Controls)
            {
                Product p = new Product(npr.GetProduct());

                int currentQuantiy = 0;
                if (Int32.TryParse(p.quantity, out currentQuantiy))
                {
                    currentQuantiy -= p.requestedQuantitiy;
                    if(currentQuantiy > 0)
                    {
                        p.quantity = currentQuantiy.ToString();
                        products.Add(p);
                        transations.Add(new Transation("", DateTime.Now.ToString("yyyy-MM-dd"), p.id, p.requestedQuantitiy.ToString(), m_currentUser.nNumber, m_currentUser.department, p.price, "false"));
                    }
                    else
                    {
                        notEnough.Add(p);
                    }                   
                }
            }

            if(notEnough.Count == 0)
                DatabaseComms.updateProductQuantities(checkoutItemsCallback, products, transations);
            else
            {
                foreach(Product p in notEnough)
                {
                    notifyUser("Not enough stock of " + p.name);
                }
            }
        }

        private void checkoutItemsCallback(bool success)
        {
            if (success)
            {
                this.Invoke((Action)delegate { clearAll(); });
            }
            else
            {
                notifyUser("Failed to return products.");
            }
        }

        private void btn_clearAll_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void clearAll()
        {
            m_products.Clear();
            m_products = new List<Product>();
            pnl_products.Controls.Clear();
        }

        private void getScannedProductCallback(Product p)
        {
            if(p != null)
            {
                this.Invoke((Action)delegate 
                {
                    p.requestedQuantitiy = 1;

                    bool bAlreadyInBasket = false;
                    foreach (BasketRow basketRow in pnl_products.Controls)
                    {
                        if (basketRow.getProductId() == p.id)
                        {
                            basketRow.addQuantity(p.requestedQuantitiy);
                            bAlreadyInBasket = true;
                        }
                    }

                    if (!bAlreadyInBasket)
                    {
                        m_products.Add(p);
                        addRow(new BasketRow(p, this));
                    }
                });                                    
            }
        }

        private void m_scanedProductTimer_Tick(object sender, EventArgs e)
        {
            DatabaseComms.getScannedProduct(m_currentUser.nNumber, getScannedProductCallback);
        }
    }
}
