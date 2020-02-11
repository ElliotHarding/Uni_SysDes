using StockManagementSystem.User_Controls;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace StockManagementSystem.Pages
{
    public partial class Shipments : BaseForm
    {
        public Shipments()
        {
            InitializeComponent();
            addNavBar();
        }

        private void Btn_newShipment_Click(object sender, EventArgs e)
        {
            goToNextPage(SystemPage.NewShipment);
        }

        private void Btn_viewShipments_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dateFrom.Value;
            DateTime toDate = dateTo.Value;

            if (fromDate != null && toDate != null)
            {
                DatabaseComms.getShipments(getShipmentsCallback, "orderDate > '" + fromDate.ToString("yyyy-MM-dd") + "' AND orderDate < '" + toDate.ToString("yyyy-MM-dd") + "'");
            }
            else
            {
                notifyUser("Please make sure dates are correct.");
            }
        }

        private void getShipmentsCallback(List<Shipment> shipments)
        {
            if(shipments != null && shipments.Count > 0)
            {
                pnl_shipments.Invoke((Action)delegate {
                    pnl_shipments.Controls.Clear();
                    int rowIndex = 0;
                    foreach (Shipment shipment in shipments)
                    {
                        ShipmentRow productRow = new ShipmentRow(this, shipment);
                        productRow.Parent = pnl_shipments;
                        productRow.Location = new Point(0, rowIndex * productRow.Height);
                        rowIndex++;
                    }
                });                
            }
            else
            {
                notifyUser("No shipments found. Check internet?");
            }            
        }

        public void viewShipment(Shipment shipment)
        {
            ViewShipment.ShipmentToView = shipment;
            goToNextPage(SystemPage.ViewShipment);
        }

        private void btn_addExpectedDelivery_Click(object sender, EventArgs e)
        {
            goToNextPage(SystemPage.ExpectedDelivery);
        }
    }
}
