using StockManagementSystem.Pages;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace StockManagementSystem
{
    static class Program //Elliot
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DatabaseComms.getItemsMap(getMapCallback);

            BaseForm currentPage = null;
            SystemPage nextPage = SystemPage.Login;
            while(nextPage != SystemPage.EndPage)
            {
                switch (nextPage)
                {
                    case SystemPage.Messages:
                        currentPage = new Messages();
                        break;
                    case SystemPage.Login:
                        currentPage = new Login();
                        break;
                    case SystemPage.Basket:
                        currentPage = new Basket();
                        break;
                    case SystemPage.ProductsPage:
                        currentPage = new ProductsPage();
                        break;
                    case SystemPage.SignUp:
                        currentPage = new SignUp();
                        break;
                    case SystemPage.ExpectedDelivery:
                        currentPage = new ExpectedDelivery();
                        break;
                    case SystemPage.Invoices:
                        currentPage = new Invoices();
                        break;
                    case SystemPage.NewShipment:
                        currentPage = new NewShipment();
                        break;
                    case SystemPage.ViewProduct:
                        currentPage = new ViewProduct();
                        break;
                    case SystemPage.AdminSettings:
                        currentPage = new AdminSettings();
                        break;
                    case SystemPage.Settings:
                        currentPage = new Settings();
                        break;
                    case SystemPage.Shipment:
                        currentPage = new Shipments();
                        break;
                    case SystemPage.ViewShipment:
                        currentPage = new ViewShipment();
                        break;

                    //End cases:
                    case SystemPage.EndPage:                        
                        break;
                    default:
                        nextPage = SystemPage.EndPage;
                        break;
                }

                if(currentPage != null)
                {
                    Application.Run(currentPage);
                    nextPage = currentPage.getNextPage();
                }                
            }
        }

        private static void getMapCallback(Bitmap map)
        {
            AdminSettings.FloorMap = map;
        }
    }
}
