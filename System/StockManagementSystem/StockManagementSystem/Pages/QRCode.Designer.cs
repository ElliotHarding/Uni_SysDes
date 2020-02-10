namespace StockManagementSystem.Pages
{
    partial class QRCode
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
            this.btn_input = new System.Windows.Forms.Button();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.btn_output = new System.Windows.Forms.Button();
            this.txt_output = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_qr)).BeginInit();
            this.SuspendLayout();
            // 
            // pbox_qr
            // 
            this.pbox_qr.BackColor = System.Drawing.Color.White;
            this.pbox_qr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbox_qr.Location = new System.Drawing.Point(176, 182);
            this.pbox_qr.Name = "pbox_qr";
            this.pbox_qr.Size = new System.Drawing.Size(400, 400);
            this.pbox_qr.TabIndex = 0;
            this.pbox_qr.TabStop = false;
            // 
            // btn_input
            // 
            this.btn_input.Location = new System.Drawing.Point(348, 142);
            this.btn_input.Name = "btn_input";
            this.btn_input.Size = new System.Drawing.Size(75, 23);
            this.btn_input.TabIndex = 1;
            this.btn_input.Text = "Generate";
            this.btn_input.UseVisualStyleBackColor = true;
            this.btn_input.Click += new System.EventHandler(this.Btn_input_Click);
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(176, 116);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(400, 20);
            this.txt_input.TabIndex = 2;
            // 
            // btn_output
            // 
            this.btn_output.Location = new System.Drawing.Point(348, 624);
            this.btn_output.Name = "btn_output";
            this.btn_output.Size = new System.Drawing.Size(75, 23);
            this.btn_output.TabIndex = 1;
            this.btn_output.Text = "Read";
            this.btn_output.UseVisualStyleBackColor = true;
            this.btn_output.Click += new System.EventHandler(this.Btn_output_Click);
            // 
            // txt_output
            // 
            this.txt_output.Location = new System.Drawing.Point(176, 598);
            this.txt_output.Name = "txt_output";
            this.txt_output.Size = new System.Drawing.Size(400, 20);
            this.txt_output.TabIndex = 2;
            // 
            // QRCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 709);
            this.Controls.Add(this.txt_output);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.btn_output);
            this.Controls.Add(this.btn_input);
            this.Controls.Add(this.pbox_qr);
            this.Name = "QRCode";
            this.Text = "QRCode";
            ((System.ComponentModel.ISupportInitialize)(this.pbox_qr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbox_qr;
        private System.Windows.Forms.Button btn_input;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.Button btn_output;
        private System.Windows.Forms.TextBox txt_output;
    }
}