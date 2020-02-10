namespace StockManagementSystem.User_Controls
{
    partial class BasketRow
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
            this.pb_image = new System.Windows.Forms.PictureBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.c_quantitiy = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_remove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_quantitiy)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_image
            // 
            this.pb_image.Location = new System.Drawing.Point(4, 4);
            this.pb_image.Name = "pb_image";
            this.pb_image.Size = new System.Drawing.Size(49, 40);
            this.pb_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_image.TabIndex = 0;
            this.pb_image.TabStop = false;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(59, 17);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(45, 16);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Name";
            // 
            // c_quantitiy
            // 
            this.c_quantitiy.Location = new System.Drawing.Point(835, 17);
            this.c_quantitiy.Margin = new System.Windows.Forms.Padding(1);
            this.c_quantitiy.Name = "c_quantitiy";
            this.c_quantitiy.Size = new System.Drawing.Size(45, 20);
            this.c_quantitiy.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(787, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quantity";
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(884, 14);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(23, 23);
            this.btn_remove.TabIndex = 7;
            this.btn_remove.Text = "X";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // BasketRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.c_quantitiy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.pb_image);
            this.Name = "BasketRow";
            this.Size = new System.Drawing.Size(910, 50);
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_quantitiy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_image;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.NumericUpDown c_quantitiy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_remove;
    }
}
