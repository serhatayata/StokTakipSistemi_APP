
namespace StokTakipSistemiAPP
{
    partial class FrmSilinenler
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
            this.cmbTablolar = new System.Windows.Forms.ComboBox();
            this.lblTablolar = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGeriGetir = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbTablolar);
            this.panel1.Controls.Add(this.lblTablolar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 64);
            this.panel1.TabIndex = 0;
            // 
            // cmbTablolar
            // 
            this.cmbTablolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbTablolar.FormattingEnabled = true;
            this.cmbTablolar.Location = new System.Drawing.Point(130, 23);
            this.cmbTablolar.Name = "cmbTablolar";
            this.cmbTablolar.Size = new System.Drawing.Size(197, 24);
            this.cmbTablolar.TabIndex = 0;
            this.cmbTablolar.SelectedIndexChanged += new System.EventHandler(this.cmbTablolar_SelectedIndexChanged);
            // 
            // lblTablolar
            // 
            this.lblTablolar.AutoSize = true;
            this.lblTablolar.Location = new System.Drawing.Point(19, 23);
            this.lblTablolar.Name = "lblTablolar";
            this.lblTablolar.Size = new System.Drawing.Size(83, 20);
            this.lblTablolar.TabIndex = 26;
            this.lblTablolar.Text = "Tablolar :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnGeriGetir);
            this.panel2.Controls.Add(this.btnKapat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 299);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(787, 88);
            this.panel2.TabIndex = 1;
            // 
            // btnGeriGetir
            // 
            this.btnGeriGetir.Location = new System.Drawing.Point(237, 26);
            this.btnGeriGetir.Name = "btnGeriGetir";
            this.btnGeriGetir.Size = new System.Drawing.Size(142, 37);
            this.btnGeriGetir.TabIndex = 0;
            this.btnGeriGetir.Text = "Geri Getir";
            this.btnGeriGetir.UseVisualStyleBackColor = true;
            this.btnGeriGetir.Click += new System.EventHandler(this.btnGeriGetir_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(407, 26);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(142, 37);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(787, 235);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // FrmSilinenler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 387);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmSilinenler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Silinenler";
            this.Load += new System.EventHandler(this.FrmSilinenler_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbTablolar;
        private System.Windows.Forms.Label lblTablolar;
        private System.Windows.Forms.Button btnGeriGetir;
        private System.Windows.Forms.Button btnKapat;
    }
}