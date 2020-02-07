﻿using System;
using System.Collections.Generic;
using System.Drawing;
using StockManagementSystem.User_Controls;

namespace StockManagementSystem.Pages
{
    public partial class NewShipment : BaseForm
    {
        private int m_iRowIndex = 0;
        List<Product> m_newProducts = new List<Product>();

        public NewShipment()
        {
            InitializeComponent();
            addNavBar();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string itemCode = tb_itemCode.Text;
            string itemSupplierCode = tb_supplierItemCode.Text;
            string quantitiy = tb_quantitiy.Text;

            int iQuantitiy;
            if (Int32.TryParse(quantitiy, out iQuantitiy))
            {
                if(itemCode != null && itemCode != "")
                {
                    DatabaseComms.updateProductQuantity(updateProductQuantityCallback, quantitiy,  "id = '" + itemCode + "'");
                }
                else if(itemSupplierCode != null && itemSupplierCode != "")
                {
                    DatabaseComms.updateProductQuantity(updateProductQuantityCallback, quantitiy, "externalId = '" + itemSupplierCode + "'");
                }
                else
                {
                    notifyUser("Add either item code or supplier item code.");
                }
            }
            else
            {
                notifyUser("Invalid quantitiy input.");
            }
        }

        internal void removeNewProductRow(NewProductRow productRowToRemove)
        {
            List<NewProductRow> products = new List<NewProductRow>();
            foreach (NewProductRow npr in pnl_newProducts.Controls)
            {
                if (productRowToRemove != npr)
                {
                    products.Add(npr);
                }
            }

            this.SuspendLayout();

            m_iRowIndex = 0;
            pnl_newProducts.Controls.Clear();

            foreach (NewProductRow npr in products)
            {
                addRow(npr);
            }

            this.ResumeLayout();
        }

        private void addRow(NewProductRow productRow)
        {
            productRow.Parent = pnl_newProducts;
            productRow.Location = new Point(0, m_iRowIndex * (productRow.Height + 10));
            m_iRowIndex++;
        }

        private void btn_addNewProductRow_Click(object sender, EventArgs e)
        {
            addRow(new NewProductRow(this));
        }

        private void btn_addNewProducts_Click(object sender, EventArgs e)
        {
            m_newProducts = new List<Product>();
            foreach (NewProductRow npr in pnl_newProducts.Controls)
            {
                m_newProducts.Add(npr.GetProduct());
            }

            if (m_newProducts.Count > 0)
                DatabaseComms.uploadProducts(m_newProducts, uploadProductsCallback);
        }

        private void updateProductQuantityCallback(bool success)
        {
            if(success)
            {
                notifyUser("Success in adding items", "Success");
            }
            else
            {
                notifyUser("Failed to add items, check codes, or internet.");
            }
        }     

        private void uploadProductsCallback(bool success)
        {
            if (success)
            {
                notifyUser("Added shipment and products.", "Success");
                this.Invoke((Action)delegate { goToNextPage(SystemPage.NewShipment); });
            }
            else
            {
                notifyUser("Failed to add products of shipment. Check internet.");
            }
        }
    }
}
