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
            else if (currentForm.GetType() == typeof(ExpectedDelivery))
            {
                btn_expectedDelivery.BackColor = Color.Green;
            }
            else if (currentForm.GetType() == typeof(NewShipment))
            {
                btn_newShipment.BackColor = Color.Green;
            }
            else if (currentForm.GetType() == typeof(CheckIn))
            {
                btn_checkIn.BackColor = Color.Green;
            }
            else if (currentForm.GetType() == typeof(Invoices))
            {
                btn_invoices.BackColor = Color.Green;
            }
            else if (currentForm.GetType() == typeof(CheckOut))
            {
                btn_checkout.BackColor = Color.Green;
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
            m_currentForm.goToNextPage(SystemPage.NewShipment);
        }

        private void btn_checkIn_Click(object sender, EventArgs e)
        {
            m_currentForm.goToNextPage(SystemPage.CheckIn);
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            m_currentForm.goToNextPage(SystemPage.CheckOut);
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            if (m_bIsAdmin)
                m_currentForm.goToNextPage(SystemPage.AdminSettings);
            else
                m_currentForm.goToNextPage(SystemPage.Settings);
        }
    }
}
