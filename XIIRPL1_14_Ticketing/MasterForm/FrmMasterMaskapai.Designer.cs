namespace XIIRPL1_14_Ticketing.MasterForm
{
    partial class FrmMasterMaskapai
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
            txtJumlahKru = new NumericUpDown();
            label7 = new Label();
            txtPerusahaan = new TextBox();
            txtNama = new TextBox();
            label4 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            label2 = new Label();
            label1 = new Label();
            id = new TextBox();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)txtJumlahKru).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(623, 416);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(75, 23);
            btnSimpan.TabIndex = 33;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(542, 415);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(75, 23);
            btnBatal.TabIndex = 32;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(542, 312);
            txtDeskripsi.Multiline = true;
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(233, 94);
            txtDeskripsi.TabIndex = 31;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(468, 312);
            label8.Name = "label8";
            label8.Size = new Size(68, 15);
            label8.TabIndex = 30;
            label8.Text = "Deskripsi";
            // 
            // txtJumlahKru
            // 
            txtJumlahKru.Location = new Point(174, 383);
            txtJumlahKru.Name = "txtJumlahKru";
            txtJumlahKru.Size = new Size(260, 23);
            txtJumlahKru.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(53, 391);
            label7.Name = "label7";
            label7.Size = new Size(78, 15);
            label7.TabIndex = 28;
            label7.Text = "Jumlah kru";
            label7.Click += label7_Click;
            // 
            // txtPerusahaan
            // 
            txtPerusahaan.Location = new Point(174, 344);
            txtPerusahaan.Name = "txtPerusahaan";
            txtPerusahaan.Size = new Size(260, 23);
            txtPerusahaan.TabIndex = 25;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(174, 304);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(260, 23);
            txtNama.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(53, 352);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 21;
            label4.Text = "Perusahaan";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(53, 307);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 20;
            label3.Text = "Nama";
            label3.Click += label3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Edit, Delete });
            dataGridView1.Location = new Point(25, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(722, 207);
            dataGridView1.TabIndex = 19;
            dataGridView1.CellClick += dataGridView1_CellClick;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(25, 44);
            label2.Name = "label2";
            label2.Size = new Size(335, 15);
            label2.TabIndex = 18;
            label2.Text = "Semua maskapai yang terdaftar akan muncul disini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 16);
            label1.Name = "label1";
            label1.Size = new Size(209, 28);
            label1.TabIndex = 17;
            label1.Text = "Master Maskapai";
            // 
            // id
            // 
            id.Location = new Point(174, 416);
            id.Name = "id";
            id.Size = new Size(90, 23);
            id.TabIndex = 34;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(704, 416);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 35;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // FrmMasterMaskapai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEdit);
            Controls.Add(id);
            Controls.Add(btnSimpan);
            Controls.Add(btnBatal);
            Controls.Add(txtDeskripsi);
            Controls.Add(label8);
            Controls.Add(txtJumlahKru);
            Controls.Add(label7);
            Controls.Add(txtPerusahaan);
            Controls.Add(txtNama);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmMasterMaskapai";
            Text = "FrmMasterMaskapai";
            Load += FrmMasterMaskapai_Load;
            ((System.ComponentModel.ISupportInitialize)txtJumlahKru).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSimpan;
        private Button btnBatal;
        private TextBox txtDeskripsi;
        private Label label8;
        private NumericUpDown txtJumlahKru;
        private Label label7;
        private TextBox txtPerusahaan;
        private TextBox txtNama;
        private Label label4;
        private Label label3;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label1;
        private TextBox id;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Button btnEdit;
    }
}