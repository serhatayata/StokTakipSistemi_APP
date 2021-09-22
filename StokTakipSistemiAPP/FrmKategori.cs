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
    public partial class FrmKategori : Form
    {
        public FrmKategori()
        {
            InitializeComponent();
        }
        public KategoriDetayDTO detay = new KategoriDetayDTO();
        public bool isUpdate = false;
        private void FrmKategori_Load(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                txtKategoriAd.Text = detay.KategoriAd; 
            }
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        KategoriBLL bll = new KategoriBLL();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtKategoriAd.Text.Trim() == "")
            {
                MessageBox.Show("Kategori Boş","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                if (isUpdate)
                {
                    if (detay.KategoriAd == txtKategoriAd.Text)
                    {
                        MessageBox.Show("Değişiklik yok.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        detay.KategoriAd = txtKategoriAd.Text;
                        if (bll.Update(detay))
                        {
                            MessageBox.Show("Güncellendi..", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                }
                else
                {
                    KategoriDetayDTO detay = new KategoriDetayDTO();
                    detay.KategoriAd = txtKategoriAd.Text;
                    if (bll.Insert(detay))
                    {
                        MessageBox.Show("Eklendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtKategoriAd.Clear();
                    }
                }
            }
        }

     
    }
}
