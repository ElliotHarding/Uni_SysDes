﻿using System;
using System.Drawing;
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

            if (currentForm.GetType() == typeof(ProductsPage))
            {
                btn_products.BackColor = Color.Green;
            }   
            else if(currentForm.GetType() == typeof(Messages))
            {
                btn_messages.BackColor = Color.Green;
            }
            else if (currentForm.GetType() == typeof(Basket))
            {
                btn_basket.BackColor = Color.Green;
            }
            else if(currentForm.GetType() == typeof(Settings))
            {
                btn_settings.BackColor = Color.Green;
            }

            if (currentForm.GetType() != typeof(Messages) && Messages.messages.Count > 0)
                lbl_messageCount.Text = Messages.messages.Count.ToString();
            else
                lbl_messageCount.Hide();
        }

        private void btn_messages_Click(object sender, EventArgs e)
        {
            m_currentForm.goToNextPage(SystemPage.Messages);
        }

        private void btn_products_Click(object sender, EventArgs e)
        {
            m_currentForm.goToNextPage(SystemPage.ProductsPage);
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            m_currentForm.goToNextPage(SystemPage.Settings);
        }

        private void btn_basket_Click(object sender, EventArgs e)
        {
            m_currentForm.goToNextPage(SystemPage.Basket);
        }
    }
}
