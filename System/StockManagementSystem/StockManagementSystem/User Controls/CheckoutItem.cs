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

    public partial class CheckoutItem : UserControl
    {


        public Product mProduct;
        public CheckOut mCheck;
        public CheckoutItem(Product product, CheckOut check)
        {
            mCheck = check;
            mProduct = product;
            InitializeComponent();

            Bitmap bitmap = product.getBitmap();
            if (bitmap != null)
            {
                pictureBox1.Image = bitmap;
            }
            else
            {
                pictureBox1.Image = StockManagementSystem.Properties.Resources.NoImage;
            }

            lbl_prodName.Text = product.name;
            int place = 0;
            if (Int32.TryParse(product.quantity, out place))
            {
                prodQnt.Value = place;
            }


        }


        private void LblRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           mCheck.removeItem(mProduct);
        }
    }
}
