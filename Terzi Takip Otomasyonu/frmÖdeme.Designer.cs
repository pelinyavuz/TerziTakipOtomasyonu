namespace Terzi_Takip_Otomasyonu
{
    partial class frmÖdeme
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
            this.dgKıyafetler = new System.Windows.Forms.DataGridView();
            this.clmOdeme_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAlışTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTeslimTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSonÖdemeTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTahsilat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbÖdemeKaydet = new System.Windows.Forms.GroupBox();
            this.tbTahsilat1 = new System.Windows.Forms.TextBox();
            this.lblTahsilat1 = new System.Windows.Forms.Label();
            this.tbSonÖdemeTarihi1 = new System.Windows.Forms.TextBox();
            this.lblSonÖdemeTarihi1 = new System.Windows.Forms.Label();
            this.tbTeslimTarihi1 = new System.Windows.Forms.TextBox();
            this.lblTeslimTarihi1 = new System.Windows.Forms.Label();
            this.tbAlışTarihi1 = new System.Windows.Forms.TextBox();
            this.lblAlışTarihi1 = new System.Windows.Forms.Label();
            this.btnÖdemeKaydet = new System.Windows.Forms.Button();
            this.tbFiyat1 = new System.Windows.Forms.TextBox();
            this.lblFiyat1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgKıyafetler)).BeginInit();
            this.gbÖdemeKaydet.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgKıyafetler
            // 
            this.dgKıyafetler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgKıyafetler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKıyafetler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmOdeme_no,
            this.clmFiyat,
            this.clmAlışTarihi,
            this.clmTeslimTarihi,
            this.clmSonÖdemeTarihi,
            this.clmTahsilat});
            this.dgKıyafetler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgKıyafetler.Location = new System.Drawing.Point(0, 207);
            this.dgKıyafetler.Name = "dgKıyafetler";
            this.dgKıyafetler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgKıyafetler.Size = new System.Drawing.Size(755, 94);
            this.dgKıyafetler.TabIndex = 2;
            // 
            // clmOdeme_no
            // 
            this.clmOdeme_no.DataPropertyName = "Ödeme No";
            this.clmOdeme_no.HeaderText = "Ödeme No";
            this.clmOdeme_no.Name = "clmOdeme_no";
            this.clmOdeme_no.Visible = false;
            // 
            // clmFiyat
            // 
            this.clmFiyat.DataPropertyName = "Fiyat";
            this.clmFiyat.HeaderText = "Fiyat";
            this.clmFiyat.Name = "clmFiyat";
            // 
            // clmAlışTarihi
            // 
            this.clmAlışTarihi.DataPropertyName = "Alış Tarihi";
            this.clmAlışTarihi.HeaderText = "Alış Tarihi";
            this.clmAlışTarihi.Name = "clmAlışTarihi";
            // 
            // clmTeslimTarihi
            // 
            this.clmTeslimTarihi.DataPropertyName = "Teslim Tarihi";
            this.clmTeslimTarihi.HeaderText = "Teslim Tarihi";
            this.clmTeslimTarihi.Name = "clmTeslimTarihi";
            // 
            // clmSonÖdemeTarihi
            // 
            this.clmSonÖdemeTarihi.DataPropertyName = "Son Ödeme Tarihi";
            this.clmSonÖdemeTarihi.HeaderText = "Son Ödeme Tarihi";
            this.clmSonÖdemeTarihi.Name = "clmSonÖdemeTarihi";
            // 
            // clmTahsilat
            // 
            this.clmTahsilat.DataPropertyName = "Tahsilat";
            this.clmTahsilat.HeaderText = "Tahsilat";
            this.clmTahsilat.Name = "clmTahsilat";
            // 
            // gbÖdemeKaydet
            // 
            this.gbÖdemeKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gbÖdemeKaydet.Controls.Add(this.tbTahsilat1);
            this.gbÖdemeKaydet.Controls.Add(this.lblTahsilat1);
            this.gbÖdemeKaydet.Controls.Add(this.tbSonÖdemeTarihi1);
            this.gbÖdemeKaydet.Controls.Add(this.lblSonÖdemeTarihi1);
            this.gbÖdemeKaydet.Controls.Add(this.tbTeslimTarihi1);
            this.gbÖdemeKaydet.Controls.Add(this.lblTeslimTarihi1);
            this.gbÖdemeKaydet.Controls.Add(this.tbAlışTarihi1);
            this.gbÖdemeKaydet.Controls.Add(this.lblAlışTarihi1);
            this.gbÖdemeKaydet.Controls.Add(this.btnÖdemeKaydet);
            this.gbÖdemeKaydet.Controls.Add(this.tbFiyat1);
            this.gbÖdemeKaydet.Controls.Add(this.lblFiyat1);
            this.gbÖdemeKaydet.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbÖdemeKaydet.Location = new System.Drawing.Point(0, 0);
            this.gbÖdemeKaydet.Name = "gbÖdemeKaydet";
            this.gbÖdemeKaydet.Size = new System.Drawing.Size(755, 207);
            this.gbÖdemeKaydet.TabIndex = 4;
            this.gbÖdemeKaydet.TabStop = false;
            this.gbÖdemeKaydet.Text = "Ödeme Ekle";
            this.gbÖdemeKaydet.Enter += new System.EventHandler(this.gbÖdemeKaydet_Enter);
            // 
            // tbTahsilat1
            // 
            this.tbTahsilat1.Location = new System.Drawing.Point(131, 151);
            this.tbTahsilat1.Name = "tbTahsilat1";
            this.tbTahsilat1.Size = new System.Drawing.Size(94, 20);
            this.tbTahsilat1.TabIndex = 29;
            // 
            // lblTahsilat1
            // 
            this.lblTahsilat1.AutoSize = true;
            this.lblTahsilat1.Location = new System.Drawing.Point(34, 154);
            this.lblTahsilat1.Name = "lblTahsilat1";
            this.lblTahsilat1.Size = new System.Drawing.Size(44, 13);
            this.lblTahsilat1.TabIndex = 28;
            this.lblTahsilat1.Text = "Tahsilat";
            // 
            // tbSonÖdemeTarihi1
            // 
            this.tbSonÖdemeTarihi1.Location = new System.Drawing.Point(131, 116);
            this.tbSonÖdemeTarihi1.Name = "tbSonÖdemeTarihi1";
            this.tbSonÖdemeTarihi1.Size = new System.Drawing.Size(94, 20);
            this.tbSonÖdemeTarihi1.TabIndex = 27;
            // 
            // lblSonÖdemeTarihi1
            // 
            this.lblSonÖdemeTarihi1.AutoSize = true;
            this.lblSonÖdemeTarihi1.Location = new System.Drawing.Point(33, 120);
            this.lblSonÖdemeTarihi1.Name = "lblSonÖdemeTarihi1";
            this.lblSonÖdemeTarihi1.Size = new System.Drawing.Size(92, 13);
            this.lblSonÖdemeTarihi1.TabIndex = 26;
            this.lblSonÖdemeTarihi1.Text = "Son Ödeme Tarihi";
            // 
            // tbTeslimTarihi1
            // 
            this.tbTeslimTarihi1.Location = new System.Drawing.Point(131, 80);
            this.tbTeslimTarihi1.Name = "tbTeslimTarihi1";
            this.tbTeslimTarihi1.Size = new System.Drawing.Size(94, 20);
            this.tbTeslimTarihi1.TabIndex = 25;
            // 
            // lblTeslimTarihi1
            // 
            this.lblTeslimTarihi1.AutoSize = true;
            this.lblTeslimTarihi1.Location = new System.Drawing.Point(34, 87);
            this.lblTeslimTarihi1.Name = "lblTeslimTarihi1";
            this.lblTeslimTarihi1.Size = new System.Drawing.Size(66, 13);
            this.lblTeslimTarihi1.TabIndex = 25;
            this.lblTeslimTarihi1.Text = "Teslim Tarihi";
            // 
            // tbAlışTarihi1
            // 
            this.tbAlışTarihi1.Location = new System.Drawing.Point(131, 53);
            this.tbAlışTarihi1.Name = "tbAlışTarihi1";
            this.tbAlışTarihi1.Size = new System.Drawing.Size(94, 20);
            this.tbAlışTarihi1.TabIndex = 24;
            // 
            // lblAlışTarihi1
            // 
            this.lblAlışTarihi1.AutoSize = true;
            this.lblAlışTarihi1.Location = new System.Drawing.Point(34, 56);
            this.lblAlışTarihi1.Name = "lblAlışTarihi1";
            this.lblAlışTarihi1.Size = new System.Drawing.Size(52, 13);
            this.lblAlışTarihi1.TabIndex = 20;
            this.lblAlışTarihi1.Text = "Alış Tarihi";
            // 
            // btnÖdemeKaydet
            // 
            this.btnÖdemeKaydet.Location = new System.Drawing.Point(272, 171);
            this.btnÖdemeKaydet.Name = "btnÖdemeKaydet";
            this.btnÖdemeKaydet.Size = new System.Drawing.Size(92, 30);
            this.btnÖdemeKaydet.TabIndex = 9;
            this.btnÖdemeKaydet.Text = "Ödeme Kaydet";
            this.btnÖdemeKaydet.UseVisualStyleBackColor = true;
            // 
            // tbFiyat1
            // 
            this.tbFiyat1.Location = new System.Drawing.Point(131, 27);
            this.tbFiyat1.Name = "tbFiyat1";
            this.tbFiyat1.Size = new System.Drawing.Size(94, 20);
            this.tbFiyat1.TabIndex = 8;
            // 
            // lblFiyat1
            // 
            this.lblFiyat1.AutoSize = true;
            this.lblFiyat1.Location = new System.Drawing.Point(33, 28);
            this.lblFiyat1.Name = "lblFiyat1";
            this.lblFiyat1.Size = new System.Drawing.Size(29, 13);
            this.lblFiyat1.TabIndex = 7;
            this.lblFiyat1.Text = "Fiyat";
            // 
            // frmÖdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 301);
            this.Controls.Add(this.gbÖdemeKaydet);
            this.Controls.Add(this.dgKıyafetler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmÖdeme";
            this.Text = "frmÖdeme";
            ((System.ComponentModel.ISupportInitialize)(this.dgKıyafetler)).EndInit();
            this.gbÖdemeKaydet.ResumeLayout(false);
            this.gbÖdemeKaydet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgKıyafetler;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOdeme_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAlışTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTeslimTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSonÖdemeTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTahsilat;
        private System.Windows.Forms.GroupBox gbÖdemeKaydet;
        private System.Windows.Forms.Label lblTahsilat1;
        private System.Windows.Forms.TextBox tbSonÖdemeTarihi1;
        private System.Windows.Forms.Label lblSonÖdemeTarihi1;
        private System.Windows.Forms.TextBox tbTeslimTarihi1;
        private System.Windows.Forms.Label lblTeslimTarihi1;
        private System.Windows.Forms.TextBox tbAlışTarihi1;
        private System.Windows.Forms.Label lblAlışTarihi1;
        private System.Windows.Forms.Button btnÖdemeKaydet;
        private System.Windows.Forms.TextBox tbFiyat1;
        private System.Windows.Forms.Label lblFiyat1;
        private System.Windows.Forms.TextBox tbTahsilat1;
    }
}