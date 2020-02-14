namespace StockManagementSystem.User_Controls
{
    partial class TextfieldRow
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
            this.txt_text = new System.Windows.Forms.TextBox();
            this.btn_remove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_text
            // 
            this.txt_text.Location = new System.Drawing.Point(4, 4);
            this.txt_text.Name = "txt_text";
            this.txt_text.Size = new System.Drawing.Size(145, 20);
            this.txt_text.TabIndex = 0;
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(154, 2);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(23, 23);
            this.btn_remove.TabIndex = 1;
            this.btn_remove.Text = "X";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.Btn_remove_Click);
            // 
            // TextfieldRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.txt_text);
            this.Name = "TextfieldRow";
            this.Size = new System.Drawing.Size(180, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_text;
        private System.Windows.Forms.Button btn_remove;
    }
}
