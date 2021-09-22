
namespace StokTakipSistemiAPP
{
    partial class FrmUrunListesi
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
            this.btnAra = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.grpStok = new System.Windows.Forms.GroupBox();
            this.rbSKucuk = new System.Windows.Forms.RadioButton();
            this.rbSEsit = new System.Windows.Forms.RadioButton();
            this.rbSBuyuk = new System.Windows.Forms.RadioButton();
            this.grpFiyat = new System.Windows.Forms.GroupBox();
            this.rbKucuk = new System.Windows.Forms.RadioButton();
            this.rbEsit = new System.Windows.Forms.RadioButton();
            this.rbBuyuk = new System.Windows.Forms.RadioButton();
            this.lblUrunStok = new System.Windows.Forms.Label();
            this.txtUrunStok = new System.Windows.Forms.TextBox();
            this.lblUrunFiyat = new System.Windows.Forms.Label();
            this.txtUrunFiyat = new System.Windows.Forms.TextBox();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.lblKategori = new System.Windows.Forms.Label();
            this.lblUrunAd = new System.Windows.Forms.Label();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.grpStok.SuspendLayout();
            this.grpFiyat.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAra);
            this.panel1.Controls.Add(this.btnTemizle);
            this.panel1.Controls.Add(this.grpStok);
            this.panel1.Controls.Add(this.grpFiyat);
            this.panel1.Controls.Add(this.lblUrunStok);
            this.panel1.Controls.Add(this.txtUrunStok);
            this.panel1.Controls.Add(this.lblUrunFiyat);
            this.panel1.Controls.Add(this.txtUrunFiyat);
            this.panel1.Controls.Add(this.cmbKategori);
            this.panel1.Controls.Add(this.lblKategori);
            this.panel1.Controls.Add(this.lblUrunAd);
            this.panel1.Controls.Add(this.txtUrunAd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 176);
            this.panel1.TabIndex = 0;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(363, 124);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(142, 37);
            this.btnAra.TabIndex = 6;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(533, 124);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(142, 37);
            this.btnTemizle.TabIndex = 7;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // grpStok
            // 
            this.grpStok.Controls.Add(this.rbSKucuk);
            this.grpStok.Controls.Add(this.rbSEsit);
            this.grpStok.Controls.Add(this.rbSBuyuk);
            this.grpStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpStok.Location = new System.Drawing.Point(701, 78);
            this.grpStok.Name = "grpStok";
            this.grpStok.Size = new System.Drawing.Size(268, 55);
            this.grpStok.TabIndex = 5;
            this.grpStok.TabStop = false;
            this.grpStok.Text = "Stok";
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
            this.grpFiyat.Location = new System.Drawing.Point(701, 17);
            this.grpFiyat.Name = "grpFiyat";
            this.grpFiyat.Size = new System.Drawing.Size(268, 55);
            this.grpFiyat.TabIndex = 4;
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
            // lblUrunStok
            // 
            this.lblUrunStok.AutoSize = true;
            this.lblUrunStok.Location = new System.Drawing.Point(359, 81);
            this.lblUrunStok.Name = "lblUrunStok";
            this.lblUrunStok.Size = new System.Drawing.Size(100, 20);
            this.lblUrunStok.TabIndex = 14;
            this.lblUrunStok.Text = "Ürün Stok :";
            // 
            // txtUrunStok
            // 
            this.txtUrunStok.Location = new System.Drawing.Point(477, 78);
            this.txtUrunStok.Name = "txtUrunStok";
            this.txtUrunStok.Size = new System.Drawing.Size(197, 26);
            this.txtUrunStok.TabIndex = 3;
            this.txtUrunStok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrunStok_KeyPress);
            // 
            // lblUrunFiyat
            // 
            this.lblUrunFiyat.AutoSize = true;
            this.lblUrunFiyat.Location = new System.Drawing.Point(359, 29);
            this.lblUrunFiyat.Name = "lblUrunFiyat";
            this.lblUrunFiyat.Size = new System.Drawing.Size(102, 20);
            this.lblUrunFiyat.TabIndex = 12;
            this.lblUrunFiyat.Text = "Ürün Fiyat :";
            // 
            // txtUrunFiyat
            // 
            this.txtUrunFiyat.Location = new System.Drawing.Point(477, 26);
            this.txtUrunFiyat.Name = "txtUrunFiyat";
            this.txtUrunFiyat.Size = new System.Drawing.Size(197, 26);
            this.txtUrunFiyat.TabIndex = 2;
            this.txtUrunFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrunFiyat_KeyPress);
            // 
            // cmbKategori
            // 
            this.cmbKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(126, 81);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(197, 24);
            this.cmbKategori.TabIndex = 1;
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(24, 81);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(86, 20);
            this.lblKategori.TabIndex = 9;
            this.lblKategori.Text = "Kategori :";
            // 
            // lblUrunAd
            // 
            this.lblUrunAd.AutoSize = true;
            this.lblUrunAd.Location = new System.Drawing.Point(24, 29);
            this.lblUrunAd.Name = "lblUrunAd";
            this.lblUrunAd.Size = new System.Drawing.Size(85, 20);
            this.lblUrunAd.TabIndex = 7;
            this.lblUrunAd.Text = "Ürün Ad :";
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(126, 26);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(197, 26);
            this.txtUrunAd.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnEkle);
            this.panel2.Controls.Add(this.btnGuncelle);
            this.panel2.Controls.Add(this.btnSil);
            this.panel2.Controls.Add(this.btnKapat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 373);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(972, 78);
            this.panel2.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(155, 22);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(142, 37);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(325, 22);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(142, 37);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(495, 22);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(142, 37);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(665, 22);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(142, 37);
            this.btnKapat.TabIndex = 3;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(972, 197);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // FrmUrunListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 451);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmUrunListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Listesi";
            this.Load += new System.EventHandler(this.FrmUrunListesi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpStok.ResumeLayout(false);
            this.grpStok.PerformLayout();
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
        private System.Windows.Forms.Label lblUrunAd;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Label lblUrunStok;
        private System.Windows.Forms.TextBox txtUrunStok;
        private System.Windows.Forms.Label lblUrunFiyat;
        private System.Windows.Forms.TextBox txtUrunFiyat;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.GroupBox grpStok;
        private System.Windows.Forms.RadioButton rbSKucuk;
        private System.Windows.Forms.RadioButton rbSEsit;
        private System.Windows.Forms.RadioButton rbSBuyuk;
        private System.Windows.Forms.GroupBox grpFiyat;
        private System.Windows.Forms.RadioButton rbKucuk;
        private System.Windows.Forms.RadioButton rbEsit;
        private System.Windows.Forms.RadioButton rbBuyuk;
    }
}