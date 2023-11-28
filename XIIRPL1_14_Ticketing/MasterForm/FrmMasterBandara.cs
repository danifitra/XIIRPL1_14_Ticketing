using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XIIRPL1_14_Ticketing.MasterForm
{
    public partial class FrmMasterBandara : Form
    {
        ComboBoxFunction cb = new ComboBoxFunction();

        public NpgsqlCommand cmd;
        public NpgsqlDataReader dr;
        public FrmMasterBandara()
        {

            InitializeComponent();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.conn.Open();
                String sql = "INSERT INTO db_ticket_xii_rpl_1_14.tbl_bandara" +
                    "(id,nama,kode_iata,kota,negara_id,jumlah_terminal,alamat)" +
                    "VALUES" +
                    "('" + id.Text + "'," +
                    "'" + txtNama.Text + "'," +
                    "'" + txtKodeIata.Text + "'," +
                    "'" + txtKota.Text + "'," +
                    "'" + txtNegara.SelectedValue + "'," +
                    "'" + txtJmlTerminal.Value + "'," +
                    "'" + txtAlamat.Text + "')";
                cmd = new NpgsqlCommand(sql, koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Simpan Data Bandara");
                koneksi.conn.Close();
                view_data();
                nomor_urut();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message" + ex.Message);
                koneksi.conn.Close();
            }
        }
        public void view_data()
        {
            string sql = "SELECT tbl_bandara.id, " +
                         "tbl_bandara.nama AS nama_bandara, " +
                         "tbl_bandara.kode_iata, " +
                         "tbl_bandara.kota, " +
                         "tbl_negara.nama AS negara, " +
                         "tbl_bandara.jumlah_terminal " +
                         "FROM db_ticket_xii_rpl_1_14.tbl_bandara " +
                         "INNER JOIN db_ticket_xii_rpl_1_14.tbl_negara ON tbl_bandara.negara_id = tbl_negara.id";

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, koneksi.conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[2].HeaderText = "ID";
            dataGridView1.Columns[3].HeaderText = "Nama Bandara";
            dataGridView1.Columns[4].HeaderText = "Kode IATA";
            dataGridView1.Columns[5].HeaderText = "Kota";
            dataGridView1.Columns[6].HeaderText = "Negara";
            dataGridView1.Columns[7].HeaderText = "Jumlah Terminal";
        }


        private void FrmMasterBandara_Load(object sender, EventArgs e)
        {
            view_data();
            nomor_urut();

            //Menampilkan data negara dari database dan dimasukkan kw combobox
            string query = "SELECT * FROM db_ticket_xii_rpl_1_14.tbl_negara";
            //ComboBoxFunction.Set_ComboBox(query, "nama", txtNegara);
            txtNegara.DataSource = cb.getData(query);
            txtNegara.DisplayMember = "nama";
            txtNegara.ValueMember = "id";
        }

        public void nomor_urut()
        {
            int hitung, nomor;
            koneksi.conn.Open();
            string sql = "SELECT id FROM db_ticket_xii_rpl_1_14.tbl_bandara " +
                "where id in(select max(id) FROM db_ticket_xii_rpl_1_14.tbl_bandara) " +
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                int id;
                id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                try
                {
                    koneksi.conn.Open();
                    string sql = "DELETE FROM db_ticket_xii_rpl_1_14.tbl_bandara WHERE id=@id";
                    cmd = new NpgsqlCommand(sql, koneksi.conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Data Berhasil Dihapus");
                        view_data();
                    }
                    else
                    {
                        MessageBox.Show("Data Tidak Berhasil Dihapus");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    koneksi.conn.Close();
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                id.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                txtNama.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["nama"].Value);
                txtKodeIata.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["kode_iata"].Value);
                txtKota.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["kota"].Value);
                txtNegara.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["negara_id"].Value);
                txtJmlTerminal.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["jumlah_terminal"].Value);
                txtAlamat.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["alamat"].Value);
                btnSimpan.Enabled = false;
                BtnEdit.Enabled = true;

            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.conn.Open();
                String sql = "UPDATE db_ticket_xii_rpl_1_14.tbl_bandara SET nama = '" + txtNama.Text + "', kode_iata = '" + txtKodeIata.Text + "', kota = '" + txtKota.Text + "', negara_id ='" + txtNegara.Text + "', jumlah_terminal ='" + txtJmlTerminal.Text + "', alamat = '" + txtAlamat.Text + "' WHERE id = '" + id.Text + "'";
                cmd = new NpgsqlCommand(sql, koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Simpan Data Bandara");
                view_data();
                koneksi.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtNegara_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


