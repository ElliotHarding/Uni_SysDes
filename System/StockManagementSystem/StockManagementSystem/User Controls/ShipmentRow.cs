using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystem.Pages;

namespace StockManagementSystem.User_Controls
{
    public partial class ShipmentRow : UserControl
    {
        Shipments m_shipmentsPage;
        Shipment m_shipment;

        public ShipmentRow(Shipments shipmentsPage, Shipment shipment)
        {
            InitializeComponent();
            m_shipmentsPage = shipmentsPage;
            m_shipment = shipment;

            lbl_supplierSiteName.Text = shipment.supplierSiteName;
            lbl_orderNo.Text = shipment.orderNo;
            lbl_requestedDate.Text = shipment.requestedDate;
            lbl_supplierName.Text = shipment.supplierName;
        }

        private void Btn_view_Click(object sender, EventArgs e)
        {
            m_shipmentsPage.viewShipment(m_shipment);
        }
    }
}
