using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem
{
    public class Address
    {
        public Address(string line1, string line2, string line3, string postCode_)
        {
            this.line1 = line1;
            this.line2 = line2;
            this.line3 = line3;
            postCode = postCode_;
        }
        public string line1 { get; set; }
        public string line2 { get; set; }
        public string line3 { get; set; }
        public string postCode { get; set; }
    }
}
