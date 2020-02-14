namespace StockManagementSystem.Pages
{
    partial class UserInputParagraphDialog
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
            this.lbl_text = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_okay = new System.Windows.Forms.Button();
            this.txt_userInput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lbl_text
            // 
            this.lbl_text.AutoSize = true;
            this.lbl_text.Location = new System.Drawing.Point(12, 11);
            this.lbl_text.Name = "lbl_text";
            this.lbl_text.Size = new System.Drawing.Size(40, 13);
            this.lbl_text.TabIndex = 6;
            this.lbl_text.Text = "lbl_text";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(310, 136);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // btn_okay
            // 
            this.btn_okay.Location = new System.Drawing.Point(405, 136);
            this.btn_okay.Name = "btn_okay";
            this.btn_okay.Size = new System.Drawing.Size(75, 23);
            this.btn_okay.TabIndex = 4;
            this.btn_okay.Text = "Okay";
            this.btn_okay.UseVisualStyleBackColor = true;
            this.btn_okay.Click += new System.EventHandler(this.Btn_okay_Click);
            // 
            // txt_userInput
            // 
            this.txt_userInput.Location = new System.Drawing.Point(12, 34);
            this.txt_userInput.Name = "txt_userInput";
            this.txt_userInput.Size = new System.Drawing.Size(468, 96);
            this.txt_userInput.TabIndex = 7;
            this.txt_userInput.Text = "txt_userInput";
            // 
            // UserInputParagraphDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 166);
            this.ControlBox = false;
            this.Controls.Add(this.txt_userInput);
            this.Controls.Add(this.lbl_text);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_okay);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserInputParagraphDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter Text";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_text;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_okay;
        private System.Windows.Forms.RichTextBox txt_userInput;
    }
}