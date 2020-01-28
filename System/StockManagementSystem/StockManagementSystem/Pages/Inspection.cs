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
    public partial class Inspection : BaseForm
    {
        public static List<Product> products = new List<Product>();
        public Inspection()
        {
            InitializeComponent();
            addNavBar();
            populatePanel();
        }
                
        private void populatePanel()
        {
            //int spacing = 0;
            //foreach(Product product in products)
            //{
            //    TransationRow productRow = new TransationRow();
            //    productRow.Parent = pnl_inspection;
            //    productRow.Location = new Point(0, spacing += 30);
            //}
        }

        private void Btn_sendToStores_Click(object sender, EventArgs e)
        {

        }
    }
}
