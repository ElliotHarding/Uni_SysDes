using StockManagementSystem.Pages;
using System.Windows.Forms;

namespace StockManagementSystem.User_Controls
{
    public partial class NewProductRow : BaseForm
    {
        ExpectedDelivery m_shipmentDetails;

        public NewProductRow(ExpectedDelivery shipmentDetails)
        {
            InitializeComponent();
            m_shipmentDetails = shipmentDetails;
        }

        public Product GetProduct()
        {
            return new Product("", tb_suppliersId.Text, "", tb_description.Text, "", "", "0", "", tb_price.Text, tb_vat.Text, "", "", tb_name.Text);
        }

        private void btn_remove_Click(object sender, System.EventArgs e)
        {
            m_shipmentDetails.removeNewProductRow(this);
        }
    }
}
