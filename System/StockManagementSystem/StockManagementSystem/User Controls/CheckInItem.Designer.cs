namespace StockManagementSystem.User_Controls
{
    partial class CheckInItem
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
            this.cInPicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cInQnt = new System.Windows.Forms.NumericUpDown();
            this.lbl_cInName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cInPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cInQnt)).BeginInit();
            this.SuspendLayout();
            // 
            // cInPicture
            // 
            this.cInPicture.Location = new System.Drawing.Point(20, 12);
            this.cInPicture.Margin = new System.Windows.Forms.Padding(1);
            this.cInPicture.Name = "cInPicture";
            this.cInPicture.Size = new System.Drawing.Size(82, 66);
            this.cInPicture.TabIndex = 0;
            this.cInPicture.TabStop = false;
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
            // cInQnt
            // 
            this.cInQnt.Location = new System.Drawing.Point(633, 44);
            this.cInQnt.Margin = new System.Windows.Forms.Padding(1);
            this.cInQnt.Name = "cInQnt";
            this.cInQnt.Size = new System.Drawing.Size(45, 20);
            this.cInQnt.TabIndex = 4;
            // 
            // lbl_cInName
            // 
            this.lbl_cInName.AutoSize = true;
            this.lbl_cInName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cInName.Location = new System.Drawing.Point(110, 31);
            this.lbl_cInName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_cInName.Name = "lbl_cInName";
            this.lbl_cInName.Size = new System.Drawing.Size(86, 31);
            this.lbl_cInName.TabIndex = 6;
            this.lbl_cInName.Text = "label3";
            // 
            // CheckInItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_cInName);
            this.Controls.Add(this.cInQnt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cInPicture);
            this.Name = "CheckInItem";
            this.Size = new System.Drawing.Size(862, 100);
            ((System.ComponentModel.ISupportInitialize)(this.cInPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cInQnt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cInPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown cInQnt;
        private System.Windows.Forms.Label lbl_cInName;
    }
}
