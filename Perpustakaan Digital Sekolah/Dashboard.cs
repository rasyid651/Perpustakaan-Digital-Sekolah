using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perpustakaan_Digital_Sekolah
{
    public partial class Dashboard : Form
    {
        string conDb = @"Data Source=.\SQLEXPRESS;Database=PerpusSekolah;Integrated Security=True;TrustServerCertificate=True;";
       
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dbs = new Dashboard();
            dbs.Show();
            this.Hide();
        }

        private void btnKelolaBuku_Click(object sender, EventArgs e)
        {
            CrudBuku cb = new CrudBuku();
            cb.Show();
            this.Hide();
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            Laporan laporan = new Laporan();
            laporan.Show();
            this.Hide();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            if (UserSession.name == "admin")
            {
                lblRole.Text = "admin";
            }else
            {
                lblRole.Text = "petugas";
            }
        }

        private void btnPinjam_Click(object sender, EventArgs e)
        {
            CrudPinjaman pj = new CrudPinjaman();
            pj.Show();
            this.Hide();
        }
    }
}
