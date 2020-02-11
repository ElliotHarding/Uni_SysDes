using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;

namespace StockManagementSystem.Classes
{
    public class Tools
    {
        public static string passwordHash(string password)
        {
            var md5 = new MD5CryptoServiceProvider();
            var md5data = md5.ComputeHash(Encoding.ASCII.GetBytes(password));
            return Convert.ToBase64String(md5data);
        }
        
        public bool sendEmail(string recipient, string subject, string[] contents)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.To.Add(recipient);
                mail.From = new MailAddress("stockMan675412@gmail.com");
                mail.Subject = subject;
                foreach (string s in contents)
                {
                    mail.Body = s + "\n";
                }
                mail.IsBodyHtml = true;

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.Credentials = new NetworkCredential("stockMan675412@gmail.com", "StockMan66");
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                }
            }
            catch(Exception)
            {
                return false;
            }         
            return true;
        }

        public Bitmap base64ToBitmap(string base64)
        {
            Bitmap bmp = null;
            try
            {
                System.IO.MemoryStream memoryStream = new System.IO.MemoryStream(Convert.FromBase64String(base64));
                memoryStream.Position = 0;

                bmp = (Bitmap)Bitmap.FromStream(memoryStream);

                memoryStream.Close();
            }
            catch (Exception)
            {
            }

            return bmp;
        }

        public string bitmapToBase64(Bitmap bmp)
        {
            string image = null;
            if (bmp != null)
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream();

                var encoder = ImageCodecInfo.GetImageEncoders().First(c => c.FormatID == ImageFormat.Jpeg.Guid);
                var encParams = new EncoderParameters() { Param = new[] { new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 10L) } };

                bmp.Save(ms, encoder, encParams);
                byte[] byteImage = ms.ToArray();
                image = Convert.ToBase64String(byteImage);
            }
            return image;
        }
    }
}
