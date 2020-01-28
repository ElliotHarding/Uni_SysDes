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

    public partial class CheckInItem : UserControl
    {
        
        public CheckInItem(Product product, CheckIn checkIn)
        {
            InitializeComponent();

            Bitmap bitmap = product.getBitmap();
            if (bitmap != null)
            {
                cInPicture.Image = bitmap;
            }
            else
            {
                cInPicture.Image = StockManagementSystem.Properties.Resources.NoImage;
            }

            lbl_cInName.Text = product.name;
            int place = 0;
            if (Int32.TryParse(product.quantity, out place))
            {
                cInQnt.Value = place;
            }


        }


    }
}
