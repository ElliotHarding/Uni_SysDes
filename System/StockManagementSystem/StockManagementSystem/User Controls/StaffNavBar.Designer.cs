namespace StockManagementSystem.Classes
{
    partial class StaffNavBar
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
            this.btn_messages = new System.Windows.Forms.Button();
            this.btn_products = new System.Windows.Forms.Button();
            this.btn_inspection = new System.Windows.Forms.Button();
            this.btn_invoices = new System.Windows.Forms.Button();
            this.btn_expectedDelivery = new System.Windows.Forms.Button();
            this.btn_newShipment = new System.Windows.Forms.Button();
            this.btn_checkIn = new System.Windows.Forms.Button();
            this.btn_checkout = new System.Windows.Forms.Button();
            this.lbl_numMessages = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_messages
            // 
            this.btn_messages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_messages.Location = new System.Drawing.Point(4, 11);
            this.btn_messages.Name = "btn_messages";
            this.btn_messages.Size = new System.Drawing.Size(102, 30);
            this.btn_messages.TabIndex = 0;
            this.btn_messages.Text = "Messages";
            this.btn_messages.UseVisualStyleBackColor = true;
            this.btn_messages.Click += new System.EventHandler(this.btn_messages_Click);
            // 
            // btn_products
            // 
            this.btn_products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_products.Location = new System.Drawing.Point(104, 11);
            this.btn_products.Name = "btn_products";
            this.btn_products.Size = new System.Drawing.Size(102, 30);
            this.btn_products.TabIndex = 1;
            this.btn_products.Text = "Products";
            this.btn_products.UseVisualStyleBackColor = true;
            this.btn_products.Click += new System.EventHandler(this.btn_products_Click);
            // 
            // btn_inspection
            // 
            this.btn_inspection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inspection.Location = new System.Drawing.Point(204, 11);
            this.btn_inspection.Name = "btn_inspection";
            this.btn_inspection.Size = new System.Drawing.Size(102, 30);
            this.btn_inspection.TabIndex = 2;
            this.btn_inspection.Text = "Inspection";
            this.btn_inspection.UseVisualStyleBackColor = true;
            this.btn_inspection.Click += new System.EventHandler(this.btn_inspection_Click);
            // 
            // btn_invoices
            // 
            this.btn_invoices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_invoices.Location = new System.Drawing.Point(304, 11);
            this.btn_invoices.Name = "btn_invoices";
            this.btn_invoices.Size = new System.Drawing.Size(102, 30);
            this.btn_invoices.TabIndex = 3;
            this.btn_invoices.Text = "Invoices";
            this.btn_invoices.UseVisualStyleBackColor = true;
            this.btn_invoices.Click += new System.EventHandler(this.btn_invoices_Click);
            // 
            // btn_expectedDelivery
            // 
            this.btn_expectedDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_expectedDelivery.Location = new System.Drawing.Point(404, 11);
            this.btn_expectedDelivery.Name = "btn_expectedDelivery";
            this.btn_expectedDelivery.Size = new System.Drawing.Size(103, 30);
            this.btn_expectedDelivery.TabIndex = 4;
            this.btn_expectedDelivery.Text = "Expected Delivery";
            this.btn_expectedDelivery.UseVisualStyleBackColor = true;
            this.btn_expectedDelivery.Click += new System.EventHandler(this.btn_expectedDelivery_Click);
            // 
            // btn_newShipment
            // 
            this.btn_newShipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_newShipment.Location = new System.Drawing.Point(505, 11);
            this.btn_newShipment.Name = "btn_newShipment";
            this.btn_newShipment.Size = new System.Drawing.Size(102, 30);
            this.btn_newShipment.TabIndex = 5;
            this.btn_newShipment.Text = "New Shipment";
            this.btn_newShipment.UseVisualStyleBackColor = true;
            this.btn_newShipment.Click += new System.EventHandler(this.btn_newShipment_Click);
            // 
            // btn_checkIn
            // 
            this.btn_checkIn.BackColor = System.Drawing.SystemColors.Control;
            this.btn_checkIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_checkIn.Location = new System.Drawing.Point(605, 11);
            this.btn_checkIn.Name = "btn_checkIn";
            this.btn_checkIn.Size = new System.Drawing.Size(102, 30);
            this.btn_checkIn.TabIndex = 6;
            this.btn_checkIn.Text = "Check-In";
            this.btn_checkIn.UseVisualStyleBackColor = false;
            this.btn_checkIn.Click += new System.EventHandler(this.btn_checkIn_Click);
            // 
            // btn_checkout
            // 
            this.btn_checkout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_checkout.Location = new System.Drawing.Point(705, 11);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(102, 30);
            this.btn_checkout.TabIndex = 7;
            this.btn_checkout.Text = "Check-Out";
            this.btn_checkout.UseVisualStyleBackColor = true;
            this.btn_checkout.Click += new System.EventHandler(this.btn_checkout_Click);
            // 
            // lbl_numMessages
            // 
            this.lbl_numMessages.AutoSize = true;
            this.lbl_numMessages.ForeColor = System.Drawing.Color.Red;
            this.lbl_numMessages.Location = new System.Drawing.Point(89, 14);
            this.lbl_numMessages.Name = "lbl_numMessages";
            this.lbl_numMessages.Size = new System.Drawing.Size(13, 13);
            this.lbl_numMessages.TabIndex = 8;
            this.lbl_numMessages.Text = "1";
            // 
            // StaffNavBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_numMessages);
            this.Controls.Add(this.btn_checkout);
            this.Controls.Add(this.btn_checkIn);
            this.Controls.Add(this.btn_newShipment);
            this.Controls.Add(this.btn_expectedDelivery);
            this.Controls.Add(this.btn_invoices);
            this.Controls.Add(this.btn_inspection);
            this.Controls.Add(this.btn_products);
            this.Controls.Add(this.btn_messages);
            this.Name = "StaffNavBar";
            this.Size = new System.Drawing.Size(812, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_messages;
        private System.Windows.Forms.Button btn_products;
        private System.Windows.Forms.Button btn_inspection;
        private System.Windows.Forms.Button btn_invoices;
        private System.Windows.Forms.Button btn_expectedDelivery;
        private System.Windows.Forms.Button btn_newShipment;
        private System.Windows.Forms.Button btn_checkIn;
        private System.Windows.Forms.Button btn_checkout;
        private System.Windows.Forms.Label lbl_numMessages;
    }
}
