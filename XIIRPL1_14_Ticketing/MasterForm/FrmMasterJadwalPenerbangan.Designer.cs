namespace XIIRPL1_14_Ticketing.MasterForm
{
    partial class FrmMasterJadwalPenerbangan
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
            label8 = new Label();
            label7 = new Label();
            txtKodePenerbangan = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            txtDari = new ComboBox();
            txtKe = new ComboBox();
            txtMaskapai = new ComboBox();
            label9 = new Label();
            txtDurasiPenerbangan = new TextBox();
            txtHargaPerTiket = new NumericUpDown();
            label10 = new Label();
            dateTimePickerWaktuPenerbangan = new DateTimePicker();
            dateTimePickerTanggal = new DateTimePicker();
            id = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtHargaPerTiket).BeginInit();
            SuspendLayout();
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(700, 427);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(75, 23);
            btnSimpan.TabIndex = 33;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(591, 427);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(75, 23);
            btnBatal.TabIndex = 32;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(440, 338);
            label8.Name = "label8";
            label8.Size = new Size(150, 15);
            label8.TabIndex = 30;
            label8.Text = "Waktu Keberangkatan";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(440, 313);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 28;
            label7.Text = "Tanggal";
            // 
            // txtKodePenerbangan
            // 
            txtKodePenerbangan.Location = new Point(189, 305);
            txtKodePenerbangan.Name = "txtKodePenerbangan";
            txtKodePenerbangan.Size = new Size(245, 23);
            txtKodePenerbangan.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(53, 401);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 23;
            label6.Text = "Maskapai";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(53, 369);
            label5.Name = "label5";
            label5.Size = new Size(25, 15);
            label5.TabIndex = 22;
            label5.Text = "Ke";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(53, 338);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 21;
            label4.Text = "Dari";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(53, 308);
            label3.Name = "label3";
            label3.Size = new Size(130, 15);
            label3.TabIndex = 20;
            label3.Text = "Kode penerbangan";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(41, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(722, 207);
            dataGridView1.TabIndex = 19;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(25, 44);
            label2.Name = "label2";
            label2.Size = new Size(310, 15);
            label2.TabIndex = 18;
            label2.Text = "Semua jadwal penerbangan akan muncul disini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 16);
            label1.Name = "label1";
            label1.Size = new Size(343, 28);
            label1.TabIndex = 17;
            label1.Text = "Master Jadwal Penerbangan";
            // 
            // txtDari
            // 
            txtDari.FormattingEnabled = true;
            txtDari.Location = new Point(189, 334);
            txtDari.Name = "txtDari";
            txtDari.Size = new Size(245, 23);
            txtDari.TabIndex = 34;
            // 
            // txtKe
            // 
            txtKe.FormattingEnabled = true;
            txtKe.Location = new Point(189, 366);
            txtKe.Name = "txtKe";
            txtKe.Size = new Size(245, 23);
            txtKe.TabIndex = 35;
            // 
            // txtMaskapai
            // 
            txtMaskapai.FormattingEnabled = true;
            txtMaskapai.Location = new Point(189, 398);
            txtMaskapai.Name = "txtMaskapai";
            txtMaskapai.Size = new Size(245, 23);
            txtMaskapai.TabIndex = 36;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(440, 366);
            label9.Name = "label9";
            label9.Size = new Size(139, 15);
            label9.TabIndex = 37;
            label9.Text = "Durasi penerbangan";
            label9.Click += label9_Click;
            // 
            // txtDurasiPenerbangan
            // 
            txtDurasiPenerbangan.Location = new Point(591, 366);
            txtDurasiPenerbangan.Multiline = true;
            txtDurasiPenerbangan.Name = "txtDurasiPenerbangan";
            txtDurasiPenerbangan.Size = new Size(184, 23);
            txtDurasiPenerbangan.TabIndex = 38;
            // 
            // txtHargaPerTiket
            // 
            txtHargaPerTiket.Location = new Point(591, 398);
            txtHargaPerTiket.Name = "txtHargaPerTiket";
            txtHargaPerTiket.Size = new Size(184, 23);
            txtHargaPerTiket.TabIndex = 39;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(440, 400);
            label10.Name = "label10";
            label10.Size = new Size(104, 15);
            label10.TabIndex = 40;
            label10.Text = "Harga per tiket";
            // 
            // dateTimePickerWaktuPenerbangan
            // 
            dateTimePickerWaktuPenerbangan.Format = DateTimePickerFormat.Time;
            dateTimePickerWaktuPenerbangan.Location = new Point(591, 334);
            dateTimePickerWaktuPenerbangan.Name = "dateTimePickerWaktuPenerbangan";
            dateTimePickerWaktuPenerbangan.Size = new Size(184, 23);
            dateTimePickerWaktuPenerbangan.TabIndex = 41;
            // 
            // dateTimePickerTanggal
            // 
            dateTimePickerTanggal.Format = DateTimePickerFormat.Short;
            dateTimePickerTanggal.Location = new Point(591, 305);
            dateTimePickerTanggal.Name = "dateTimePickerTanggal";
            dateTimePickerTanggal.Size = new Size(184, 23);
            dateTimePickerTanggal.TabIndex = 42;
            // 
            // id
            // 
            id.Location = new Point(440, 418);
            id.Multiline = true;
            id.Name = "id";
            id.Size = new Size(89, 23);
            id.TabIndex = 43;
            // 
            // FrmMasterJadwalPenerbangan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(id);
            Controls.Add(dateTimePickerTanggal);
            Controls.Add(dateTimePickerWaktuPenerbangan);
            Controls.Add(label10);
            Controls.Add(txtHargaPerTiket);
            Controls.Add(txtDurasiPenerbangan);
            Controls.Add(label9);
            Controls.Add(txtMaskapai);
            Controls.Add(txtKe);
            Controls.Add(txtDari);
            Controls.Add(btnSimpan);
            Controls.Add(btnBatal);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtKodePenerbangan);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmMasterJadwalPenerbangan";
            Text = "FrmMasterJadwalPenerbangan";
            Load += FrmMasterJadwalPenerbangan_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtHargaPerTiket).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSimpan;
        private Button btnBatal;
        private Label label8;
        private Label label7;
        private TextBox txtKodePenerbangan;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label1;
        private ComboBox txtDari;
        private ComboBox txtKe;
        private ComboBox txtMaskapai;
        private Label label9;
        private TextBox txtDurasiPenerbangan;
        private NumericUpDown txtHargaPerTiket;
        private Label label10;
        private DateTimePicker dateTimePickerWaktuPenerbangan;
        private DateTimePicker dateTimePickerTanggal;
        private TextBox id;
    }
}