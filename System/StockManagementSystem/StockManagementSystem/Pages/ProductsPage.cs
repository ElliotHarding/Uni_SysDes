using StockManagementSystem.Classes;
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
    public partial class ProductsPage : Form
    {
        public ProductsPage()
        {
            InitializeComponent();
            NavBar navigationBar = new NavBar(this);
            Controls.Add(navigationBar);
        }
    }
}
