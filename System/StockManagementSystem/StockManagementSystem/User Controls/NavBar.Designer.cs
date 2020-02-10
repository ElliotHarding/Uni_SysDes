namespace StockManagementSystem.Classes
{
    partial class NavBar
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
            this.btn_basket = new System.Windows.Forms.Button();
            this.lbl_messageCount = new System.Windows.Forms.Label();
            this.btn_settings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_messages
            // 
            this.btn_messages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_messages.Location = new System.Drawing.Point(73, 6);
            this.btn_messages.Name = "btn_messages";
            this.btn_messages.Size = new System.Drawing.Size(220, 41);
            this.btn_messages.TabIndex = 3;
            this.btn_messages.TabStop = false;
            this.btn_messages.Text = "Messages";
            this.btn_messages.UseVisualStyleBackColor = true;
            this.btn_messages.Click += new System.EventHandler(this.btn_messages_Click);
            // 
            // btn_products
            // 
            this.btn_products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_products.Location = new System.Drawing.Point(292, 6);
            this.btn_products.Name = "btn_products";
            this.btn_products.Size = new System.Drawing.Size(220, 41);
            this.btn_products.TabIndex = 4;
            this.btn_products.TabStop = false;
            this.btn_products.Text = "Products";
            this.btn_products.UseVisualStyleBackColor = true;
            this.btn_products.Click += new System.EventHandler(this.btn_products_Click);
            // 
            // btn_basket
            // 
            this.btn_basket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_basket.Location = new System.Drawing.Point(511, 6);
            this.btn_basket.Name = "btn_basket";
            this.btn_basket.Size = new System.Drawing.Size(220, 41);
            this.btn_basket.TabIndex = 5;
            this.btn_basket.TabStop = false;
            this.btn_basket.Text = "Basket";
            this.btn_basket.UseVisualStyleBackColor = true;
            this.btn_basket.Click += new System.EventHandler(this.btn_basket_Click);
            // 
            // lbl_messageCount
            // 
            this.lbl_messageCount.AutoSize = true;
            this.lbl_messageCount.ForeColor = System.Drawing.Color.Red;
            this.lbl_messageCount.Location = new System.Drawing.Point(279, 9);
            this.lbl_messageCount.Name = "lbl_messageCount";
            this.lbl_messageCount.Size = new System.Drawing.Size(13, 13);
            this.lbl_messageCount.TabIndex = 6;
            this.lbl_messageCount.Text = "1";
            // 
            // btn_settings
            // 
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.Location = new System.Drawing.Point(730, 6);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(220, 41);
            this.btn_settings.TabIndex = 7;
            this.btn_settings.TabStop = false;
            this.btn_settings.Text = "Settings";
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // NavBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_settings);
            this.Controls.Add(this.lbl_messageCount);
            this.Controls.Add(this.btn_basket);
            this.Controls.Add(this.btn_products);
            this.Controls.Add(this.btn_messages);
            this.MaximumSize = new System.Drawing.Size(1024, 50);
            this.MinimumSize = new System.Drawing.Size(1024, 50);
            this.Name = "NavBar";
            this.Size = new System.Drawing.Size(1024, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_messages;
        private System.Windows.Forms.Button btn_products;
        private System.Windows.Forms.Button btn_basket;
        private System.Windows.Forms.Label lbl_messageCount;
        private System.Windows.Forms.Button btn_settings;
    }
}
