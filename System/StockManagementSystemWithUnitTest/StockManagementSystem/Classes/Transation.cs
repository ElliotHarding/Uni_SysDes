using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem
{
    public class Transation
    {
        public Transation(string id_, string date_, string productId_, string quantitiy_, string nNumber_, string department_, string price_, string isReturn_)
        {
            id = id_;
            date = date_;
            productId = productId_;
            quantity = quantitiy_;
            nNumber = nNumber_;
            department = department_;
            price = price_;
            isReturn = isReturn_;
        }

        public string id { get; set; }
        public string date { get; set; }
        public string productId { get; set; }        
        public string quantity { get; set; }
        public string nNumber { get; set; }
        public string department { get; set; }
        public string price { get; set; }
        public string isReturn { get; set; }
    }
}
