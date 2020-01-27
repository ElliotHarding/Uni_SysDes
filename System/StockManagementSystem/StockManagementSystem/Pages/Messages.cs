using StockManagementSystem.User_Controls;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace StockManagementSystem.Pages
{
    public partial class Messages : BaseForm
    {
        public static List<string> messages;

        public Messages()
        {
            InitializeComponent();
            addNavBar();

            int yPos = 0;
            const int yInc = 55;
            foreach(string s in messages)
            {
                MessageControl messageControl = new MessageControl(s);
                messageControl.Location = new Point(0, yPos);
                messagesPanel.Controls.Add(messageControl);
                yPos += yInc;
            }
        }

        public static void checkMessages()
        {
            messages.Clear();
            string currentDate = DateTime.Now.AddDays(30).ToString("dd-MM-yyyy");

            DatabaseComms.getProducts(ExpiringProducts, "CAST(expiryDate as datetime) < " + currentDate);
        }

        private static void ExpiringProducts(List<Product> products)
        {
            foreach(Product p in products)
            {
                messages.Add(p.name + " is about to expire : " + p.expiryDate);
            }
        }
    }
}
