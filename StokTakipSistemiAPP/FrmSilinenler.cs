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
using StokTakipSistemiAPP.DAL.DTO;
namespace StokTakipSistemiAPP
{
    public partial class FrmSilinenler : Form
    {
        public FrmSilinenler()
        {
            InitializeComponent();
        }
        SatisDTO dto = new SatisDTO();
        SatisBLL bll = new SatisBLL();
        private void FrmSilinenler_Load(object sender, EventArgs e)
        {
            cmbTablolar.Items.Add("Kategoriler");
            cmbTablolar.Items.Add("Ürünler");
            cmbTablolar.Items.Add("Müşteriler");
            cmbTablolar.Items.Add("Satış");
            dto = bll.Select(true);
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
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbTablolar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTablolar.SelectedIndex == 0)
            {
                dataGridView1.DataSource = dto.Kategoriler;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Kategori Adı";
            }
            else if (cmbTablolar.SelectedIndex == 1)
            {
                dataGridView1.DataSource = dto.Urunler;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Ürün Ad";
                dataGridView1.Columns[2].HeaderText = "Kategori Ad";
                dataGridView1.Columns[3].HeaderText = "Stok Miktarı";
                dataGridView1.Columns[4].HeaderText = "Ürün Fiyat";
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
            }
            else if (cmbTablolar.SelectedIndex == 2)
            {
                dataGridView1.DataSource = dto.Musteriler;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Müşteri Adı";
            }
            else
            {
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
                dataGridView1.Columns[11].Visible = false;
                dataGridView1.Columns[12].Visible = false;
                dataGridView1.Columns[13].Visible = false;
            }
        }
        SatisDetayDTO satis = new SatisDetayDTO();
        UrunDetayDTO urun = new UrunDetayDTO();
        KategoriDetayDTO kategori = new KategoriDetayDTO();
        MusteriDetayDTO musteri = new MusteriDetayDTO();
        KategoriBLL kategoribll = new KategoriBLL();
        UrunBLL urunbll = new UrunBLL();
        MusteriBLL musteribll = new MusteriBLL();
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (cmbTablolar.SelectedIndex == 0)
            {
                kategori.ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                kategori.KategoriAd = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            else if (cmbTablolar.SelectedIndex == 1)
            {
                urun.UrunAd = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                urun.ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                urun.Fiyat = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
                urun.KategoriID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
                urun.isKategoriDeleted = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[7].Value);
            }
            else if (cmbTablolar.SelectedIndex == 2)
            {
                musteri.ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                musteri.MusteriAd = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            else if (cmbTablolar.SelectedIndex == 3)
            {
                satis.MusteriAd = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                satis.UrunAd = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                satis.Fiyat = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                satis.SatisID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[10].Value);
                satis.UrunID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[7].Value);
                satis.MusteriID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[8].Value);
                satis.SatisMiktar = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
            }
        }
        private void btnGeriGetir_Click(object sender, EventArgs e)
        {
            if (cmbTablolar.SelectedIndex == 0)
            {
                if (kategoribll.GetBack(kategori))
                {
                    MessageBox.Show("Geri geldi.","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    bll = new SatisBLL();
                    dto = bll.Select(true);
                    dataGridView1.DataSource = dto.Kategoriler;
                }
            }
            else if(cmbTablolar.SelectedIndex == 1)
            {
                if (urunbll.GetBack(urun))
                {
                    if (urun.isKategoriDeleted)
                    {
                        MessageBox.Show("Kategori silindi. Bu ürün geri getirilemez.");
                    }
                    else
                    {
                        MessageBox.Show("Geri geldi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bll = new SatisBLL();
                        dto = bll.Select(true);
                        dataGridView1.DataSource = dto.Urunler;
                    }
                }
            }
            else if (cmbTablolar.SelectedIndex == 2)
            {
                if (musteribll.GetBack(musteri))
                {
                    MessageBox.Show("Geri geldi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bll = new SatisBLL();
                    dto = bll.Select(true);
                    dataGridView1.DataSource = dto.Musteriler;
                }
            }
            else if (cmbTablolar.SelectedIndex == 3)
            {
                if (bll.GetBack(satis))
                {
                    if (!satis.uDeleted && !satis.kDeleted && !satis.mDeleted)
                    {
                        MessageBox.Show("Silinemez."); 
                    }
                    else
                    {
                        MessageBox.Show("Geri geldi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bll = new SatisBLL();
                        dto = bll.Select(true);
                        dataGridView1.DataSource = dto.Satislar;
                    }
                }
            }
        }
    }
}
