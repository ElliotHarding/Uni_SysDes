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
            this.btn_checkOut = new System.Windows.Forms.Button();
            this.lbl_messageCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_messages
            // 
            this.btn_messages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_messages.Location = new System.Drawing.Point(183, 5);
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
            this.btn_products.Location = new System.Drawing.Point(402, 5);
            this.btn_products.Name = "btn_products";
            this.btn_products.Size = new System.Drawing.Size(220, 41);
            this.btn_products.TabIndex = 4;
            this.btn_products.TabStop = false;
            this.btn_products.Text = "Products";
            this.btn_products.UseVisualStyleBackColor = true;
            this.btn_products.Click += new System.EventHandler(this.btn_products_Click);
            // 
            // btn_checkOut
            // 
            this.btn_checkOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_checkOut.Location = new System.Drawing.Point(621, 5);
            this.btn_checkOut.Name = "btn_checkOut";
            this.btn_checkOut.Size = new System.Drawing.Size(220, 41);
            this.btn_checkOut.TabIndex = 5;
            this.btn_checkOut.TabStop = false;
            this.btn_checkOut.Text = "Check Out";
            this.btn_checkOut.UseVisualStyleBackColor = true;
            this.btn_checkOut.Click += new System.EventHandler(this.btn_checkout_Click);
            // 
            // lbl_messageCount
            // 
            this.lbl_messageCount.AutoSize = true;
            this.lbl_messageCount.ForeColor = System.Drawing.Color.Red;
            this.lbl_messageCount.Location = new System.Drawing.Point(389, 8);
            this.lbl_messageCount.Name = "lbl_messageCount";
            this.lbl_messageCount.Size = new System.Drawing.Size(13, 13);
            this.lbl_messageCount.TabIndex = 6;
            this.lbl_messageCount.Text = "1";
            // 
            // NavBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_messageCount);
            this.Controls.Add(this.btn_checkOut);
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
        private System.Windows.Forms.Button btn_checkOut;
        private System.Windows.Forms.Label lbl_messageCount;
    }
}
