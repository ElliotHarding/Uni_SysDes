using StockManagementSystem.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem.Pages
{
    public partial class CheckIn : BaseForm
    {
        public static List<Product> products = new List<Product>();

        public CheckIn()
        {
            InitializeComponent();
            addNavBar();
        }

        private void populate()
        {
            if (products != null && products.Count() > 0)
            {
                foreach (Product product in products)
                {

                    CheckInItem checkIn = new CheckInItem(product, this);
                    if (cInBox.Controls.Count < 0)
                    {
                        cInBox.Controls.Clear();
                    }
                    else
                    {
                        cInBox.Controls.Add(checkIn);

                    }
                }
            }
        }

    }
}
