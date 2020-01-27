using StockManagementSystem.User_Controls;
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
    public partial class Invoices : BaseForm
    {
        public Invoices()
        {
            InitializeComponent();
            addNavBar();
        }

        int spacing = 0;

        //Temporary button until definite number of rows is determined
        private void Btn_add_row_Click(object sender, EventArgs e)
        {
            spacing += 30;
            InspectionRow inspectionRow = new InspectionRow();
            inspectionRow.Parent = pnl_invoice;
            inspectionRow.Location = new Point(inspectionRow_1.Location.X, inspectionRow_1.Location.Y + spacing);
        }
    }
}
