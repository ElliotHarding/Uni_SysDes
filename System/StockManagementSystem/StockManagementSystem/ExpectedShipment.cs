using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem
{
    public class ExpectedShipment
    {
        public ExpectedShipment(string shipmentId_, string dateExpected_, string supplierName_, string supplierId_)
        {
            shipmentId = shipmentId_;
            dateExpected = dateExpected_;
            supplierName = supplierName_;
            supplierId = supplierId_;
        }

        public string shipmentId { get; set; }
        public string dateExpected { get; set; }
        public string supplierName { get; set; }
        public string supplierId { get; set; }
    }
}
