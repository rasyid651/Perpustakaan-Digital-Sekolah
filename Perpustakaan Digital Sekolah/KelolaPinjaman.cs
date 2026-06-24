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
    public partial class KelolaPinjaman : Form
    {
        string conDb = @"Data Source.\SQLEXPRESS;Database=PerpusSekolah;Integrated Security=True;TrustServerCertiface=True;";
        public int idPinjamEdit = 0; // 0 tambah, > 0 edit
        public KelolaPinjaman()
        {
            InitializeComponent();
        }

        private void KelolaPinjaman_Load(object sender, EventArgs e)
        {
            LoadComboPeminjam();
            LoadComboBuku();
            setTanggal();
        }

        private void LoadComboPeminjam()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conDb))
                {
                    con.Open();
                    string query = "SELECT id_user, nama FROM tbl_user ORDER BY nama";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            System.Data.DataTable dt = new System.Data.DataTable();
                            adapter.Fill(dt);
                            cbNamPin.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan nama : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadComboBuku()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conDb))
                {
                    con.Open();
                    string query = "SELECT id_buku,judul + '(Stok:' + CAST(stok as VARCHAR) + ' )' as display FROM tbl_buku WHERE stok > 0";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            System.Data.DataTable dt = new System.Data.DataTable();
                            adapter.Fill(dt);
                            cbPilihBuku.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan buku : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setTanggal()
        {
            datePinjam.Value = DateTime.Now;
            datePinjamKembali.Value = DateTime.Now.AddDays(7);
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (cbPilihBuku.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih buku terlebih dahulu!");
                return;
            }

            // ambil data
            int idBuku = Convert.ToInt32(cbPilihBuku.SelectedValue);
            string judulBuku = cbPilihBuku.Text.Split('(')[0].Trim();
            int jumlah = (int)nudJumlah.Value;

            // cek buku sudah di cart blm
            bool sudahAda = false;
            foreach (DataGridViewRow row in dgvCartBuku.Rows)
            {
                if (row.Cells["colNo"].Value.ToString() == idBuku.ToString()) 
                {
                // tambah jumlah
                int qtyLama = Convert.ToInt32(row.Cells["colJumlah"].Value);
                row.Cells["colJumlah"].Value = qtyLama + jumlah;
                sudahAda = true;
                break;
                }
            }

            if (!sudahAda)
            {
                dgvCartBuku.Rows.Add(idBuku, judulBuku, jumlah);
            }

            HitungTotalBuku();
        }

        private void dgvCartBuku_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // hapus baris
            if (e.ColumnIndex == dgvCartBuku.Columns["colAksi"].Index && e.RowIndex >= 0)
            {
                dgvCartBuku.Rows.RemoveAt(e.RowIndex);
                HitungTotalBuku();
            }
        }

        private void HitungTotalBuku()
        {
            int total = 0;
            foreach(DataGridViewRow row in dgvCartBuku.Rows)
            {
                if (!row.IsNewRow)
                {
                    total += Convert.ToInt32(row.Cells["colJumlah"].Value);
                }
                lblTotal.Text = $"Total: {total} buku";
            }
        }

        public void LoadDataEdit()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conDb))
                {
                    con.Open();
                    string query = @"SELECT * FROM tbl_peminjaman WHERE id_pinjam = @idPin";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@idPin", idPinjamEdit);
                        
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                datePinjam.Value = Convert.ToDateTime(reader["tanggal"]);
                                datePinjamKembali.Value = Convert.ToDateTime(reader["tanggal"]);
                            }
                        }

                    }
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan Data edit : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // validasi
            if (cbNamPin.SelectedIndex == 1){
                MessageBox.Show("Pilih peminjam!");
                return;
            }

            if (dgvCartBuku.Rows.Count == 0 || (dgvCartBuku.Rows.Count == 1 && dgvCartBuku.Rows[0].IsNewRow))
            {
                MessageBox.Show("Minimal 1 buku harus dipilih!");
                return;
            }

            DialogResult konfirmasi = MessageBox.Show("Simpan data peminjam?", "Konfirmasi", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (konfirmasi == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(conDb))
                    {
                        con.Open();

                        // ketika gagal maka data akan batal terkirim
                        SqlTransaction trans = con.BeginTransaction();

                        try
                        {
                            int idPinjam = 0;
                            int idUser = Convert.ToInt32(cbNamPin.SelectedValue);

                            if (idPinjamEdit > 0)
                            {
                                // UPDATE
                                string query = "UPDATE tbl_peminjaman SET tanggal = @tgl, tanggal_kembali = @tgl_kembali WHERE id_pinjam = @id";
                                using (SqlCommand cmd = new SqlCommand(query, con, trans))
                                {
                                    cmd.Parameters.AddWithValue("@tgl", datePinjam.Value);
                                    cmd.Parameters.AddWithValue("@tgl_kembali", datePinjamKembali.Value);
                                    cmd.Parameters.AddWithValue("@id", idPinjamEdit);
                                    cmd.ExecuteNonQuery();
                                    idPinjam = idPinjamEdit;
                                }
                            }
                            else
                            {
                                // INSERT
                                string query = @"INSERT INTO tbl_peminjaman (id_user, tanggal, tanggal_kembali, status) 
                                               VALUES (@user, @tgl, @tgl_kembali, 0); SELECT SCOPE_IDENTITY()";

                                using (SqlCommand cmd = new SqlCommand(query, con, trans))
                                {
                                    cmd.Parameters.AddWithValue("@user", idUser);
                                    cmd.Parameters.AddWithValue("@tgl", datePinjam.Value);
                                    cmd.Parameters.AddWithValue("@tgl_kembali", datePinjamKembali.Value);
                                    idPinjam = Convert.ToInt32(cmd.ExecuteScalar());
                                }
                            }

                            // Insert detail peminjaman
                            foreach (DataGridViewRow row in dgvCartBuku.Rows)
                            {
                                if (!row.IsNewRow)
                                {
                                    int idBuku = Convert.ToInt32(row.Cells["colIdBuku"].Value);
                                    int jumlah = Convert.ToInt32(row.Cells["colJumlah"].Value);

                                    // Insert ke detail
                                    string queryDetail = @"INSERT INTO tbl_detail_peminjaman (id_pinjam, id_buku, jumlah) 
                                                          VALUES (@pinjam, @buku, @jml)";

                                    using (SqlCommand cmdDetail = new SqlCommand(queryDetail, con, trans))
                                    {
                                        cmdDetail.Parameters.AddWithValue("@pinjam", idPinjam);
                                        cmdDetail.Parameters.AddWithValue("@buku", idBuku);
                                        cmdDetail.Parameters.AddWithValue("@jml", jumlah);
                                        cmdDetail.ExecuteNonQuery();
                                    }

                                    // Kurangi stok buku
                                    string queryStok = "UPDATE tbl_buku SET stok = stok - @jml WHERE id_buku = @buku";
                                    using (SqlCommand cmdStok = new SqlCommand(queryStok, con, trans))
                                    {
                                        cmdStok.Parameters.AddWithValue("@jml", jumlah);
                                        cmdStok.Parameters.AddWithValue("@buku", idBuku);
                                        cmdStok.ExecuteNonQuery();
                                    }
                                }
                            }

                            trans.Commit();
                            MessageBox.Show("Data berhasil disimpan!", "Sukses",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        catch
                        {
                            trans.Rollback();
                            throw;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            CrudPinjaman cpj = new CrudPinjaman();
            cpj.Show();
            this.Hide();
        }
    }
}
