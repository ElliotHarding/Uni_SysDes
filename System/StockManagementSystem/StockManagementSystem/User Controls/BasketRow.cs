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

            int quantity = 0;
            if (Int32.TryParse(product.quantity, out quantity))
                c_quantitiy.Value = quantity;
        }

        public Product GetProduct()
        {
            m_product.quantity = c_quantitiy.Value.ToString();
            return m_product;
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            m_basketPage.removeRow(this);
        }
    }
}
