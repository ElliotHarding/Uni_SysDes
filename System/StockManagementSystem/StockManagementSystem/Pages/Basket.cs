using System;
using System.Collections.Generic;
using System.Drawing;
using StockManagementSystem.User_Controls;

namespace StockManagementSystem.Pages
{
    public partial class Basket : BaseForm
    {
        static public List<Product> products = new List<Product>();
        private int m_iRowIndex = 0;

        public Basket()
        {
            InitializeComponent();
            addNavBar();

            foreach(Product p in products)
            {
                addRow(new BasketRow(p, this));
            }

            if (products.Count > 0)
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

        private List<Product> getProducts()
        {
            List<Product> newProducts = new List<Product>();
            foreach (BasketRow npr in pnl_products.Controls)
            {
                newProducts.Add(npr.GetProduct());
            }
            return newProducts;
        }

        private void btn_sendToInspection_Click(object sender, EventArgs e)
        {
            List<Product> products = getProducts();
            //todo
            clearAll();
        }

        private void btn_returnItems_Click(object sender, EventArgs e)
        {
            List<Product> products = getProducts();
            //todo
            clearAll();
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            List<Product> products = getProducts();
            //todo
            clearAll();
        }

        private void btn_clearAll_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void clearAll()
        {
            products.Clear();
            products = new List<Product>();
            pnl_products.Controls.Clear();
        }
    }
}
