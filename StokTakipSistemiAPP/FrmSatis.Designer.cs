
namespace StokTakipSistemiAPP
{
    partial class FrmSatis
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
            this.grpMusteriler = new System.Windows.Forms.GroupBox();
            this.dataGridMusteriler = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblAramaMusteriAd = new System.Windows.Forms.Label();
            this.txtAramaMusteriAd = new System.Windows.Forms.TextBox();
            this.grpUrunler = new System.Windows.Forms.GroupBox();
            this.dataGridUrunler = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.lblAramaKategori = new System.Windows.Forms.Label();
            this.lblMusteriAd = new System.Windows.Forms.Label();
            this.txtMusteriAd = new System.Windows.Forms.TextBox();
            this.lblUrunAd = new System.Windows.Forms.Label();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.lblUrunFiyat = new System.Windows.Forms.Label();
            this.txtUrunFiyat = new System.Windows.Forms.TextBox();
            this.lblUrunStok = new System.Windows.Forms.Label();
            this.txtUrunStok = new System.Windows.Forms.TextBox();
            this.lblSatisMiktari = new System.Windows.Forms.Label();
            this.txtSatisMiktari = new System.Windows.Forms.TextBox();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.grpMusteriler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMusteriler)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.grpUrunler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUrunler)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grpMusteriler);
            this.panel1.Controls.Add(this.grpUrunler);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(497, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 524);
            this.panel1.TabIndex = 0;
            // 
            // grpMusteriler
            // 
            this.grpMusteriler.Controls.Add(this.dataGridMusteriler);
            this.grpMusteriler.Controls.Add(this.panel3);
            this.grpMusteriler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMusteriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpMusteriler.Location = new System.Drawing.Point(0, 264);
            this.grpMusteriler.Name = "grpMusteriler";
            this.grpMusteriler.Size = new System.Drawing.Size(229, 260);
            this.grpMusteriler.TabIndex = 1;
            this.grpMusteriler.TabStop = false;
            this.grpMusteriler.Text = "Müşteriler";
            // 
            // dataGridMusteriler
            // 
            this.dataGridMusteriler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMusteriler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridMusteriler.Location = new System.Drawing.Point(3, 86);
            this.dataGridMusteriler.Name = "dataGridMusteriler";
            this.dataGridMusteriler.Size = new System.Drawing.Size(223, 171);
            this.dataGridMusteriler.TabIndex = 2;
            this.dataGridMusteriler.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMusteriler_RowEnter);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(223, 68);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(223, 68);
            this.panel4.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblAramaMusteriAd);
            this.panel5.Controls.Add(this.txtAramaMusteriAd);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(223, 68);
            this.panel5.TabIndex = 2;
            // 
            // lblAramaMusteriAd
            // 
            this.lblAramaMusteriAd.AutoSize = true;
            this.lblAramaMusteriAd.Location = new System.Drawing.Point(70, 13);
            this.lblAramaMusteriAd.Name = "lblAramaMusteriAd";
            this.lblAramaMusteriAd.Size = new System.Drawing.Size(81, 16);
            this.lblAramaMusteriAd.TabIndex = 1;
            this.lblAramaMusteriAd.Text = "Müşteri Ad";
            // 
            // txtAramaMusteriAd
            // 
            this.txtAramaMusteriAd.Location = new System.Drawing.Point(23, 40);
            this.txtAramaMusteriAd.Name = "txtAramaMusteriAd";
            this.txtAramaMusteriAd.Size = new System.Drawing.Size(180, 22);
            this.txtAramaMusteriAd.TabIndex = 0;
            this.txtAramaMusteriAd.TextChanged += new System.EventHandler(this.txtAramaMusteriAd_TextChanged);
            // 
            // grpUrunler
            // 
            this.grpUrunler.Controls.Add(this.dataGridUrunler);
            this.grpUrunler.Controls.Add(this.panel2);
            this.grpUrunler.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpUrunler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpUrunler.Location = new System.Drawing.Point(0, 0);
            this.grpUrunler.Name = "grpUrunler";
            this.grpUrunler.Size = new System.Drawing.Size(229, 264);
            this.grpUrunler.TabIndex = 0;
            this.grpUrunler.TabStop = false;
            this.grpUrunler.Text = "Ürünler";
            // 
            // dataGridUrunler
            // 
            this.dataGridUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUrunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridUrunler.Location = new System.Drawing.Point(3, 91);
            this.dataGridUrunler.Name = "dataGridUrunler";
            this.dataGridUrunler.Size = new System.Drawing.Size(223, 170);
            this.dataGridUrunler.TabIndex = 1;
            this.dataGridUrunler.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUrunler_RowEnter);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbKategori);
            this.panel2.Controls.Add(this.lblAramaKategori);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 73);
            this.panel2.TabIndex = 0;
            // 
            // cmbKategori
            // 
            this.cmbKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(21, 40);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(180, 24);
            this.cmbKategori.TabIndex = 0;
            this.cmbKategori.SelectedIndexChanged += new System.EventHandler(this.cmbKategori_SelectedIndexChanged);
            // 
            // lblAramaKategori
            // 
            this.lblAramaKategori.AutoSize = true;
            this.lblAramaKategori.Location = new System.Drawing.Point(71, 12);
            this.lblAramaKategori.Name = "lblAramaKategori";
            this.lblAramaKategori.Size = new System.Drawing.Size(84, 16);
            this.lblAramaKategori.TabIndex = 11;
            this.lblAramaKategori.Text = "Kategoriler";
            // 
            // lblMusteriAd
            // 
            this.lblMusteriAd.AutoSize = true;
            this.lblMusteriAd.Location = new System.Drawing.Point(31, 34);
            this.lblMusteriAd.Name = "lblMusteriAd";
            this.lblMusteriAd.Size = new System.Drawing.Size(105, 20);
            this.lblMusteriAd.TabIndex = 1;
            this.lblMusteriAd.Text = "Müşteri Ad :";
            // 
            // txtMusteriAd
            // 
            this.txtMusteriAd.Location = new System.Drawing.Point(166, 31);
            this.txtMusteriAd.Name = "txtMusteriAd";
            this.txtMusteriAd.ReadOnly = true;
            this.txtMusteriAd.Size = new System.Drawing.Size(233, 26);
            this.txtMusteriAd.TabIndex = 2;
            // 
            // lblUrunAd
            // 
            this.lblUrunAd.AutoSize = true;
            this.lblUrunAd.Location = new System.Drawing.Point(31, 85);
            this.lblUrunAd.Name = "lblUrunAd";
            this.lblUrunAd.Size = new System.Drawing.Size(85, 20);
            this.lblUrunAd.TabIndex = 3;
            this.lblUrunAd.Text = "Ürün Ad :";
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(166, 84);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.ReadOnly = true;
            this.txtUrunAd.Size = new System.Drawing.Size(233, 26);
            this.txtUrunAd.TabIndex = 4;
            // 
            // lblUrunFiyat
            // 
            this.lblUrunFiyat.AutoSize = true;
            this.lblUrunFiyat.Location = new System.Drawing.Point(31, 138);
            this.lblUrunFiyat.Name = "lblUrunFiyat";
            this.lblUrunFiyat.Size = new System.Drawing.Size(102, 20);
            this.lblUrunFiyat.TabIndex = 5;
            this.lblUrunFiyat.Text = "Ürün Fiyat :";
            // 
            // txtUrunFiyat
            // 
            this.txtUrunFiyat.Location = new System.Drawing.Point(166, 138);
            this.txtUrunFiyat.Name = "txtUrunFiyat";
            this.txtUrunFiyat.ReadOnly = true;
            this.txtUrunFiyat.Size = new System.Drawing.Size(233, 26);
            this.txtUrunFiyat.TabIndex = 6;
            // 
            // lblUrunStok
            // 
            this.lblUrunStok.AutoSize = true;
            this.lblUrunStok.Location = new System.Drawing.Point(31, 194);
            this.lblUrunStok.Name = "lblUrunStok";
            this.lblUrunStok.Size = new System.Drawing.Size(100, 20);
            this.lblUrunStok.TabIndex = 7;
            this.lblUrunStok.Text = "Ürün Stok :";
            // 
            // txtUrunStok
            // 
            this.txtUrunStok.Location = new System.Drawing.Point(166, 191);
            this.txtUrunStok.Name = "txtUrunStok";
            this.txtUrunStok.ReadOnly = true;
            this.txtUrunStok.Size = new System.Drawing.Size(233, 26);
            this.txtUrunStok.TabIndex = 8;
            // 
            // lblSatisMiktari
            // 
            this.lblSatisMiktari.AutoSize = true;
            this.lblSatisMiktari.Location = new System.Drawing.Point(31, 253);
            this.lblSatisMiktari.Name = "lblSatisMiktari";
            this.lblSatisMiktari.Size = new System.Drawing.Size(118, 20);
            this.lblSatisMiktari.TabIndex = 9;
            this.lblSatisMiktari.Text = "Satış Miktarı :";
            // 
            // txtSatisMiktari
            // 
            this.txtSatisMiktari.Location = new System.Drawing.Point(166, 250);
            this.txtSatisMiktari.Name = "txtSatisMiktari";
            this.txtSatisMiktari.Size = new System.Drawing.Size(233, 26);
            this.txtSatisMiktari.TabIndex = 0;
            this.txtSatisMiktari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSatisMiktari_KeyPress);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(257, 322);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(142, 37);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(99, 322);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(142, 37);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // FrmSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 524);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lblSatisMiktari);
            this.Controls.Add(this.txtSatisMiktari);
            this.Controls.Add(this.lblUrunStok);
            this.Controls.Add(this.txtUrunStok);
            this.Controls.Add(this.lblUrunFiyat);
            this.Controls.Add(this.txtUrunFiyat);
            this.Controls.Add(this.lblUrunAd);
            this.Controls.Add(this.txtUrunAd);
            this.Controls.Add(this.lblMusteriAd);
            this.Controls.Add(this.txtMusteriAd);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış";
            this.Load += new System.EventHandler(this.FrmSatis_Load);
            this.panel1.ResumeLayout(false);
            this.grpMusteriler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMusteriler)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.grpUrunler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUrunler)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpMusteriler;
        private System.Windows.Forms.DataGridView dataGridMusteriler;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox grpUrunler;
        private System.Windows.Forms.DataGridView dataGridUrunler;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Label lblAramaKategori;
        private System.Windows.Forms.Label lblAramaMusteriAd;
        private System.Windows.Forms.TextBox txtAramaMusteriAd;
        private System.Windows.Forms.Label lblMusteriAd;
        private System.Windows.Forms.TextBox txtMusteriAd;
        private System.Windows.Forms.Label lblUrunAd;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.Label lblUrunFiyat;
        private System.Windows.Forms.TextBox txtUrunFiyat;
        private System.Windows.Forms.Label lblUrunStok;
        private System.Windows.Forms.TextBox txtUrunStok;
        private System.Windows.Forms.Label lblSatisMiktari;
        private System.Windows.Forms.TextBox txtSatisMiktari;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnKaydet;
    }
}