namespace StockManagementSystem.User_Controls
{
    partial class NewProductRow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_suppliersId = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_description = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_setImage = new System.Windows.Forms.Button();
            this.btn_setMapLocation = new System.Windows.Forms.Button();
            this.mskTB_price = new System.Windows.Forms.MaskedTextBox();
            this.mskTB_vat = new System.Windows.Forms.MaskedTextBox();
            this.mskTB_expectedQuantity = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // tb_suppliersId
            // 
            this.tb_suppliersId.Location = new System.Drawing.Point(669, 67);
            this.tb_suppliersId.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tb_suppliersId.Name = "tb_suppliersId";
            this.tb_suppliersId.Size = new System.Drawing.Size(580, 38);
            this.tb_suppliersId.TabIndex = 0;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(133, 29);
            this.tb_name.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(463, 38);
            this.tb_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(669, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(577, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Supplier Product Id / Universal Product Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1301, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description";
            // 
            // tb_description
            // 
            this.tb_description.Location = new System.Drawing.Point(1301, 67);
            this.tb_description.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tb_description.MaxLength = 450;
            this.tb_description.Name = "tb_description";
            this.tb_description.Size = new System.Drawing.Size(1033, 142);
            this.tb_description.TabIndex = 6;
            this.tb_description.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(131, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 34);
            this.label5.TabIndex = 9;
            this.label5.Text = "£";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 167);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 32);
            this.label6.TabIndex = 11;
            this.label6.Text = "VAT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(131, 164);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 34);
            this.label7.TabIndex = 12;
            this.label7.Text = "£";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(669, 126);
            this.label8.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 32);
            this.label8.TabIndex = 14;
            this.label8.Text = "Quantity";
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(2304, 7);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(59, 52);
            this.btn_remove.TabIndex = 15;
            this.btn_remove.Text = "X";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_setImage
            // 
            this.btn_setImage.Location = new System.Drawing.Point(32, 222);
            this.btn_setImage.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_setImage.Name = "btn_setImage";
            this.btn_setImage.Size = new System.Drawing.Size(200, 55);
            this.btn_setImage.TabIndex = 16;
            this.btn_setImage.Text = "Set Image";
            this.btn_setImage.UseVisualStyleBackColor = true;
            this.btn_setImage.Click += new System.EventHandler(this.btn_setImage_Click);
            // 
            // btn_setMapLocation
            // 
            this.btn_setMapLocation.Location = new System.Drawing.Point(248, 222);
            this.btn_setMapLocation.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_setMapLocation.Name = "btn_setMapLocation";
            this.btn_setMapLocation.Size = new System.Drawing.Size(288, 55);
            this.btn_setMapLocation.TabIndex = 17;
            this.btn_setMapLocation.Text = "Set Map Location";
            this.btn_setMapLocation.UseVisualStyleBackColor = true;
            this.btn_setMapLocation.Click += new System.EventHandler(this.btn_setMapLocation_Click);
            // 
            // mskTB_price
            // 
            this.mskTB_price.Location = new System.Drawing.Point(200, 93);
            this.mskTB_price.Mask = "999.99";
            this.mskTB_price.Name = "mskTB_price";
            this.mskTB_price.PromptChar = '0';
            this.mskTB_price.Size = new System.Drawing.Size(396, 38);
            this.mskTB_price.TabIndex = 18;
            // 
            // mskTB_vat
            // 
            this.mskTB_vat.Location = new System.Drawing.Point(200, 160);
            this.mskTB_vat.Mask = "999.99";
            this.mskTB_vat.Name = "mskTB_vat";
            this.mskTB_vat.PromptChar = '0';
            this.mskTB_vat.Size = new System.Drawing.Size(396, 38);
            this.mskTB_vat.TabIndex = 19;
            // 
            // mskTB_expectedQuantity
            // 
            this.mskTB_expectedQuantity.Location = new System.Drawing.Point(669, 161);
            this.mskTB_expectedQuantity.Mask = "00000";
            this.mskTB_expectedQuantity.Name = "mskTB_expectedQuantity";
            this.mskTB_expectedQuantity.Size = new System.Drawing.Size(396, 38);
            this.mskTB_expectedQuantity.TabIndex = 20;
            this.mskTB_expectedQuantity.ValidatingType = typeof(int);
            // 
            // NewProductRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mskTB_expectedQuantity);
            this.Controls.Add(this.mskTB_vat);
            this.Controls.Add(this.mskTB_price);
            this.Controls.Add(this.btn_setMapLocation);
            this.Controls.Add(this.btn_setImage);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_description);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_suppliersId);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "NewProductRow";
            this.Size = new System.Drawing.Size(2373, 293);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_suppliersId;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox tb_description;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_setImage;
        private System.Windows.Forms.Button btn_setMapLocation;
        private System.Windows.Forms.MaskedTextBox mskTB_price;
        private System.Windows.Forms.MaskedTextBox mskTB_vat;
        private System.Windows.Forms.MaskedTextBox mskTB_expectedQuantity;
    }
}
