using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem
{
    public class Product
    {
        public Product(string id_, string externalId_, string image_, string information_, string locationX_, string locationY_, string quantitiy_, string expieryDate_, string price_, string vat_, string dangerDescription_, string retProductNo_, string name_)
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
            name = name_;
        }

        public Product(string id_, string externalId_, Bitmap image_, string information_, string locationX_, string locationY_, string quantitiy_, string expieryDate_, string price_, string vat_, string dangerDescription_, string retProductNo_, string name_)
        {
            id = id_;
            externalId = externalId_;
            information = information_;
            locationX = locationX_;
            locationY = locationY_;
            quantity = quantitiy_;
            expiryDate = expieryDate_;
            price = price_;
            vat = vat_;
            dangerDescription = dangerDescription_;
            retProductNo = retProductNo_;
            name = name_;
            setBitmap(image_);
        }

        public Product(Product p)
        {
            id = p.id;
            externalId = p.externalId;
            image = p.image;
            information = p.information;
            locationX = p.locationX;
            locationY = p.locationY;
            quantity = p.quantity;
            expiryDate = p.expiryDate;
            price = p.price;
            vat = p.vat;
            dangerDescription = p.dangerDescription;
            retProductNo = p.retProductNo;
            name = p.name;
            requestedQuantitiy = p.requestedQuantitiy;
        }

        public string id { get; set; }
        public string externalId { get; set; }
        public string name { get; set; }
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

        public int requestedQuantitiy = 0;

        public Bitmap getBitmap()
        {
            if (image == null)
                return null;

            Bitmap bmp = null;
            try
            {
                System.IO.MemoryStream memoryStream = new System.IO.MemoryStream(Convert.FromBase64String(image));
                memoryStream.Position = 0;

                bmp = (Bitmap)Bitmap.FromStream(memoryStream);

                memoryStream.Close();
            }
            catch (Exception)
            {               
            }            

            return bmp;
        }

        public void setBitmap(Bitmap bmp)
        {
            if(bmp != null)
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream();

                var encoder = ImageCodecInfo.GetImageEncoders().First(c => c.FormatID == ImageFormat.Jpeg.Guid);
                var encParams = new EncoderParameters() { Param = new[] { new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 10L) } };

                bmp.Save(ms, encoder, encParams);
                byte[] byteImage = ms.ToArray();
                image = Convert.ToBase64String(byteImage);
            }            
        }

    }
}
