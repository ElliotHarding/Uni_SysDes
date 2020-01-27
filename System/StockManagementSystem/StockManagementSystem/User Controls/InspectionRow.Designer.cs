namespace StockManagementSystem.User_Controls
{
    partial class InspectionRow
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
            this.btn_find_1 = new System.Windows.Forms.Button();
            this.txt_info_1 = new System.Windows.Forms.TextBox();
            this.txt_quality_1 = new System.Windows.Forms.TextBox();
            this.txt_quantity_1 = new System.Windows.Forms.TextBox();
            this.txt_item_1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_find_1
            // 
            this.btn_find_1.Location = new System.Drawing.Point(174, 3);
            this.btn_find_1.Name = "btn_find_1";
            this.btn_find_1.Size = new System.Drawing.Size(75, 20);
            this.btn_find_1.TabIndex = 28;
            this.btn_find_1.Text = "Find";
            this.btn_find_1.UseVisualStyleBackColor = true;
            // 
            // txt_info_1
            // 
            this.txt_info_1.Location = new System.Drawing.Point(544, 4);
            this.txt_info_1.Name = "txt_info_1";
            this.txt_info_1.Size = new System.Drawing.Size(209, 20);
            this.txt_info_1.TabIndex = 25;
            // 
            // txt_quality_1
            // 
            this.txt_quality_1.Location = new System.Drawing.Point(407, 4);
            this.txt_quality_1.Name = "txt_quality_1";
            this.txt_quality_1.Size = new System.Drawing.Size(111, 20);
            this.txt_quality_1.TabIndex = 24;
            // 
            // txt_quantity_1
            // 
            this.txt_quantity_1.Location = new System.Drawing.Point(276, 4);
            this.txt_quantity_1.Name = "txt_quantity_1";
            this.txt_quantity_1.Size = new System.Drawing.Size(111, 20);
            this.txt_quantity_1.TabIndex = 26;
            // 
            // txt_item_1
            // 
            this.txt_item_1.Location = new System.Drawing.Point(3, 3);
            this.txt_item_1.Name = "txt_item_1";
            this.txt_item_1.Size = new System.Drawing.Size(164, 20);
            this.txt_item_1.TabIndex = 27;
            // 
            // InspectionRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_find_1);
            this.Controls.Add(this.txt_info_1);
            this.Controls.Add(this.txt_quality_1);
            this.Controls.Add(this.txt_quantity_1);
            this.Controls.Add(this.txt_item_1);
            this.Name = "InspectionRow";
            this.Size = new System.Drawing.Size(760, 28);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_find_1;
        private System.Windows.Forms.TextBox txt_info_1;
        private System.Windows.Forms.TextBox txt_quality_1;
        private System.Windows.Forms.TextBox txt_quantity_1;
        private System.Windows.Forms.TextBox txt_item_1;
    }
}
