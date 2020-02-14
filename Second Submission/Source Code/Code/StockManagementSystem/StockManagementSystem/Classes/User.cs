using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem
{
    public class User
    {
        public User(string nNumber_, string password_, string department_, string role_)
        {
            nNumber = nNumber_;
            password = password_;
            department = department_;
            role = role_;
        }

        public string nNumber { get; set; }
        public string password { get; set; }
        public string department { get; set; }
        public string role { get; set; }
    }
}
