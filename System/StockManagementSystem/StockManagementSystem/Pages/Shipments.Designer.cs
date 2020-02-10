namespace StockManagementSystem.Pages
{
    partial class Shipments
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.pnl_shipments = new System.Windows.Forms.Panel();
            this.btn_viewShipments = new System.Windows.Forms.Button();
            this.btn_newShipment = new System.Windows.Forms.Button();
            this.btn_addExpectedDelivery = new System.Windows.Forms.Button();
            this.lbl_requestedDate = new System.Windows.Forms.Label();
            this.lbl_orderNo = new System.Windows.Forms.Label();
            this.lbl_supplierSiteName = new System.Windows.Forms.Label();
            this.lbl_supplierName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(464, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Date to";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "Date from";
            // 
            // dateTo
            // 
            this.dateTo.Location = new System.Drawing.Point(467, 111);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(147, 20);
            this.dateTo.TabIndex = 66;
            // 
            // dateFrom
            // 
            this.dateFrom.Location = new System.Drawing.Point(314, 111);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(147, 20);
            this.dateFrom.TabIndex = 65;
            // 
            // pnl_shipments
            // 
            this.pnl_shipments.AutoScroll = true;
            this.pnl_shipments.Location = new System.Drawing.Point(35, 185);
            this.pnl_shipments.Name = "pnl_shipments";
            this.pnl_shipments.Size = new System.Drawing.Size(938, 400);
            this.pnl_shipments.TabIndex = 57;
            // 
            // btn_viewShipments
            // 
            this.btn_viewShipments.Location = new System.Drawing.Point(620, 110);
            this.btn_viewShipments.Name = "btn_viewShipments";
            this.btn_viewShipments.Size = new System.Drawing.Size(103, 22);
            this.btn_viewShipments.TabIndex = 56;
            this.btn_viewShipments.Text = "View";
            this.btn_viewShipments.UseVisualStyleBackColor = true;
            this.btn_viewShipments.Click += new System.EventHandler(this.Btn_viewShipments_Click);
            // 
            // btn_newShipment
            // 
            this.btn_newShipment.Location = new System.Drawing.Point(383, 34);
            this.btn_newShipment.Name = "btn_newShipment";
            this.btn_newShipment.Size = new System.Drawing.Size(135, 22);
            this.btn_newShipment.TabIndex = 69;
            this.btn_newShipment.Text = "Add New Shipment";
            this.btn_newShipment.UseVisualStyleBackColor = true;
            this.btn_newShipment.Click += new System.EventHandler(this.Btn_newShipment_Click);
            // 
            // btn_addExpectedDelivery
            // 
            this.btn_addExpectedDelivery.Location = new System.Drawing.Point(524, 34);
            this.btn_addExpectedDelivery.Name = "btn_addExpectedDelivery";
            this.btn_addExpectedDelivery.Size = new System.Drawing.Size(135, 22);
            this.btn_addExpectedDelivery.TabIndex = 70;
            this.btn_addExpectedDelivery.Text = "Add Expected Delivery";
            this.btn_addExpectedDelivery.UseVisualStyleBackColor = true;
            this.btn_addExpectedDelivery.Click += new System.EventHandler(this.btn_addExpectedDelivery_Click);
            // 
            // lbl_requestedDate
            // 
            this.lbl_requestedDate.AutoSize = true;
            this.lbl_requestedDate.Location = new System.Drawing.Point(653, 169);
            this.lbl_requestedDate.Name = "lbl_requestedDate";
            this.lbl_requestedDate.Size = new System.Drawing.Size(85, 13);
            this.lbl_requestedDate.TabIndex = 74;
            this.lbl_requestedDate.Text = "Requested Date";
            // 
            // lbl_orderNo
            // 
            this.lbl_orderNo.AutoSize = true;
            this.lbl_orderNo.Location = new System.Drawing.Point(453, 169);
            this.lbl_orderNo.Name = "lbl_orderNo";
            this.lbl_orderNo.Size = new System.Drawing.Size(50, 13);
            this.lbl_orderNo.TabIndex = 73;
            this.lbl_orderNo.Text = "Order No";
            // 
            // lbl_supplierSiteName
            // 
            this.lbl_supplierSiteName.AutoSize = true;
            this.lbl_supplierSiteName.Location = new System.Drawing.Point(228, 169);
            this.lbl_supplierSiteName.Name = "lbl_supplierSiteName";
            this.lbl_supplierSiteName.Size = new System.Drawing.Size(97, 13);
            this.lbl_supplierSiteName.TabIndex = 72;
            this.lbl_supplierSiteName.Text = "Supplier Site Name";
            // 
            // lbl_supplierName
            // 
            this.lbl_supplierName.AutoSize = true;
            this.lbl_supplierName.Location = new System.Drawing.Point(46, 169);
            this.lbl_supplierName.Name = "lbl_supplierName";
            this.lbl_supplierName.Size = new System.Drawing.Size(76, 13);
            this.lbl_supplierName.TabIndex = 71;
            this.lbl_supplierName.Text = "Supplier Name";
            // 
            // Shipments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.lbl_requestedDate);
            this.Controls.Add(this.lbl_orderNo);
            this.Controls.Add(this.lbl_supplierSiteName);
            this.Controls.Add(this.lbl_supplierName);
            this.Controls.Add(this.btn_addExpectedDelivery);
            this.Controls.Add(this.btn_newShipment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.pnl_shipments);
            this.Controls.Add(this.btn_viewShipments);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 720);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 720);
            this.Name = "Shipments";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shipments";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.Panel pnl_shipments;
        private System.Windows.Forms.Button btn_viewShipments;
        private System.Windows.Forms.Button btn_newShipment;
        private System.Windows.Forms.Button btn_addExpectedDelivery;
        private System.Windows.Forms.Label lbl_requestedDate;
        private System.Windows.Forms.Label lbl_orderNo;
        private System.Windows.Forms.Label lbl_supplierSiteName;
        private System.Windows.Forms.Label lbl_supplierName;
    }
}