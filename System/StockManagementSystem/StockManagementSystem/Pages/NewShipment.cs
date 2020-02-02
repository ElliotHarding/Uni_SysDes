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
    public partial class NewShipment : BaseForm
    {
        public NewShipment()
        {
            InitializeComponent();
            addNavBar();
        }

        private void btn_updateShipment_Click(object sender, EventArgs e)
        {
            goToNextPage(SystemPage.ShipmentUpdateStock);
        }

        private void btn_newShipment_Click(object sender, EventArgs e)
        {
            goToNextPage(SystemPage.ShipmentDetails);
        }
    }
}
