namespace StockManagementSystem.Pages
{
    partial class ViewProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_editMapLocation = new System.Windows.Forms.Button();
            this.txt_actionQuantitiy = new System.Windows.Forms.TextBox();
            this.btn_checkInOut = new System.Windows.Forms.Button();
            this.lbl_quantitiy = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_productInfo = new System.Windows.Forms.Label();
            this.lbl_currentStock = new System.Windows.Forms.Label();
            this.lbl_supplierCode = new System.Windows.Forms.Label();
            this.lbl_productName = new System.Windows.Forms.Label();
            this.btn_saveChanges = new System.Windows.Forms.Button();
            this.btn_removeProduct = new System.Windows.Forms.Button();
            this.lbl_vat = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.pictureBoxMap = new System.Windows.Forms.PictureBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_editMapLocation
            // 
            this.btn_editMapLocation.Location = new System.Drawing.Point(644, 247);
            this.btn_editMapLocation.Name = "btn_editMapLocation";
            this.btn_editMapLocation.Size = new System.Drawing.Size(111, 23);
            this.btn_editMapLocation.TabIndex = 13;
            this.btn_editMapLocation.Text = "Edit Map Location";
            this.btn_editMapLocation.UseVisualStyleBackColor = true;
            this.btn_editMapLocation.Click += new System.EventHandler(this.btn_editMapLocation_Click);
            // 
            // txt_actionQuantitiy
            // 
            this.txt_actionQuantitiy.Location = new System.Drawing.Point(321, 248);
            this.txt_actionQuantitiy.Name = "txt_actionQuantitiy";
            this.txt_actionQuantitiy.Size = new System.Drawing.Size(41, 20);
            this.txt_actionQuantitiy.TabIndex = 9;
            // 
            // btn_checkInOut
            // 
            this.btn_checkInOut.Location = new System.Drawing.Point(368, 247);
            this.btn_checkInOut.Name = "btn_checkInOut";
            this.btn_checkInOut.Size = new System.Drawing.Size(93, 23);
            this.btn_checkInOut.TabIndex = 7;
            this.btn_checkInOut.Text = "Check In/Out";
            this.btn_checkInOut.UseVisualStyleBackColor = true;
            this.btn_checkInOut.Click += new System.EventHandler(this.btn_checkIn_Click);
            // 
            // lbl_quantitiy
            // 
            this.lbl_quantitiy.AutoSize = true;
            this.lbl_quantitiy.Location = new System.Drawing.Point(261, 251);
            this.lbl_quantitiy.Name = "lbl_quantitiy";
            this.lbl_quantitiy.Size = new System.Drawing.Size(54, 13);
            this.lbl_quantitiy.TabIndex = 6;
            this.lbl_quantitiy.Text = "Quantitiy :";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_productInfo);
            this.panel1.Location = new System.Drawing.Point(522, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 87);
            this.panel1.TabIndex = 5;
            // 
            // lbl_productInfo
            // 
            this.lbl_productInfo.AutoSize = true;
            this.lbl_productInfo.Location = new System.Drawing.Point(3, 9);
            this.lbl_productInfo.Name = "lbl_productInfo";
            this.lbl_productInfo.Size = new System.Drawing.Size(35, 13);
            this.lbl_productInfo.TabIndex = 3;
            this.lbl_productInfo.Text = "label2";
            this.lbl_productInfo.Click += new System.EventHandler(this.lbl_productInfo_Click);
            // 
            // lbl_currentStock
            // 
            this.lbl_currentStock.AutoSize = true;
            this.lbl_currentStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_currentStock.Location = new System.Drawing.Point(369, 94);
            this.lbl_currentStock.Name = "lbl_currentStock";
            this.lbl_currentStock.Size = new System.Drawing.Size(93, 16);
            this.lbl_currentStock.TabIndex = 4;
            this.lbl_currentStock.Text = "Current Stock :";
            this.lbl_currentStock.Click += new System.EventHandler(this.lbl_currentStock_Click);
            // 
            // lbl_supplierCode
            // 
            this.lbl_supplierCode.AutoSize = true;
            this.lbl_supplierCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_supplierCode.Location = new System.Drawing.Point(368, 161);
            this.lbl_supplierCode.Name = "lbl_supplierCode";
            this.lbl_supplierCode.Size = new System.Drawing.Size(100, 16);
            this.lbl_supplierCode.TabIndex = 17;
            this.lbl_supplierCode.Text = "Supplier Code :";
            this.lbl_supplierCode.Click += new System.EventHandler(this.lbl_supplierCode_Click);
            // 
            // lbl_productName
            // 
            this.lbl_productName.AutoSize = true;
            this.lbl_productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productName.Location = new System.Drawing.Point(369, 62);
            this.lbl_productName.Name = "lbl_productName";
            this.lbl_productName.Size = new System.Drawing.Size(57, 20);
            this.lbl_productName.TabIndex = 2;
            this.lbl_productName.Text = "label1";
            this.lbl_productName.Click += new System.EventHandler(this.lbl_productName_Click);
            // 
            // btn_saveChanges
            // 
            this.btn_saveChanges.Location = new System.Drawing.Point(660, 582);
            this.btn_saveChanges.Name = "btn_saveChanges";
            this.btn_saveChanges.Size = new System.Drawing.Size(89, 23);
            this.btn_saveChanges.TabIndex = 14;
            this.btn_saveChanges.Text = "Save Changes";
            this.btn_saveChanges.UseVisualStyleBackColor = true;
            this.btn_saveChanges.Click += new System.EventHandler(this.btn_saveChanges_Click);
            // 
            // btn_removeProduct
            // 
            this.btn_removeProduct.Location = new System.Drawing.Point(548, 582);
            this.btn_removeProduct.Name = "btn_removeProduct";
            this.btn_removeProduct.Size = new System.Drawing.Size(106, 23);
            this.btn_removeProduct.TabIndex = 19;
            this.btn_removeProduct.Text = "Remove Product";
            this.btn_removeProduct.UseVisualStyleBackColor = true;
            this.btn_removeProduct.Click += new System.EventHandler(this.btn_removeProduct_Click);
            // 
            // lbl_vat
            // 
            this.lbl_vat.AutoSize = true;
            this.lbl_vat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vat.Location = new System.Drawing.Point(369, 140);
            this.lbl_vat.Name = "lbl_vat";
            this.lbl_vat.Size = new System.Drawing.Size(41, 16);
            this.lbl_vat.TabIndex = 18;
            this.lbl_vat.Text = "VAT :";
            this.lbl_vat.Click += new System.EventHandler(this.lbl_vat_Click);
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(369, 116);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(45, 16);
            this.lbl_price.TabIndex = 20;
            this.lbl_price.Text = "Pirce :";
            this.lbl_price.Click += new System.EventHandler(this.lbl_price_Click);
            // 
            // pictureBoxMap
            // 
            this.pictureBoxMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMap.Location = new System.Drawing.Point(255, 276);
            this.pictureBoxMap.Name = "pictureBoxMap";
            this.pictureBoxMap.Size = new System.Drawing.Size(500, 300);
            this.pictureBoxMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMap.TabIndex = 12;
            this.pictureBoxMap.TabStop = false;
            this.pictureBoxMap.Click += new System.EventHandler(this.PictureBoxMap_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox.Image = global::StockManagementSystem.Properties.Resources.NoImage;
            this.pictureBox.Location = new System.Drawing.Point(219, 61);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(143, 116);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // ViewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_currentStock);
            this.Controls.Add(this.lbl_vat);
            this.Controls.Add(this.lbl_supplierCode);
            this.Controls.Add(this.btn_removeProduct);
            this.Controls.Add(this.btn_saveChanges);
            this.Controls.Add(this.btn_editMapLocation);
            this.Controls.Add(this.pictureBoxMap);
            this.Controls.Add(this.txt_actionQuantitiy);
            this.Controls.Add(this.btn_checkInOut);
            this.Controls.Add(this.lbl_quantitiy);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_productName);
            this.Controls.Add(this.pictureBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 720);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 720);
            this.Name = "ViewProduct";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Product";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lbl_productName;
        private System.Windows.Forms.Label lbl_productInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_quantitiy;
        private System.Windows.Forms.Button btn_checkInOut;
        private System.Windows.Forms.TextBox txt_actionQuantitiy;
        private System.Windows.Forms.PictureBox pictureBoxMap;
        private System.Windows.Forms.Button btn_editMapLocation;
        private System.Windows.Forms.Label lbl_currentStock;
        private System.Windows.Forms.Button btn_saveChanges;
        private System.Windows.Forms.Label lbl_supplierCode;
        private System.Windows.Forms.Button btn_removeProduct;
        private System.Windows.Forms.Label lbl_vat;
        private System.Windows.Forms.Label lbl_price;
    }
}