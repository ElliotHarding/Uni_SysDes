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
    public partial class TextfieldRow : UserControl
    {
        AdminSettings m_adminSettings;

        public TextfieldRow(AdminSettings adminSettings, string value = "")
        {
            InitializeComponent();
            txt_text.Text = value;
            m_adminSettings = adminSettings;
        }

        private void Btn_remove_Click(object sender, EventArgs e)
        {
            m_adminSettings.remove(this);
        }

        public string getValue()
        {
            return txt_text.Text;
        }
    }
}
