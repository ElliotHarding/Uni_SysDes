using StockManagementSystem.Pages;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace StockManagementSystem.User_Controls
{
    public partial class NewProductRow : UserControl
    {
        ExpectedDelivery m_shipmentDetails = null;
        NewShipment m_newShipment = null;
        Bitmap m_bitmap = null;

        public NewProductRow(ExpectedDelivery shipmentDetails)
        {
            InitializeComponent();
            m_shipmentDetails = shipmentDetails;
        }

        public NewProductRow(NewShipment shipmentDetails)
        {
            InitializeComponent();
            m_newShipment = shipmentDetails;
        }

        public Product GetProduct()
        {
            return new Product("", tb_suppliersId.Text, m_bitmap, tb_description.Text, "", "", "0", "", tb_price.Text, tb_vat.Text, "", "", tb_name.Text);
        }

        private void btn_remove_Click(object sender, System.EventArgs e)
        {
            if(m_shipmentDetails != null)
             m_shipmentDetails.removeNewProductRow(this);
            else
                m_newShipment.removeNewProductRow(this);
        }

        private void btn_setImage_Click(object sender, System.EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        m_bitmap = new Bitmap(dlg.FileName);
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }
        }
    }
}
