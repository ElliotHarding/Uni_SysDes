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
            this.btn_shipment = new System.Windows.Forms.Button();
            this.lbl_numMessages = new System.Windows.Forms.Label();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_basket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_messages
            // 
            this.btn_messages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_messages.Location = new System.Drawing.Point(161, 10);
            this.btn_messages.Name = "btn_messages";
            this.btn_messages.Size = new System.Drawing.Size(102, 29);
            this.btn_messages.TabIndex = 0;
            this.btn_messages.TabStop = false;
            this.btn_messages.Text = "Messages";
            this.btn_messages.UseVisualStyleBackColor = true;
            this.btn_messages.Click += new System.EventHandler(this.btn_messages_Click);
            // 
            // btn_products
            // 
            this.btn_products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_products.Location = new System.Drawing.Point(261, 10);
            this.btn_products.Name = "btn_products";
            this.btn_products.Size = new System.Drawing.Size(102, 29);
            this.btn_products.TabIndex = 1;
            this.btn_products.TabStop = false;
            this.btn_products.Text = "Products";
            this.btn_products.UseVisualStyleBackColor = true;
            this.btn_products.Click += new System.EventHandler(this.btn_products_Click);
            // 
            // btn_inspection
            // 
            this.btn_inspection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inspection.Location = new System.Drawing.Point(361, 10);
            this.btn_inspection.Name = "btn_inspection";
            this.btn_inspection.Size = new System.Drawing.Size(102, 29);
            this.btn_inspection.TabIndex = 2;
            this.btn_inspection.TabStop = false;
            this.btn_inspection.Text = "Inspection";
            this.btn_inspection.UseVisualStyleBackColor = true;
            this.btn_inspection.Click += new System.EventHandler(this.btn_inspection_Click);
            // 
            // btn_invoices
            // 
            this.btn_invoices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_invoices.Location = new System.Drawing.Point(461, 10);
            this.btn_invoices.Name = "btn_invoices";
            this.btn_invoices.Size = new System.Drawing.Size(102, 29);
            this.btn_invoices.TabIndex = 3;
            this.btn_invoices.TabStop = false;
            this.btn_invoices.Text = "Invoices";
            this.btn_invoices.UseVisualStyleBackColor = true;
            this.btn_invoices.Click += new System.EventHandler(this.btn_invoices_Click);
            // 
            // btn_shipment
            // 
            this.btn_shipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_shipment.Location = new System.Drawing.Point(562, 10);
            this.btn_shipment.Name = "btn_shipment";
            this.btn_shipment.Size = new System.Drawing.Size(102, 29);
            this.btn_shipment.TabIndex = 5;
            this.btn_shipment.TabStop = false;
            this.btn_shipment.Text = "Shipments";
            this.btn_shipment.UseVisualStyleBackColor = true;
            this.btn_shipment.Click += new System.EventHandler(this.btn_newShipment_Click);
            // 
            // lbl_numMessages
            // 
            this.lbl_numMessages.AutoSize = true;
            this.lbl_numMessages.ForeColor = System.Drawing.Color.Red;
            this.lbl_numMessages.Location = new System.Drawing.Point(246, 13);
            this.lbl_numMessages.Name = "lbl_numMessages";
            this.lbl_numMessages.Size = new System.Drawing.Size(13, 13);
            this.lbl_numMessages.TabIndex = 8;
            this.lbl_numMessages.Text = "1";
            // 
            // btn_settings
            // 
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.Location = new System.Drawing.Point(764, 10);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(102, 29);
            this.btn_settings.TabIndex = 9;
            this.btn_settings.TabStop = false;
            this.btn_settings.Text = "Settings";
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_basket
            // 
            this.btn_basket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_basket.Location = new System.Drawing.Point(663, 10);
            this.btn_basket.Name = "btn_basket";
            this.btn_basket.Size = new System.Drawing.Size(102, 29);
            this.btn_basket.TabIndex = 10;
            this.btn_basket.TabStop = false;
            this.btn_basket.Text = "Basket";
            this.btn_basket.UseVisualStyleBackColor = true;
            this.btn_basket.Click += new System.EventHandler(this.btn_basket_Click);
            // 
            // StaffNavBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_basket);
            this.Controls.Add(this.btn_settings);
            this.Controls.Add(this.lbl_numMessages);
            this.Controls.Add(this.btn_shipment);
            this.Controls.Add(this.btn_invoices);
            this.Controls.Add(this.btn_inspection);
            this.Controls.Add(this.btn_products);
            this.Controls.Add(this.btn_messages);
            this.MaximumSize = new System.Drawing.Size(1024, 50);
            this.MinimumSize = new System.Drawing.Size(1024, 50);
            this.Name = "StaffNavBar";
            this.Size = new System.Drawing.Size(1024, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_messages;
        private System.Windows.Forms.Button btn_products;
        private System.Windows.Forms.Button btn_inspection;
        private System.Windows.Forms.Button btn_invoices;
        private System.Windows.Forms.Button btn_shipment;
        private System.Windows.Forms.Label lbl_numMessages;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_basket;
    }
}
