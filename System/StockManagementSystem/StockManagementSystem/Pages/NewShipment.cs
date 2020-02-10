using System;
using System.Collections.Generic;
using System.Drawing;
using StockManagementSystem.User_Controls;

namespace StockManagementSystem.Pages
{
    public partial class NewShipment : BaseForm
    {
        private int m_iRowIndex = 0;       

        public NewShipment()
        {
            InitializeComponent();
            addNavBar();
        }

        //todo test:
        int m_updateQuantity = 0;
        private void btn_add_Click(object sender, EventArgs e)
        {
            string itemCode = tb_itemCode.Text;
            string itemSupplierCode = tb_supplierItemCode.Text;
            string quantitiy = tb_quantitiy.Text;

            int iQuantitiy;
            if (Int32.TryParse(quantitiy, out iQuantitiy))
            {
                m_updateQuantity = iQuantitiy;
                if (itemCode != null && itemCode != "")
                {                    
                    DatabaseComms.getProducts(getOrigionalProductForUpdateCallback, 100, "id = '" + itemCode + "'");
                }
                else if(itemSupplierCode != null && itemSupplierCode != "")
                {                    
                    DatabaseComms.getProducts(getOrigionalProductForUpdateCallback, 100, "externalId = '" + itemSupplierCode + "'");
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

        private void getOrigionalProductForUpdateCallback(List<Product> products)
        {
            if(products != null && products.Count > 0 && products[0] != null)
            {
                int iCurrentQuantity;
                if (Int32.TryParse(products[0].quantity, out iCurrentQuantity))
                {
                    iCurrentQuantity += m_updateQuantity;
                    DatabaseComms.updateProductQuantity(updateProductQuantityCallback, iCurrentQuantity.ToString(), "id = '" + products[0].id + "'");
                }
                else
                {
                    notifyUser("Unable to update product");
                }                
            }
            else
            {
                notifyUser("Unable to find product");
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
            List<Product> newProducts = new List<Product>();
            foreach (NewProductRow npr in pnl_newProducts.Controls)
            {
                newProducts.Add(npr.GetProduct());
            }

            if (newProducts.Count > 0)
                DatabaseComms.uploadProducts(newProducts, uploadProductsCallback);
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
                notifyUser("Added products.", "Success");
                this.Invoke((Action)delegate { pnl_newProducts.Controls.Clear(); });
            }
            else
            {
                notifyUser("Failed to add products of shipment. Check internet.");
            }
        }
    }
}
