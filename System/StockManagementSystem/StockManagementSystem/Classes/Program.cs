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
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
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
                    case SystemPage.EndPage:                        
                        break;
                    default:
                        nextPage = SystemPage.EndPage;
                        break;
                }

                if(currentPage != null)
                {
                    Application.Run(currentPage);
                    nextPage = currentPage.nextPage;
                }                
            }
        }
    }
}
