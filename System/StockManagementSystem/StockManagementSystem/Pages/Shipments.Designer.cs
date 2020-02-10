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
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(521, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Date to";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "Date from";
            // 
            // dateTo
            // 
            this.dateTo.Location = new System.Drawing.Point(524, 115);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(147, 20);
            this.dateTo.TabIndex = 66;
            // 
            // dateFrom
            // 
            this.dateFrom.Location = new System.Drawing.Point(371, 115);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(147, 20);
            this.dateFrom.TabIndex = 65;
            // 
            // pnl_shipments
            // 
            this.pnl_shipments.AutoScroll = true;
            this.pnl_shipments.Location = new System.Drawing.Point(35, 185);
            this.pnl_shipments.Name = "pnl_shipments";
            this.pnl_shipments.Size = new System.Drawing.Size(938, 368);
            this.pnl_shipments.TabIndex = 57;
            // 
            // btn_viewShipments
            // 
            this.btn_viewShipments.Location = new System.Drawing.Point(467, 141);
            this.btn_viewShipments.Name = "btn_viewShipments";
            this.btn_viewShipments.Size = new System.Drawing.Size(103, 22);
            this.btn_viewShipments.TabIndex = 56;
            this.btn_viewShipments.Text = "View";
            this.btn_viewShipments.UseVisualStyleBackColor = true;
            this.btn_viewShipments.Click += new System.EventHandler(this.Btn_viewShipments_Click);
            // 
            // btn_newShipment
            // 
            this.btn_newShipment.Location = new System.Drawing.Point(463, 33);
            this.btn_newShipment.Name = "btn_newShipment";
            this.btn_newShipment.Size = new System.Drawing.Size(119, 22);
            this.btn_newShipment.TabIndex = 69;
            this.btn_newShipment.Text = "Add New Shipment";
            this.btn_newShipment.UseVisualStyleBackColor = true;
            this.btn_newShipment.Click += new System.EventHandler(this.Btn_newShipment_Click);
            // 
            // Shipments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
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
    }
}