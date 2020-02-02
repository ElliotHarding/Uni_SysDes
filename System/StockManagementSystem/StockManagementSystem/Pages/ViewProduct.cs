﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace StockManagementSystem.Pages
{
    public partial class ViewProduct : BaseForm
    {
        public static Product product = null;
        private bool m_bAwaitingClick = false;

        public ViewProduct()
        {
            InitializeComponent();

            addNavBar();

            lbl_productName.Text = product.name;
            lbl_productInfo.Text = product.information;
            lbl_currentStock.Text = "Current Stock : " + product.quantity;
            lbl_price.Text = "Price : " + product.price + "£";
            lbl_vat.Text = "VAT : " + product.vat + "£";
            lbl_supplierCode.Text = "todo"; //product.supplierCode....

            Bitmap bitmap = product.getBitmap();
            if (bitmap != null)
                pictureBox.Image = bitmap;
            else
                pictureBox.Image = StockManagementSystem.Properties.Resources.NoImage;

            refreshMapLocation();

            if (m_currentUser.role != "admin")
            {
                btn_checkIn.Hide();
                btn_editMapLocation.Hide();
                lbl_supplierCode.Hide();
                btn_saveChanges.Hide();
                btn_removeProduct.Hide();
            }
        }

        private void refreshMapLocation()
        {
            //todo get map image...
            Bitmap bitmap = StockManagementSystem.Properties.Resources.NoImage;
            int mapX = 0;
            int mapY = 0;           
            if (Int32.TryParse(product.locationX, out mapX) && Int32.TryParse(product.locationY, out mapY))
            {
                const int drawOffsetX = -11; //TODO: VALUES BASED OF HALF IMAGE SIZE THAT IS USED AS MARKER
                const int drawOffsety = -20;
                Graphics graphics = Graphics.FromImage(bitmap);
                graphics.DrawString("x", new Font(new FontFamily("Calibri"), 32, FontStyle.Regular, GraphicsUnit.Pixel),
                    new SolidBrush(Color.Black), mapX + drawOffsetX, mapY + drawOffsety);
            }

            pictureBoxMap.Image = bitmap;
        }

        private void btn_editMapLocation_Click(object sender, EventArgs e)
        {
            m_bAwaitingClick = true;
        }

        private void PictureBoxMap_Click(object sender, EventArgs e)
        {
            if(m_bAwaitingClick)
            {
                Point p = pictureBoxMap.PointToClient(Cursor.Position);
                product.locationX = p.X.ToString();
                product.locationY = p.Y.ToString();
                m_bAwaitingClick = false;
                refreshMapLocation();
            }
        }

        private void btn_checkIn_Click(object sender, EventArgs e)
        {
            int quantitiy = 0;
            if (Int32.TryParse(txt_actionQuantitiy.Text, out quantitiy))
            {
                Product p = new Product(product);
                p.quantity = txt_actionQuantitiy.Text;
                //todo add to checkin page....
            }
            else
            {
                notifyUser("Enter correct quantitiy");
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
                    if (quantitiy > 0 && quantitiy <= currentQuantitiy)
                    {
                        Product p = new Product(product);
                        p.quantity = txt_actionQuantitiy.Text;
                        //todo add to checkout page....
                    }
                    else
                    {
                        notifyUser("Invalid ammount");
                    }
                }
                else
                {
                    notifyUser("Database error #E1");
                }           
            }
            else
            {
                notifyUser("Enter correct quantitiy");
            }
        }

        private void btn_saveChanges_Click(object sender, EventArgs e)
        {
            DatabaseComms.updateProduct(product, onUpdateProductRequest);
        }

        private void onUpdateProductRequest(bool success)
        {
            if(success)
                notifyUser("Updated product");
            else
                notifyUser("Failed to upload product changes");
        }

        private void btn_removeProduct_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to remove the product and all it's information?", "Remove product?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DatabaseComms.query("DELETE FROM PRODUCTS WHERE id = '" + product.id + "';", removeProductCallback);
            }            
        }

        private void removeProductCallback(bool success)
        {
            if(success)
            {
                notifyUser("Product removed");
                this.Invoke((Action)delegate { goToNextPage(SystemPage.ProductsPage); });
            }
            else
            {
                notifyUser("Failed to remove product. Check network.");
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            if(m_currentUser.role == "admin" || m_currentUser.role == "staff")
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
        }

        private void lbl_productName_Click(object sender, EventArgs e)
        {
            if (m_currentUser.role == "admin" || m_currentUser.role == "staff")
            {
                UserInputStringDialog userInputStringDialog = new UserInputStringDialog("Enter new name: ");
                DialogResult dialogResult = userInputStringDialog.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    product.name = userInputStringDialog.result;
                    lbl_productName.Text = userInputStringDialog.result;
                }
            }
        }

        private void lbl_currentStock_Click(object sender, EventArgs e)
        {
            if (m_currentUser.role == "admin" || m_currentUser.role == "staff")
            {
                UserInputStringDialog userInputStringDialog = new UserInputStringDialog("Enter new stock amount: ");
                DialogResult dialogResult = userInputStringDialog.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    string stockAmount = userInputStringDialog.result;
                    int iStockAmount;
                    if (Int32.TryParse(stockAmount, out iStockAmount))
                    {
                        if (iStockAmount > 0)
                        {
                            product.quantity = stockAmount;
                            lbl_currentStock.Text = "Current Stock : " + stockAmount;
                        }
                        else
                        {
                            notifyUser("Can't have a negative number");
                        }
                    }
                    else
                    {
                        notifyUser("Invalid input");
                    }
                }
            }
        }

        private void lbl_price_Click(object sender, EventArgs e)
        {
            if (m_currentUser.role == "admin" || m_currentUser.role == "staff")
            {
                UserInputStringDialog userInputStringDialog = new UserInputStringDialog("Enter new VAT: ");
                DialogResult dialogResult = userInputStringDialog.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    int price;
                    if (Int32.TryParse(userInputStringDialog.result, out price))
                    {
                        product.price = userInputStringDialog.result;
                        lbl_price.Text = "Price : " + userInputStringDialog.result + "£";
                    }
                    else
                    {
                        notifyUser("Invalid input");
                    }
                }
            }
        }

        private void lbl_vat_Click(object sender, EventArgs e)
        {
            if (m_currentUser.role == "admin" || m_currentUser.role == "staff")
            {
                UserInputStringDialog userInputStringDialog = new UserInputStringDialog("Enter new VAT: ");
                DialogResult dialogResult = userInputStringDialog.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    int vat;
                    if (Int32.TryParse(userInputStringDialog.result, out vat))
                    {
                        product.vat = userInputStringDialog.result;
                        lbl_vat.Text = "VAT : " + userInputStringDialog.result + "£";
                    }
                    else
                    {
                        notifyUser("Invalid input");
                    }                       
                }
            }
        }

        private void lbl_supplierCode_Click(object sender, EventArgs e)
        {
            if (m_currentUser.role == "admin" || m_currentUser.role == "staff")
            {
                UserInputStringDialog userInputStringDialog = new UserInputStringDialog("Enter new supplier code: ");
                DialogResult dialogResult = userInputStringDialog.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    //Todo verify && add supplierCode
                    string supplierCode = userInputStringDialog.result;
                    //product.
                }
            }
        }

        private void lbl_productInfo_Click(object sender, EventArgs e)
        {
            if (m_currentUser.role == "admin" || m_currentUser.role == "staff")
            {
                UserInputParagraphDialog userInputParagraphDialog = new UserInputParagraphDialog("Enter product info: ", product.information);
                DialogResult dialogResult = userInputParagraphDialog.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    product.information = userInputParagraphDialog.paragraph;
                    lbl_productInfo.Text = userInputParagraphDialog.paragraph;
                }
            }
        }
    }
}
