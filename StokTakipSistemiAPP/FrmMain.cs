using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipSistemiAPP
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            FrmMusteriListesi frm = new FrmMusteriListesi();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }
        private void btnUrunler_Click(object sender, EventArgs e)
        {
            FrmUrunListesi frm = new FrmUrunListesi();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }
        private void btnSatis_Click(object sender, EventArgs e)
        {
            FrmSatisListesi frm = new FrmSatisListesi();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnStokEkleme_Click(object sender, EventArgs e)
        {
            FrmStokEkle frm = new FrmStokEkle();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnSilinenler_Click(object sender, EventArgs e)
        {
            FrmSilinenler frm = new FrmSilinenler();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }
        private void btnKategoriler_Click(object sender, EventArgs e)
        {
            FrmKategoriListesi frm = new FrmKategoriListesi();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
