using System;
using System.Windows.Forms;
using StockManagementSystem.Pages;

namespace StockManagementSystem.User_Controls
{
    public partial class BasketRow : UserControl
    {
        Basket m_basketPage = null;
        Product m_product = null;

        public BasketRow(Product product, Basket basketPage)
        {
            InitializeComponent();
            m_basketPage = basketPage;
            m_product = product;

            pb_image.Image = product.getBitmap();

            c_quantitiy.Value = product.requestedQuantitiy;
        }

        public string getProductId()
        {
            return m_product.id;
        }

        public void addQuantity(int amount)
        {
            c_quantitiy.Value = c_quantitiy.Value + amount;
        }

        public Product GetProduct()
        {
            m_product.requestedQuantitiy = Decimal.ToInt32(c_quantitiy.Value);
            return m_product;
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            m_basketPage.removeRow(this);
        }
    }
}
