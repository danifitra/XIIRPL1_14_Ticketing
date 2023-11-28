using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XIIRPL1_14_Ticketing.MasterForm
{
    public partial class FrmMasterJadwalPenerbangan : Form
    {
        public NpgsqlCommand cmd;
        public NpgsqlDataReader dr;
        ComboBoxFunction cb = new ComboBoxFunction();
        public FrmMasterJadwalPenerbangan()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.conn.Open();
                String sql = "INSERT INTO db_ticket_xii_rpl_1_14.tbl_jadwal_penerbangan" +
                    "(id,kode_penerbangan,bandara_keberangkatan_id,bandara_tujuan_id,maskapai_id,tanggal_waktu_keberangkatan,durasi_penerbangan,harga_per_tiket,waktu_keberangkatan)" +
                    "VALUES" +
                    "('" + id.Text + "'," +
                    "'" + txtKodePenerbangan.Text + "'," +
                    "'" + txtDari.SelectedValue + "'," +
                    "'" + txtKe.SelectedValue + "'," +
                    "'" + txtMaskapai.SelectedValue + "'," +
                    "'" + dateTimePickerTanggal.Value + "')" +
                    "'" + dateTimePickerWaktuPenerbangan.Value + "')" +
                    "'" + txtHargaPerTiket.Text + "')" +
                    "'" + txtDurasiPenerbangan.Text + "')";
                cmd = new NpgsqlCommand(sql, koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Simpan Data Bandara");
                view_data();
                koneksi.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message" + ex.Message);
            }
        }

        private void FrmMasterJadwalPenerbangan_Load(object sender, EventArgs e)
        {
            nomor_urut();
            view_data();
            bandara();
            maskapai();

            //Menampilkan data negara dari database dan dimasukkan kw combobox
            string query = "SELECT * FROM db_ticket_xii_rpl_1_14.tbl_maskapai";
            ComboBoxFunction.Set_ComboBox(query, "nama", txtMaskapai);
        }

        public void nomor_urut()
        {
            int hitung, nomor;
            koneksi.conn.Open();
            string sql = "SELECT id FROM db_ticket_xii_rpl_1_14.tbl_jadwal_penerbangan " +
                "where id in(select max(id) FROM db_ticket_xii_rpl_1_14.tbl_jadwal_penerbangan) " +
                "order by id desc";
            cmd = new NpgsqlCommand(sql, koneksi.conn);
            dr = cmd.ExecuteReader();
            dr.Read();

            if (dr.HasRows)
            {
                nomor = Convert.ToInt32(dr[0]);
                hitung = nomor + 1;
            }
            else
            {
                hitung = 1;
            }
            dr.Close();
            id.Text = Convert.ToString(hitung);
            koneksi.conn.Close();

        }

        public void view_data()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT * FROM db_ticket_xii_rpl_1_14.tbl_jadwal_penerbangan", koneksi.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "db_ticket_xii_rpl_1_14.tbl_kode_promo");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        public void bandara()
        {
            //menampilkan data bandara dari database dan dimasukkan di combobox
            string query = "SELECT * FROM db_ticket_xii_rpl_1_14.tbl_bandara";

            txtKe.DataSource = cb.getData(query);
            txtKe.DisplayMember = "nama";
            txtKe.ValueMember = "id";

            txtDari.DataSource = cb.getData(query);
            txtDari.DisplayMember = "nama";
            txtDari.ValueMember = "id";
        }

        public void maskapai()
        {
            //menampilkan data maskapai dari database dan dimasukkan ke combobox
            string query = "SELECT * FROM db_ticket_xii_rpl_1_14.tbl_maskapai";

            txtMaskapai.DataSource = cb.getData(query);
            txtMaskapai.DisplayMember = "nama";
            txtMaskapai.ValueMember = "id";
        }
    }
}
