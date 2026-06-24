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

namespace Perpustakaan_Digital_Sekolah
{
    public partial class Login : Form
    {
        string conDb = @"Data Source=.\SQLEXPRESS;Database=PerpusSekolah;Integrated Security=True;TrustServerCertificate=True;";
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            // validasi inputan
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Email atau Password tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ambil inputan
            string name = txtName.Text;
            string password = txtPassword.Text;

            // cek database
            try
            {
                using (SqlConnection con = new SqlConnection(conDb))
                {
                    con.Open();
                    string query = @"SELECT id_user,name,email,password FROM tbl_user WHERE name = @name AND password = @pw";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // mengirim data ke query
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@pw", password);

                        // menjalankan perintah
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                if (reader.Read())
                                {

                                
                                // Simpan data session
                                UserSession.IdUser = Convert.ToInt32(reader["id_user"]);
                                UserSession.name = reader["name"].ToString();
                                UserSession.email = reader["email"].ToString();
                                UserSession.password = reader["password"].ToString();

                                MessageBox.Show("Berhasil login!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                if (UserSession.email == "admin@gmail.com")
                                {
                                    Dashboard keDashboard = new Dashboard();
                                    keDashboard.Show();
                                    this.Hide();
                                }
                                else if (UserSession.email == "petugas@gmail.com")
                                {
                                    Dashboard keDashboard = new Dashboard();
                                    keDashboard.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Name tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            }
                            else
                            {
                                MessageBox.Show("Email tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal login :" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
