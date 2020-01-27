namespace StockManagementSystem.User_Controls
{
    partial class CheckoutItem
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.prodQnt = new System.Windows.Forms.NumericUpDown();
            this.lbl_prodName = new System.Windows.Forms.Label();
            this.lblRemove = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodQnt)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(20, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 66);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(605, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Qnt.";
            // 
            // prodQnt
            // 
            this.prodQnt.Location = new System.Drawing.Point(633, 44);
            this.prodQnt.Margin = new System.Windows.Forms.Padding(1);
            this.prodQnt.Name = "prodQnt";
            this.prodQnt.Size = new System.Drawing.Size(45, 20);
            this.prodQnt.TabIndex = 4;
            // 
            // lbl_prodName
            // 
            this.lbl_prodName.AutoSize = true;
            this.lbl_prodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prodName.Location = new System.Drawing.Point(110, 31);
            this.lbl_prodName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_prodName.Name = "lbl_prodName";
            this.lbl_prodName.Size = new System.Drawing.Size(86, 31);
            this.lbl_prodName.TabIndex = 6;
            this.lbl_prodName.Text = "label3";
            // 
            // lblRemove
            // 
            this.lblRemove.AutoSize = true;
            this.lblRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemove.LinkColor = System.Drawing.Color.Red;
            this.lblRemove.Location = new System.Drawing.Point(742, 48);
            this.lblRemove.Name = "lblRemove";
            this.lblRemove.Size = new System.Drawing.Size(66, 16);
            this.lblRemove.TabIndex = 7;
            this.lblRemove.TabStop = true;
            this.lblRemove.Text = "Remove";
            this.lblRemove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblRemove_LinkClicked);
            // 
            // CheckoutItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblRemove);
            this.Controls.Add(this.lbl_prodName);
            this.Controls.Add(this.prodQnt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CheckoutItem";
            this.Size = new System.Drawing.Size(862, 100);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodQnt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown prodQnt;
        private System.Windows.Forms.Label lbl_prodName;
        private System.Windows.Forms.LinkLabel lblRemove;
    }
}
