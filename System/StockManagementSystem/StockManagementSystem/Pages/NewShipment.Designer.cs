namespace StockManagementSystem.Pages
{
    partial class NewShipment
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
            this.tb_itemCode = new System.Windows.Forms.TextBox();
            this.tb_supplierItemCode = new System.Windows.Forms.TextBox();
            this.tb_quantitiy = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_scanItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_itemCode
            // 
            this.tb_itemCode.Location = new System.Drawing.Point(80, 107);
            this.tb_itemCode.Name = "tb_itemCode";
            this.tb_itemCode.Size = new System.Drawing.Size(212, 20);
            this.tb_itemCode.TabIndex = 0;
            // 
            // tb_supplierItemCode
            // 
            this.tb_supplierItemCode.Location = new System.Drawing.Point(322, 107);
            this.tb_supplierItemCode.Name = "tb_supplierItemCode";
            this.tb_supplierItemCode.Size = new System.Drawing.Size(212, 20);
            this.tb_supplierItemCode.TabIndex = 1;
            // 
            // tb_quantitiy
            // 
            this.tb_quantitiy.Location = new System.Drawing.Point(206, 150);
            this.tb_quantitiy.Name = "tb_quantitiy";
            this.tb_quantitiy.Size = new System.Drawing.Size(212, 20);
            this.tb_quantitiy.TabIndex = 2;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(269, 188);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Item Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Supplier Item Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Or";
            // 
            // btn_scanItem
            // 
            this.btn_scanItem.Location = new System.Drawing.Point(700, 176);
            this.btn_scanItem.Name = "btn_scanItem";
            this.btn_scanItem.Size = new System.Drawing.Size(75, 23);
            this.btn_scanItem.TabIndex = 8;
            this.btn_scanItem.Text = "Scan Item";
            this.btn_scanItem.UseVisualStyleBackColor = true;
            // 
            // NewShipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.btn_scanItem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tb_quantitiy);
            this.Controls.Add(this.tb_supplierItemCode);
            this.Controls.Add(this.tb_itemCode);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 720);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 720);
            this.Name = "NewShipment";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " New Shipment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_itemCode;
        private System.Windows.Forms.TextBox tb_supplierItemCode;
        private System.Windows.Forms.TextBox tb_quantitiy;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_scanItem;
    }
}