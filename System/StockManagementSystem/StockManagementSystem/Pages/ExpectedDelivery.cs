﻿using StockManagementSystem.User_Controls;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace StockManagementSystem.Pages
{
    public partial class ExpectedDelivery : BaseForm
    {
        private int m_iRowIndex = 0;
        List<Product> newProducts = new List<Product>();

        public ExpectedDelivery()
        {
            InitializeComponent();
            setupGlobalControls(this);
        }

        private void btn_addShipmentDetails_Click(object sender, EventArgs e)
        {
            string supplierName = supplierNameTxt.Text;
            string supplierSiteName = supplierSiteNameTxt.Text;
            string supplierRemitToAddressLine1 = supplierRemitToAddressTxt1.Text;
            string supplierRemitToAddressLine2 = supplierRemitToAddressTxt2.Text;
            string supplierRemitToAddressLine3 = supplierRemitToAddressTxt3.Text;
            string supplierRemitToAddressLine4 = supplierRemitToAddressTxt4.Text;
            string orderNo = orderNumberTxt.Text;
            string orderLine = orderLineTxt.Text;
            string orderDate = dt_order.Value.ToString("yyyy-MM-dd");
            string requestedDate = dt_requested.Value.ToString("yyyy-MM-dd"); ;
            string promisedDate = dt_promised.Value.ToString("yyyy-MM-dd"); ;
            string goodsAndServicesAddressLine1 = goodsAndServicesAddressTxt1.Text;
            string goodsAndServicesAddressLine2 = goodsAndServicesAddressTxt2.Text;
            string goodsAndServicesAddressLine3 = goodsAndServicesAddressTxt3.Text;
            string goodsAndServicesAddressLine4 = goodsAndServicesAddressTxt4.Text;
            string vat = VATTxt.Text;
            string invoiceTotal = invoiceTotalTxt.Text;

            if (DateTime.Parse(orderDate) < DateTime.Parse(requestedDate))
            {
                notifyUser("The requested date cannot occur before the order date");
                return;
            }

            if (vat == null || vat == "" || !int.TryParse(vat, out int i))
            {
                notifyUser("Please enter a valid VAT amount");
                return;
            }

            if (invoiceTotal == null || invoiceTotal == "" || !int.TryParse(invoiceTotal, out int ii))
            {
                notifyUser("Please enter a valid invoice total");
                return;
            }

            if (supplierName == null || supplierName == "")
            {
                notifyUser("Please enter a supplier name");
                return;
            }

            if (supplierSiteName == null || supplierSiteName == "")
            {
                notifyUser("Please enter a supplier site name");
                return;
            }

            if (supplierRemitToAddressLine1 == null || supplierRemitToAddressLine1 == "")
            {
                notifyUser("Please enter a supplier remit to address");
                return;
            }

            if (orderNo == null || orderNo == "")
            {
                notifyUser("Please enter an order number");
                return;
            }

            if (goodsAndServicesAddressLine1 == null || goodsAndServicesAddressLine1 == "")
            {
                notifyUser("Please enter an goods and services address");
                return;
            }

            Shipment shipment = new Shipment(null, supplierName, supplierSiteName,
                supplierRemitToAddressLine1, supplierRemitToAddressLine2, supplierRemitToAddressLine3, supplierRemitToAddressLine4,
                orderNo, orderLine, orderDate, requestedDate, promisedDate,
                goodsAndServicesAddressLine1, goodsAndServicesAddressLine2, goodsAndServicesAddressLine3, goodsAndServicesAddressLine4,
                vat, invoiceTotal);

            newProducts = new List<Product>();
            foreach (NewProductRow npr in pnl_newProducts.Controls)
            {
                newProducts.Add(npr.GetProduct());
            }

            startProgressBar();
            DatabaseComms.uploadShipment(shipment, addShipmentCallback);
        }

        private void addShipmentCallback(bool success)
        {            
            if (success)
            {
                if (newProducts.Count > 0)
                {
                    DatabaseComms.uploadProducts(newProducts, uploadProductsCallback);
                }                    
                else
                {
                    notifyUser("Added shipment.", "Success");
                    this.Invoke((Action)delegate { stopProgressBar(); });
                    this.Invoke((Action)delegate { goToNextPage(SystemPage.NewShipment); });
                }
            }
            else
            {
                this.Invoke((Action)delegate { stopProgressBar(); });
                notifyUser("Failed to upload new shipment. Check internet.");
            }
        }

        private void uploadProductsCallback(bool success)
        {
            this.Invoke((Action)delegate { stopProgressBar(); });
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

        public void removeNewProductRow(NewProductRow productRowToRemove)
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

        private void btn_addNewProductRow_Click(object sender, EventArgs e)
        {
            addRow(new NewProductRow(this));
        }

        private void addRow(NewProductRow productRow)
        {
            productRow.Parent = pnl_newProducts;
            productRow.Location = new Point(0, m_iRowIndex * (productRow.Height + 10));
            m_iRowIndex++;
        }
    }
}
