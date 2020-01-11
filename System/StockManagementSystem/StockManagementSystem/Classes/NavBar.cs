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

namespace StockManagementSystem.Classes
{
    public partial class NavBar : UserControl
    {
        BaseForm m_currentForm;

        public NavBar(BaseForm currentForm)
        {
            m_currentForm = currentForm;
            SetBounds(0, currentForm.Height - 100, currentForm.Width, 100);
            InitializeComponent();
        }

        private void btn_messages_Click(object sender, EventArgs e)
        {
            m_currentForm.nextPage = SystemPage.Messages;
            m_currentForm.Close();
        }

        private void btn_products_Click(object sender, EventArgs e)
        {
            m_currentForm.nextPage = SystemPage.ProductsPage;
            m_currentForm.Close();
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            m_currentForm.nextPage = SystemPage.CheckOut;
            m_currentForm.Close();
        }
    }
}
