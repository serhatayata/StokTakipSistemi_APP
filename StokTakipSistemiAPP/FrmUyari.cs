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
using StokTakipSistemiAPP.DAL.DAO;
namespace StokTakipSistemiAPP
{
    public partial class FrmUyari : Form
    {
        public FrmUyari()
        {
            InitializeComponent();
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            FrmMain frm = new FrmMain();
            this.Hide();
            frm.ShowDialog();
        }
        UrunBLL bll = new UrunBLL();
        UrunDTO dto = new UrunDTO();
        private void FrmUyari_Load(object sender, EventArgs e)
        {
            //Stok miktarı 50'nin altındaki ürünleri göstereceğiz
            dto = bll.Select();
            dto.Urunler = dto.Urunler.Where(x=> x.StokMiktari <= 50).ToList();
            if (dto.Urunler.Count == 0)
            {
                FrmMain frm = new FrmMain();
                this.Visible = false;
                frm.ShowDialog();
            }
            else
            {
                dataGridView1.DataSource = dto.Urunler;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Ürün Ad";
                dataGridView1.Columns[2].HeaderText = "Kategori Ad";
                dataGridView1.Columns[3].HeaderText = "Stok Miktarı";
                dataGridView1.Columns[4].HeaderText = "Ürün Fiyat";
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;
            }
    
        }
    }
}
