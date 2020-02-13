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
    public partial class LogOut : UserControl
    {
        BaseForm m_currentForm;
        public LogOut(BaseForm currentForm)
        {
            m_currentForm = currentForm;
            InitializeComponent();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            m_currentForm.logOut();
        }
    }
}
