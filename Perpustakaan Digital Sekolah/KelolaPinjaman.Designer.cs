namespace Perpustakaan_Digital_Sekolah
{
    partial class KelolaPinjaman
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvCartBuku = new System.Windows.Forms.DataGridView();
            this.colJudul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAksi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.nudJumlah = new System.Windows.Forms.NumericUpDown();
            this.cbPilihBuku = new System.Windows.Forms.ComboBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartBuku)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlah)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(578, 691);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(4);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(284, 52);
            this.btnSimpan.TabIndex = 42;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.Color.Brown;
            this.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatal.ForeColor = System.Drawing.Color.White;
            this.btnBatal.Location = new System.Drawing.Point(180, 691);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(4);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(284, 52);
            this.btnBatal.TabIndex = 41;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = false;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(50, 124);
            this.txtNama.Margin = new System.Windows.Forms.Padding(4);
            this.txtNama.Multiline = true;
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(381, 36);
            this.txtNama.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 24);
            this.label4.TabIndex = 33;
            this.label4.Text = "Nama Peminjam :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 25);
            this.label2.TabIndex = 45;
            this.label2.Text = "Informasi Peminjam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 416);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 25);
            this.label3.TabIndex = 46;
            this.label3.Text = "Daftar Buku Yang di Pinjam";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 182);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 24);
            this.label5.TabIndex = 47;
            this.label5.Text = "Tanggal Pinjam";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(50, 220);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(269, 22);
            this.dateTimePicker1.TabIndex = 48;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(50, 322);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(269, 22);
            this.dateTimePicker2.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 284);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 24);
            this.label6.TabIndex = 49;
            this.label6.Text = "Tanggal Kembali";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 358);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(231, 17);
            this.label7.TabIndex = 51;
            this.label7.Text = "(Default: 7 hari dari tanggal pinjam)";
            // 
            // dgvCartBuku
            // 
            this.dgvCartBuku.BackgroundColor = System.Drawing.Color.White;
            this.dgvCartBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCartBuku.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colJudul,
            this.colJumlah,
            this.colAksi});
            this.dgvCartBuku.Location = new System.Drawing.Point(49, 466);
            this.dgvCartBuku.Name = "dgvCartBuku";
            this.dgvCartBuku.RowHeadersWidth = 51;
            this.dgvCartBuku.RowTemplate.Height = 24;
            this.dgvCartBuku.Size = new System.Drawing.Size(623, 150);
            this.dgvCartBuku.TabIndex = 57;
            // 
            // colJudul
            // 
            this.colJudul.DataPropertyName = "judul";
            this.colJudul.HeaderText = "Judul Buku";
            this.colJudul.MinimumWidth = 6;
            this.colJudul.Name = "colJudul";
            this.colJudul.Width = 125;
            // 
            // colJumlah
            // 
            this.colJumlah.DataPropertyName = "jumlah";
            this.colJumlah.HeaderText = "Jumlah";
            this.colJumlah.MinimumWidth = 6;
            this.colJumlah.Name = "colJumlah";
            this.colJumlah.Width = 125;
            // 
            // colAksi
            // 
            this.colAksi.HeaderText = "Aksi";
            this.colAksi.MinimumWidth = 6;
            this.colAksi.Name = "colAksi";
            this.colAksi.Text = "Hapus";
            this.colAksi.Width = 125;
            // 
            // nudJumlah
            // 
            this.nudJumlah.Location = new System.Drawing.Point(888, 128);
            this.nudJumlah.Name = "nudJumlah";
            this.nudJumlah.Size = new System.Drawing.Size(82, 22);
            this.nudJumlah.TabIndex = 56;
            // 
            // cbPilihBuku
            // 
            this.cbPilihBuku.DisplayMember = "judul";
            this.cbPilihBuku.FormattingEnabled = true;
            this.cbPilihBuku.Location = new System.Drawing.Point(538, 126);
            this.cbPilihBuku.Name = "cbPilihBuku";
            this.cbPilihBuku.Size = new System.Drawing.Size(324, 24);
            this.cbPilihBuku.TabIndex = 55;
            this.cbPilihBuku.ValueMember = "id_buku";
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.Location = new System.Drawing.Point(538, 182);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(4);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(166, 45);
            this.btnTambah.TabIndex = 54;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(534, 89);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 24);
            this.label8.TabIndex = 53;
            this.label8.Text = "Pilih Buku";
            // 
            // KelolaPinjaman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1067, 791);
            this.Controls.Add(this.nudJumlah);
            this.Controls.Add(this.cbPilihBuku);
            this.Controls.Add(this.dgvCartBuku);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KelolaPinjaman";
            this.Text = "KelolaPinjaman";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartBuku)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlah)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.ComboBox cbPilihBuku;
        private System.Windows.Forms.NumericUpDown nudJumlah;
        private System.Windows.Forms.DataGridView dgvCartBuku;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJudul;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJumlah;
        private System.Windows.Forms.DataGridViewButtonColumn colAksi;
    }
}