using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Perpustakaan_Digital_Sekolah
{
    public partial class CrudBuku : Form
    {
        string conDb = @"Data Source=.\SQLEXPRESS;Database=PerpusSekolah;Integrated Security=True;TrustServerCertificate=True;";
        private bool isModeEdit = false;
        public CrudBuku()
        {
            InitializeComponent();
        }

        private void CrudBuku_Load(object sender, EventArgs e)
        {
            TampilkanDataBuku();

            if (UserSession.name == "admin")
            {
                lblRole.Text = "admin";
            }
            else
            {
                lblRole.Text = "petugas";
                btnEdit.Visible = false;
                btnHapus.Visible = false;
                btnHapus.Visible = false;
                btnSimpan.Visible = false;
            }
            LoadKategori();
        }

        private void TampilkanDataBuku()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conDb))
                {
                    con.Open();
                    string query = @"SELECT id_buku,judul,kategori,penulis,stok FROM tbl_buku ORDER BY id_buku";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            System.Data.DataTable dts = new System.Data.DataTable();
                            // isi data ke table sementara
                            adapter.Fill(dts);
                            dgvCrudBuku.DataSource = dts;

                            if (dgvCrudBuku.Columns["id_buku"] != null)
                                dgvCrudBuku.Columns["id_buku"].Visible = false;

                            TampilkanNoUrut();
                        }
                    }
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Data gagal ditampilkan :" + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void TampilkanNoUrut()
        {
            int no = 1;
            foreach (DataGridViewRow row in dgvCrudBuku.Rows)
            {
                if (!row.IsNewRow)
                {
                    row.Cells["colNo"].Value = no++;
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            TampilkanDataBuku();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // validasi input
            if (string.IsNullOrEmpty(txtNama.Text) || string.IsNullOrEmpty(txtKategori.Text) 
                || string.IsNullOrEmpty(txtPenulis.Text) || string.IsNullOrEmpty(txtStok.Text))
            {
                MessageBox.Show("Field tidak boleh kosong!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // ambil data
                int stok = Convert.ToInt32(txtStok.Text);

                using (SqlConnection con = new SqlConnection(conDb))
                {
                    con.Open();
                    string query = "";

                    if (isModeEdit)
                    {
                        // query update
                        query = @"UPDATE tbl_buku SET judul = @jdl, kategori = @ktg, penulis = @pns, stok = @stk WHERE id_buku = @idBuk";
                    }else
                    {
                        // query add
                        query = @"INSERT INTO tbl_buku (judul,kategori,penulis,stok) VALUES (@jdl,@ktg,@pns,@stk)";
                    }

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // mengirim data ke query
                        cmd.Parameters.AddWithValue("@jdl", txtNama.Text);
                        cmd.Parameters.AddWithValue("@ktg", txtKategori.Text);
                        cmd.Parameters.AddWithValue("@pns", txtPenulis.Text);
                        cmd.Parameters.AddWithValue("@stk", stok);

                        if (isModeEdit)
                        {
                            cmd.Parameters.AddWithValue("@idBuk", txtNama.Tag);
                        }

                        int hasil = cmd.ExecuteNonQuery();

                        string pesan = isModeEdit
                            ? "Data berhasil diupdate"
                            : "Data berhasil ditambahkan";

                        MessageBox.Show(pesan, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtNama.Clear();
                        txtKategori.Clear();
                        txtPenulis.Clear();
                        txtStok.Clear();

                        isModeEdit = false;
                        btnSimpan.Text = "Simpan";
                        txtNama.Tag = null;
                        
                        TampilkanDataBuku();
                    }
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Data gagal disimpan : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // validasi data
            if (dgvCrudBuku.CurrentRow == null)
            {
                MessageBox.Show("Pilih baris terlebih dahulu!","Peirngatan",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataTable dt = (DataTable)dgvCrudBuku.DataSource;
                int rowIndex = dgvCrudBuku.CurrentRow.Index;

                if (rowIndex >= 0 && rowIndex < dt.Rows.Count)
                {
                    DataRow row = dt.Rows[rowIndex];

                    // ambil data buku
                    int idBuku = Convert.ToInt32(row["id_buku"]);
                    string judul = row["judul"].ToString();
                    string kategori = row["kategori"].ToString();
                    string penulis = row["penulis"].ToString();
                    int stok = Convert.ToInt32(row["stok"]);

                    // isi textbox dari tabel
                    txtNama.Text = judul;
                    txtKategori.Text = kategori;
                    txtPenulis.Text = penulis;
                    txtStok.Text = stok.ToString();

                    txtNama.Tag = idBuku;

                    // set mode edit
                    isModeEdit = true;
                    btnSimpan.Text = "Update";
                    txtNama.Focus();

                }

            }catch (Exception ex)
            {
                MessageBox.Show("Data gagal diupdate : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            // validasi data
            if (dgvCrudBuku.CurrentRow == null)
            {
                MessageBox.Show("Pilih baris terlebih dahulu!", "Peirngatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ambil data yang ingin dihapus
            int idBuku = Convert.ToInt32(dgvCrudBuku.CurrentRow.Cells["id_buku"].Value.ToString());
            string judul = dgvCrudBuku.CurrentRow.Cells["colJudul"].Value.ToString();

            // konfirmasi hapus
            DialogResult konfirmasi = MessageBox.Show("Yakin ingin menghapus data?",
                "Konfirmasi hapus",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            // jika hapus 
            if (konfirmasi == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(conDb))
                    {
                        con.Open();
                        string query = "DELETE  FROM tbl_buku WHERE id_buku = @idBuk";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@idBuk", idBuku);
                            cmd.ExecuteNonQuery();

                        }

                        MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TampilkanDataBuku();
                    }
                }catch (Exception ex)
                {
                    MessageBox.Show("Gagal menghapus data :" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void LoadKategori()
        {
            using(SqlConnection con = new SqlConnection(conDb))
            {
                con.Open();
                string query = "SELECT DISTINCT kategori FROM tbl_buku";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    cbKategori.SelectedIndex = -1;
                    cbKategori.DataSource = dt;
                }
            }
        }
        private void btnCari_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conDb))
                {
                    con.Open();
                    string query = @"SELECT id_buku,judul,kategori,penulis,stok
                    FROM tbl_buku WHERE judul LIKE @keyword OR kategori LIKE @keyword";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@keyword", "%" + txtCari.Text + "%");

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvCrudBuku.DataSource = dt;
                            TampilkanNoUrut();
                        }
                    }
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Pencarian gagal : " + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
        }


    }
}
