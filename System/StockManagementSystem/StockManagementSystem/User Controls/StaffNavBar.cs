using System;
using System.Drawing;
using System.Windows.Forms;
using StockManagementSystem.Pages;

namespace StockManagementSystem.Classes
{
    public partial class StaffNavBar : UserControl
    {
        BaseForm m_currentForm;
        bool m_bIsAdmin;

        public StaffNavBar(BaseForm currentForm, bool isAdmin)
        {
            m_currentForm = currentForm;
            m_bIsAdmin = isAdmin;

            SetBounds(0, currentForm.Height - 100, currentForm.Width, 100);

            InitializeComponent();            

            if (currentForm.GetType() == typeof(ProductsPage))
            {
                btn_products.BackColor = Color.Green;
            }
            else if (currentForm.GetType() == typeof(Messages))
            {
                btn_messages.BackColor = Color.Green;
            }
            else if (currentForm.GetType() == typeof(Inspection))
            {
                btn_inspection.BackColor = Color.Green;
            }
            else if (currentForm.GetType() == typeof(Shipment))
            {
                btn_shipment.BackColor = Color.Green;
            }
            else if (currentForm.GetType() == typeof(Invoices))
            {
                btn_invoices.BackColor = Color.Green;
            }
            else if (currentForm.GetType() == typeof(Basket))
            {
                btn_basket.BackColor = Color.Green;
            }
            else if (currentForm.GetType() == typeof(Settings) || currentForm.GetType() == typeof(AdminSettings))
            {
                btn_settings.BackColor = Color.Green;
            }

            if (currentForm.GetType() != typeof(Messages) && Messages.messages.Count > 0)
                lbl_numMessages.Text = Messages.messages.Count.ToString();
            else
                lbl_numMessages.Hide();
        }

        private void btn_messages_Click(object sender, EventArgs e)
        {
            m_currentForm.goToNextPage(SystemPage.Messages);
        }

        private void btn_products_Click(object sender, EventArgs e)
        {
            m_currentForm.goToNextPage(SystemPage.ProductsPage);
        }

        private void btn_inspection_Click(object sender, EventArgs e)
        {
            m_currentForm.goToNextPage(SystemPage.Inspection);
        }

        private void btn_invoices_Click(object sender, EventArgs e)
        {
            m_currentForm.goToNextPage(SystemPage.Invoices);
        }

        private void btn_expectedDelivery_Click(object sender, EventArgs e)
        {
            m_currentForm.goToNextPage(SystemPage.ExpectedDelivery);
        }

        private void btn_newShipment_Click(object sender, EventArgs e)
        {
            m_currentForm.goToNextPage(SystemPage.Shipment);
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            if (m_bIsAdmin)
                m_currentForm.goToNextPage(SystemPage.AdminSettings);
            else
                m_currentForm.goToNextPage(SystemPage.Settings);
        }

        private void btn_basket_Click(object sender, EventArgs e)
        {
            m_currentForm.goToNextPage(SystemPage.Basket);
        }
    }
}
