using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CatatanKeuangan
{
    class config
    {
        SqlConnection cnn;
        private string strkoneksi = null;

        public SqlConnection buka()
        {
            try
            {
                strkoneksi = "Server = .\\SQLEXPRESS; Database = db_catatan_keuangan ; Integrated Security = SSPI";
                cnn = new SqlConnection(strkoneksi);
                cnn.Open();
                //MessageBox.Show("Berhasil Konek");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return cnn;
        }

    }
}
