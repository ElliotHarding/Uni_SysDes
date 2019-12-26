using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem
{
    public class Invoice
    {
        public Invoice(string id_, string departmentId_, string productId_, string date_,
            string price_, string quantity_, string vat_)
        {
            id = id_;
            departmentId = departmentId_;
            productId = productId_;
            date = date_;
            price = price_;
            quantitiy = quantity_;
            vat = vat_;
        }
        public string id { get; set; }
        public string departmentId { get; set; }
        public string productId { get; set; }
        public string date { get; set; }
        public string price { get; set; }
        public string quantitiy { get; set; }
        public string vat { get; set; }
    }
}
