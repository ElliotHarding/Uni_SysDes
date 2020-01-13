namespace StockManagementSystem.Pages
{
    partial class ProductsPage
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
            this.panel_products = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel_products
            // 
            this.panel_products.Location = new System.Drawing.Point(2, 2);
            this.panel_products.Name = "panel_products";
            this.panel_products.Size = new System.Drawing.Size(794, 613);
            this.panel_products.TabIndex = 0;
            // 
            // ProductsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 709);
            this.Controls.Add(this.panel_products);
            this.Name = "ProductsPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_products;
    }
}