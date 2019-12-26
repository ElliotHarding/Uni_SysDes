using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem
{
    public class Shipment
    {
        public Shipment(string id_, string supplierName_, string supplierSiteName_, string supplierRemitToAddressLine1, string supplierRemitToAddressLine2, string supplierRemitToAddressLine3, string supplierRemitToAddressPostCode, string orderNo_,
            string date_, string requestedDate_, string promisedDate_, string goodsAndServices_, string vat_, string invoiceTotal_, string supplierIdNumber_, string universalProductCode_, string itemDescription_, string quantity_, string unitOfMeasure_,
            string unitOfPrice_, string extendedPrice_)
        {
            id = id_;
            supplierName = supplierName_;
            supplierSiteName = supplierSiteName_;
            supplierRemitToAddress = new Address(supplierRemitToAddressLine1, supplierRemitToAddressLine2, supplierRemitToAddressLine3, supplierRemitToAddressPostCode);
            orderNo = orderNo_;
            date = date_;
            requestedDate = requestedDate_;
            promisedDate = promisedDate_;
            goodsAndServices = goodsAndServices_;
            vat = vat_;
            invoiceTotal = invoiceTotal_;
            supplierIdNumber = supplierIdNumber_;
            universalProductCode = universalProductCode_;
            itemDescription = itemDescription_;
            quantity = quantity_;
            unitOfMeasure = unitOfMeasure_;
            unitOfPrice = unitOfPrice_;
            extendedPrice = extendedPrice_;
        }

        public string id { get; set; }
        public string supplierName { get; set; }
        public string supplierSiteName { get; set; }
        public Address supplierRemitToAddress { get; set; }
        public string orderNo { get; set; }
        public string date { get; set; }
        public string requestedDate { get; set; }
        public string promisedDate { get; set; }
        public string goodsAndServices { get; set; }
        public string vat { get; set; }
        public string invoiceTotal { get; set; }
        public string supplierIdNumber { get; set; }
        public string universalProductCode { get; set; }
        public string itemDescription { get; set; }
        public string quantity { get; set; }
        public string unitOfMeasure { get; set; }
        public string unitOfPrice { get; set; }
        public string extendedPrice { get; set; }
    }
}
