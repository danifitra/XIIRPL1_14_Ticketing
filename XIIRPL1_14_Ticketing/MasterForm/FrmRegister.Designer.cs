namespace XIIRPL1_14_Ticketing.MasterForm
{
    partial class FrmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegister));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtUsername = new TextBox();
            txtNama = new TextBox();
            txtNomorTlp = new TextBox();
            txtPassword = new TextBox();
            txtTglLahir = new DateTimePicker();
            btnDaftar = new Button();
            label8 = new Label();
            txtLinkLabel = new LinkLabel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(141, 32);
            label1.TabIndex = 0;
            label1.Text = "Daftar Akun";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 41);
            label2.Name = "label2";
            label2.Size = new Size(400, 21);
            label2.TabIndex = 1;
            label2.Text = "Daftarkan diri Anda untuk menggunakan Bromo Airlines";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 133);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 2;
            label3.Text = "Username :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 162);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 3;
            label4.Text = "Nama : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 191);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 4;
            label5.Text = "Tanggal Lahir : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 220);
            label6.Name = "label6";
            label6.Size = new Size(124, 20);
            label6.TabIndex = 5;
            label6.Text = "Nomor Telepon : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 250);
            label7.Name = "label7";
            label7.Size = new Size(81, 20);
            label7.TabIndex = 6;
            label7.Text = "Password : ";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(166, 134);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(246, 23);
            txtUsername.TabIndex = 7;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(166, 163);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(246, 23);
            txtNama.TabIndex = 8;
            // 
            // txtNomorTlp
            // 
            txtNomorTlp.Location = new Point(166, 221);
            txtNomorTlp.Name = "txtNomorTlp";
            txtNomorTlp.Size = new Size(246, 23);
            txtNomorTlp.TabIndex = 10;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(166, 250);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(246, 23);
            txtPassword.TabIndex = 11;
            // 
            // txtTglLahir
            // 
            txtTglLahir.Location = new Point(166, 192);
            txtTglLahir.Name = "txtTglLahir";
            txtTglLahir.Size = new Size(246, 23);
            txtTglLahir.TabIndex = 12;
            // 
            // btnDaftar
            // 
            btnDaftar.Location = new Point(337, 297);
            btnDaftar.Name = "btnDaftar";
            btnDaftar.Size = new Size(75, 23);
            btnDaftar.TabIndex = 13;
            btnDaftar.Text = "Daftar";
            btnDaftar.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(12, 420);
            label8.Name = "label8";
            label8.Size = new Size(146, 21);
            label8.TabIndex = 14;
            label8.Text = "Sudah punya akun?";
            // 
            // txtLinkLabel
            // 
            txtLinkLabel.AutoSize = true;
            txtLinkLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLinkLabel.Location = new Point(164, 420);
            txtLinkLabel.Name = "txtLinkLabel";
            txtLinkLabel.Size = new Size(49, 21);
            txtLinkLabel.TabIndex = 15;
            txtLinkLabel.TabStop = true;
            txtLinkLabel.Text = "Login";
            txtLinkLabel.LinkClicked += txtLinkLabel_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(448, 114);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(302, 226);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // FrmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(txtLinkLabel);
            Controls.Add(label8);
            Controls.Add(btnDaftar);
            Controls.Add(txtTglLahir);
            Controls.Add(txtPassword);
            Controls.Add(txtNomorTlp);
            Controls.Add(txtNama);
            Controls.Add(txtUsername);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmRegister";
            Text = "FrmRegister";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtUsername;
        private TextBox txtNama;
        private TextBox txtNomorTlp;
        private TextBox txtPassword;
        private DateTimePicker txtTglLahir;
        private Button btnDaftar;
        private Label label8;
        private LinkLabel txtLinkLabel;
        private PictureBox pictureBox1;
    }
}