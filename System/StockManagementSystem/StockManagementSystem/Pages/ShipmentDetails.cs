using System;

namespace StockManagementSystem.Pages
{
    public partial class ShipmentDetails : BaseForm
    {
        private Shipment m_shipment;

        public ShipmentDetails()
        {
            InitializeComponent();
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

            //Todo validation

            m_shipment = new Shipment(null, supplierName, supplierSiteName,
                supplierRemitToAddressLine1, supplierRemitToAddressLine2, supplierRemitToAddressLine3, supplierRemitToAddressLine4,
                orderNo, orderLine, orderDate, requestedDate, promisedDate,
                goodsAndServicesAddressLine1, goodsAndServicesAddressLine2, goodsAndServicesAddressLine3, goodsAndServicesAddressLine4,
                vat, invoiceTotal);
        }

        private void addShipmentCallback(bool success)
        {

        }
    }
}
