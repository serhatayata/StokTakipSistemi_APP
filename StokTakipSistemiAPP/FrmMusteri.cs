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
    public partial class FrmMusteri : Form
    {
        public FrmMusteri()
        {
            InitializeComponent();
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        MusteriDetayDTO detay = new MusteriDetayDTO();
        MusteriBLL bll = new MusteriBLL();
        public MusteriDetayDTO detaydto = new MusteriDetayDTO();
        public bool isUpdate = false;
        private void FrmMusteri_Load(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                txtMusteriAd.Text = detaydto.MusteriAd;
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtMusteriAd.Text.Trim() == "")
            {
                MessageBox.Show("Müşteri Adı Boş","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                if (isUpdate)
                {
                    if (detaydto.MusteriAd == txtMusteriAd.Text)
                    {
                        MessageBox.Show("Değişikli yok.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        detaydto.MusteriAd = txtMusteriAd.Text;
                        if (bll.Update(detaydto))
                        {
                            MessageBox.Show("Eklendi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                }
                else
                {
                    detay.MusteriAd = txtMusteriAd.Text;
                    if (bll.Insert(detay))
                    {
                        MessageBox.Show("Eklendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMusteriAd.Clear();
                    }
                }
            }
        }

     
    }
}
