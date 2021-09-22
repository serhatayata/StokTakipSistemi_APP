
namespace StokTakipSistemiAPP
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnKategoriler = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSilinenler = new System.Windows.Forms.Button();
            this.btnStokEkleme = new System.Windows.Forms.Button();
            this.btnSatis = new System.Windows.Forms.Button();
            this.btnUrunler = new System.Windows.Forms.Button();
            this.btnMusteri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKategoriler
            // 
            this.btnKategoriler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnKategoriler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKategoriler.Image = ((System.Drawing.Image)(resources.GetObject("btnKategoriler.Image")));
            this.btnKategoriler.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKategoriler.Location = new System.Drawing.Point(299, 149);
            this.btnKategoriler.Name = "btnKategoriler";
            this.btnKategoriler.Size = new System.Drawing.Size(114, 112);
            this.btnKategoriler.TabIndex = 6;
            this.btnKategoriler.Text = "Kategoriler";
            this.btnKategoriler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKategoriler.UseVisualStyleBackColor = false;
            this.btnKategoriler.Click += new System.EventHandler(this.btnKategoriler_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(160, 281);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(114, 112);
            this.btnExit.TabIndex = 5;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSilinenler
            // 
            this.btnSilinenler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSilinenler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSilinenler.Image = ((System.Drawing.Image)(resources.GetObject("btnSilinenler.Image")));
            this.btnSilinenler.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSilinenler.Location = new System.Drawing.Point(160, 149);
            this.btnSilinenler.Name = "btnSilinenler";
            this.btnSilinenler.Size = new System.Drawing.Size(114, 112);
            this.btnSilinenler.TabIndex = 4;
            this.btnSilinenler.Text = "Silinenler";
            this.btnSilinenler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSilinenler.UseVisualStyleBackColor = false;
            this.btnSilinenler.Click += new System.EventHandler(this.btnSilinenler_Click);
            // 
            // btnStokEkleme
            // 
            this.btnStokEkleme.BackColor = System.Drawing.Color.Pink;
            this.btnStokEkleme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStokEkleme.Image = ((System.Drawing.Image)(resources.GetObject("btnStokEkleme.Image")));
            this.btnStokEkleme.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStokEkleme.Location = new System.Drawing.Point(21, 149);
            this.btnStokEkleme.Name = "btnStokEkleme";
            this.btnStokEkleme.Size = new System.Drawing.Size(114, 112);
            this.btnStokEkleme.TabIndex = 3;
            this.btnStokEkleme.Text = "Stok Ekleme";
            this.btnStokEkleme.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStokEkleme.UseVisualStyleBackColor = false;
            this.btnStokEkleme.Click += new System.EventHandler(this.btnStokEkleme_Click);
            // 
            // btnSatis
            // 
            this.btnSatis.BackColor = System.Drawing.Color.Gray;
            this.btnSatis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSatis.Image = ((System.Drawing.Image)(resources.GetObject("btnSatis.Image")));
            this.btnSatis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSatis.Location = new System.Drawing.Point(299, 21);
            this.btnSatis.Name = "btnSatis";
            this.btnSatis.Size = new System.Drawing.Size(114, 112);
            this.btnSatis.TabIndex = 2;
            this.btnSatis.Text = "Satış";
            this.btnSatis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSatis.UseVisualStyleBackColor = false;
            this.btnSatis.Click += new System.EventHandler(this.btnSatis_Click);
            // 
            // btnUrunler
            // 
            this.btnUrunler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUrunler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUrunler.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunler.Image")));
            this.btnUrunler.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUrunler.Location = new System.Drawing.Point(160, 21);
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.Size = new System.Drawing.Size(114, 112);
            this.btnUrunler.TabIndex = 1;
            this.btnUrunler.Text = "Ürünler";
            this.btnUrunler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUrunler.UseVisualStyleBackColor = false;
            this.btnUrunler.Click += new System.EventHandler(this.btnUrunler_Click);
            // 
            // btnMusteri
            // 
            this.btnMusteri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMusteri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMusteri.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteri.Image")));
            this.btnMusteri.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMusteri.Location = new System.Drawing.Point(21, 21);
            this.btnMusteri.Name = "btnMusteri";
            this.btnMusteri.Size = new System.Drawing.Size(114, 112);
            this.btnMusteri.TabIndex = 0;
            this.btnMusteri.Text = "Müşteriler";
            this.btnMusteri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMusteri.UseVisualStyleBackColor = false;
            this.btnMusteri.Click += new System.EventHandler(this.btnMusteri_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 413);
            this.Controls.Add(this.btnKategoriler);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSilinenler);
            this.Controls.Add(this.btnStokEkleme);
            this.Controls.Add(this.btnSatis);
            this.Controls.Add(this.btnUrunler);
            this.Controls.Add(this.btnMusteri);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Takip";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMusteri;
        private System.Windows.Forms.Button btnUrunler;
        private System.Windows.Forms.Button btnSatis;
        private System.Windows.Forms.Button btnStokEkleme;
        private System.Windows.Forms.Button btnSilinenler;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnKategoriler;
    }
}