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
    public partial class UserInputParagraphDialog : Form
    {
        public string paragraph = null;

        public UserInputParagraphDialog(string displayText, string previous = null)
        {
            InitializeComponent();
            lbl_text.Text = displayText;
            if(previous != null)
            {
                txt_userInput.Text = previous;
            }
        }

        private void Btn_okay_Click(object sender, EventArgs e)
        {
            paragraph = txt_userInput.Text;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
