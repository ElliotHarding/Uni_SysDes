namespace StockManagementSystem.Pages
{
    partial class Invoices
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
            this.lbl_department = new System.Windows.Forms.Label();
            this.cmb_department = new System.Windows.Forms.ComboBox();
            this.btn_create_from_log = new System.Windows.Forms.Button();
            this.pnl_invoice = new System.Windows.Forms.Panel();
            this.inspectionRow_1 = new StockManagementSystem.User_Controls.InspectionRow();
            this.btn_send_invoice = new System.Windows.Forms.Button();
            this.btn_add_row = new System.Windows.Forms.Button();
            this.lbl_info = new System.Windows.Forms.Label();
            this.lbl_charge = new System.Windows.Forms.Label();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.lbl_item = new System.Windows.Forms.Label();
            this.pnl_invoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_department
            // 
            this.lbl_department.AutoSize = true;
            this.lbl_department.Location = new System.Drawing.Point(249, 190);
            this.lbl_department.Name = "lbl_department";
            this.lbl_department.Size = new System.Drawing.Size(114, 13);
            this.lbl_department.TabIndex = 0;
            this.lbl_department.Text = "Department Taken For";
            // 
            // cmb_department
            // 
            this.cmb_department.FormattingEnabled = true;
            this.cmb_department.Location = new System.Drawing.Point(252, 206);
            this.cmb_department.Name = "cmb_department";
            this.cmb_department.Size = new System.Drawing.Size(147, 21);
            this.cmb_department.TabIndex = 1;
            // 
            // btn_create_from_log
            // 
            this.btn_create_from_log.Location = new System.Drawing.Point(415, 205);
            this.btn_create_from_log.Name = "btn_create_from_log";
            this.btn_create_from_log.Size = new System.Drawing.Size(103, 22);
            this.btn_create_from_log.TabIndex = 2;
            this.btn_create_from_log.Text = "Create From Log";
            this.btn_create_from_log.UseVisualStyleBackColor = true;
            // 
            // pnl_invoice
            // 
            this.pnl_invoice.AutoScroll = true;
            this.pnl_invoice.Controls.Add(this.inspectionRow_1);
            this.pnl_invoice.Location = new System.Drawing.Point(12, 256);
            this.pnl_invoice.Name = "pnl_invoice";
            this.pnl_invoice.Size = new System.Drawing.Size(772, 160);
            this.pnl_invoice.TabIndex = 3;
            // 
            // inspectionRow_1
            // 
            this.inspectionRow_1.Location = new System.Drawing.Point(0, 3);
            this.inspectionRow_1.Name = "inspectionRow_1";
            this.inspectionRow_1.Size = new System.Drawing.Size(760, 28);
            this.inspectionRow_1.TabIndex = 0;
            // 
            // btn_send_invoice
            // 
            this.btn_send_invoice.Location = new System.Drawing.Point(332, 558);
            this.btn_send_invoice.Name = "btn_send_invoice";
            this.btn_send_invoice.Size = new System.Drawing.Size(139, 22);
            this.btn_send_invoice.TabIndex = 4;
            this.btn_send_invoice.Text = "Create and Send Invoice";
            this.btn_send_invoice.UseVisualStyleBackColor = true;
            // 
            // btn_add_row
            // 
            this.btn_add_row.Location = new System.Drawing.Point(669, 206);
            this.btn_add_row.Name = "btn_add_row";
            this.btn_add_row.Size = new System.Drawing.Size(103, 22);
            this.btn_add_row.TabIndex = 5;
            this.btn_add_row.Text = "Add Row";
            this.btn_add_row.UseVisualStyleBackColor = true;
            this.btn_add_row.Click += new System.EventHandler(this.Btn_add_row_Click);
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Location = new System.Drawing.Point(555, 241);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(108, 13);
            this.lbl_info.TabIndex = 35;
            this.lbl_info.Text = "Additional Information";
            // 
            // lbl_charge
            // 
            this.lbl_charge.AutoSize = true;
            this.lbl_charge.Location = new System.Drawing.Point(418, 241);
            this.lbl_charge.Name = "lbl_charge";
            this.lbl_charge.Size = new System.Drawing.Size(41, 13);
            this.lbl_charge.TabIndex = 34;
            this.lbl_charge.Text = "Charge";
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Location = new System.Drawing.Point(287, 241);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(46, 13);
            this.lbl_quantity.TabIndex = 33;
            this.lbl_quantity.Text = "Quantity";
            // 
            // lbl_item
            // 
            this.lbl_item.AutoSize = true;
            this.lbl_item.Location = new System.Drawing.Point(14, 241);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(27, 13);
            this.lbl_item.TabIndex = 32;
            this.lbl_item.Text = "Item";
            // 
            // Invoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 709);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.lbl_charge);
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.lbl_item);
            this.Controls.Add(this.btn_add_row);
            this.Controls.Add(this.btn_send_invoice);
            this.Controls.Add(this.pnl_invoice);
            this.Controls.Add(this.btn_create_from_log);
            this.Controls.Add(this.cmb_department);
            this.Controls.Add(this.lbl_department);
            this.Name = "Invoices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoices";
            this.pnl_invoice.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_department;
        private System.Windows.Forms.ComboBox cmb_department;
        private System.Windows.Forms.Button btn_create_from_log;
        private System.Windows.Forms.Panel pnl_invoice;
        private User_Controls.InspectionRow inspectionRow_1;
        private System.Windows.Forms.Button btn_send_invoice;
        private System.Windows.Forms.Button btn_add_row;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.Label lbl_charge;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.Label lbl_item;
    }
}