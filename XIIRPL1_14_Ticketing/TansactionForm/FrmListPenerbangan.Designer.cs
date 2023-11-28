namespace XIIRPL1_14_Ticketing.TansactionForm
{
    partial class FrmListPenerbangan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListPenerbangan));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            label3 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(60, 12);
            label1.Name = "label1";
            label1.Size = new Size(221, 31);
            label1.TabIndex = 1;
            label1.Text = "List Penerbangan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 47);
            label2.Name = "label2";
            label2.Size = new Size(391, 15);
            label2.TabIndex = 2;
            label2.Text = "Juanda(SUB) -> Soekarno-Hatta (CGK)  Mon, 22 May 2023  1 Penumpang\r\n";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(checkBox4);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 96);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(724, 117);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 19);
            label3.Name = "label3";
            label3.Size = new Size(123, 15);
            label3.TabIndex = 0;
            label3.Text = "Waktu Keberangkatan";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 37);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(91, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "00:00 - 06:00";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(103, 37);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(91, 19);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "06:00 - 12:00";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(200, 37);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(91, 19);
            checkBox3.TabIndex = 3;
            checkBox3.Text = "12:00 - 18:00";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(297, 37);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(91, 19);
            checkBox4.TabIndex = 4;
            checkBox4.Text = "18:00 - 24:00";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 59);
            label4.Name = "label4";
            label4.Size = new Size(116, 15);
            label4.TabIndex = 5;
            label4.Text = "Urutkan Berdasarkan";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(8, 77);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(612, 88);
            button1.Name = "button1";
            button1.Size = new Size(112, 23);
            button1.TabIndex = 7;
            button1.Text = "Terapkan Filter";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 219);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(724, 126);
            dataGridView1.TabIndex = 4;
            // 
            // FrmListPenerbangan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 357);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "FrmListPenerbangan";
            Text = "FrmListPenerbangan";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label3;
        private Button button1;
        private ComboBox comboBox1;
        private Label label4;
        private DataGridView dataGridView1;
    }
}