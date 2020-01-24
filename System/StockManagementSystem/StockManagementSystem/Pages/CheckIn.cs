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
    public partial class CheckIn : BaseForm
    {
        //log number with product taken out, that product has expierydate which can be applied to product if it were to be returned,
        //Quality which method to take in terms of inspecting prodouct or not when returning

        public CheckIn()
        {
            InitializeComponent();
            addNavBar();
        }
    }
}
