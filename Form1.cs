using System.Data.SqlClient;

namespace CatatanKeuangan
{
    public partial class Form1 : Form
    {
        config con = new config();
        SqlCommand cmd;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        public static String id;

        public Form1()
        {
            InitializeComponent();
        }

        private void lbRegistrasi_Click(object sender, EventArgs e)
        {
            Form_Registrasi register = new Form_Registrasi();
            register.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM [dbo].[tb_user] WHERE username = '"+txtUsername.Text+ "' AND password = '"+txtPassword.Text+"'", con.buka());
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        id = reader["id"].ToString();
                        MessageBox.Show("Login Berhasil");
                        Home home = new Home();
                        home.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Username Atau Password Yang Anda Masukkan Tidak Sesuai");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}