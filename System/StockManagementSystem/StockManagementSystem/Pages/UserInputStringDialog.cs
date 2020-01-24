using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem.Pages
{
    public partial class UserInputStringDialog : Form
    {
        public string result = null;

        public UserInputStringDialog(string displayText)
        {
            InitializeComponent();
            lbl_text.Text = displayText;
        }

        private void Btn_okay_Click(object sender, EventArgs e)
        {
            result = txt_text.Text;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
