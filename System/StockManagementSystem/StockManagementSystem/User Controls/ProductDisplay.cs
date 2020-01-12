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
    public partial class ProductDisplay : UserControl
    {
        BaseForm m_currentForm;
        Product m_product;

        public ProductDisplay(BaseForm currentForm, Product product)
        {
            InitializeComponent();
            pictureBox.Image = product.getBitmap();
            lbl_productName.Text = product.name;

            m_currentForm = currentForm;
            m_product = product;

            foreach (Control control in Controls)
            {
                control.Click += new EventHandler(ControlMouseDown);
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            onClick();
        }

        void ControlMouseDown(object sender, EventArgs e)
        {
            onClick();
        }

        private void onClick()
        {
            ViewProduct.product = m_product;
            m_currentForm.goToNextPage(SystemPage.ViewProduct);
        }
    }
}
