using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem
{
    public class Product
    {
        public Product(string id_, string externalId_, string image_, string information_, string locationX_, string locationY_, string quantitiy_, string expieryDate_, string price_, string vat_, string dangerDescription_, string retProductNo_)
        {
            id = id_;
            externalId = externalId_;
            image = image_;
            information = information_;
            locationX = locationX_;
            locationY = locationY_;
            quantity = quantitiy_;
            expiryDate = expieryDate_;
            price = price_;
            vat = vat_;
            dangerDescription = dangerDescription_;
            retProductNo = retProductNo_;
        }
        public string id { get; set; }
        public string externalId { get; set; }
        public string image { get; set; }
        public string information { get; set; }
        public string locationX { get; set; }
        public string locationY { get; set; }
        public string quantity { get; set; }
        public string expiryDate { get; set; }
        public string price { get; set; }
        public string vat { get; set; }
        public string dangerDescription { get; set; }//If null not dangerous
        public string retProductNo { get; set; }//if null not return product

    }
}
