namespace StockManagementSystem.Pages
{
    partial class Inspection
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
            this.pnl_inspection = new System.Windows.Forms.Panel();
            this.inspectionRow_1 = new StockManagementSystem.User_Controls.InspectionRow();
            this.lbl_info = new System.Windows.Forms.Label();
            this.lbl_quality = new System.Windows.Forms.Label();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.lbl_item = new System.Windows.Forms.Label();
            this.btn_send = new System.Windows.Forms.Button();
            this.pnl_inspection.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_inspection
            // 
            this.pnl_inspection.AutoScroll = true;
            this.pnl_inspection.Controls.Add(this.inspectionRow_1);
            this.pnl_inspection.Controls.Add(this.lbl_info);
            this.pnl_inspection.Controls.Add(this.lbl_quality);
            this.pnl_inspection.Controls.Add(this.lbl_quantity);
            this.pnl_inspection.Controls.Add(this.lbl_item);
            this.pnl_inspection.Location = new System.Drawing.Point(12, 217);
            this.pnl_inspection.Name = "pnl_inspection";
            this.pnl_inspection.Size = new System.Drawing.Size(776, 179);
            this.pnl_inspection.TabIndex = 4;
            // 
            // inspectionRow_1
            // 
            this.inspectionRow_1.Location = new System.Drawing.Point(0, 30);
            this.inspectionRow_1.Name = "inspectionRow_1";
            this.inspectionRow_1.Size = new System.Drawing.Size(760, 28);
            this.inspectionRow_1.TabIndex = 32;
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Location = new System.Drawing.Point(544, 5);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(108, 13);
            this.lbl_info.TabIndex = 31;
            this.lbl_info.Text = "Additional Information";
            // 
            // lbl_quality
            // 
            this.lbl_quality.AutoSize = true;
            this.lbl_quality.Location = new System.Drawing.Point(407, 5);
            this.lbl_quality.Name = "lbl_quality";
            this.lbl_quality.Size = new System.Drawing.Size(39, 13);
            this.lbl_quality.TabIndex = 30;
            this.lbl_quality.Text = "Quality";
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Location = new System.Drawing.Point(276, 5);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(46, 13);
            this.lbl_quantity.TabIndex = 29;
            this.lbl_quantity.Text = "Quantity";
            // 
            // lbl_item
            // 
            this.lbl_item.AutoSize = true;
            this.lbl_item.Location = new System.Drawing.Point(3, 5);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(27, 13);
            this.lbl_item.TabIndex = 28;
            this.lbl_item.Text = "Item";
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(357, 402);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(91, 20);
            this.btn_send.TabIndex = 33;
            this.btn_send.Text = "Send To Stores";
            this.btn_send.UseVisualStyleBackColor = true;
            // 
            // Inspection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 709);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.pnl_inspection);
            this.Name = "Inspection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inspection";
            this.pnl_inspection.ResumeLayout(false);
            this.pnl_inspection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_inspection;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.Label lbl_quality;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.Label lbl_item;
        private User_Controls.InspectionRow inspectionRow_1;
        private System.Windows.Forms.Button btn_send;
    }
}