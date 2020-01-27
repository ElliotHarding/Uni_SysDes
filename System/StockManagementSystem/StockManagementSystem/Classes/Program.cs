using StockManagementSystem.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

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
                    case SystemPage.CheckOut:
                        currentPage = new CheckOut();
                        break;
                    case SystemPage.ProductsPage:
                        currentPage = new ProductsPage();
                        break;
                    case SystemPage.SignUp:
                        currentPage = new SignUp();
                        break;
                    case SystemPage.CheckIn:
                        currentPage = new CheckIn();
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
                    case SystemPage.Inspection:
                        currentPage = new Inspection();
                        break;
                    case SystemPage.ViewProduct:
                        currentPage = new ViewProduct();
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
                    Application.Run(new Invoices());
                    nextPage = currentPage.getNextPage();
                }                
            }
        }
    }
}
