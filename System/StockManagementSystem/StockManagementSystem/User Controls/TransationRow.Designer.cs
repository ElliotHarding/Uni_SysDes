namespace StockManagementSystem.User_Controls
{
    partial class TransationRow
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
            this.btn_remove = new System.Windows.Forms.Button();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.txt_productId = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_nNumber = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(896, 5);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(20, 20);
            this.btn_remove.TabIndex = 36;
            this.btn_remove.Text = "X";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.Btn_remove_Click);
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(784, 5);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(50, 20);
            this.txt_quantity.TabIndex = 37;
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(643, 5);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(135, 20);
            this.dateTime.TabIndex = 41;
            // 
            // txt_productId
            // 
            this.txt_productId.Location = new System.Drawing.Point(189, 5);
            this.txt_productId.Name = "txt_productId";
            this.txt_productId.Size = new System.Drawing.Size(180, 20);
            this.txt_productId.TabIndex = 42;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(3, 5);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(180, 20);
            this.txt_name.TabIndex = 43;
            // 
            // txt_nNumber
            // 
            this.txt_nNumber.Location = new System.Drawing.Point(375, 5);
            this.txt_nNumber.Name = "txt_nNumber";
            this.txt_nNumber.Size = new System.Drawing.Size(180, 20);
            this.txt_nNumber.TabIndex = 44;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(840, 5);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(50, 20);
            this.txt_price.TabIndex = 45;
            // 
            // TransationRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_nNumber);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_productId);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.btn_remove);
            this.Name = "TransationRow";
            this.Size = new System.Drawing.Size(920, 28);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.TextBox txt_productId;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_nNumber;
        private System.Windows.Forms.TextBox txt_price;
    }
}
