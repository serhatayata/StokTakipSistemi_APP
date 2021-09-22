using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StokTakipSistemiAPP.DAL;
using StokTakipSistemiAPP.BLL;
using StokTakipSistemiAPP.DAL.DAO;
using StokTakipSistemiAPP.DAL.DTO;

namespace StokTakipSistemiAPP
{
    public partial class FrmKategoriListesi : Form
    {
        public FrmKategoriListesi()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmKategori frm = new FrmKategori();
            frm.isUpdate = false;
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
            dto = bll.Select();
            dataGridView1.DataSource = dto.Kategoriler;
        }
        KategoriDTO dto = new KategoriDTO();
        KategoriBLL bll = new KategoriBLL();
        private void FrmKategoriListesi_Load(object sender, EventArgs e)
        {
            dto = bll.Select();
            dataGridView1.DataSource = dto.Kategoriler;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Kategori Adı";
        }
        private void txtKategoriAd_TextChanged(object sender, EventArgs e)
        {
            List<KategoriDetayDTO> list = new List<KategoriDetayDTO>();
            list = dto.Kategoriler;
            list = list.Where(x=> x.KategoriAd.Contains(txtKategoriAd.Text)).ToList();
            dataGridView1.DataSource = list;

        }
        KategoriDetayDTO detay = new KategoriDetayDTO();
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detay.ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            detay.KategoriAd = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (detay.ID == 0)
            {
                MessageBox.Show("Kategori seçiniz.","UYARI", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                FrmKategori frm = new FrmKategori();
                frm.isUpdate = true;
                frm.detay = detay;
                this.Hide();
                frm.ShowDialog();
                this.Visible = true;
                bll = new KategoriBLL();
                dto = bll.Select();
                dataGridView1.DataSource = dto.Kategoriler;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (detay.ID == 0)
            {
                MessageBox.Show("Kategori Seçiniz..");
            }
            else
            {
                DialogResult result = MessageBox.Show("Silinsin mi?", "Dikkat", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (bll.Delete(detay))
                    {
                        MessageBox.Show("Silindi.");
                        dto = bll.Select();
                        dataGridView1.DataSource = dto.Kategoriler;
                    }
                }
            }
        }
    }
}
