﻿namespace WinFormApp
{
    partial class RegisterForm
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
            this.UserLoginField = new System.Windows.Forms.TextBox();
            this.UserEmailField = new System.Windows.Forms.TextBox();
            this.UserPasswordField = new System.Windows.Forms.TextBox();
            this.RegButton = new System.Windows.Forms.Button();
            this.LinkToAuth = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(54, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UserLoginField
            // 
            this.UserLoginField.BackColor = System.Drawing.Color.Gainsboro;
            this.UserLoginField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserLoginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserLoginField.ForeColor = System.Drawing.Color.Gray;
            this.UserLoginField.Location = new System.Drawing.Point(27, 67);
            this.UserLoginField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UserLoginField.Name = "UserLoginField";
            this.UserLoginField.Size = new System.Drawing.Size(233, 24);
            this.UserLoginField.TabIndex = 1;
            this.UserLoginField.Enter += new System.EventHandler(this.TextBox_Enter);
            this.UserLoginField.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // UserEmailField
            // 
            this.UserEmailField.BackColor = System.Drawing.Color.Gainsboro;
            this.UserEmailField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserEmailField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserEmailField.ForeColor = System.Drawing.Color.Gray;
            this.UserEmailField.Location = new System.Drawing.Point(27, 114);
            this.UserEmailField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UserEmailField.Name = "UserEmailField";
            this.UserEmailField.Size = new System.Drawing.Size(233, 24);
            this.UserEmailField.TabIndex = 2;
            this.UserEmailField.Enter += new System.EventHandler(this.TextBox_Enter);
            this.UserEmailField.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // UserPasswordField
            // 
            this.UserPasswordField.BackColor = System.Drawing.Color.Gainsboro;
            this.UserPasswordField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserPasswordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserPasswordField.ForeColor = System.Drawing.Color.Gray;
            this.UserPasswordField.Location = new System.Drawing.Point(28, 163);
            this.UserPasswordField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UserPasswordField.Name = "UserPasswordField";
            this.UserPasswordField.Size = new System.Drawing.Size(233, 24);
            this.UserPasswordField.TabIndex = 3;
            this.UserPasswordField.Enter += new System.EventHandler(this.TextBox_Enter);
            this.UserPasswordField.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // RegButton
            // 
            this.RegButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.RegButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegButton.Location = new System.Drawing.Point(40, 208);
            this.RegButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(205, 32);
            this.RegButton.TabIndex = 4;
            this.RegButton.Text = "Зарегистрироваться";
            this.RegButton.UseVisualStyleBackColor = false;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // LinkToAuth
            // 
            this.LinkToAuth.AutoSize = true;
            this.LinkToAuth.LinkColor = System.Drawing.Color.Silver;
            this.LinkToAuth.Location = new System.Drawing.Point(98, 265);
            this.LinkToAuth.Name = "LinkToAuth";
            this.LinkToAuth.Size = new System.Drawing.Size(73, 14);
            this.LinkToAuth.TabIndex = 10;
            this.LinkToAuth.TabStop = true;
            this.LinkToAuth.Text = "Авторизация";
            this.LinkToAuth.VisitedLinkColor = System.Drawing.Color.Silver;
            this.LinkToAuth.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkToAuth_LinkClicked);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(284, 311);
            this.Controls.Add(this.LinkToAuth);
            this.Controls.Add(this.RegButton);
            this.Controls.Add(this.UserPasswordField);
            this.Controls.Add(this.UserEmailField);
            this.Controls.Add(this.UserLoginField);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Crimson;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.Enter += new System.EventHandler(this.TextBox_Enter);
            this.Leave += new System.EventHandler(this.TextBox_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserLoginField;
        private System.Windows.Forms.TextBox UserEmailField;
        private System.Windows.Forms.TextBox UserPasswordField;
        private System.Windows.Forms.Button RegButton;
        private System.Windows.Forms.LinkLabel LinkToAuth;
    }
}