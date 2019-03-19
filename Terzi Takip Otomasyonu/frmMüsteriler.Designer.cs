namespace Terzi_Takip_Otomasyonu
{
    partial class frmMüsteriler
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
            this.dgMüşteriler = new System.Windows.Forms.DataGridView();
            this.Musteri_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMusteri_adı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMusteri_soyadı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCinsiyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTelefon_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmE_posta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAdres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbKişiKaydet = new System.Windows.Forms.GroupBox();
            this.lblCinsiyet1 = new System.Windows.Forms.Label();
            this.cbKadın1 = new System.Windows.Forms.CheckBox();
            this.cbErkek1 = new System.Windows.Forms.CheckBox();
            this.tbAdres1 = new System.Windows.Forms.TextBox();
            this.lblAdres1 = new System.Windows.Forms.Label();
            this.tbEPosta1 = new System.Windows.Forms.TextBox();
            this.lblEPosta1 = new System.Windows.Forms.Label();
            this.tbTelefonNo1 = new System.Windows.Forms.TextBox();
            this.lblTelefonNo1 = new System.Windows.Forms.Label();
            this.tbMüşteriSoyadı1 = new System.Windows.Forms.TextBox();
            this.lblMüşteriSoyadı1 = new System.Windows.Forms.Label();
            this.btnKişiKaydet = new System.Windows.Forms.Button();
            this.tbMüşteriAdı1 = new System.Windows.Forms.TextBox();
            this.lblMüşteriAdı1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgMüşteriler)).BeginInit();
            this.gbKişiKaydet.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgMüşteriler
            // 
            this.dgMüşteriler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgMüşteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMüşteriler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Musteri_no,
            this.clmMusteri_adı,
            this.clmMusteri_soyadı,
            this.clmCinsiyet,
            this.clmTelefon_no,
            this.clmE_posta,
            this.clmAdres});
            this.dgMüşteriler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgMüşteriler.Location = new System.Drawing.Point(0, 259);
            this.dgMüşteriler.Name = "dgMüşteriler";
            this.dgMüşteriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMüşteriler.Size = new System.Drawing.Size(827, 96);
            this.dgMüşteriler.TabIndex = 1;
            // 
            // Musteri_no
            // 
            this.Musteri_no.DataPropertyName = "Musteri_no";
            this.Musteri_no.HeaderText = "Musteri_no";
            this.Musteri_no.Name = "Musteri_no";
            this.Musteri_no.Visible = false;
            // 
            // clmMusteri_adı
            // 
            this.clmMusteri_adı.DataPropertyName = "Musteri_adı";
            this.clmMusteri_adı.HeaderText = "Musteri Adı";
            this.clmMusteri_adı.Name = "clmMusteri_adı";
            // 
            // clmMusteri_soyadı
            // 
            this.clmMusteri_soyadı.DataPropertyName = "Musteri_soyadı";
            this.clmMusteri_soyadı.HeaderText = "Musteri Soyadı";
            this.clmMusteri_soyadı.Name = "clmMusteri_soyadı";
            // 
            // clmCinsiyet
            // 
            this.clmCinsiyet.DataPropertyName = "Cinsiyet";
            this.clmCinsiyet.HeaderText = "Cinsiyet";
            this.clmCinsiyet.Name = "clmCinsiyet";
            // 
            // clmTelefon_no
            // 
            this.clmTelefon_no.DataPropertyName = "Telefon_no";
            this.clmTelefon_no.HeaderText = "Telefon no";
            this.clmTelefon_no.Name = "clmTelefon_no";
            // 
            // clmE_posta
            // 
            this.clmE_posta.DataPropertyName = "E_posta";
            this.clmE_posta.HeaderText = "E-posta";
            this.clmE_posta.Name = "clmE_posta";
            // 
            // clmAdres
            // 
            this.clmAdres.DataPropertyName = "Adres";
            this.clmAdres.HeaderText = "Adres";
            this.clmAdres.Name = "clmAdres";
            // 
            // gbKişiKaydet
            // 
            this.gbKişiKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gbKişiKaydet.Controls.Add(this.lblCinsiyet1);
            this.gbKişiKaydet.Controls.Add(this.cbKadın1);
            this.gbKişiKaydet.Controls.Add(this.cbErkek1);
            this.gbKişiKaydet.Controls.Add(this.tbAdres1);
            this.gbKişiKaydet.Controls.Add(this.lblAdres1);
            this.gbKişiKaydet.Controls.Add(this.tbEPosta1);
            this.gbKişiKaydet.Controls.Add(this.lblEPosta1);
            this.gbKişiKaydet.Controls.Add(this.tbTelefonNo1);
            this.gbKişiKaydet.Controls.Add(this.lblTelefonNo1);
            this.gbKişiKaydet.Controls.Add(this.tbMüşteriSoyadı1);
            this.gbKişiKaydet.Controls.Add(this.lblMüşteriSoyadı1);
            this.gbKişiKaydet.Controls.Add(this.btnKişiKaydet);
            this.gbKişiKaydet.Controls.Add(this.tbMüşteriAdı1);
            this.gbKişiKaydet.Controls.Add(this.lblMüşteriAdı1);
            this.gbKişiKaydet.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbKişiKaydet.Location = new System.Drawing.Point(0, 0);
            this.gbKişiKaydet.Name = "gbKişiKaydet";
            this.gbKişiKaydet.Size = new System.Drawing.Size(827, 259);
            this.gbKişiKaydet.TabIndex = 3;
            this.gbKişiKaydet.TabStop = false;
            this.gbKişiKaydet.Text = "Kişi Ekle";
            // 
            // lblCinsiyet1
            // 
            this.lblCinsiyet1.AutoSize = true;
            this.lblCinsiyet1.Location = new System.Drawing.Point(237, 83);
            this.lblCinsiyet1.Name = "lblCinsiyet1";
            this.lblCinsiyet1.Size = new System.Drawing.Size(43, 13);
            this.lblCinsiyet1.TabIndex = 32;
            this.lblCinsiyet1.Text = "Cinsiyet";
            // 
            // cbKadın1
            // 
            this.cbKadın1.AutoSize = true;
            this.cbKadın1.Location = new System.Drawing.Point(297, 92);
            this.cbKadın1.Name = "cbKadın1";
            this.cbKadın1.Size = new System.Drawing.Size(53, 17);
            this.cbKadın1.TabIndex = 31;
            this.cbKadın1.Text = "Kadın";
            this.cbKadın1.UseVisualStyleBackColor = true;
            // 
            // cbErkek1
            // 
            this.cbErkek1.AutoSize = true;
            this.cbErkek1.Location = new System.Drawing.Point(297, 69);
            this.cbErkek1.Name = "cbErkek1";
            this.cbErkek1.Size = new System.Drawing.Size(54, 17);
            this.cbErkek1.TabIndex = 30;
            this.cbErkek1.Text = "Erkek";
            this.cbErkek1.UseVisualStyleBackColor = true;
            // 
            // tbAdres1
            // 
            this.tbAdres1.Location = new System.Drawing.Point(106, 138);
            this.tbAdres1.Name = "tbAdres1";
            this.tbAdres1.Size = new System.Drawing.Size(150, 20);
            this.tbAdres1.TabIndex = 29;
            // 
            // lblAdres1
            // 
            this.lblAdres1.AutoSize = true;
            this.lblAdres1.Location = new System.Drawing.Point(42, 143);
            this.lblAdres1.Name = "lblAdres1";
            this.lblAdres1.Size = new System.Drawing.Size(34, 13);
            this.lblAdres1.TabIndex = 28;
            this.lblAdres1.Text = "Adres";
            // 
            // tbEPosta1
            // 
            this.tbEPosta1.Location = new System.Drawing.Point(106, 102);
            this.tbEPosta1.Name = "tbEPosta1";
            this.tbEPosta1.Size = new System.Drawing.Size(64, 20);
            this.tbEPosta1.TabIndex = 27;
            // 
            // lblEPosta1
            // 
            this.lblEPosta1.AutoSize = true;
            this.lblEPosta1.Location = new System.Drawing.Point(42, 105);
            this.lblEPosta1.Name = "lblEPosta1";
            this.lblEPosta1.Size = new System.Drawing.Size(44, 13);
            this.lblEPosta1.TabIndex = 26;
            this.lblEPosta1.Text = "E Posta";
            // 
            // tbTelefonNo1
            // 
            this.tbTelefonNo1.Location = new System.Drawing.Point(106, 66);
            this.tbTelefonNo1.Name = "tbTelefonNo1";
            this.tbTelefonNo1.Size = new System.Drawing.Size(64, 20);
            this.tbTelefonNo1.TabIndex = 25;
            // 
            // lblTelefonNo1
            // 
            this.lblTelefonNo1.AutoSize = true;
            this.lblTelefonNo1.Location = new System.Drawing.Point(42, 70);
            this.lblTelefonNo1.Name = "lblTelefonNo1";
            this.lblTelefonNo1.Size = new System.Drawing.Size(58, 13);
            this.lblTelefonNo1.TabIndex = 25;
            this.lblTelefonNo1.Text = "Telefon no";
            // 
            // tbMüşteriSoyadı1
            // 
            this.tbMüşteriSoyadı1.Location = new System.Drawing.Point(285, 25);
            this.tbMüşteriSoyadı1.Name = "tbMüşteriSoyadı1";
            this.tbMüşteriSoyadı1.Size = new System.Drawing.Size(64, 20);
            this.tbMüşteriSoyadı1.TabIndex = 24;
            // 
            // lblMüşteriSoyadı1
            // 
            this.lblMüşteriSoyadı1.AutoSize = true;
            this.lblMüşteriSoyadı1.Location = new System.Drawing.Point(194, 28);
            this.lblMüşteriSoyadı1.Name = "lblMüşteriSoyadı1";
            this.lblMüşteriSoyadı1.Size = new System.Drawing.Size(76, 13);
            this.lblMüşteriSoyadı1.TabIndex = 20;
            this.lblMüşteriSoyadı1.Text = "Musteri Soyadı";
            // 
            // btnKişiKaydet
            // 
            this.btnKişiKaydet.Location = new System.Drawing.Point(164, 189);
            this.btnKişiKaydet.Name = "btnKişiKaydet";
            this.btnKişiKaydet.Size = new System.Drawing.Size(92, 30);
            this.btnKişiKaydet.TabIndex = 9;
            this.btnKişiKaydet.Text = "Kişi Kaydet";
            this.btnKişiKaydet.UseVisualStyleBackColor = true;
            // 
            // tbMüşteriAdı1
            // 
            this.tbMüşteriAdı1.Location = new System.Drawing.Point(106, 25);
            this.tbMüşteriAdı1.Name = "tbMüşteriAdı1";
            this.tbMüşteriAdı1.Size = new System.Drawing.Size(64, 20);
            this.tbMüşteriAdı1.TabIndex = 8;
            // 
            // lblMüşteriAdı1
            // 
            this.lblMüşteriAdı1.AutoSize = true;
            this.lblMüşteriAdı1.Location = new System.Drawing.Point(41, 28);
            this.lblMüşteriAdı1.Name = "lblMüşteriAdı1";
            this.lblMüşteriAdı1.Size = new System.Drawing.Size(59, 13);
            this.lblMüşteriAdı1.TabIndex = 7;
            this.lblMüşteriAdı1.Text = "Musteri Adı";
            // 
            // frmMüsteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 355);
            this.Controls.Add(this.gbKişiKaydet);
            this.Controls.Add(this.dgMüşteriler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMüsteriler";
            this.Text = "frmMüsteriler";
            ((System.ComponentModel.ISupportInitialize)(this.dgMüşteriler)).EndInit();
            this.gbKişiKaydet.ResumeLayout(false);
            this.gbKişiKaydet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMüşteriler;
        private System.Windows.Forms.DataGridViewTextBoxColumn Musteri_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMusteri_adı;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMusteri_soyadı;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCinsiyet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTelefon_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmE_posta;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAdres;
        private System.Windows.Forms.GroupBox gbKişiKaydet;
        private System.Windows.Forms.Button btnKişiKaydet;
        private System.Windows.Forms.TextBox tbMüşteriAdı1;
        private System.Windows.Forms.Label lblMüşteriAdı1;
        private System.Windows.Forms.Label lblAdres1;
        private System.Windows.Forms.TextBox tbEPosta1;
        private System.Windows.Forms.Label lblEPosta1;
        private System.Windows.Forms.TextBox tbTelefonNo1;
        private System.Windows.Forms.Label lblTelefonNo1;
        private System.Windows.Forms.TextBox tbMüşteriSoyadı1;
        private System.Windows.Forms.Label lblMüşteriSoyadı1;
        private System.Windows.Forms.Label lblCinsiyet1;
        private System.Windows.Forms.CheckBox cbKadın1;
        private System.Windows.Forms.CheckBox cbErkek1;
        private System.Windows.Forms.TextBox tbAdres1;
    }
}