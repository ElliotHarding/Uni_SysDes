namespace StockManagementSystem.Pages
{
    partial class UserInputStringDialog
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
            this.btn_okay = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_text = new System.Windows.Forms.TextBox();
            this.lbl_text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_okay
            // 
            this.btn_okay.Location = new System.Drawing.Point(112, 62);
            this.btn_okay.Name = "btn_okay";
            this.btn_okay.Size = new System.Drawing.Size(75, 23);
            this.btn_okay.TabIndex = 0;
            this.btn_okay.Text = "Okay";
            this.btn_okay.UseVisualStyleBackColor = true;
            this.btn_okay.Click += new System.EventHandler(this.Btn_okay_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(11, 62);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // txt_text
            // 
            this.txt_text.Location = new System.Drawing.Point(36, 36);
            this.txt_text.Name = "txt_text";
            this.txt_text.Size = new System.Drawing.Size(128, 20);
            this.txt_text.TabIndex = 2;
            // 
            // lbl_text
            // 
            this.lbl_text.AutoSize = true;
            this.lbl_text.Location = new System.Drawing.Point(12, 9);
            this.lbl_text.Name = "lbl_text";
            this.lbl_text.Size = new System.Drawing.Size(40, 13);
            this.lbl_text.TabIndex = 3;
            this.lbl_text.Text = "lbl_text";
            // 
            // UserInputStringDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 94);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_text);
            this.Controls.Add(this.txt_text);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_okay);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserInputStringDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter Value";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_okay;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txt_text;
        private System.Windows.Forms.Label lbl_text;
    }
}