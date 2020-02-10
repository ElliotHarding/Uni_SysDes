namespace StockManagementSystem.Pages
{
    partial class QRCodeDisplay
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
            this.pbox_qr = new System.Windows.Forms.PictureBox();
            this.btn_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_qr)).BeginInit();
            this.SuspendLayout();
            // 
            // pbox_qr
            // 
            this.pbox_qr.BackColor = System.Drawing.Color.White;
            this.pbox_qr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbox_qr.Location = new System.Drawing.Point(12, 12);
            this.pbox_qr.Name = "pbox_qr";
            this.pbox_qr.Size = new System.Drawing.Size(400, 400);
            this.pbox_qr.TabIndex = 1;
            this.pbox_qr.TabStop = false;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(175, 418);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.Btn_save_Click);
            // 
            // QRCodeDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 451);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.pbox_qr);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QRCodeDisplay";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR Code";
            ((System.ComponentModel.ISupportInitialize)(this.pbox_qr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbox_qr;
        private System.Windows.Forms.Button btn_save;
    }
}