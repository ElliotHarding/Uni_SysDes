namespace StockManagementSystem.User_Controls
{
    partial class ShipmentRow
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
            this.btn_view = new System.Windows.Forms.Button();
            this.lbl_supplierName = new System.Windows.Forms.Label();
            this.lbl_supplierSiteName = new System.Windows.Forms.Label();
            this.lbl_orderNo = new System.Windows.Forms.Label();
            this.lbl_requestedDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_view
            // 
            this.btn_view.Location = new System.Drawing.Point(837, 3);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(75, 23);
            this.btn_view.TabIndex = 0;
            this.btn_view.Text = "View";
            this.btn_view.UseVisualStyleBackColor = true;
            this.btn_view.Click += new System.EventHandler(this.Btn_view_Click);
            // 
            // lbl_supplierName
            // 
            this.lbl_supplierName.AutoSize = true;
            this.lbl_supplierName.Location = new System.Drawing.Point(13, 8);
            this.lbl_supplierName.Name = "lbl_supplierName";
            this.lbl_supplierName.Size = new System.Drawing.Size(76, 13);
            this.lbl_supplierName.TabIndex = 1;
            this.lbl_supplierName.Text = "Supplier Name";
            // 
            // lbl_supplierSiteName
            // 
            this.lbl_supplierSiteName.AutoSize = true;
            this.lbl_supplierSiteName.Location = new System.Drawing.Point(195, 8);
            this.lbl_supplierSiteName.Name = "lbl_supplierSiteName";
            this.lbl_supplierSiteName.Size = new System.Drawing.Size(97, 13);
            this.lbl_supplierSiteName.TabIndex = 2;
            this.lbl_supplierSiteName.Text = "Supplier Site Name";
            // 
            // lbl_orderNo
            // 
            this.lbl_orderNo.AutoSize = true;
            this.lbl_orderNo.Location = new System.Drawing.Point(420, 8);
            this.lbl_orderNo.Name = "lbl_orderNo";
            this.lbl_orderNo.Size = new System.Drawing.Size(50, 13);
            this.lbl_orderNo.TabIndex = 3;
            this.lbl_orderNo.Text = "Order No";
            // 
            // lbl_requestedDate
            // 
            this.lbl_requestedDate.AutoSize = true;
            this.lbl_requestedDate.Location = new System.Drawing.Point(620, 8);
            this.lbl_requestedDate.Name = "lbl_requestedDate";
            this.lbl_requestedDate.Size = new System.Drawing.Size(85, 13);
            this.lbl_requestedDate.TabIndex = 4;
            this.lbl_requestedDate.Text = "Requested Date";
            // 
            // ShipmentRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_requestedDate);
            this.Controls.Add(this.lbl_orderNo);
            this.Controls.Add(this.lbl_supplierSiteName);
            this.Controls.Add(this.lbl_supplierName);
            this.Controls.Add(this.btn_view);
            this.Name = "ShipmentRow";
            this.Size = new System.Drawing.Size(916, 28);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.Label lbl_supplierName;
        private System.Windows.Forms.Label lbl_supplierSiteName;
        private System.Windows.Forms.Label lbl_orderNo;
        private System.Windows.Forms.Label lbl_requestedDate;
    }
}
