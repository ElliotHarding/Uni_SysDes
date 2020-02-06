using System;

namespace StockManagementSystem.Pages
{
    public partial class NewShipment : BaseForm
    {
        public NewShipment()
        {
            InitializeComponent();
            addNavBar();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string itemCode = tb_itemCode.Text;
            string itemSupplierCode = tb_supplierItemCode.Text;
            string quantitiy = tb_quantitiy.Text;

            int iQuantitiy;
            if (Int32.TryParse(quantitiy, out iQuantitiy))
            {
                if(itemCode != null && itemCode != "")
                {
                    DatabaseComms.updateProductQuantity(updateProductQuantityCallback, quantitiy,  "id = '" + itemCode + "'");
                }
                else if(itemSupplierCode != null && itemSupplierCode != "")
                {
                    DatabaseComms.updateProductQuantity(updateProductQuantityCallback, quantitiy, "externalId = '" + itemSupplierCode + "'");
                }
                else
                {
                    notifyUser("Add either item code or supplier item code.");
                }
            }
            else
            {
                notifyUser("Invalid quantitiy input.");
            }
        }

        private void updateProductQuantityCallback(bool success)
        {
            if(success)
            {
                notifyUser("Success in adding items", "Success");
            }
            else
            {
                notifyUser("Failed to add items, check codes, or internet.");
            }
        }
    }
}
