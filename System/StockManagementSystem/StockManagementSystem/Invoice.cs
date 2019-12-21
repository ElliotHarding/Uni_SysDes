using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem
{
    class Invoice
    {
        string id { get; set; }
        string departmentId { get; set; }
        string productId { get; set; }
        string date { get; set; }
        string price { get; set; }
        string quantitiy { get; set; }
        string vat { get; set; }
    }
}
