namespace Terzi_Takip_Otomasyonu
{
    partial class Islem
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
            this.clmIslem_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDikim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTadil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTamir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbKıyafetKaydet = new System.Windows.Forms.GroupBox();
            this.tbTamir = new System.Windows.Forms.TextBox();
            this.tbTadil = new System.Windows.Forms.TextBox();
            this.Elbise = new System.Windows.Forms.Label();
            this.Etek = new System.Windows.Forms.Label();
            this.btnİşlemKaydet = new System.Windows.Forms.Button();
            this.tbDikim = new System.Windows.Forms.TextBox();
            this.lblÖlçüNo1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgKıyafetler)).BeginInit();
            this.gbKıyafetKaydet.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgKıyafetler
            // 
            this.dgKıyafetler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgKıyafetler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKıyafetler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIslem_No,
            this.clmDikim,
            this.clmTadil,
            this.clmTamir});
            this.dgKıyafetler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgKıyafetler.Location = new System.Drawing.Point(0, 269);
            this.dgKıyafetler.Name = "dgKıyafetler";
            this.dgKıyafetler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgKıyafetler.Size = new System.Drawing.Size(982, 155);
            this.dgKıyafetler.TabIndex = 1;
            // 
            // clmIslem_No
            // 
            this.clmIslem_No.HeaderText = "Islem_No";
            this.clmIslem_No.Name = "clmIslem_No";
            this.clmIslem_No.Visible = false;
            // 
            // clmDikim
            // 
            this.clmDikim.HeaderText = "Dikim";
            this.clmDikim.Name = "clmDikim";
            // 
            // clmTadil
            // 
            this.clmTadil.HeaderText = "Tadil";
            this.clmTadil.Name = "clmTadil";
            // 
            // clmTamir
            // 
            this.clmTamir.HeaderText = "Tamir";
            this.clmTamir.Name = "clmTamir";
            // 
            // gbKıyafetKaydet
            // 
            this.gbKıyafetKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gbKıyafetKaydet.Controls.Add(this.tbTamir);
            this.gbKıyafetKaydet.Controls.Add(this.tbTadil);
            this.gbKıyafetKaydet.Controls.Add(this.Elbise);
            this.gbKıyafetKaydet.Controls.Add(this.Etek);
            this.gbKıyafetKaydet.Controls.Add(this.btnİşlemKaydet);
            this.gbKıyafetKaydet.Controls.Add(this.tbDikim);
            this.gbKıyafetKaydet.Controls.Add(this.lblÖlçüNo1);
            this.gbKıyafetKaydet.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbKıyafetKaydet.Location = new System.Drawing.Point(0, 0);
            this.gbKıyafetKaydet.Name = "gbKıyafetKaydet";
            this.gbKıyafetKaydet.Size = new System.Drawing.Size(982, 269);
            this.gbKıyafetKaydet.TabIndex = 3;
            this.gbKıyafetKaydet.TabStop = false;
            this.gbKıyafetKaydet.Text = "İşlem Ekle";
            // 
            // tbTamir
            // 
            this.tbTamir.Location = new System.Drawing.Point(82, 80);
            this.tbTamir.Name = "tbTamir";
            this.tbTamir.Size = new System.Drawing.Size(100, 20);
            this.tbTamir.TabIndex = 17;
            // 
            // tbTadil
            // 
            this.tbTadil.Location = new System.Drawing.Point(82, 54);
            this.tbTadil.Name = "tbTadil";
            this.tbTadil.Size = new System.Drawing.Size(100, 20);
            this.tbTadil.TabIndex = 16;
            // 
            // Elbise
            // 
            this.Elbise.AutoSize = true;
            this.Elbise.Location = new System.Drawing.Point(41, 80);
            this.Elbise.Name = "Elbise";
            this.Elbise.Size = new System.Drawing.Size(33, 13);
            this.Elbise.TabIndex = 11;
            this.Elbise.Text = "Tamir";
            // 
            // Etek
            // 
            this.Etek.AutoSize = true;
            this.Etek.Location = new System.Drawing.Point(41, 57);
            this.Etek.Name = "Etek";
            this.Etek.Size = new System.Drawing.Size(30, 13);
            this.Etek.TabIndex = 10;
            this.Etek.Text = "Tadil";
            // 
            // btnİşlemKaydet
            // 
            this.btnİşlemKaydet.Location = new System.Drawing.Point(96, 149);
            this.btnİşlemKaydet.Name = "btnİşlemKaydet";
            this.btnİşlemKaydet.Size = new System.Drawing.Size(92, 30);
            this.btnİşlemKaydet.TabIndex = 9;
            this.btnİşlemKaydet.Text = "İşlem Kaydet";
            this.btnİşlemKaydet.UseVisualStyleBackColor = true;
            // 
            // tbDikim
            // 
            this.tbDikim.Location = new System.Drawing.Point(96, 25);
            this.tbDikim.Name = "tbDikim";
            this.tbDikim.Size = new System.Drawing.Size(64, 20);
            this.tbDikim.TabIndex = 8;
            // 
            // lblÖlçüNo1
            // 
            this.lblÖlçüNo1.AutoSize = true;
            this.lblÖlçüNo1.Location = new System.Drawing.Point(41, 28);
            this.lblÖlçüNo1.Name = "lblÖlçüNo1";
            this.lblÖlçüNo1.Size = new System.Drawing.Size(33, 13);
            this.lblÖlçüNo1.TabIndex = 7;
            this.lblÖlçüNo1.Text = "Dikim";
            // 
            // Islem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 424);
            this.Controls.Add(this.gbKıyafetKaydet);
            this.Controls.Add(this.dgKıyafetler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Islem";
            this.Text = "Borc";
            ((System.ComponentModel.ISupportInitialize)(this.dgKıyafetler)).EndInit();
            this.gbKıyafetKaydet.ResumeLayout(false);
            this.gbKıyafetKaydet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgKıyafetler;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIslem_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDikim;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTadil;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTamir;
        private System.Windows.Forms.GroupBox gbKıyafetKaydet;
        private System.Windows.Forms.TextBox tbTamir;
        private System.Windows.Forms.TextBox tbTadil;
        private System.Windows.Forms.Label Elbise;
        private System.Windows.Forms.Label Etek;
        private System.Windows.Forms.Button btnİşlemKaydet;
        private System.Windows.Forms.TextBox tbDikim;
        private System.Windows.Forms.Label lblÖlçüNo1;
    }
}