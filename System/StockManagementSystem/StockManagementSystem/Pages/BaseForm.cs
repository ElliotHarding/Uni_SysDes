using StockManagementSystem.Classes;
using System.Windows.Forms;

namespace StockManagementSystem.Pages
{
    public enum SystemPage
    {
        Messages,
        Login,
        Basket,
        ProductsPage,
        ViewProduct,
        ViewShipment,
        Shipment,
        SignUp,
        Invoices,
        ExpectedDelivery,
        NewShipment,
        AdminSettings,
        Settings,
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
            if(m_currentUser != null)
            {
                if(m_currentUser.role == "admin" || m_currentUser.role == "staff")
                {
                    StaffNavBar navigationBar = new StaffNavBar(this, m_currentUser.role == "admin");
                    Controls.Add(navigationBar);
                }
                else
                {
                    NavBar navigationBar = new NavBar(this);
                    Controls.Add(navigationBar);
                };
            }
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

        protected void notifyUser(string error, string title = "Warning")
        {
            MessageBox.Show(error, title);
        }
    }
}
