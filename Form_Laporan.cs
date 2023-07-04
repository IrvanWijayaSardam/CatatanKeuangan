using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace CatatanKeuangan
{
    public partial class Form_Laporan : Form
    {
        config con = new config();
        SqlCommand cmd;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        String idUser = Form1.id;


        public Form_Laporan()
        {
            InitializeComponent();
            showData(idUser);
        }
        private void showData(String id)
        {
            try
            {
                adapter = new SqlDataAdapter("SELECT id,tgl_trx,jumlah_trx,tipe_trx,deskripsi FROM [dbo].[tb_trx] WHERE id_user = '" + id + "'", con.buka());
                DataSet ds = new DataSet();
                adapter.Fill(ds, "tb_trx");
                dgvLaporan.DataSource = ds.Tables["tb_trx"].DefaultView;
                dgvLaporan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                getSaldoKeluar();
                getSaldoMasuk();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getSaldoKeluar()
        {
            try
            {
                cmd = new SqlCommand("SELECT SUM(CONVERT(NUMERIC(10, 2), jumlah_trx)) AS jumlah_trx FROM [dbo].[tb_trx] WHERE id_user = '" + idUser + "' AND tipe_trx='keluar'", con.buka());
                reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    lbUangKeluar.Text = "Rp. " + reader["jumlah_trx"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void getSaldoMasuk()
        {
            try
            {
                cmd = new SqlCommand("SELECT SUM(CONVERT(NUMERIC(10, 2), jumlah_trx)) AS jumlah_trx FROM [dbo].[tb_trx] WHERE id_user = '" + idUser + "' AND tipe_trx='masuk'", con.buka());
                reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    lbUangKeluar.Text = "Rp. " + reader["jumlah_trx"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            try
            {
                Home fHome= new Home();
                fHome.Show();
                this.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    
}
