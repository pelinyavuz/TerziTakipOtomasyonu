namespace Terzi_Takip_Otomasyonu
{
    partial class Adres
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
            this.clmAdres_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCadde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMahalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSokak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBina_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmİlçe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmŞehir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbAdresKaydet = new System.Windows.Forms.GroupBox();
            this.tbŞehir = new System.Windows.Forms.TextBox();
            this.tbİlçe = new System.Windows.Forms.TextBox();
            this.tbBinaNo = new System.Windows.Forms.TextBox();
            this.tbSokak = new System.Windows.Forms.TextBox();
            this.tbMahalle = new System.Windows.Forms.TextBox();
            this.tbCadde = new System.Windows.Forms.TextBox();
            this.Gömlek = new System.Windows.Forms.Label();
            this.Ceket = new System.Windows.Forms.Label();
            this.Tişört = new System.Windows.Forms.Label();
            this.Pantolon = new System.Windows.Forms.Label();
            this.Elbise = new System.Windows.Forms.Label();
            this.Cadde = new System.Windows.Forms.Label();
            this.btnAdresKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgKıyafetler)).BeginInit();
            this.gbAdresKaydet.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgKıyafetler
            // 
            this.dgKıyafetler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgKıyafetler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKıyafetler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmAdres_no,
            this.clmCadde,
            this.clmMahalle,
            this.clmSokak,
            this.clmBina_no,
            this.clmİlçe,
            this.clmŞehir});
            this.dgKıyafetler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgKıyafetler.Location = new System.Drawing.Point(0, 357);
            this.dgKıyafetler.Name = "dgKıyafetler";
            this.dgKıyafetler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgKıyafetler.Size = new System.Drawing.Size(913, 155);
            this.dgKıyafetler.TabIndex = 2;
            // 
            // clmAdres_no
            // 
            this.clmAdres_no.HeaderText = "Adres_no";
            this.clmAdres_no.Name = "clmAdres_no";
            this.clmAdres_no.Visible = false;
            // 
            // clmCadde
            // 
            this.clmCadde.HeaderText = "Cadde";
            this.clmCadde.Name = "clmCadde";
            // 
            // clmMahalle
            // 
            this.clmMahalle.HeaderText = "Mahalle";
            this.clmMahalle.Name = "clmMahalle";
            // 
            // clmSokak
            // 
            this.clmSokak.HeaderText = "Sokak";
            this.clmSokak.Name = "clmSokak";
            // 
            // clmBina_no
            // 
            this.clmBina_no.HeaderText = "Bina_no";
            this.clmBina_no.Name = "clmBina_no";
            // 
            // clmİlçe
            // 
            this.clmİlçe.HeaderText = "İlçe";
            this.clmİlçe.Name = "clmİlçe";
            // 
            // clmŞehir
            // 
            this.clmŞehir.HeaderText = "Şehir";
            this.clmŞehir.Name = "clmŞehir";
            // 
            // gbAdresKaydet
            // 
            this.gbAdresKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gbAdresKaydet.Controls.Add(this.tbŞehir);
            this.gbAdresKaydet.Controls.Add(this.tbİlçe);
            this.gbAdresKaydet.Controls.Add(this.tbBinaNo);
            this.gbAdresKaydet.Controls.Add(this.tbSokak);
            this.gbAdresKaydet.Controls.Add(this.tbMahalle);
            this.gbAdresKaydet.Controls.Add(this.tbCadde);
            this.gbAdresKaydet.Controls.Add(this.Gömlek);
            this.gbAdresKaydet.Controls.Add(this.Ceket);
            this.gbAdresKaydet.Controls.Add(this.Tişört);
            this.gbAdresKaydet.Controls.Add(this.Pantolon);
            this.gbAdresKaydet.Controls.Add(this.Elbise);
            this.gbAdresKaydet.Controls.Add(this.Cadde);
            this.gbAdresKaydet.Controls.Add(this.btnAdresKaydet);
            this.gbAdresKaydet.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbAdresKaydet.Location = new System.Drawing.Point(0, 0);
            this.gbAdresKaydet.Name = "gbAdresKaydet";
            this.gbAdresKaydet.Size = new System.Drawing.Size(913, 357);
            this.gbAdresKaydet.TabIndex = 3;
            this.gbAdresKaydet.TabStop = false;
            this.gbAdresKaydet.Text = "Adres Ekle";
            // 
            // tbŞehir
            // 
            this.tbŞehir.Location = new System.Drawing.Point(521, 73);
            this.tbŞehir.Name = "tbŞehir";
            this.tbŞehir.Size = new System.Drawing.Size(100, 20);
            this.tbŞehir.TabIndex = 21;
            // 
            // tbİlçe
            // 
            this.tbİlçe.Location = new System.Drawing.Point(521, 50);
            this.tbİlçe.Name = "tbİlçe";
            this.tbİlçe.Size = new System.Drawing.Size(100, 20);
            this.tbİlçe.TabIndex = 20;
            // 
            // tbBinaNo
            // 
            this.tbBinaNo.Location = new System.Drawing.Point(303, 77);
            this.tbBinaNo.Name = "tbBinaNo";
            this.tbBinaNo.Size = new System.Drawing.Size(100, 20);
            this.tbBinaNo.TabIndex = 19;
            // 
            // tbSokak
            // 
            this.tbSokak.Location = new System.Drawing.Point(303, 50);
            this.tbSokak.Name = "tbSokak";
            this.tbSokak.Size = new System.Drawing.Size(100, 20);
            this.tbSokak.TabIndex = 18;
            // 
            // tbMahalle
            // 
            this.tbMahalle.Location = new System.Drawing.Point(82, 80);
            this.tbMahalle.Name = "tbMahalle";
            this.tbMahalle.Size = new System.Drawing.Size(100, 20);
            this.tbMahalle.TabIndex = 17;
            // 
            // tbCadde
            // 
            this.tbCadde.Location = new System.Drawing.Point(82, 54);
            this.tbCadde.Name = "tbCadde";
            this.tbCadde.Size = new System.Drawing.Size(100, 20);
            this.tbCadde.TabIndex = 16;
            // 
            // Gömlek
            // 
            this.Gömlek.AutoSize = true;
            this.Gömlek.Location = new System.Drawing.Point(480, 80);
            this.Gömlek.Name = "Gömlek";
            this.Gömlek.Size = new System.Drawing.Size(31, 13);
            this.Gömlek.TabIndex = 15;
            this.Gömlek.Text = "Şehir";
            // 
            // Ceket
            // 
            this.Ceket.AutoSize = true;
            this.Ceket.Location = new System.Drawing.Point(480, 57);
            this.Ceket.Name = "Ceket";
            this.Ceket.Size = new System.Drawing.Size(24, 13);
            this.Ceket.TabIndex = 14;
            this.Ceket.Text = "İlçe";
            this.Ceket.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Tişört
            // 
            this.Tişört.AutoSize = true;
            this.Tişört.Location = new System.Drawing.Point(253, 80);
            this.Tişört.Name = "Tişört";
            this.Tişört.Size = new System.Drawing.Size(45, 13);
            this.Tişört.TabIndex = 13;
            this.Tişört.Text = "Bina No";
            // 
            // Pantolon
            // 
            this.Pantolon.AutoSize = true;
            this.Pantolon.Location = new System.Drawing.Point(253, 57);
            this.Pantolon.Name = "Pantolon";
            this.Pantolon.Size = new System.Drawing.Size(38, 13);
            this.Pantolon.TabIndex = 12;
            this.Pantolon.Text = "Sokak";
            // 
            // Elbise
            // 
            this.Elbise.AutoSize = true;
            this.Elbise.Location = new System.Drawing.Point(41, 80);
            this.Elbise.Name = "Elbise";
            this.Elbise.Size = new System.Drawing.Size(44, 13);
            this.Elbise.TabIndex = 11;
            this.Elbise.Text = "Mahalle";
            // 
            // Cadde
            // 
            this.Cadde.AutoSize = true;
            this.Cadde.Location = new System.Drawing.Point(41, 57);
            this.Cadde.Name = "Cadde";
            this.Cadde.Size = new System.Drawing.Size(38, 13);
            this.Cadde.TabIndex = 10;
            this.Cadde.Text = "Cadde";
            // 
            // btnAdresKaydet
            // 
            this.btnAdresKaydet.Location = new System.Drawing.Point(303, 118);
            this.btnAdresKaydet.Name = "btnAdresKaydet";
            this.btnAdresKaydet.Size = new System.Drawing.Size(92, 30);
            this.btnAdresKaydet.TabIndex = 9;
            this.btnAdresKaydet.Text = "Adres Kaydet";
            this.btnAdresKaydet.UseVisualStyleBackColor = true;
            // 
            // Adres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 512);
            this.Controls.Add(this.gbAdresKaydet);
            this.Controls.Add(this.dgKıyafetler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Adres";
            this.Text = "Adres";
            ((System.ComponentModel.ISupportInitialize)(this.dgKıyafetler)).EndInit();
            this.gbAdresKaydet.ResumeLayout(false);
            this.gbAdresKaydet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgKıyafetler;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAdres_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCadde;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMahalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSokak;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBina_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmİlçe;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmŞehir;
        private System.Windows.Forms.GroupBox gbAdresKaydet;
        private System.Windows.Forms.TextBox tbŞehir;
        private System.Windows.Forms.TextBox tbİlçe;
        private System.Windows.Forms.TextBox tbBinaNo;
        private System.Windows.Forms.TextBox tbSokak;
        private System.Windows.Forms.TextBox tbMahalle;
        private System.Windows.Forms.TextBox tbCadde;
        private System.Windows.Forms.Label Gömlek;
        private System.Windows.Forms.Label Ceket;
        private System.Windows.Forms.Label Tişört;
        private System.Windows.Forms.Label Pantolon;
        private System.Windows.Forms.Label Elbise;
        private System.Windows.Forms.Label Cadde;
        private System.Windows.Forms.Button btnAdresKaydet;
    }
}