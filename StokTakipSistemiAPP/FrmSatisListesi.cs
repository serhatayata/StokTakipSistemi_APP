using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StokTakipSistemiAPP.DAL.DTO;
using StokTakipSistemiAPP.DAL.DAO;
using StokTakipSistemiAPP.BLL;
namespace StokTakipSistemiAPP
{
    public partial class FrmSatisListesi : Form
    {
        public FrmSatisListesi()
        {
            InitializeComponent();
        }
        SatisDTO dto = new SatisDTO();
        SatisBLL bll = new SatisBLL();
        private void FrmSatisListesi_Load(object sender, EventArgs e)
        {
            dto = bll.Select();
            cmbKategori.DataSource = dto.Kategoriler;
            cmbKategori.DisplayMember = "KategoriAd";
            cmbKategori.ValueMember = "ID";
            cmbKategori.SelectedIndex = -1;
            dataGridView1.DataSource = dto.Satislar;
            dataGridView1.Columns[0].HeaderText = "Ürün Adı";
            dataGridView1.Columns[1].HeaderText = "Müşteri Adı";
            dataGridView1.Columns[2].HeaderText = "Kategori";
            dataGridView1.Columns[3].HeaderText = "Fiyatı";
            dataGridView1.Columns[4].HeaderText = "Satış Tarihi";
            dataGridView1.Columns[5].HeaderText = "Satış Miktarı";
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;

    }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void txtSatisMiktari_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            { e.Handled = true; }
        }

        private void txtUrunFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            { e.Handled = true; }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmSatis frm = new FrmSatis();
            frm.dto = dto;
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
            dto = bll.Select();
            dataGridView1.DataSource = dto.Satislar;
            temizle();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            List<SatisDetayDTO> list = dto.Satislar;
            if (txtUrunAd.Text.Trim() != "")
            {
                list = list.Where(x => x.UrunAd.Contains(txtUrunAd.Text)).ToList();
            }
            if (txtMusteriAd.Text.Trim() != "")
            {
                list = list.Where(x => x.MusteriAd.Contains(txtMusteriAd.Text)).ToList();
            }
            //Kategori Arama
            if (cmbKategori.SelectedIndex != -1)
            {
                list = list.Where(x => x.KategoriID == Convert.ToInt32(cmbKategori.SelectedValue)).ToList();
            }
            //Fiyat Arama
            if (rbBuyuk.Checked)
            {
                list = list.Where(x => x.Fiyat > Convert.ToInt32(txtUrunFiyat.Text)).ToList();
            }
            if (rbKucuk.Checked)
            {
                list = list.Where(x => x.Fiyat < Convert.ToInt32(txtUrunFiyat.Text)).ToList();
            }
            if (rbEsit.Checked)
            {
                list = list.Where(x => x.Fiyat == Convert.ToInt32(txtUrunFiyat.Text)).ToList();
            }
            //Satış Arama
            if (rbSBuyuk.Checked)
            {
                list = list.Where(x => x.SatisMiktar > Convert.ToInt32(txtSatisMiktari.Text)).ToList();
            }
            if (rbSKucuk.Checked)
            {
                list = list.Where(x => x.SatisMiktar < Convert.ToInt32(txtSatisMiktari.Text)).ToList();
            }
            if (rbSEsit.Checked)
            {
                list = list.Where(x => x.SatisMiktar == Convert.ToInt32(txtSatisMiktari.Text)).ToList();
            }
            if (chTarih.Checked)
            {
                list = list.Where(x => x.SatisTarihi > dpBaslangic.Value && x.SatisTarihi < dpBitis.Value).ToList();
            }
            dataGridView1.DataSource = list;

        }
        void temizle()
        {
            txtUrunAd.Clear();
            txtUrunFiyat.Clear();
            txtSatisMiktari.Clear();
            txtMusteriAd.Clear();
            cmbKategori.SelectedIndex = -1;
            rbBuyuk.Checked = false;
            rbKucuk.Checked = false;
            rbEsit.Checked = false;
            rbSBuyuk.Checked = false;
            rbSEsit.Checked = false;
            rbSKucuk.Checked = false;
            dpBaslangic.Value = DateTime.Today;
            dpBitis.Value = DateTime.Today;
            chTarih.Checked = false;
            dataGridView1.DataSource = dto.Satislar;
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
        SatisDetayDTO detay = new SatisDetayDTO();
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detay.MusteriAd = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            detay.UrunAd = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            detay.Fiyat = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
            detay.SatisID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[10].Value);
            detay.UrunID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[7].Value);
            detay.MusteriID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[8].Value);
            detay.SatisMiktar = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
    }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (detay.UrunID ==0)
            {
                MessageBox.Show("Seçim yapınız.");
            }
            else
            {
                FrmSatis frm = new FrmSatis();
                frm.dto = dto;
                frm.detaydto = detay;
                frm.isUpdate = true;
                this.Hide();
                frm.ShowDialog();
                this.Visible = true;
                bll = new SatisBLL();
                dto = bll.Select();
                dataGridView1.DataSource = dto.Satislar;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (detay.SatisID == 0)
            {
                MessageBox.Show("Satış seçiniz.","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult result = MessageBox.Show("Silmek istediğinizden emin misiniz?.", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (bll.Delete(detay))
                    {
                        MessageBox.Show("Silme işlemi başarılı.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bll = new SatisBLL();
                        dto = bll.Select();
                        dataGridView1.DataSource = dto.Satislar;
                    }
                }
            }
        }
    }
}
