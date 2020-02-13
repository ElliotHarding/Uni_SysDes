﻿namespace StockManagementSystem.Pages
{
    partial class Settings
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
            this.btn_setPassword = new System.Windows.Forms.Button();
            this.tb_newPassword1 = new System.Windows.Forms.TextBox();
            this.tb_newPassword2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_stopSystem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_setPassword
            // 
            this.btn_setPassword.Location = new System.Drawing.Point(449, 405);
            this.btn_setPassword.Name = "btn_setPassword";
            this.btn_setPassword.Size = new System.Drawing.Size(118, 23);
            this.btn_setPassword.TabIndex = 0;
            this.btn_setPassword.Text = "Set New Password";
            this.btn_setPassword.UseVisualStyleBackColor = true;
            this.btn_setPassword.Click += new System.EventHandler(this.btn_setPassword_Click);
            // 
            // tb_newPassword1
            // 
            this.tb_newPassword1.Location = new System.Drawing.Point(427, 320);
            this.tb_newPassword1.Name = "tb_newPassword1";
            this.tb_newPassword1.Size = new System.Drawing.Size(163, 20);
            this.tb_newPassword1.TabIndex = 2;
            this.tb_newPassword1.UseSystemPasswordChar = true;
            // 
            // tb_newPassword2
            // 
            this.tb_newPassword2.Location = new System.Drawing.Point(427, 369);
            this.tb_newPassword2.Name = "tb_newPassword2";
            this.tb_newPassword2.Size = new System.Drawing.Size(163, 20);
            this.tb_newPassword2.TabIndex = 3;
            this.tb_newPassword2.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "New Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(427, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "New Password";
            // 
            // btn_stopSystem
            // 
            this.btn_stopSystem.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_stopSystem.Location = new System.Drawing.Point(449, 143);
            this.btn_stopSystem.Name = "btn_stopSystem";
            this.btn_stopSystem.Size = new System.Drawing.Size(118, 23);
            this.btn_stopSystem.TabIndex = 37;
            this.btn_stopSystem.Text = "Stop System";
            this.btn_stopSystem.UseVisualStyleBackColor = true;
            this.btn_stopSystem.Click += new System.EventHandler(this.btn_stopSystem_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.btn_stopSystem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_newPassword2);
            this.Controls.Add(this.tb_newPassword1);
            this.Controls.Add(this.btn_setPassword);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 720);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 720);
            this.Name = "Settings";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_setPassword;
        private System.Windows.Forms.TextBox tb_newPassword1;
        private System.Windows.Forms.TextBox tb_newPassword2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_stopSystem;
    }
}