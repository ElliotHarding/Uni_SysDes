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
            this.btn_updateSupplierCode = new System.Windows.Forms.Button();
            this.btn_changeStockAmount = new System.Windows.Forms.Button();
            this.txt_actionQuantitiy = new System.Windows.Forms.TextBox();
            this.btn_checkout = new System.Windows.Forms.Button();
            this.btn_checkIn = new System.Windows.Forms.Button();
            this.lbl_quantitiy = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_productInfo = new System.Windows.Forms.Label();
            this.btn_editInfo = new System.Windows.Forms.Button();
            this.lbl_productName = new System.Windows.Forms.Label();
            this.btn_editPicture = new System.Windows.Forms.Button();
            this.pictureBoxMap = new System.Windows.Forms.PictureBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lbl_currentStock = new System.Windows.Forms.Label();
            this.btn_saveChanges = new System.Windows.Forms.Button();
            this.lbl_uploadError = new System.Windows.Forms.Label();
            this.lbl_CheckInOutError = new System.Windows.Forms.Label();
            this.lbl_supplierCode = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_editMapLocation
            // 
            this.btn_editMapLocation.Location = new System.Drawing.Point(537, 247);
            this.btn_editMapLocation.Name = "btn_editMapLocation";
            this.btn_editMapLocation.Size = new System.Drawing.Size(111, 23);
            this.btn_editMapLocation.TabIndex = 13;
            this.btn_editMapLocation.Text = "Edit Map Location";
            this.btn_editMapLocation.UseVisualStyleBackColor = true;
            this.btn_editMapLocation.Click += new System.EventHandler(this.btn_editMapLocation_Click);
            // 
            // btn_updateSupplierCode
            // 
            this.btn_updateSupplierCode.Location = new System.Drawing.Point(553, 179);
            this.btn_updateSupplierCode.Name = "btn_updateSupplierCode";
            this.btn_updateSupplierCode.Size = new System.Drawing.Size(132, 23);
            this.btn_updateSupplierCode.TabIndex = 11;
            this.btn_updateSupplierCode.Text = "Update Supplier Code";
            this.btn_updateSupplierCode.UseVisualStyleBackColor = true;
            this.btn_updateSupplierCode.Click += new System.EventHandler(this.btn_updateSupplierCode_Click);
            // 
            // btn_changeStockAmount
            // 
            this.btn_changeStockAmount.Location = new System.Drawing.Point(415, 160);
            this.btn_changeStockAmount.Name = "btn_changeStockAmount";
            this.btn_changeStockAmount.Size = new System.Drawing.Size(132, 23);
            this.btn_changeStockAmount.TabIndex = 10;
            this.btn_changeStockAmount.Text = "Change Stock Amount";
            this.btn_changeStockAmount.UseVisualStyleBackColor = true;
            this.btn_changeStockAmount.Click += new System.EventHandler(this.bttn_changeStockAmount_Click);
            // 
            // txt_actionQuantitiy
            // 
            this.txt_actionQuantitiy.Location = new System.Drawing.Point(224, 221);
            this.txt_actionQuantitiy.Name = "txt_actionQuantitiy";
            this.txt_actionQuantitiy.Size = new System.Drawing.Size(100, 20);
            this.txt_actionQuantitiy.TabIndex = 9;
            // 
            // btn_checkout
            // 
            this.btn_checkout.Location = new System.Drawing.Point(249, 247);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(93, 23);
            this.btn_checkout.TabIndex = 8;
            this.btn_checkout.Text = "Check-Out";
            this.btn_checkout.UseVisualStyleBackColor = true;
            this.btn_checkout.Click += new System.EventHandler(this.btn_checkout_Click);
            // 
            // btn_checkIn
            // 
            this.btn_checkIn.Location = new System.Drawing.Point(149, 247);
            this.btn_checkIn.Name = "btn_checkIn";
            this.btn_checkIn.Size = new System.Drawing.Size(93, 23);
            this.btn_checkIn.TabIndex = 7;
            this.btn_checkIn.Text = "Check-In";
            this.btn_checkIn.UseVisualStyleBackColor = true;
            this.btn_checkIn.Click += new System.EventHandler(this.btn_checkIn_Click);
            // 
            // lbl_quantitiy
            // 
            this.lbl_quantitiy.AutoSize = true;
            this.lbl_quantitiy.Location = new System.Drawing.Point(164, 224);
            this.lbl_quantitiy.Name = "lbl_quantitiy";
            this.lbl_quantitiy.Size = new System.Drawing.Size(54, 13);
            this.lbl_quantitiy.TabIndex = 6;
            this.lbl_quantitiy.Text = "Quantitiy :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_productInfo);
            this.panel1.Location = new System.Drawing.Point(261, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 92);
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
            // 
            // btn_editInfo
            // 
            this.btn_editInfo.Location = new System.Drawing.Point(261, 160);
            this.btn_editInfo.Name = "btn_editInfo";
            this.btn_editInfo.Size = new System.Drawing.Size(93, 23);
            this.btn_editInfo.TabIndex = 4;
            this.btn_editInfo.Text = "Edit Information";
            this.btn_editInfo.UseVisualStyleBackColor = true;
            this.btn_editInfo.Click += new System.EventHandler(this.btn_editInfo_Click);
            // 
            // lbl_productName
            // 
            this.lbl_productName.AutoSize = true;
            this.lbl_productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productName.Location = new System.Drawing.Point(262, 38);
            this.lbl_productName.Name = "lbl_productName";
            this.lbl_productName.Size = new System.Drawing.Size(57, 20);
            this.lbl_productName.TabIndex = 2;
            this.lbl_productName.Text = "label1";
            // 
            // btn_editPicture
            // 
            this.btn_editPicture.Location = new System.Drawing.Point(112, 160);
            this.btn_editPicture.Name = "btn_editPicture";
            this.btn_editPicture.Size = new System.Drawing.Size(75, 23);
            this.btn_editPicture.TabIndex = 1;
            this.btn_editPicture.Text = "Edit Picture";
            this.btn_editPicture.UseVisualStyleBackColor = true;
            this.btn_editPicture.Click += new System.EventHandler(this.btn_editPicture_Click);
            // 
            // pictureBoxMap
            // 
            this.pictureBoxMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMap.Location = new System.Drawing.Point(148, 276);
            this.pictureBoxMap.Name = "pictureBoxMap";
            this.pictureBoxMap.Size = new System.Drawing.Size(500, 300);
            this.pictureBoxMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxMap.TabIndex = 12;
            this.pictureBoxMap.TabStop = false;
            this.pictureBoxMap.Click += new System.EventHandler(this.PictureBoxMap_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(112, 37);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(143, 116);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // lbl_currentStock
            // 
            this.lbl_currentStock.AutoSize = true;
            this.lbl_currentStock.Location = new System.Drawing.Point(596, 43);
            this.lbl_currentStock.Name = "lbl_currentStock";
            this.lbl_currentStock.Size = new System.Drawing.Size(78, 13);
            this.lbl_currentStock.TabIndex = 4;
            this.lbl_currentStock.Text = "Current Stock :";
            // 
            // btn_saveChanges
            // 
            this.btn_saveChanges.Location = new System.Drawing.Point(354, 582);
            this.btn_saveChanges.Name = "btn_saveChanges";
            this.btn_saveChanges.Size = new System.Drawing.Size(89, 23);
            this.btn_saveChanges.TabIndex = 14;
            this.btn_saveChanges.Text = "Save Changes";
            this.btn_saveChanges.UseVisualStyleBackColor = true;
            this.btn_saveChanges.Click += new System.EventHandler(this.btn_saveChanges_Click);
            // 
            // lbl_uploadError
            // 
            this.lbl_uploadError.AutoSize = true;
            this.lbl_uploadError.ForeColor = System.Drawing.Color.Red;
            this.lbl_uploadError.Location = new System.Drawing.Point(338, 608);
            this.lbl_uploadError.Name = "lbl_uploadError";
            this.lbl_uploadError.Size = new System.Drawing.Size(126, 13);
            this.lbl_uploadError.TabIndex = 15;
            this.lbl_uploadError.Text = "Failed to upload changes";
            // 
            // lbl_CheckInOutError
            // 
            this.lbl_CheckInOutError.AutoSize = true;
            this.lbl_CheckInOutError.ForeColor = System.Drawing.Color.Red;
            this.lbl_CheckInOutError.Location = new System.Drawing.Point(348, 252);
            this.lbl_CheckInOutError.Name = "lbl_CheckInOutError";
            this.lbl_CheckInOutError.Size = new System.Drawing.Size(110, 13);
            this.lbl_CheckInOutError.TabIndex = 16;
            this.lbl_CheckInOutError.Text = "Enter correct quantitiy";
            // 
            // lbl_supplierCode
            // 
            this.lbl_supplierCode.AutoSize = true;
            this.lbl_supplierCode.Location = new System.Drawing.Point(553, 160);
            this.lbl_supplierCode.Name = "lbl_supplierCode";
            this.lbl_supplierCode.Size = new System.Drawing.Size(29, 13);
            this.lbl_supplierCode.TabIndex = 17;
            this.lbl_supplierCode.Text = "label";
            // 
            // ViewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 709);
            this.Controls.Add(this.lbl_supplierCode);
            this.Controls.Add(this.lbl_CheckInOutError);
            this.Controls.Add(this.lbl_uploadError);
            this.Controls.Add(this.btn_saveChanges);
            this.Controls.Add(this.lbl_currentStock);
            this.Controls.Add(this.btn_editMapLocation);
            this.Controls.Add(this.pictureBoxMap);
            this.Controls.Add(this.btn_updateSupplierCode);
            this.Controls.Add(this.btn_changeStockAmount);
            this.Controls.Add(this.txt_actionQuantitiy);
            this.Controls.Add(this.btn_checkout);
            this.Controls.Add(this.btn_checkIn);
            this.Controls.Add(this.lbl_quantitiy);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_editInfo);
            this.Controls.Add(this.lbl_productName);
            this.Controls.Add(this.btn_editPicture);
            this.Controls.Add(this.pictureBox);
            this.Name = "ViewProduct";
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
        private System.Windows.Forms.Button btn_editPicture;
        private System.Windows.Forms.Label lbl_productName;
        private System.Windows.Forms.Label lbl_productInfo;
        private System.Windows.Forms.Button btn_editInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_quantitiy;
        private System.Windows.Forms.Button btn_checkIn;
        private System.Windows.Forms.Button btn_checkout;
        private System.Windows.Forms.TextBox txt_actionQuantitiy;
        private System.Windows.Forms.Button btn_changeStockAmount;
        private System.Windows.Forms.Button btn_updateSupplierCode;
        private System.Windows.Forms.PictureBox pictureBoxMap;
        private System.Windows.Forms.Button btn_editMapLocation;
        private System.Windows.Forms.Label lbl_currentStock;
        private System.Windows.Forms.Button btn_saveChanges;
        private System.Windows.Forms.Label lbl_uploadError;
        private System.Windows.Forms.Label lbl_CheckInOutError;
        private System.Windows.Forms.Label lbl_supplierCode;
    }
}