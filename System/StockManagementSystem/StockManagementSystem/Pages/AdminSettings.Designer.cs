namespace StockManagementSystem.Pages
{
    partial class AdminSettings
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
            this.cb_privilege = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.btn_addUser = new System.Windows.Forms.Button();
            this.lbl_departments = new System.Windows.Forms.Label();
            this.btn_updateDepartments = new System.Windows.Forms.Button();
            this.pnl_departments = new System.Windows.Forms.Panel();
            this.btn_addDepartment = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_newPassword2 = new System.Windows.Forms.TextBox();
            this.tb_newPassword1 = new System.Windows.Forms.TextBox();
            this.btn_setPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_privilege
            // 
            this.cb_privilege.FormattingEnabled = true;
            this.cb_privilege.Items.AddRange(new object[] {
            "admin",
            "staff"});
            this.cb_privilege.Location = new System.Drawing.Point(228, 365);
            this.cb_privilege.Margin = new System.Windows.Forms.Padding(2);
            this.cb_privilege.Name = "cb_privilege";
            this.cb_privilege.Size = new System.Drawing.Size(226, 21);
            this.cb_privilege.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 348);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Privilege";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 294);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Password";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(228, 245);
            this.Username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(55, 13);
            this.Username.TabIndex = 20;
            this.Username.Text = "Username";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(228, 311);
            this.txt_password.Margin = new System.Windows.Forms.Padding(2);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(226, 20);
            this.txt_password.TabIndex = 19;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(228, 261);
            this.txt_username.Margin = new System.Windows.Forms.Padding(2);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(226, 20);
            this.txt_username.TabIndex = 18;
            // 
            // btn_addUser
            // 
            this.btn_addUser.Location = new System.Drawing.Point(231, 398);
            this.btn_addUser.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addUser.Name = "btn_addUser";
            this.btn_addUser.Size = new System.Drawing.Size(87, 26);
            this.btn_addUser.TabIndex = 17;
            this.btn_addUser.Text = "Add New User";
            this.btn_addUser.UseVisualStyleBackColor = true;
            this.btn_addUser.Click += new System.EventHandler(this.Btn_addUser_Click);
            // 
            // lbl_departments
            // 
            this.lbl_departments.AutoSize = true;
            this.lbl_departments.Location = new System.Drawing.Point(540, 238);
            this.lbl_departments.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_departments.Name = "lbl_departments";
            this.lbl_departments.Size = new System.Drawing.Size(67, 13);
            this.lbl_departments.TabIndex = 25;
            this.lbl_departments.Text = "Departments";
            // 
            // btn_updateDepartments
            // 
            this.btn_updateDepartments.Location = new System.Drawing.Point(574, 407);
            this.btn_updateDepartments.Margin = new System.Windows.Forms.Padding(2);
            this.btn_updateDepartments.Name = "btn_updateDepartments";
            this.btn_updateDepartments.Size = new System.Drawing.Size(132, 26);
            this.btn_updateDepartments.TabIndex = 26;
            this.btn_updateDepartments.Text = "Update Departments";
            this.btn_updateDepartments.UseVisualStyleBackColor = true;
            this.btn_updateDepartments.Click += new System.EventHandler(this.Btn_updateDepartments_Click);
            // 
            // pnl_departments
            // 
            this.pnl_departments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_departments.Location = new System.Drawing.Point(543, 254);
            this.pnl_departments.Name = "pnl_departments";
            this.pnl_departments.Size = new System.Drawing.Size(197, 150);
            this.pnl_departments.TabIndex = 27;
            // 
            // btn_addDepartment
            // 
            this.btn_addDepartment.Location = new System.Drawing.Point(745, 254);
            this.btn_addDepartment.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addDepartment.Name = "btn_addDepartment";
            this.btn_addDepartment.Size = new System.Drawing.Size(26, 26);
            this.btn_addDepartment.TabIndex = 28;
            this.btn_addDepartment.Text = "+";
            this.btn_addDepartment.UseVisualStyleBackColor = true;
            this.btn_addDepartment.Click += new System.EventHandler(this.Btn_addDepartment_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "New Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "New Password";
            // 
            // tb_newPassword2
            // 
            this.tb_newPassword2.Location = new System.Drawing.Point(259, 140);
            this.tb_newPassword2.Name = "tb_newPassword2";
            this.tb_newPassword2.Size = new System.Drawing.Size(163, 20);
            this.tb_newPassword2.TabIndex = 31;
            this.tb_newPassword2.UseSystemPasswordChar = true;
            // 
            // tb_newPassword1
            // 
            this.tb_newPassword1.Location = new System.Drawing.Point(259, 91);
            this.tb_newPassword1.Name = "tb_newPassword1";
            this.tb_newPassword1.Size = new System.Drawing.Size(163, 20);
            this.tb_newPassword1.TabIndex = 30;
            this.tb_newPassword1.UseSystemPasswordChar = true;
            // 
            // btn_setPassword
            // 
            this.btn_setPassword.Location = new System.Drawing.Point(281, 176);
            this.btn_setPassword.Name = "btn_setPassword";
            this.btn_setPassword.Size = new System.Drawing.Size(118, 23);
            this.btn_setPassword.TabIndex = 29;
            this.btn_setPassword.Text = "Set New Password";
            this.btn_setPassword.UseVisualStyleBackColor = true;
            this.btn_setPassword.Click += new System.EventHandler(this.btn_setPassword_Click);
            // 
            // AdminSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_newPassword2);
            this.Controls.Add(this.tb_newPassword1);
            this.Controls.Add(this.btn_setPassword);
            this.Controls.Add(this.btn_addDepartment);
            this.Controls.Add(this.pnl_departments);
            this.Controls.Add(this.btn_updateDepartments);
            this.Controls.Add(this.lbl_departments);
            this.Controls.Add(this.cb_privilege);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.btn_addUser);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 720);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 720);
            this.Name = "AdminSettings";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cb_privilege;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Button btn_addUser;
        private System.Windows.Forms.Label lbl_departments;
        private System.Windows.Forms.Button btn_updateDepartments;
        private System.Windows.Forms.Panel pnl_departments;
        private System.Windows.Forms.Button btn_addDepartment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_newPassword2;
        private System.Windows.Forms.TextBox tb_newPassword1;
        private System.Windows.Forms.Button btn_setPassword;
    }
}