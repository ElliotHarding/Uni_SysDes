using System;
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
    }
}
