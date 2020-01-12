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
        SignUp,
        Inspection,
        Invoices,
        ExpectedDelivery,
        NewShipment,
        EndPage
    }

    public enum NavBarType
    {
        User,
        Staff,
        None
    }

    public class BaseForm : Form
    {
        public SystemPage nextPage = SystemPage.EndPage;
        static User m_currentUser = null;

        public BaseForm()
        {          
        }

        protected void addNavBar(NavBarType navBarType)
        {
            switch (navBarType)
            {
                case NavBarType.Staff:
                    break;
                case NavBarType.User:
                    NavBar navigationBar = new NavBar(this);
                    Controls.Add(navigationBar);
                    break;
            }
        }

        protected void goToNextPage(SystemPage page)
        {
            nextPage = page;
            this.Close();
        }
    }
}
