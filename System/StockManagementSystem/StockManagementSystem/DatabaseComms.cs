using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem
{
    class DatabaseComms
    {
        static HttpClient m_client = new HttpClient();
        private const string m_postUrl = "http://stockmanagersystem.gearhostpreview.com/dbPost.php?request=";
        //private static const string m_getUrl = "http://stockmanagersystem.gearhostpreview.com/dbRequest.php?request=";

        public static async void uploadData(String query, Action<bool> callback)
        {
            WebRequest request = WebRequest.Create(m_postUrl+query);
            request.Method = "GET";

            WebResponse webResponse = request.GetResponse();
            Stream dataStream = webResponse.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string response = reader.ReadToEnd();
            reader.Close();
            dataStream.Close();
            webResponse.Close();

            callback(response == "null");
        }
    }
}
