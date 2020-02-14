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
            this.pnl_invoice = new System.Windows.Forms.Panel();
            this.btn_create_from_log = new System.Windows.Forms.Button();
            this.cmb_department = new System.Windows.Forms.ComboBox();
            this.lbl_department = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_charge = new System.Windows.Forms.Label();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.lbl_item = new System.Windows.Forms.Label();
            this.btn_add_row = new System.Windows.Forms.Button();
            this.btn_send_invoice = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_nNumber = new System.Windows.Forms.Label();
            this.lbl_ProductId = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnl_invoice
            // 
            this.pnl_invoice.AutoScroll = true;
            this.pnl_invoice.Location = new System.Drawing.Point(42, 211);
            this.pnl_invoice.Name = "pnl_invoice";
            this.pnl_invoice.Size = new System.Drawing.Size(938, 320);
            this.pnl_invoice.TabIndex = 39;
            // 
            // btn_create_from_log
            // 
            this.btn_create_from_log.Location = new System.Drawing.Point(474, 119);
            this.btn_create_from_log.Name = "btn_create_from_log";
            this.btn_create_from_log.Size = new System.Drawing.Size(103, 22);
            this.btn_create_from_log.TabIndex = 38;
            this.btn_create_from_log.Text = "Fill From Log";
            this.btn_create_from_log.UseVisualStyleBackColor = true;
            this.btn_create_from_log.Click += new System.EventHandler(this.Btn_create_from_log_Click);
            // 
            // cmb_department
            // 
            this.cmb_department.FormattingEnabled = true;
            this.cmb_department.Location = new System.Drawing.Point(297, 92);
            this.cmb_department.Name = "cmb_department";
            this.cmb_department.Size = new System.Drawing.Size(147, 21);
            this.cmb_department.TabIndex = 37;
            // 
            // lbl_department
            // 
            this.lbl_department.AutoSize = true;
            this.lbl_department.Location = new System.Drawing.Point(294, 76);
            this.lbl_department.Name = "lbl_department";
            this.lbl_department.Size = new System.Drawing.Size(114, 13);
            this.lbl_department.TabIndex = 36;
            this.lbl_department.Text = "Department Taken For";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(684, 195);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(30, 13);
            this.lbl_date.TabIndex = 45;
            this.lbl_date.Text = "Date";
            // 
            // lbl_charge
            // 
            this.lbl_charge.AutoSize = true;
            this.lbl_charge.Location = new System.Drawing.Point(881, 195);
            this.lbl_charge.Name = "lbl_charge";
            this.lbl_charge.Size = new System.Drawing.Size(41, 13);
            this.lbl_charge.TabIndex = 44;
            this.lbl_charge.Text = "Charge";
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Location = new System.Drawing.Point(826, 196);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(46, 13);
            this.lbl_quantity.TabIndex = 43;
            this.lbl_quantity.Text = "Quantity";
            // 
            // lbl_item
            // 
            this.lbl_item.AutoSize = true;
            this.lbl_item.Location = new System.Drawing.Point(46, 196);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(27, 13);
            this.lbl_item.TabIndex = 42;
            this.lbl_item.Text = "Item";
            // 
            // btn_add_row
            // 
            this.btn_add_row.Location = new System.Drawing.Point(130, 537);
            this.btn_add_row.Name = "btn_add_row";
            this.btn_add_row.Size = new System.Drawing.Size(82, 22);
            this.btn_add_row.TabIndex = 41;
            this.btn_add_row.Text = "Add Row";
            this.btn_add_row.UseVisualStyleBackColor = true;
            this.btn_add_row.Click += new System.EventHandler(this.Btn_add_row_Click);
            // 
            // btn_send_invoice
            // 
            this.btn_send_invoice.Location = new System.Drawing.Point(438, 537);
            this.btn_send_invoice.Name = "btn_send_invoice";
            this.btn_send_invoice.Size = new System.Drawing.Size(139, 22);
            this.btn_send_invoice.TabIndex = 40;
            this.btn_send_invoice.Text = "Create Invoice";
            this.btn_send_invoice.UseVisualStyleBackColor = true;
            this.btn_send_invoice.Click += new System.EventHandler(this.Btn_send_invoice_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(42, 537);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(82, 23);
            this.btn_clear.TabIndex = 46;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.Btn_clear_Click);
            // 
            // dateFrom
            // 
            this.dateFrom.Location = new System.Drawing.Point(450, 93);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(147, 20);
            this.dateFrom.TabIndex = 47;
            // 
            // dateTo
            // 
            this.dateTo.Location = new System.Drawing.Point(603, 93);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(147, 20);
            this.dateTo.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(447, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Date from";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(600, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Date to";
            // 
            // lbl_nNumber
            // 
            this.lbl_nNumber.AutoSize = true;
            this.lbl_nNumber.Location = new System.Drawing.Point(416, 196);
            this.lbl_nNumber.Name = "lbl_nNumber";
            this.lbl_nNumber.Size = new System.Drawing.Size(55, 13);
            this.lbl_nNumber.TabIndex = 51;
            this.lbl_nNumber.Text = "N Number";
            // 
            // lbl_ProductId
            // 
            this.lbl_ProductId.AutoSize = true;
            this.lbl_ProductId.Location = new System.Drawing.Point(230, 195);
            this.lbl_ProductId.Name = "lbl_ProductId";
            this.lbl_ProductId.Size = new System.Drawing.Size(56, 13);
            this.lbl_ProductId.TabIndex = 52;
            this.lbl_ProductId.Text = "Product Id";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(881, 542);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(92, 13);
            this.lbl_total.TabIndex = 53;
            this.lbl_total.Text = "Total Charge :  £0";
            // 
            // Invoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_ProductId);
            this.Controls.Add(this.lbl_nNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.pnl_invoice);
            this.Controls.Add(this.btn_create_from_log);
            this.Controls.Add(this.cmb_department);
            this.Controls.Add(this.lbl_department);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_charge);
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.lbl_item);
            this.Controls.Add(this.btn_add_row);
            this.Controls.Add(this.btn_send_invoice);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 720);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 720);
            this.Name = "Invoices";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoices";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_invoice;
        private System.Windows.Forms.Button btn_create_from_log;
        private System.Windows.Forms.ComboBox cmb_department;
        private System.Windows.Forms.Label lbl_department;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_charge;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.Label lbl_item;
        private System.Windows.Forms.Button btn_add_row;
        private System.Windows.Forms.Button btn_send_invoice;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_nNumber;
        private System.Windows.Forms.Label lbl_ProductId;
        private System.Windows.Forms.Label lbl_total;
    }
}