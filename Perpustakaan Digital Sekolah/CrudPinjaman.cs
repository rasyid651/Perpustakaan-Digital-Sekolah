using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Perpustakaan_Digital_Sekolah
{
    public partial class CrudPinjaman : Form
    {
        string conDb = @"Data Source=.\SQLEXPRESS;Database=PerpusSekolah;Integrated Security=True;TrustServerCertificate=True;";
        private bool isModeEdit = false;
        public CrudPinjaman()
        {
            InitializeComponent();
        }

        private void CrudPinjaman_Load(object sender, EventArgs e)
        {
            TampilkanDataPeminjaman();

            if (UserSession.name == "admin")
            {
                lblRole.Text = "admin";
            }
            else
            {
                lblRole.Text = "petugas";
                btnEdit.Visible = false;
                btnTambah.Visible = false;
                btnSelesai.Visible = false;
            }
            cbStatus.SelectedIndex = 0;
        }

        private void TampilkanDataPeminjaman()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conDb))
                {
                    con.Open();
                    // query join tabel
                    string query = @"SELECT p.id_pinjam, p.tanggal, u.nama as peminjam, p.tanggal_kembali, CASE
                    WHEN p.status = 0 THEN 'Dipinjam' ELSE 'Dikembalikan' END as status_text FROM tbl_peminjaman p LEFT JOIN tbl_user
                    u ON p.id_user ORDER BY p.id_pinjam DESC";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            System.Data.DataTable dt = new System.Data.DataTable();
                            adapter.Fill(dt);
                            dgvPeminjaman.DataSource = dt;

                            if (dgvPeminjaman.Columns["id_pinjam"] != null || dgvPeminjaman.Columns["id_user"] != null)
                                dgvPeminjaman.Columns["id_pinjam"].Visible = false;
                                dgvPeminjaman.Columns["id_user"].Visible = false;

                            TampilkanNoUrut();
                        }

                    }
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Data gagal ditampilkan" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void TampilkanNoUrut()
        {
            int no = 1;
            foreach (DataGridViewRow row in dgvPeminjaman.Rows)
            {
                if (!row.IsNewRow)
                {
                    row.Cells["colNo"].Value = no++;
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtCari.Clear();
            cbStatus.SelectedIndex = 0;
            TampilkanDataPeminjaman();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvPeminjaman.CurrentRow == null)
            {
                MessageBox.Show("Pilih baris terlebih dahulu!");
                return;
            }

            // ambil data
            int idPinjam = Convert.ToInt32(dgvPeminjaman.CurrentRow.Cells["id_pinjam"].Value);

            KelolaPinjaman kpj = new KelolaPinjaman();
            kpj.idPinjamEdit = idPinjam; // set ID untuk di Edit
            kpj.LoadDataEdit();
            kpj.ShowDialog();

        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conDb))
                {
                    con.Open();
                    string query = @"SELECT p.id_pinjam, p.tanggal, u.nama as peminjam, 
                            p.tanggal_kembali, CASE 
                            WHEN p.status = 0 THEN 'Dipinjam' ELSE 'Dikembalikan' END as status_text 
                            FROM tbl_peminjaman p 
                            LEFT JOIN tbl_user u ON p.id_user = u.id_user
                            WHERE u.nama LIKE @cari";

                    if (cbStatus.SelectedIndex > 0)
                        query += "AND p.status = " + (cbStatus.SelectedIndex - 1);

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@keyword", "%" + txtCari.Text + "%");

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvPeminjaman.DataSource = dt;
                            TampilkanNoUrut();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pencarian gagal : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            if (dgvPeminjaman.CurrentRow == null)
            {
                MessageBox.Show("Pilih baris terlebih dahulu!");
                return;
            }

            DialogResult konfirmasi = MessageBox.Show("Konfirmasi pengembalian buku?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (konfirmasi == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(conDb))
                    {
                        con.Open();
                        // ambil data
                        int idPinjam = Convert.ToInt32(dgvPeminjaman.CurrentRow.Cells["id_pinjam"].Value);

                        string query = @"UPDATE tbl_peminjaman SET status = 1 WHERE id_pinjam = @idPin";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            // kirim dan jalankan ke query
                            cmd.Parameters.AddWithValue("@idPin", idPinjam);
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Pengembalian buku berhasil dicatat!", "Sukses", MessageBoxButtons.OK, 
                            MessageBoxIcon.Information);
                        TampilkanDataPeminjaman();
                    }
                }catch (Exception ex)
                {
                    MessageBox.Show("Gagal mencatat buku : " + ex.Message, "Error",MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }
    }
}
