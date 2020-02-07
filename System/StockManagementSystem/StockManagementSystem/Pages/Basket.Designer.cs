namespace StockManagementSystem.Pages
{
    partial class Basket
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
            this.btn_sendToInspection = new System.Windows.Forms.Button();
            this.btn_returnItems = new System.Windows.Forms.Button();
            this.btn_checkout = new System.Windows.Forms.Button();
            this.pnl_products = new System.Windows.Forms.Panel();
            this.btn_clearAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_sendToInspection
            // 
            this.btn_sendToInspection.Location = new System.Drawing.Point(274, 569);
            this.btn_sendToInspection.Margin = new System.Windows.Forms.Padding(1);
            this.btn_sendToInspection.Name = "btn_sendToInspection";
            this.btn_sendToInspection.Size = new System.Drawing.Size(152, 26);
            this.btn_sendToInspection.TabIndex = 8;
            this.btn_sendToInspection.Text = "Send Items To Inspection";
            this.btn_sendToInspection.UseVisualStyleBackColor = true;
            this.btn_sendToInspection.Click += new System.EventHandler(this.btn_sendToInspection_Click);
            // 
            // btn_returnItems
            // 
            this.btn_returnItems.Location = new System.Drawing.Point(428, 569);
            this.btn_returnItems.Margin = new System.Windows.Forms.Padding(1);
            this.btn_returnItems.Name = "btn_returnItems";
            this.btn_returnItems.Size = new System.Drawing.Size(152, 26);
            this.btn_returnItems.TabIndex = 7;
            this.btn_returnItems.Text = "Return Items";
            this.btn_returnItems.UseVisualStyleBackColor = true;
            this.btn_returnItems.Click += new System.EventHandler(this.btn_returnItems_Click);
            // 
            // btn_checkout
            // 
            this.btn_checkout.Location = new System.Drawing.Point(582, 569);
            this.btn_checkout.Margin = new System.Windows.Forms.Padding(1);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(152, 26);
            this.btn_checkout.TabIndex = 9;
            this.btn_checkout.Text = "Check Items Out";
            this.btn_checkout.UseVisualStyleBackColor = true;
            this.btn_checkout.Click += new System.EventHandler(this.btn_checkout_Click);
            // 
            // pnl_products
            // 
            this.pnl_products.Location = new System.Drawing.Point(41, 61);
            this.pnl_products.Name = "pnl_products";
            this.pnl_products.Size = new System.Drawing.Size(932, 498);
            this.pnl_products.TabIndex = 10;
            // 
            // btn_clearAll
            // 
            this.btn_clearAll.Location = new System.Drawing.Point(903, 34);
            this.btn_clearAll.Margin = new System.Windows.Forms.Padding(1);
            this.btn_clearAll.Name = "btn_clearAll";
            this.btn_clearAll.Size = new System.Drawing.Size(70, 23);
            this.btn_clearAll.TabIndex = 11;
            this.btn_clearAll.Text = "Clear All";
            this.btn_clearAll.UseVisualStyleBackColor = true;
            this.btn_clearAll.Click += new System.EventHandler(this.btn_clearAll_Click);
            // 
            // Basket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.btn_clearAll);
            this.Controls.Add(this.pnl_products);
            this.Controls.Add(this.btn_checkout);
            this.Controls.Add(this.btn_sendToInspection);
            this.Controls.Add(this.btn_returnItems);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 720);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 720);
            this.Name = "Basket";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Basket";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_sendToInspection;
        private System.Windows.Forms.Button btn_returnItems;
        private System.Windows.Forms.Button btn_checkout;
        private System.Windows.Forms.Panel pnl_products;
        private System.Windows.Forms.Button btn_clearAll;
    }
}