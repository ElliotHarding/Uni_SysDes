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
            this.tb_price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_vat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_expectedQuantitiy = new System.Windows.Forms.TextBox();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_setImage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_suppliersId
            // 
            this.tb_suppliersId.Location = new System.Drawing.Point(251, 28);
            this.tb_suppliersId.Name = "tb_suppliersId";
            this.tb_suppliersId.Size = new System.Drawing.Size(220, 20);
            this.tb_suppliersId.TabIndex = 0;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(50, 12);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(176, 20);
            this.tb_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Supplier Product Id / Universal Product Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(488, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description";
            // 
            // tb_description
            // 
            this.tb_description.Location = new System.Drawing.Point(488, 28);
            this.tb_description.Name = "tb_description";
            this.tb_description.Size = new System.Drawing.Size(390, 62);
            this.tb_description.TabIndex = 6;
            this.tb_description.Text = "";
            // 
            // tb_price
            // 
            this.tb_price.Location = new System.Drawing.Point(50, 38);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(151, 20);
            this.tb_price.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "£";
            // 
            // tb_vat
            // 
            this.tb_vat.Location = new System.Drawing.Point(50, 67);
            this.tb_vat.Name = "tb_vat";
            this.tb_vat.Size = new System.Drawing.Size(151, 20);
            this.tb_vat.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "VAT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(207, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "£";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(251, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Quantity";
            // 
            // tb_expectedQuantitiy
            // 
            this.tb_expectedQuantitiy.Location = new System.Drawing.Point(251, 70);
            this.tb_expectedQuantitiy.Name = "tb_expectedQuantitiy";
            this.tb_expectedQuantitiy.Size = new System.Drawing.Size(176, 20);
            this.tb_expectedQuantitiy.TabIndex = 13;
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(864, 3);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(22, 22);
            this.btn_remove.TabIndex = 15;
            this.btn_remove.Text = "X";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_setImage
            // 
            this.btn_setImage.Location = new System.Drawing.Point(12, 93);
            this.btn_setImage.Name = "btn_setImage";
            this.btn_setImage.Size = new System.Drawing.Size(75, 23);
            this.btn_setImage.TabIndex = 16;
            this.btn_setImage.Text = "Set Image";
            this.btn_setImage.UseVisualStyleBackColor = true;
            this.btn_setImage.Click += new System.EventHandler(this.btn_setImage_Click);
            // 
            // NewProductRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_setImage);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_expectedQuantitiy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_vat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_price);
            this.Controls.Add(this.tb_description);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_suppliersId);
            this.Name = "NewProductRow";
            this.Size = new System.Drawing.Size(890, 123);
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
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_vat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_expectedQuantitiy;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_setImage;
    }
}
