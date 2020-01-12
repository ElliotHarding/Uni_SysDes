﻿namespace StockManagementSystem.Classes
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
            this.btn_checkout = new System.Windows.Forms.Button();
            this.btn_products = new System.Windows.Forms.Button();
            this.btn_messages = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_checkout
            // 
            this.btn_checkout.Location = new System.Drawing.Point(512, 5);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(200, 41);
            this.btn_checkout.TabIndex = 5;
            this.btn_checkout.Text = "Check Out";
            this.btn_checkout.UseVisualStyleBackColor = true;
            this.btn_checkout.Click += new System.EventHandler(this.btn_checkout_Click);
            // 
            // btn_products
            // 
            this.btn_products.Location = new System.Drawing.Point(305, 5);
            this.btn_products.Name = "btn_products";
            this.btn_products.Size = new System.Drawing.Size(200, 41);
            this.btn_products.TabIndex = 4;
            this.btn_products.Text = "Products";
            this.btn_products.UseVisualStyleBackColor = true;
            this.btn_products.Click += new System.EventHandler(this.btn_products_Click);
            // 
            // btn_messages
            // 
            this.btn_messages.Location = new System.Drawing.Point(99, 5);
            this.btn_messages.Name = "btn_messages";
            this.btn_messages.Size = new System.Drawing.Size(200, 41);
            this.btn_messages.TabIndex = 3;
            this.btn_messages.Text = "Messages";
            this.btn_messages.UseVisualStyleBackColor = true;
            this.btn_messages.Click += new System.EventHandler(this.btn_messages_Click);
            // 
            // NavBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_checkout);
            this.Controls.Add(this.btn_products);
            this.Controls.Add(this.btn_messages);
            this.Name = "NavBar";
            this.Size = new System.Drawing.Size(812, 50);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_checkout;
        private System.Windows.Forms.Button btn_products;
        private System.Windows.Forms.Button btn_messages;
    }
}