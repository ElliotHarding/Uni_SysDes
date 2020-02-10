using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem.Pages
{
    public partial class ViewShipment : BaseForm
    {
        public static Shipment ShipmentToView;

        public ViewShipment()
        {
            InitializeComponent();
            addNavBar();

            supplierNameTxt.Text = ShipmentToView.supplierName;
            supplierSiteNameTxt.Text = ShipmentToView.supplierSiteName;
            supplierRemitToAddressTxt1.Text = ShipmentToView.supplierRemitToAddress.line1;
            supplierRemitToAddressTxt2.Text = ShipmentToView.supplierRemitToAddress.line2;
            supplierRemitToAddressTxt3.Text = ShipmentToView.supplierRemitToAddress.line3;
            supplierRemitToAddressTxt4.Text = ShipmentToView.supplierRemitToAddress.postCode;
            orderNumberTxt.Text = ShipmentToView.orderNo;
            orderLineTxt.Text = ShipmentToView.orderLine;
            goodsAndServicesAddressTxt1.Text = ShipmentToView.goodsAndServicesAddress.line1;
            goodsAndServicesAddressTxt2.Text = ShipmentToView.goodsAndServicesAddress.line2;
            goodsAndServicesAddressTxt3.Text = ShipmentToView.goodsAndServicesAddress.line3;
            goodsAndServicesAddressTxt4.Text = ShipmentToView.goodsAndServicesAddress.postCode;            
            VATTxt.Text = ShipmentToView.vat;
            invoiceTotalTxt.Text = ShipmentToView.invoiceTotal;
            dt_order.Text = DateTime.ParseExact(ShipmentToView.orderDate, "yyyy-MM-dd", CultureInfo.InvariantCulture).ToString();
            dt_requested.Text = DateTime.ParseExact(ShipmentToView.requestedDate, "yyyy-MM-dd", CultureInfo.InvariantCulture).ToString();
            dt_promised.Text = DateTime.ParseExact(ShipmentToView.promisedDate, "yyyy-MM-dd", CultureInfo.InvariantCulture).ToString();
        }

        private void btn_saveChanges_Click(object sender, EventArgs e)
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

            //Todo validation

            Shipment shipment = new Shipment(ShipmentToView.id, supplierName, supplierSiteName,
                supplierRemitToAddressLine1, supplierRemitToAddressLine2, supplierRemitToAddressLine3, supplierRemitToAddressLine4,
                orderNo, orderLine, orderDate, requestedDate, promisedDate,
                goodsAndServicesAddressLine1, goodsAndServicesAddressLine2, goodsAndServicesAddressLine3, goodsAndServicesAddressLine4,
                vat, invoiceTotal);

            DatabaseComms.updateShipment(shipment, updateShipmentCallback);
        }

        private void updateShipmentCallback(bool success)
        {
            if(success)
            {
                notifyUser("Updated", "Success");
            }
            else
            {
                notifyUser("Failed to update shipment. Check internet?");
            }
        }
    }
}
