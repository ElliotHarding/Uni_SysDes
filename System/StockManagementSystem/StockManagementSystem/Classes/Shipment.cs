namespace StockManagementSystem
{
    public class Shipment
    {
        public Shipment(string id_, string supplierName_, string supplierSiteName_, string supplierRemitToAddressLine1, string supplierRemitToAddressLine2, string supplierRemitToAddressLine3, string supplierRemitToAddressLine4, string orderNo_, string orderLine_,
            string orderDate_, string requestedDate_, string promisedDate_, string goodsAndServicesAddressLine1, string goodsAndServicesAddressLine2, string goodsAndServicesAddressLine3, string goodsAndServicesAddressLine4, string vat_, string invoiceTotal_)
        {
            id = id_;
            supplierName = supplierName_;
            supplierSiteName = supplierSiteName_;
            supplierRemitToAddress = new Address(supplierRemitToAddressLine1, supplierRemitToAddressLine2, supplierRemitToAddressLine3, supplierRemitToAddressLine4);
            orderNo = orderNo_;
            orderDate = orderDate_;
            requestedDate = requestedDate_;
            promisedDate = promisedDate_;
            goodsAndServicesAddress = new Address(goodsAndServicesAddressLine1, goodsAndServicesAddressLine2, goodsAndServicesAddressLine3, goodsAndServicesAddressLine4); ;
            vat = vat_;
            invoiceTotal = invoiceTotal_;
            orderLine = orderLine_;
        }

        public string id { get; set; }
        public string supplierName { get; set; }
        public string supplierSiteName { get; set; }
        public Address supplierRemitToAddress { get; set; }
        public string orderNo { get; set; }
        public string orderLine { get; set; }
        public string orderDate { get; set; }
        public string requestedDate { get; set; }
        public string promisedDate { get; set; }
        public Address goodsAndServicesAddress { get; set; }
        public string vat { get; set; }
        public string invoiceTotal { get; set; }
    }
}
