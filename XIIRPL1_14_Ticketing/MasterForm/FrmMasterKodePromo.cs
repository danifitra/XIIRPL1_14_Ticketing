using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XIIRPL1_14_Ticketing.MasterForm
{
    public partial class FrmMasterKodePromo : Form
    {
        public NpgsqlCommand cmd;
        public NpgsqlDataReader dr;
        public FrmMasterKodePromo()
        {
            InitializeComponent();
        }

        private void FrmMasterKodePromo_Load(object sender, EventArgs e)
        {
            nomor_urut();
            view_data();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.conn.Open();
                String sql = "INSERT INTO db_ticket_xii_rpl_1_14.tbl_kode_promo" +
                    "(id,kode,persentase_diskon,maksimum_diskon,berlaku_sampai,deskripsi)" +
                    "VALUES" +
                    "('" + id.Text + "'," +
                    "'" + txtPersentaseDiskon.Text + "'," +
                    "'" + txtKodePromo.Text + "'," +
                    "'" + txtMaksimalDiskon.Text + "'," +
                    "'" + txtBerlakuSampai.Text + "'," +
                    "'" + txtDeskripsi.Text + "')";
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

        public void view_data()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT * FROM db_ticket_xii_rpl_1_14.tbl_kode_promo", koneksi.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "db_ticket_xii_rpl_1_14.tbl_kode_promo");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        public void nomor_urut()
        {
            int hitung, nomor;
            koneksi.conn.Open();
            string sql = "SELECT id FROM db_ticket_xii_rpl_1_14.tbl_kode_promo " +
                "where id in(select max(id) FROM db_ticket_xii_rpl_1_14.tbl_kode_promo) " +
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
    }



}
