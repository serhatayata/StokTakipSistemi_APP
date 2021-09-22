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
    public partial class FrmSatis : Form
    {
        public FrmSatis()
        {
            InitializeComponent();
        }
        public SatisDTO dto = new SatisDTO();
        public SatisDetayDTO detaydto = new SatisDetayDTO();
        public bool isUpdate = false;
        private void FrmSatis_Load(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                panel1.Visible = false;
                txtMusteriAd.Text = detaydto.MusteriAd;
                txtUrunAd.Text = detaydto.UrunAd;
                txtUrunFiyat.Text = detaydto.Fiyat.ToString();
                List<UrunDetayDTO> urunler = dto.Urunler;
                UrunDetayDTO urun = urunler.First(x => x.ID == detaydto.UrunID);
                txtUrunStok.Text = urun.StokMiktari.ToString();
            }
            else
            {
                dataGridMusteriler.DataSource = dto.Musteriler;
                //Müşteri Datagrid
                dataGridMusteriler.Columns[0].Visible = false;
                dataGridMusteriler.Columns[1].HeaderText = "Müşteri Adı";
                //Ürünler datagrid
                dataGridUrunler.DataSource = dto.Urunler;
                dataGridUrunler.Columns[0].Visible = false;
                dataGridUrunler.Columns[1].HeaderText = "Ürün Adı";
                dataGridUrunler.Columns[2].HeaderText = "Kategori";
                dataGridUrunler.Columns[3].Visible = false;
                dataGridUrunler.Columns[4].Visible = false;
                dataGridUrunler.Columns[5].Visible = false;
                dataGridUrunler.Columns[6].Visible = false;
                //Combobox
                cmbKategori.DataSource = dto.Kategoriler;
                cmbKategori.DisplayMember = "KategoriAd";
                cmbKategori.ValueMember = "ID";
                cmbKategori.SelectedIndex = -1;
                if (dto.Kategoriler.Count > 0)
                {
                    comboFull = true;
                }
            }
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
        bool comboFull = false;
        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboFull)
            {
                List<UrunDetayDTO> list = dto.Urunler;
                if (cmbKategori.SelectedIndex != -1)
                {
                    list = list.Where(x => x.KategoriID == Convert.ToInt32(cmbKategori.SelectedValue)).ToList();
                    dataGridUrunler.DataSource = list;
                }
            }
        }

        private void txtAramaMusteriAd_TextChanged(object sender, EventArgs e)
        {
            List<MusteriDetayDTO> list = dto.Musteriler;
            if (txtAramaMusteriAd.Text.Trim() != "")
            {
                list = list.Where(x => x.MusteriAd.Contains(txtAramaMusteriAd.Text)).ToList();
                dataGridMusteriler.DataSource = list;
            }
        }

        private void dataGridMusteriler_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detay.MusteriID = Convert.ToInt32(dataGridMusteriler.Rows[e.RowIndex].Cells[0].Value);
            detay.MusteriAd = dataGridMusteriler.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtMusteriAd.Text = detay.MusteriAd;
        }
        SatisDetayDTO detay = new SatisDetayDTO();
        private void dataGridUrunler_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detay.UrunID = Convert.ToInt32(dataGridUrunler.Rows[e.RowIndex].Cells[0].Value);
            detay.Fiyat = Convert.ToInt32(dataGridUrunler.Rows[e.RowIndex].Cells[4].Value);
            detay.StokMiktar = Convert.ToInt32(dataGridUrunler.Rows[e.RowIndex].Cells[3].Value);
            detay.KategoriID = Convert.ToInt32(dataGridUrunler.Rows[e.RowIndex].Cells[5].Value);
            detay.UrunAd = dataGridUrunler.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtUrunStok.Text = detay.StokMiktar.ToString();
            txtUrunAd.Text = detay.UrunAd;
            txtUrunFiyat.Text = detay.Fiyat.ToString();
        }
        SatisBLL bll = new SatisBLL();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtSatisMiktari.Text.Trim() == "")
            {
                MessageBox.Show("Lütfen satış miktarı giriniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                if (isUpdate)
                {
                    if (detaydto.SatisMiktar == Convert.ToInt32(txtSatisMiktari.Text))
                    {
                        MessageBox.Show("Değişiklik yok.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        int temp = detaydto.SatisMiktar + Convert.ToInt32(txtUrunStok.Text);
                        if (temp <= Convert.ToInt32(txtSatisMiktari.Text))
                        {
                            MessageBox.Show("Yeterli stok yok.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            detaydto.SatisMiktar = Convert.ToInt32(txtSatisMiktari.Text);
                            detaydto.StokMiktar = Convert.ToInt32(txtUrunStok.Text);
                            if (bll.Update(detaydto))
                            {
                                MessageBox.Show("Güncellendi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                        }
                    }
                }
                else
                {
                    if (detay.UrunID == 0)
                    {
                        MessageBox.Show("Ürün seçiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (detay.MusteriID == 0)
                    {
                        MessageBox.Show("Müşteri seçiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (detay.StokMiktar <= Convert.ToInt32(txtSatisMiktari.Text))
                    {
                        MessageBox.Show("Yeterli stok yok.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        detay.SatisMiktar = Convert.ToInt32(txtSatisMiktari.Text);
                        if (bll.Insert(detay))
                        {
                            MessageBox.Show("Eklendi.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtSatisMiktari.Clear();
                            dto = bll.Select();
                            dataGridUrunler.DataSource = dto.Urunler;
                        }
                    }
                }
            }
        }
    }
}
