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
            this.btn_newShipment = new System.Windows.Forms.Button();
            this.btn_updateShipment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_newShipment
            // 
            this.btn_newShipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newShipment.Location = new System.Drawing.Point(253, 314);
            this.btn_newShipment.Name = "btn_newShipment";
            this.btn_newShipment.Size = new System.Drawing.Size(242, 33);
            this.btn_newShipment.TabIndex = 0;
            this.btn_newShipment.Text = "Add Brand New Product Shipment";
            this.btn_newShipment.UseVisualStyleBackColor = true;
            this.btn_newShipment.Click += new System.EventHandler(this.btn_newShipment_Click);
            // 
            // btn_updateShipment
            // 
            this.btn_updateShipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateShipment.Location = new System.Drawing.Point(514, 314);
            this.btn_updateShipment.Name = "btn_updateShipment";
            this.btn_updateShipment.Size = new System.Drawing.Size(242, 33);
            this.btn_updateShipment.TabIndex = 1;
            this.btn_updateShipment.Text = "Update Stock Shipment";
            this.btn_updateShipment.UseVisualStyleBackColor = true;
            this.btn_updateShipment.Click += new System.EventHandler(this.btn_updateShipment_Click);
            // 
            // NewShipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.btn_updateShipment);
            this.Controls.Add(this.btn_newShipment);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 720);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 720);
            this.Name = "NewShipment";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " New Shipment";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_newShipment;
        private System.Windows.Forms.Button btn_updateShipment;
    }
}