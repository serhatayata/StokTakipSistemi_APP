
namespace StokTakipSistemiAPP
{
    partial class FrmSatisListesi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.chTarih = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dpBitis = new System.Windows.Forms.DateTimePicker();
            this.dpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.lblSatisTarihAraligi = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.grpSatis = new System.Windows.Forms.GroupBox();
            this.rbSKucuk = new System.Windows.Forms.RadioButton();
            this.rbSEsit = new System.Windows.Forms.RadioButton();
            this.rbSBuyuk = new System.Windows.Forms.RadioButton();
            this.grpFiyat = new System.Windows.Forms.GroupBox();
            this.rbKucuk = new System.Windows.Forms.RadioButton();
            this.rbEsit = new System.Windows.Forms.RadioButton();
            this.rbBuyuk = new System.Windows.Forms.RadioButton();
            this.lblSatisMiktari = new System.Windows.Forms.Label();
            this.txtSatisMiktari = new System.Windows.Forms.TextBox();
            this.lblUrunFiyat = new System.Windows.Forms.Label();
            this.txtUrunFiyat = new System.Windows.Forms.TextBox();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.lblKategori = new System.Windows.Forms.Label();
            this.lblUrunAd = new System.Windows.Forms.Label();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.lblMusteriAd = new System.Windows.Forms.Label();
            this.txtMusteriAd = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.grpSatis.SuspendLayout();
            this.grpFiyat.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chTarih);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dpBitis);
            this.panel1.Controls.Add(this.dpBaslangic);
            this.panel1.Controls.Add(this.lblSatisTarihAraligi);
            this.panel1.Controls.Add(this.btnAra);
            this.panel1.Controls.Add(this.btnTemizle);
            this.panel1.Controls.Add(this.grpSatis);
            this.panel1.Controls.Add(this.grpFiyat);
            this.panel1.Controls.Add(this.lblSatisMiktari);
            this.panel1.Controls.Add(this.txtSatisMiktari);
            this.panel1.Controls.Add(this.lblUrunFiyat);
            this.panel1.Controls.Add(this.txtUrunFiyat);
            this.panel1.Controls.Add(this.cmbKategori);
            this.panel1.Controls.Add(this.lblKategori);
            this.panel1.Controls.Add(this.lblUrunAd);
            this.panel1.Controls.Add(this.txtUrunAd);
            this.panel1.Controls.Add(this.lblMusteriAd);
            this.panel1.Controls.Add(this.txtMusteriAd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 232);
            this.panel1.TabIndex = 0;
            // 
            // chTarih
            // 
            this.chTarih.AutoSize = true;
            this.chTarih.Location = new System.Drawing.Point(711, 181);
            this.chTarih.Name = "chTarih";
            this.chTarih.Size = new System.Drawing.Size(152, 24);
            this.chTarih.TabIndex = 31;
            this.chTarih.Text = "Tarih Dahil mi ?";
            this.chTarih.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "-----";
            // 
            // dpBitis
            // 
            this.dpBitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dpBitis.Location = new System.Drawing.Point(481, 183);
            this.dpBitis.Name = "dpBitis";
            this.dpBitis.Size = new System.Drawing.Size(200, 22);
            this.dpBitis.TabIndex = 29;
            // 
            // dpBaslangic
            // 
            this.dpBaslangic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dpBaslangic.Location = new System.Drawing.Point(207, 183);
            this.dpBaslangic.Name = "dpBaslangic";
            this.dpBaslangic.Size = new System.Drawing.Size(200, 22);
            this.dpBaslangic.TabIndex = 28;
            // 
            // lblSatisTarihAraligi
            // 
            this.lblSatisTarihAraligi.AutoSize = true;
            this.lblSatisTarihAraligi.Location = new System.Drawing.Point(24, 185);
            this.lblSatisTarihAraligi.Name = "lblSatisTarihAraligi";
            this.lblSatisTarihAraligi.Size = new System.Drawing.Size(164, 20);
            this.lblSatisTarihAraligi.TabIndex = 27;
            this.lblSatisTarihAraligi.Text = "Satış Tarihi Aralığı :";
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(367, 127);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(142, 37);
            this.btnAra.TabIndex = 21;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(536, 127);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(142, 37);
            this.btnTemizle.TabIndex = 22;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // grpSatis
            // 
            this.grpSatis.Controls.Add(this.rbSKucuk);
            this.grpSatis.Controls.Add(this.rbSEsit);
            this.grpSatis.Controls.Add(this.rbSBuyuk);
            this.grpSatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpSatis.Location = new System.Drawing.Point(699, 74);
            this.grpSatis.Name = "grpSatis";
            this.grpSatis.Size = new System.Drawing.Size(268, 55);
            this.grpSatis.TabIndex = 20;
            this.grpSatis.TabStop = false;
            this.grpSatis.Text = "Satış Miktarı";
            // 
            // rbSKucuk
            // 
            this.rbSKucuk.AutoSize = true;
            this.rbSKucuk.Location = new System.Drawing.Point(181, 22);
            this.rbSKucuk.Name = "rbSKucuk";
            this.rbSKucuk.Size = new System.Drawing.Size(67, 20);
            this.rbSKucuk.TabIndex = 2;
            this.rbSKucuk.TabStop = true;
            this.rbSKucuk.Text = "Küçük";
            this.rbSKucuk.UseVisualStyleBackColor = true;
            // 
            // rbSEsit
            // 
            this.rbSEsit.AutoSize = true;
            this.rbSEsit.Location = new System.Drawing.Point(109, 22);
            this.rbSEsit.Name = "rbSEsit";
            this.rbSEsit.Size = new System.Drawing.Size(52, 20);
            this.rbSEsit.TabIndex = 1;
            this.rbSEsit.TabStop = true;
            this.rbSEsit.Text = "Eşit";
            this.rbSEsit.UseVisualStyleBackColor = true;
            // 
            // rbSBuyuk
            // 
            this.rbSBuyuk.AutoSize = true;
            this.rbSBuyuk.Location = new System.Drawing.Point(21, 22);
            this.rbSBuyuk.Name = "rbSBuyuk";
            this.rbSBuyuk.Size = new System.Drawing.Size(68, 20);
            this.rbSBuyuk.TabIndex = 0;
            this.rbSBuyuk.TabStop = true;
            this.rbSBuyuk.Text = "Büyük";
            this.rbSBuyuk.UseVisualStyleBackColor = true;
            // 
            // grpFiyat
            // 
            this.grpFiyat.Controls.Add(this.rbKucuk);
            this.grpFiyat.Controls.Add(this.rbEsit);
            this.grpFiyat.Controls.Add(this.rbBuyuk);
            this.grpFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpFiyat.Location = new System.Drawing.Point(699, 13);
            this.grpFiyat.Name = "grpFiyat";
            this.grpFiyat.Size = new System.Drawing.Size(268, 55);
            this.grpFiyat.TabIndex = 19;
            this.grpFiyat.TabStop = false;
            this.grpFiyat.Text = "Fiyat";
            // 
            // rbKucuk
            // 
            this.rbKucuk.AutoSize = true;
            this.rbKucuk.Location = new System.Drawing.Point(181, 22);
            this.rbKucuk.Name = "rbKucuk";
            this.rbKucuk.Size = new System.Drawing.Size(67, 20);
            this.rbKucuk.TabIndex = 2;
            this.rbKucuk.TabStop = true;
            this.rbKucuk.Text = "Küçük";
            this.rbKucuk.UseVisualStyleBackColor = true;
            // 
            // rbEsit
            // 
            this.rbEsit.AutoSize = true;
            this.rbEsit.Location = new System.Drawing.Point(109, 22);
            this.rbEsit.Name = "rbEsit";
            this.rbEsit.Size = new System.Drawing.Size(52, 20);
            this.rbEsit.TabIndex = 1;
            this.rbEsit.TabStop = true;
            this.rbEsit.Text = "Eşit";
            this.rbEsit.UseVisualStyleBackColor = true;
            // 
            // rbBuyuk
            // 
            this.rbBuyuk.AutoSize = true;
            this.rbBuyuk.Location = new System.Drawing.Point(21, 22);
            this.rbBuyuk.Name = "rbBuyuk";
            this.rbBuyuk.Size = new System.Drawing.Size(68, 20);
            this.rbBuyuk.TabIndex = 0;
            this.rbBuyuk.TabStop = true;
            this.rbBuyuk.Text = "Büyük";
            this.rbBuyuk.UseVisualStyleBackColor = true;
            // 
            // lblSatisMiktari
            // 
            this.lblSatisMiktari.AutoSize = true;
            this.lblSatisMiktari.Location = new System.Drawing.Point(363, 74);
            this.lblSatisMiktari.Name = "lblSatisMiktari";
            this.lblSatisMiktari.Size = new System.Drawing.Size(118, 20);
            this.lblSatisMiktari.TabIndex = 26;
            this.lblSatisMiktari.Text = "Satış Miktarı :";
            // 
            // txtSatisMiktari
            // 
            this.txtSatisMiktari.Location = new System.Drawing.Point(481, 71);
            this.txtSatisMiktari.Name = "txtSatisMiktari";
            this.txtSatisMiktari.Size = new System.Drawing.Size(197, 26);
            this.txtSatisMiktari.TabIndex = 18;
            this.txtSatisMiktari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSatisMiktari_KeyPress);
            // 
            // lblUrunFiyat
            // 
            this.lblUrunFiyat.AutoSize = true;
            this.lblUrunFiyat.Location = new System.Drawing.Point(363, 25);
            this.lblUrunFiyat.Name = "lblUrunFiyat";
            this.lblUrunFiyat.Size = new System.Drawing.Size(102, 20);
            this.lblUrunFiyat.TabIndex = 25;
            this.lblUrunFiyat.Text = "Ürün Fiyat :";
            // 
            // txtUrunFiyat
            // 
            this.txtUrunFiyat.Location = new System.Drawing.Point(481, 22);
            this.txtUrunFiyat.Name = "txtUrunFiyat";
            this.txtUrunFiyat.Size = new System.Drawing.Size(197, 26);
            this.txtUrunFiyat.TabIndex = 17;
            this.txtUrunFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrunFiyat_KeyPress);
            // 
            // cmbKategori
            // 
            this.cmbKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(134, 127);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(197, 24);
            this.cmbKategori.TabIndex = 16;
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(23, 127);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(86, 20);
            this.lblKategori.TabIndex = 24;
            this.lblKategori.Text = "Kategori :";
            // 
            // lblUrunAd
            // 
            this.lblUrunAd.AutoSize = true;
            this.lblUrunAd.Location = new System.Drawing.Point(24, 74);
            this.lblUrunAd.Name = "lblUrunAd";
            this.lblUrunAd.Size = new System.Drawing.Size(85, 20);
            this.lblUrunAd.TabIndex = 23;
            this.lblUrunAd.Text = "Ürün Ad :";
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(134, 71);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(197, 26);
            this.txtUrunAd.TabIndex = 15;
            // 
            // lblMusteriAd
            // 
            this.lblMusteriAd.AutoSize = true;
            this.lblMusteriAd.Location = new System.Drawing.Point(23, 25);
            this.lblMusteriAd.Name = "lblMusteriAd";
            this.lblMusteriAd.Size = new System.Drawing.Size(105, 20);
            this.lblMusteriAd.TabIndex = 1;
            this.lblMusteriAd.Text = "Müşteri Ad :";
            // 
            // txtMusteriAd
            // 
            this.txtMusteriAd.Location = new System.Drawing.Point(134, 22);
            this.txtMusteriAd.Name = "txtMusteriAd";
            this.txtMusteriAd.Size = new System.Drawing.Size(197, 26);
            this.txtMusteriAd.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnEkle);
            this.panel2.Controls.Add(this.btnGuncelle);
            this.panel2.Controls.Add(this.btnSil);
            this.panel2.Controls.Add(this.btnKapat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 429);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(972, 88);
            this.panel2.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(171, 28);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(142, 37);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(341, 28);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(142, 37);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(511, 28);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(142, 37);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(681, 28);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(142, 37);
            this.btnKapat.TabIndex = 7;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 232);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(972, 197);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // FrmSatisListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 517);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmSatisListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Listesi";
            this.Load += new System.EventHandler(this.FrmSatisListesi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpSatis.ResumeLayout(false);
            this.grpSatis.PerformLayout();
            this.grpFiyat.ResumeLayout(false);
            this.grpFiyat.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Label lblMusteriAd;
        private System.Windows.Forms.TextBox txtMusteriAd;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.GroupBox grpSatis;
        private System.Windows.Forms.RadioButton rbSKucuk;
        private System.Windows.Forms.RadioButton rbSEsit;
        private System.Windows.Forms.RadioButton rbSBuyuk;
        private System.Windows.Forms.GroupBox grpFiyat;
        private System.Windows.Forms.RadioButton rbKucuk;
        private System.Windows.Forms.RadioButton rbEsit;
        private System.Windows.Forms.RadioButton rbBuyuk;
        private System.Windows.Forms.Label lblSatisMiktari;
        private System.Windows.Forms.TextBox txtSatisMiktari;
        private System.Windows.Forms.Label lblUrunFiyat;
        private System.Windows.Forms.TextBox txtUrunFiyat;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Label lblUrunAd;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.CheckBox chTarih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dpBitis;
        private System.Windows.Forms.DateTimePicker dpBaslangic;
        private System.Windows.Forms.Label lblSatisTarihAraligi;
    }
}