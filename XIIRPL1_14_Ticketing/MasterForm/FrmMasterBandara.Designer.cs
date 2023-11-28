namespace XIIRPL1_14_Ticketing.MasterForm
{
    partial class FrmMasterBandara
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
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNama = new TextBox();
            txtKodeIata = new TextBox();
            txtKota = new TextBox();
            label7 = new Label();
            txtJmlTerminal = new NumericUpDown();
            label8 = new Label();
            txtAlamat = new TextBox();
            btnSimpan = new Button();
            btnBatal = new Button();
            id = new TextBox();
            BtnEdit = new Button();
            txtNegara = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtJmlTerminal).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(197, 28);
            label1.TabIndex = 0;
            label1.Text = "Master Bandara";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(327, 15);
            label2.TabIndex = 1;
            label2.Text = "Semua bandara yang terdaftar akan muncul disini";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Edit, Delete });
            dataGridView1.Location = new Point(40, 92);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(722, 207);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Edit
            // 
            Edit.HeaderText = "Edit";
            Edit.Name = "Edit";
            Edit.Text = "Edit";
            Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.Name = "Delete";
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(40, 316);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 3;
            label3.Text = "Nama";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(40, 346);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 4;
            label4.Text = "Kode IATA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(40, 377);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 5;
            label5.Text = "Kota";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(40, 409);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 6;
            label6.Text = "Negara";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(124, 313);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(297, 23);
            txtNama.TabIndex = 7;
            // 
            // txtKodeIata
            // 
            txtKodeIata.Location = new Point(124, 343);
            txtKodeIata.Name = "txtKodeIata";
            txtKodeIata.Size = new Size(297, 23);
            txtKodeIata.TabIndex = 8;
            // 
            // txtKota
            // 
            txtKota.Location = new Point(124, 374);
            txtKota.Name = "txtKota";
            txtKota.Size = new Size(297, 23);
            txtKota.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(457, 316);
            label7.Name = "label7";
            label7.Size = new Size(115, 15);
            label7.TabIndex = 11;
            label7.Text = "Jumlah Terminal";
            // 
            // txtJmlTerminal
            // 
            txtJmlTerminal.Location = new Point(578, 313);
            txtJmlTerminal.Name = "txtJmlTerminal";
            txtJmlTerminal.Size = new Size(184, 23);
            txtJmlTerminal.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(457, 351);
            label8.Name = "label8";
            label8.Size = new Size(53, 15);
            label8.TabIndex = 13;
            label8.Text = "Alamat";
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(578, 346);
            txtAlamat.Multiline = true;
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(184, 68);
            txtAlamat.TabIndex = 14;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(551, 421);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(75, 23);
            btnSimpan.TabIndex = 15;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(713, 420);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(75, 23);
            btnBatal.TabIndex = 16;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            // 
            // id
            // 
            id.Location = new Point(427, 421);
            id.Name = "id";
            id.Size = new Size(100, 23);
            id.TabIndex = 17;
            // 
            // BtnEdit
            // 
            BtnEdit.Location = new Point(632, 421);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(75, 23);
            BtnEdit.TabIndex = 18;
            BtnEdit.Text = "Edit";
            BtnEdit.UseVisualStyleBackColor = true;
            BtnEdit.Click += BtnEdit_Click;
            // 
            // txtNegara
            // 
            txtNegara.FormattingEnabled = true;
            txtNegara.Location = new Point(124, 406);
            txtNegara.Name = "txtNegara";
            txtNegara.Size = new Size(297, 23);
            txtNegara.TabIndex = 19;
            txtNegara.SelectedIndexChanged += txtNegara_SelectedIndexChanged;
            // 
            // FrmMasterBandara
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNegara);
            Controls.Add(BtnEdit);
            Controls.Add(id);
            Controls.Add(btnBatal);
            Controls.Add(btnSimpan);
            Controls.Add(txtAlamat);
            Controls.Add(label8);
            Controls.Add(txtJmlTerminal);
            Controls.Add(label7);
            Controls.Add(txtKota);
            Controls.Add(txtKodeIata);
            Controls.Add(txtNama);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmMasterBandara";
            Text = "FrmMasterMaskapai";
            Load += FrmMasterBandara_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtJmlTerminal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNama;
        private TextBox txtKodeIata;
        private TextBox txtKota;
        private Label label7;
        private NumericUpDown txtJmlTerminal;
        private Label label8;
        private TextBox txtAlamat;
        private Button btnSimpan;
        private Button btnBatal;
        private TextBox id;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Button BtnEdit;
        private ComboBox txtNegara;
    }
}