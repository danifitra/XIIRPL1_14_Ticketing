namespace XIIRPL1_14_Ticketing.MasterForm
{
    partial class FrmMasterKodePromo
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
            btnSimpan = new Button();
            btnBatal = new Button();
            txtDeskripsi = new TextBox();
            label8 = new Label();
            txtPersentaseDiskon = new NumericUpDown();
            label7 = new Label();
            txtKodePromo = new TextBox();
            label4 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            txtMaksimalDiskon = new NumericUpDown();
            txtBerlakuSampai = new DateTimePicker();
            id = new TextBox();
            ((System.ComponentModel.ISupportInitialize)txtPersentaseDiskon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMaksimalDiskon).BeginInit();
            SuspendLayout();
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(676, 413);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(75, 23);
            btnSimpan.TabIndex = 46;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(570, 413);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(75, 23);
            btnBatal.TabIndex = 45;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(542, 310);
            txtDeskripsi.Multiline = true;
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(233, 94);
            txtDeskripsi.TabIndex = 44;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(468, 310);
            label8.Name = "label8";
            label8.Size = new Size(68, 15);
            label8.TabIndex = 43;
            label8.Text = "Deskripsi";
            // 
            // txtPersentaseDiskon
            // 
            txtPersentaseDiskon.Location = new Point(185, 373);
            txtPersentaseDiskon.Name = "txtPersentaseDiskon";
            txtPersentaseDiskon.Size = new Size(249, 23);
            txtPersentaseDiskon.TabIndex = 42;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(53, 375);
            label7.Name = "label7";
            label7.Size = new Size(126, 15);
            label7.TabIndex = 41;
            label7.Text = "Persentase diskon";
            // 
            // txtKodePromo
            // 
            txtKodePromo.Location = new Point(185, 310);
            txtKodePromo.Name = "txtKodePromo";
            txtKodePromo.Size = new Size(249, 23);
            txtKodePromo.TabIndex = 39;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(53, 345);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 38;
            label4.Text = "Berlaku sampai";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(53, 313);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 37;
            label3.Text = "Kode promo";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(53, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(722, 207);
            dataGridView1.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(25, 42);
            label2.Name = "label2";
            label2.Size = new Size(349, 15);
            label2.TabIndex = 35;
            label2.Text = "Semua kode promo yang terdaftar akan muncul disini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 14);
            label1.Name = "label1";
            label1.Size = new Size(241, 28);
            label1.TabIndex = 34;
            label1.Text = "Master Kode Promo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(53, 404);
            label5.Name = "label5";
            label5.Size = new Size(113, 15);
            label5.TabIndex = 47;
            label5.Text = "Maksimal diskon";
            // 
            // txtMaksimalDiskon
            // 
            txtMaksimalDiskon.Location = new Point(185, 402);
            txtMaksimalDiskon.Name = "txtMaksimalDiskon";
            txtMaksimalDiskon.Size = new Size(249, 23);
            txtMaksimalDiskon.TabIndex = 48;
            // 
            // txtBerlakuSampai
            // 
            txtBerlakuSampai.Location = new Point(185, 344);
            txtBerlakuSampai.Name = "txtBerlakuSampai";
            txtBerlakuSampai.Size = new Size(249, 23);
            txtBerlakuSampai.TabIndex = 49;
            // 
            // id
            // 
            id.Location = new Point(440, 415);
            id.Name = "id";
            id.Size = new Size(100, 23);
            id.TabIndex = 50;
            // 
            // FrmMasterKodePromo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(id);
            Controls.Add(txtBerlakuSampai);
            Controls.Add(txtMaksimalDiskon);
            Controls.Add(label5);
            Controls.Add(btnSimpan);
            Controls.Add(btnBatal);
            Controls.Add(txtDeskripsi);
            Controls.Add(label8);
            Controls.Add(txtPersentaseDiskon);
            Controls.Add(label7);
            Controls.Add(txtKodePromo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmMasterKodePromo";
            Text = "FrmMasterKodePromo";
            Load += FrmMasterKodePromo_Load;
            ((System.ComponentModel.ISupportInitialize)txtPersentaseDiskon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMaksimalDiskon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSimpan;
        private Button btnBatal;
        private TextBox txtDeskripsi;
        private Label label8;
        private NumericUpDown txtPersentaseDiskon;
        private Label label7;
        private TextBox txtKodePromo;
        private Label label4;
        private Label label3;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label1;
        private Label label5;
        private NumericUpDown txtMaksimalDiskon;
        private DateTimePicker txtBerlakuSampai;
        private TextBox id;
    }
}