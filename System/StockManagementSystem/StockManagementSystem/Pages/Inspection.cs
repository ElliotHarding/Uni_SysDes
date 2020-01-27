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
    public partial class Inspection : BaseForm
    {
        public static List<Product> products;
        
        public Inspection()
        {
            InitializeComponent();
            addNavBar();
            Inspection_Load();
        }
        int spacing = 0;

        private void Inspection_Load()
        {
            int productsSize = 20;  // Temp variable for testing purposes. Will eventually get size of products List.
            for(int i = 0; i<productsSize; i++)
            {
                spacing += 30;
                InspectionRow inspectionRow = new InspectionRow();
                inspectionRow.Parent = pnl_inspection;
                inspectionRow.Location = new Point(inspectionRow_1.Location.X, inspectionRow_1.Location.Y + spacing);
            }

        }
    }
}
