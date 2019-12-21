using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem
{
    class Product
    {
        string id { get; set; }
        string externalId { get; set; }
        string image { get; set; }
        string information { get; set; }
        string locationX { get; set; }
        string locationY { get; set; }
        string quantity { get; set; }
        string expiryDate { get; set; }
        string price { get; set; }
        string vat { get; set; }
        string dangerDescription { get; set; }//If null not dangerous
        string retProductNno { get; set; }//if null not return product

    }
}
