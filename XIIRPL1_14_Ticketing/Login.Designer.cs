﻿namespace XIIRPL1_14_Ticketing
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btnLogin = new Button();
            txtLinkLabel = new LinkLabel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(497, 318);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(102, 29);
            btnLogin.TabIndex = 15;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // txtLinkLabel
            // 
            txtLinkLabel.AutoSize = true;
            txtLinkLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLinkLabel.Location = new Point(436, 390);
            txtLinkLabel.Name = "txtLinkLabel";
            txtLinkLabel.Size = new Size(127, 21);
            txtLinkLabel.TabIndex = 14;
            txtLinkLabel.TabStop = true;
            txtLinkLabel.Text = "Daftar Sekarang!";
            txtLinkLabel.LinkClicked += txtLinkLabel_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(284, 390);
            label3.Name = "label3";
            label3.Size = new Size(146, 21);
            label3.TabIndex = 13;
            label3.Text = "Belum punya akun?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(204, 277);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 12;
            label2.Text = "Password : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(203, 241);
            label1.Name = "label1";
            label1.Size = new Size(88, 21);
            label1.TabIndex = 11;
            label1.Text = "Username :";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(297, 279);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(302, 23);
            txtPassword.TabIndex = 10;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(297, 241);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(302, 23);
            txtUsername.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(149, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(502, 159);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(txtLinkLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(pictureBox1);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private LinkLabel txtLinkLabel;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private PictureBox pictureBox1;
    }
}