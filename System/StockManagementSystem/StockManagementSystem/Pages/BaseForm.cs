using StockManagementSystem.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem.Pages
{
    public enum SystemPage
    {
        Messages,
        Login,
        CheckOut,
        CheckIn,
        ProductsPage,
        ViewProduct,
        SignUp,
        Inspection,
        Invoices,
        ExpectedDelivery,
        NewShipment,
        EndPage
    }

    public class BaseForm : Form
    {
        protected SystemPage m_nextPage { get; private set; } = SystemPage.Login;
        protected static User m_currentUser = null;

        public BaseForm()
        {
        }

        protected void addNavBar()
        {
            StaffNavBar navigationBar = new StaffNavBar(this);
            Controls.Add(navigationBar);
            /*
            if(m_currentUser != null)
            {
                if(m_currentUser.role == "admin" || m_currentUser.role == "staff")
                {
                    StaffNavBar navigationBar = new StaffNavBar(this);
                    Controls.Add(navigationBar);
                }
                else
                {
                    NavBar navigationBar = new NavBar(this);
                    Controls.Add(navigationBar);
                };
            }*/
        }

        public void goToNextPage(SystemPage page)
        {
            m_nextPage = page;
            this.Close();
        }

        public void logOut()
        {
            m_currentUser = null;
            goToNextPage(SystemPage.Login);
        }

        public SystemPage getNextPage()
        {
            return m_nextPage;
        }
    }
}
