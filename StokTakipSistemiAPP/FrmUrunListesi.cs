using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StokTakipSistemiAPP.BLL;
using StokTakipSistemiAPP.DAL.DAO;
using StokTakipSistemiAPP.DAL.DTO;

namespace StokTakipSistemiAPP
{
    public partial class FrmUrunListesi : Form
    {
        public FrmUrunListesi()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUrunFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            { e.Handled = true; }
        }

        private void txtUrunStok_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            { e.Handled = true; }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmUrun frm = new FrmUrun();
            this.Hide();
            frm.dto = dto;
            frm.ShowDialog();
            this.Visible = true;
            dto = bll.Select();
            dataGridView1.DataSource = dto.Urunler;
        }
        UrunBLL bll = new UrunBLL();
        UrunDTO dto = new UrunDTO();
        private void FrmUrunListesi_Load(object sender, EventArgs e)
        {
            dto = bll.Select();
            dataGridView1.DataSource = dto.Urunler;
            cmbKategori.DataSource = dto.Kategoriler;
            cmbKategori.DisplayMember = "KategoriAd";
            cmbKategori.ValueMember = "ID";
            cmbKategori.SelectedIndex = -1;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Ürün Ad";
            dataGridView1.Columns[2].HeaderText = "Kategori Ad";
            dataGridView1.Columns[3].HeaderText = "Stok Miktarı";
            dataGridView1.Columns[4].HeaderText = "Ürün Fiyat";
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            List<UrunDetayDTO> list = new List<UrunDetayDTO>();
            list = dto.Urunler;
            //Urun Ad Arama
            if (txtUrunAd.Text.Trim() != "")
            {
                list = list.Where(x => x.UrunAd.Contains(txtUrunAd.Text)).ToList();
            }
            //Kategori Arama
            if (cmbKategori.SelectedIndex != -1)
            {
                list = list.Where(x=> x.KategoriID == Convert.ToInt32(cmbKategori.SelectedValue)).ToList();
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
            //Stok Arama
            if (rbSBuyuk.Checked)
            {
                list = list.Where(x => x.StokMiktari > Convert.ToInt32(txtUrunStok.Text)).ToList();
            }
            if (rbSKucuk.Checked)
            {
                list = list.Where(x => x.StokMiktari < Convert.ToInt32(txtUrunStok.Text)).ToList();
            }
            if (rbSEsit.Checked)
            {
                list = list.Where(x => x.StokMiktari == Convert.ToInt32(txtUrunStok.Text)).ToList();
            }
            dataGridView1.DataSource = list;

        }
        void temizle()
        {
            txtUrunAd.Clear();
            txtUrunFiyat.Clear();
            txtUrunStok.Clear();
            cmbKategori.SelectedIndex = -1;
            rbBuyuk.Checked = false;
            rbKucuk.Checked = false;
            rbEsit.Checked = false;
            rbSBuyuk.Checked = false;
            rbSEsit.Checked = false;
            rbSKucuk.Checked = false;
            dataGridView1.DataSource = dto.Urunler;
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
        UrunDetayDTO detayDTO = new UrunDetayDTO();
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detayDTO.UrunAd = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            detayDTO.ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            detayDTO.Fiyat = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
            detayDTO.KategoriID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (detayDTO.ID == 0)
            {
                MessageBox.Show("Ürün Seçiniz.","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                FrmUrun frm = new FrmUrun();
                frm.isUpdate = true;
                frm.detaydto = detayDTO;
                frm.dto = dto;
                this.Hide();
                frm.ShowDialog();
                this.Visible = true;
                bll = new UrunBLL();
                dto = bll.Select(); 
                dataGridView1.DataSource = dto.Urunler;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (detayDTO.ID ==0)
            {
                MessageBox.Show("Seçim yapınız.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult result = MessageBox.Show("Silmek istediğinizden emin misiniz?.", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (bll.Delete(detayDTO))
                    {
                        MessageBox.Show("Silindi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bll = new UrunBLL();
                        dto = bll.Select();
                        dataGridView1.DataSource = dto.Urunler;
                    }
                }
            }
        }
    }
}
