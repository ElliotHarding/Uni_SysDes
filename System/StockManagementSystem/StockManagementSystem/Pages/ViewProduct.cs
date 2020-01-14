using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace StockManagementSystem.Pages
{
    public partial class ViewProduct : BaseForm
    {
        public static Product product = null;

        public ViewProduct()
        {
            InitializeComponent();

            addNavBar();

            lbl_uploadError.Visible = false;
            lbl_CheckInOutError.Visible = false;
            lbl_productName.Text = product.name;
            lbl_productInfo.Text = product.information;
            lbl_currentStock.Text = "Current Stock : " + product.quantity;

            Bitmap bitmap = product.getBitmap();
            if (bitmap != null)
            {
                pictureBox.Image = bitmap;

                int mapX = 0;
                int mapY = 0;
                if (Int32.TryParse(product.locationX, out mapX) && Int32.TryParse(product.locationY, out mapY))
                {
                    Graphics graphics = Graphics.FromImage(bitmap);
                    graphics.DrawString("X", new Font(new FontFamily("Times New Roman"), 32, FontStyle.Regular, GraphicsUnit.Pixel),
                        new SolidBrush(Color.Black), mapX, mapY);

                    pictureBox.Image = bitmap;
                }
            }
            else
            {
                pictureBox.Image = StockManagementSystem.Properties.Resources.NoImage;                
            }            

            if (m_currentUser.role != "admin")
            {
                btn_editPicture.Hide();
                btn_editInfo.Hide();
                bttn_changeStockAmount.Hide();
                btn_updateSupplierCode.Hide();
                btn_checkIn.Hide();
                btn_editMapLocation.Hide();
            }
        }

        private void btn_editPicture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Bitmap bmp = new Bitmap(dlg.FileName);
                        pictureBox.Image = bmp;
                        product.setBitmap(bmp);
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }                   
                }
            }
        }

        private void btn_editInfo_Click(object sender, EventArgs e)
        {

        }

        private void bttn_changeStockAmount_Click(object sender, EventArgs e)
        {

        }

        private void btn_updateSupplierCode_Click(object sender, EventArgs e)
        {

        }

        private void btn_editMapLocation_Click(object sender, EventArgs e)
        {

        }

        private void btn_checkIn_Click(object sender, EventArgs e)
        {
            int quantitiy = 0;
            if (Int32.TryParse(txt_actionQuantitiy.Text, out quantitiy))
            {
                int currentQuantitiy = 0;
                if (Int32.TryParse(product.quantity, out currentQuantitiy))
                {
                    product.quantity = (currentQuantitiy + quantitiy).ToString();
                }
                else
                {
                    //todo
                }
            }
            else
            {
                lbl_CheckInOutError.Visible = true;
            }
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            int quantitiy = 0;
            if (Int32.TryParse(txt_actionQuantitiy.Text, out quantitiy))
            {
                int currentQuantitiy = 0;
                if (Int32.TryParse(product.quantity, out currentQuantitiy))
                {
                    product.quantity = (currentQuantitiy - quantitiy).ToString();
                }
                else
                {
                    //todo
                }
            }
            else
            {
                lbl_CheckInOutError.Visible = true;
            }
        }

        private void btn_saveChanges_Click(object sender, EventArgs e)
        {
            lbl_uploadError.Visible = false;
            DatabaseComms.updateProduct(product, onUpdateProductRequest);
        }

        private void onUpdateProductRequest(bool success)
        {
            if(!success)
            {
                lbl_uploadError.Invoke((Action)delegate { lbl_uploadError.Visible = true; });
            }
        }
    }
}
