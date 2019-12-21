using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem
{
    class Shipment
    {
        string supplierName { get; set; }
        string supplierSiteName { get; set; }
        Address supplierRemitToAddress { get; set; }
        string orderNo { get; set; }
        string date { get; set; }
        string requestedDate { get; set; }
        string promisedDate { get; set; }
        string goodsAndServices { get; set; }
        string vat { get; set; }
        string invoiceTotal { get; set; }
        string supplierIdNumber { get; set; }
        string universalProductCode { get; set; }
        string itemDescription { get; set; }
        string quantity { get; set; }
        string unitOfMeasure { get; set; }
        string unitOfPrice { get; set; }
        string extendedPrice { get; set; }
    }
}
