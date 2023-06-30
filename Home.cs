using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatatanKeuangan
{
    public partial class Home : Form
    {
        config con = new config();
        SqlCommand cmd;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        String idUser = Form1.id;


        public Home()
        {
            InitializeComponent();
            showData(idUser);
            getTotalSaldo();
        }

        private void showData(String id)
        {
            try
            {
                adapter = new SqlDataAdapter("SELECT id,tgl_trx,jumlah_trx,tipe_trx,deskripsi FROM [dbo].[tb_trx] WHERE id_user = '"+id+"'", con.buka());
                DataSet ds = new DataSet();
                adapter.Fill(ds, "tb_trx");
                dgvListTransaksi.DataSource = ds.Tables["tb_trx"].DefaultView;
                dgvListTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                getTotalSaldo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                string tipeTrx = rbUangMasuk.Checked ? "masuk" : "keluar";
                cmd = new SqlCommand("INSERT INTO [dbo].[tb_trx] (id_user, tgl_trx, jumlah_trx, tipe_trx,deskripsi) VALUES (@id_user, @tgl_trx, @jumlah_trx, @tipe_trx,@deskripsi)", con.buka());
                cmd.Parameters.AddWithValue("@id_user", idUser);
                cmd.Parameters.AddWithValue("@tgl_trx", dtpTanggal.Value.ToString());
                cmd.Parameters.AddWithValue("@jumlah_trx", txtJumlahTrx.Text);
                cmd.Parameters.AddWithValue("@deskripsi", txtDeskripsi.Text);
                cmd.Parameters.AddWithValue("@tipe_trx", tipeTrx);
                reader = cmd.ExecuteReader();
                MessageBox.Show("Berhasil Menambah Transaksi");
                showData(idUser);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvListTransaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvListTransaksi.Rows.Count)
            {
                DataGridViewRow row = dgvListTransaksi.Rows[e.RowIndex];
                if (row.Cells["jumlah_trx"].Value.ToString() != "")
                {
                    txtId.Text = row.Cells["id"].Value.ToString();
                    txtJumlahTrx.Text = row.Cells["jumlah_trx"].Value.ToString();
                    dtpTanggal.Text = row.Cells["tgl_trx"].Value.ToString();
                    txtDeskripsi.Text = row.Cells["deskripsi"].Value.ToString();
                    rbUangMasuk.Checked = row.Cells["tipe_trx"].Value.ToString().Equals("masuk");
                    rbUangKeluar.Checked = row.Cells["tipe_trx"].Value.ToString().Equals("keluar");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        void clear()
        {
            txtId.Clear();
            dtpTanggal.Value = DateTime.Now;
            txtJumlahTrx.Clear();
            txtDeskripsi.Clear();
            rbUangKeluar.Checked = false;
            rbUangMasuk.Checked ^= false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string tipeTrx = rbUangMasuk.Checked ? "masuk" : "keluar";
                cmd = new SqlCommand("UPDATE [dbo].[tb_trx] SET tgl_trx=@tgl_trx, jumlah_trx=@jumlah_trx, tipe_trx=@tipe_trx ,deskripsi=@deskripsi WHERE id = '"+txtId.Text+"'", con.buka());
                cmd.Parameters.AddWithValue("@id_user", idUser);
                cmd.Parameters.AddWithValue("@tgl_trx", dtpTanggal.Value.ToString());
                cmd.Parameters.AddWithValue("@jumlah_trx", txtJumlahTrx.Text);
                cmd.Parameters.AddWithValue("@deskripsi", txtDeskripsi.Text);
                cmd.Parameters.AddWithValue("@tipe_trx", tipeTrx);
                reader = cmd.ExecuteReader();
                MessageBox.Show("Berhasil Menambah Transaksi");
                showData(idUser);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getTotalSaldo()
        {
            try
            {
                cmd = new SqlCommand("SELECT SUM(CASE WHEN tipe_trx = 'masuk' THEN jumlah_trx ELSE 0 END) - SUM(CASE WHEN tipe_trx = 'keluar' THEN jumlah_trx ELSE 0 END) AS total_saldo FROM [dbo].[tb_trx] WHERE id_user = '"+idUser+"'", con.buka());
                reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    lbTotalSaldo.Text = "Rp. "+ reader["total_saldo"].ToString();
                } 
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBaru_Click(object sender, EventArgs e)
        {
            clear();
            showData(idUser);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("DELETE FROM [dbo].[tb_trx] WHERE id = '" + txtId.Text + "'", con.buka());
                reader = cmd.ExecuteReader();
                MessageBox.Show("Transaksi Telah Terhapus");
                showData(idUser);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
