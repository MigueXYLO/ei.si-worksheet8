﻿namespace WindowsClient
{
    partial class FormMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnGetUsers = new System.Windows.Forms.Button();
            this.lboxUsers = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGetDescription = new System.Windows.Forms.Button();
            this.txtMyDescription = new System.Windows.Forms.TextBox();
            this.btnSetDescription = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(21, 37);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(369, 22);
            this.txtLogin.TabIndex = 1;
            this.txtLogin.Text = "si";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(21, 89);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(369, 22);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "123";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnGetUsers
            // 
            this.btnGetUsers.Location = new System.Drawing.Point(21, 121);
            this.btnGetUsers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGetUsers.Name = "btnGetUsers";
            this.btnGetUsers.Size = new System.Drawing.Size(371, 28);
            this.btnGetUsers.TabIndex = 4;
            this.btnGetUsers.Text = "Get Users";
            this.btnGetUsers.UseVisualStyleBackColor = true;
            this.btnGetUsers.Click += new System.EventHandler(this.BtnGetUsers_Click);
            // 
            // lboxUsers
            // 
            this.lboxUsers.FormattingEnabled = true;
            this.lboxUsers.ItemHeight = 16;
            this.lboxUsers.Location = new System.Drawing.Point(425, 37);
            this.lboxUsers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lboxUsers.Name = "lboxUsers";
            this.lboxUsers.Size = new System.Drawing.Size(347, 148);
            this.lboxUsers.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Users";
            // 
            // btnGetDescription
            // 
            this.btnGetDescription.Location = new System.Drawing.Point(425, 193);
            this.btnGetDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGetDescription.Name = "btnGetDescription";
            this.btnGetDescription.Size = new System.Drawing.Size(347, 28);
            this.btnGetDescription.TabIndex = 7;
            this.btnGetDescription.Text = "Get Selected User Description";
            this.btnGetDescription.UseVisualStyleBackColor = true;
            this.btnGetDescription.Click += new System.EventHandler(this.BtnGetDescription_Click);
            // 
            // txtMyDescription
            // 
            this.txtMyDescription.Location = new System.Drawing.Point(21, 190);
            this.txtMyDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMyDescription.Multiline = true;
            this.txtMyDescription.Name = "txtMyDescription";
            this.txtMyDescription.Size = new System.Drawing.Size(369, 98);
            this.txtMyDescription.TabIndex = 8;
            // 
            // btnSetDescription
            // 
            this.btnSetDescription.Location = new System.Drawing.Point(21, 295);
            this.btnSetDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSetDescription.Name = "btnSetDescription";
            this.btnSetDescription.Size = new System.Drawing.Size(371, 28);
            this.btnSetDescription.TabIndex = 9;
            this.btnSetDescription.Text = "Set My Description";
            this.btnSetDescription.UseVisualStyleBackColor = true;
            this.btnSetDescription.Click += new System.EventHandler(this.BtnSetDescription_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Enabled = false;
            this.txtDescription.Location = new System.Drawing.Point(425, 229);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(345, 94);
            this.txtDescription.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Description";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 336);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnSetDescription);
            this.Controls.Add(this.txtMyDescription);
            this.Controls.Add(this.btnGetDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lboxUsers);
            this.Controls.Add(this.btnGetUsers);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "WindowsClient";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnGetUsers;
        private System.Windows.Forms.ListBox lboxUsers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGetDescription;
        private System.Windows.Forms.TextBox txtMyDescription;
        private System.Windows.Forms.Button btnSetDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label4;
    }
}

