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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.datePinjam = new System.Windows.Forms.DateTimePicker();
            this.datePinjamKembali = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvCartBuku = new System.Windows.Forms.DataGridView();
            this.nudJumlah = new System.Windows.Forms.NumericUpDown();
            this.cbPilihBuku = new System.Windows.Forms.ComboBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbNamPin = new System.Windows.Forms.ComboBox();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJudul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAksi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblTotal = new System.Windows.Forms.Label();
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
            this.btnSimpan.Location = new System.Drawing.Point(434, 561);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(213, 42);
            this.btnSimpan.TabIndex = 42;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.Color.Brown;
            this.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatal.ForeColor = System.Drawing.Color.White;
            this.btnBatal.Location = new System.Drawing.Point(135, 561);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(213, 42);
            this.btnBatal.TabIndex = 41;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 18);
            this.label4.TabIndex = 33;
            this.label4.Text = "Nama Peminjam :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Informasi Peminjam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Daftar Buku Yang di Pinjam";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 18);
            this.label5.TabIndex = 47;
            this.label5.Text = "Tanggal Pinjam";
            // 
            // datePinjam
            // 
            this.datePinjam.Location = new System.Drawing.Point(38, 179);
            this.datePinjam.Name = "datePinjam";
            this.datePinjam.Size = new System.Drawing.Size(203, 20);
            this.datePinjam.TabIndex = 48;
            // 
            // datePinjamKembali
            // 
            this.datePinjamKembali.Location = new System.Drawing.Point(38, 262);
            this.datePinjamKembali.Name = "datePinjamKembali";
            this.datePinjamKembali.Size = new System.Drawing.Size(203, 20);
            this.datePinjamKembali.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 18);
            this.label6.TabIndex = 49;
            this.label6.Text = "Tanggal Kembali";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "(Default: 7 hari dari tanggal pinjam)";
            // 
            // dgvCartBuku
            // 
            this.dgvCartBuku.BackgroundColor = System.Drawing.Color.White;
            this.dgvCartBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCartBuku.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNo,
            this.colJudul,
            this.colJumlah,
            this.colAksi});
            this.dgvCartBuku.Location = new System.Drawing.Point(37, 379);
            this.dgvCartBuku.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCartBuku.Name = "dgvCartBuku";
            this.dgvCartBuku.RowHeadersWidth = 51;
            this.dgvCartBuku.RowTemplate.Height = 24;
            this.dgvCartBuku.Size = new System.Drawing.Size(658, 122);
            this.dgvCartBuku.TabIndex = 57;
            this.dgvCartBuku.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCartBuku_CellContentClick);
            // 
            // nudJumlah
            // 
            this.nudJumlah.Location = new System.Drawing.Point(666, 104);
            this.nudJumlah.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudJumlah.Name = "nudJumlah";
            this.nudJumlah.Size = new System.Drawing.Size(62, 20);
            this.nudJumlah.TabIndex = 56;
            // 
            // cbPilihBuku
            // 
            this.cbPilihBuku.DisplayMember = "display";
            this.cbPilihBuku.FormattingEnabled = true;
            this.cbPilihBuku.Location = new System.Drawing.Point(404, 102);
            this.cbPilihBuku.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbPilihBuku.Name = "cbPilihBuku";
            this.cbPilihBuku.Size = new System.Drawing.Size(244, 21);
            this.cbPilihBuku.TabIndex = 55;
            this.cbPilihBuku.ValueMember = "id_buku";
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.Location = new System.Drawing.Point(404, 148);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(124, 37);
            this.btnTambah.TabIndex = 54;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(400, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 18);
            this.label8.TabIndex = 53;
            this.label8.Text = "Pilih Buku";
            // 
            // cbNamPin
            // 
            this.cbNamPin.DisplayMember = "nama";
            this.cbNamPin.FormattingEnabled = true;
            this.cbNamPin.Location = new System.Drawing.Point(37, 102);
            this.cbNamPin.Margin = new System.Windows.Forms.Padding(2);
            this.cbNamPin.Name = "cbNamPin";
            this.cbNamPin.Size = new System.Drawing.Size(244, 21);
            this.cbNamPin.TabIndex = 58;
            this.cbNamPin.ValueMember = "id_user";
            // 
            // colNo
            // 
            this.colNo.HeaderText = "No";
            this.colNo.Name = "colNo";
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
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(593, 341);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(14, 16);
            this.lblTotal.TabIndex = 59;
            this.lblTotal.Text = ">";
            // 
            // KelolaPinjaman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 643);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.cbNamPin);
            this.Controls.Add(this.nudJumlah);
            this.Controls.Add(this.cbPilihBuku);
            this.Controls.Add(this.dgvCartBuku);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.datePinjamKembali);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.datePinjam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.label4);
            this.Name = "KelolaPinjaman";
            this.Text = "KelolaPinjaman";
            this.Load += new System.EventHandler(this.KelolaPinjaman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartBuku)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlah)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker datePinjam;
        private System.Windows.Forms.DateTimePicker datePinjamKembali;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.ComboBox cbPilihBuku;
        private System.Windows.Forms.NumericUpDown nudJumlah;
        private System.Windows.Forms.DataGridView dgvCartBuku;
        private System.Windows.Forms.ComboBox cbNamPin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJudul;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJumlah;
        private System.Windows.Forms.DataGridViewButtonColumn colAksi;
        private System.Windows.Forms.Label lblTotal;
    }
}