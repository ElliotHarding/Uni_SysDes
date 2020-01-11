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
        ProductsPage,
        SignUp,
        EndPage
    }

    public enum NavBarType
    {
        User,
        Admin,
        None
    }

    public class BaseForm : Form
    {
        public SystemPage nextPage = SystemPage.EndPage;

        public BaseForm()
        {          
        }

        protected void addNavBar(NavBarType navBarType)
        {
            switch (navBarType)
            {
                case NavBarType.Admin:
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
