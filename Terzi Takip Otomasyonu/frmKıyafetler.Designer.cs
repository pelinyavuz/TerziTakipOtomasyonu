namespace Terzi_Takip_Otomasyonu
{
    partial class frmKıyafetler
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
            this.Kıyafet_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOlcu_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEtek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmElbise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPantolon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTisört = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCeket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGömlek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbKıyafetKaydet = new System.Windows.Forms.GroupBox();
            this.tbGömlek = new System.Windows.Forms.TextBox();
            this.tbCeket = new System.Windows.Forms.TextBox();
            this.tbTişört = new System.Windows.Forms.TextBox();
            this.tbPantolon = new System.Windows.Forms.TextBox();
            this.tbElbise = new System.Windows.Forms.TextBox();
            this.tbEtek = new System.Windows.Forms.TextBox();
            this.Gömlek = new System.Windows.Forms.Label();
            this.Ceket = new System.Windows.Forms.Label();
            this.Tişört = new System.Windows.Forms.Label();
            this.Pantolon = new System.Windows.Forms.Label();
            this.Elbise = new System.Windows.Forms.Label();
            this.Etek = new System.Windows.Forms.Label();
            this.btnKıyafetKaydet = new System.Windows.Forms.Button();
            this.tbÖlçüNo1 = new System.Windows.Forms.TextBox();
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
            this.Kıyafet_no,
            this.clmOlcu_no,
            this.clmEtek,
            this.clmElbise,
            this.clmPantolon,
            this.clmTisört,
            this.clmCeket,
            this.clmGömlek});
            this.dgKıyafetler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgKıyafetler.Location = new System.Drawing.Point(0, 181);
            this.dgKıyafetler.Name = "dgKıyafetler";
            this.dgKıyafetler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgKıyafetler.Size = new System.Drawing.Size(755, 155);
            this.dgKıyafetler.TabIndex = 0;
            this.dgKıyafetler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgKıyafetler_CellContentClick);
            // 
            // Kıyafet_no
            // 
            this.Kıyafet_no.DataPropertyName = "Kıyafet_no";
            this.Kıyafet_no.HeaderText = "Kıyafet_no";
            this.Kıyafet_no.Name = "Kıyafet_no";
            this.Kıyafet_no.Visible = false;
            // 
            // clmOlcu_no
            // 
            this.clmOlcu_no.DataPropertyName = "Olcu_no";
            this.clmOlcu_no.HeaderText = "Olcu_no";
            this.clmOlcu_no.Name = "clmOlcu_no";
            // 
            // clmEtek
            // 
            this.clmEtek.DataPropertyName = "Etek";
            this.clmEtek.HeaderText = "Etek";
            this.clmEtek.Name = "clmEtek";
            // 
            // clmElbise
            // 
            this.clmElbise.DataPropertyName = "Elbise";
            this.clmElbise.HeaderText = "Elbise";
            this.clmElbise.Name = "clmElbise";
            // 
            // clmPantolon
            // 
            this.clmPantolon.DataPropertyName = "Pantolon";
            this.clmPantolon.HeaderText = "Pantolon";
            this.clmPantolon.Name = "clmPantolon";
            // 
            // clmTisört
            // 
            this.clmTisört.DataPropertyName = "Tisört";
            this.clmTisört.HeaderText = "Tisört";
            this.clmTisört.Name = "clmTisört";
            // 
            // clmCeket
            // 
            this.clmCeket.DataPropertyName = "Ceket";
            this.clmCeket.HeaderText = "Ceket";
            this.clmCeket.Name = "clmCeket";
            // 
            // clmGömlek
            // 
            this.clmGömlek.DataPropertyName = "Gömlek";
            this.clmGömlek.HeaderText = "Gömlek";
            this.clmGömlek.Name = "clmGömlek";
            // 
            // gbKıyafetKaydet
            // 
            this.gbKıyafetKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gbKıyafetKaydet.Controls.Add(this.tbGömlek);
            this.gbKıyafetKaydet.Controls.Add(this.tbCeket);
            this.gbKıyafetKaydet.Controls.Add(this.tbTişört);
            this.gbKıyafetKaydet.Controls.Add(this.tbPantolon);
            this.gbKıyafetKaydet.Controls.Add(this.tbElbise);
            this.gbKıyafetKaydet.Controls.Add(this.tbEtek);
            this.gbKıyafetKaydet.Controls.Add(this.Gömlek);
            this.gbKıyafetKaydet.Controls.Add(this.Ceket);
            this.gbKıyafetKaydet.Controls.Add(this.Tişört);
            this.gbKıyafetKaydet.Controls.Add(this.Pantolon);
            this.gbKıyafetKaydet.Controls.Add(this.Elbise);
            this.gbKıyafetKaydet.Controls.Add(this.Etek);
            this.gbKıyafetKaydet.Controls.Add(this.btnKıyafetKaydet);
            this.gbKıyafetKaydet.Controls.Add(this.tbÖlçüNo1);
            this.gbKıyafetKaydet.Controls.Add(this.lblÖlçüNo1);
            this.gbKıyafetKaydet.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbKıyafetKaydet.Location = new System.Drawing.Point(0, 0);
            this.gbKıyafetKaydet.Name = "gbKıyafetKaydet";
            this.gbKıyafetKaydet.Size = new System.Drawing.Size(755, 181);
            this.gbKıyafetKaydet.TabIndex = 2;
            this.gbKıyafetKaydet.TabStop = false;
            this.gbKıyafetKaydet.Text = "Kıyafet Ekle";
            this.gbKıyafetKaydet.Enter += new System.EventHandler(this.gbKıyafetKaydet_Enter);
            // 
            // tbGömlek
            // 
            this.tbGömlek.Location = new System.Drawing.Point(521, 73);
            this.tbGömlek.Name = "tbGömlek";
            this.tbGömlek.Size = new System.Drawing.Size(100, 20);
            this.tbGömlek.TabIndex = 21;
            // 
            // tbCeket
            // 
            this.tbCeket.Location = new System.Drawing.Point(521, 50);
            this.tbCeket.Name = "tbCeket";
            this.tbCeket.Size = new System.Drawing.Size(100, 20);
            this.tbCeket.TabIndex = 20;
            // 
            // tbTişört
            // 
            this.tbTişört.Location = new System.Drawing.Point(303, 77);
            this.tbTişört.Name = "tbTişört";
            this.tbTişört.Size = new System.Drawing.Size(100, 20);
            this.tbTişört.TabIndex = 19;
            // 
            // tbPantolon
            // 
            this.tbPantolon.Location = new System.Drawing.Point(303, 50);
            this.tbPantolon.Name = "tbPantolon";
            this.tbPantolon.Size = new System.Drawing.Size(100, 20);
            this.tbPantolon.TabIndex = 18;
            // 
            // tbElbise
            // 
            this.tbElbise.Location = new System.Drawing.Point(82, 80);
            this.tbElbise.Name = "tbElbise";
            this.tbElbise.Size = new System.Drawing.Size(100, 20);
            this.tbElbise.TabIndex = 17;
            // 
            // tbEtek
            // 
            this.tbEtek.Location = new System.Drawing.Point(82, 54);
            this.tbEtek.Name = "tbEtek";
            this.tbEtek.Size = new System.Drawing.Size(100, 20);
            this.tbEtek.TabIndex = 16;
            // 
            // Gömlek
            // 
            this.Gömlek.AutoSize = true;
            this.Gömlek.Location = new System.Drawing.Point(480, 80);
            this.Gömlek.Name = "Gömlek";
            this.Gömlek.Size = new System.Drawing.Size(43, 13);
            this.Gömlek.TabIndex = 15;
            this.Gömlek.Text = "Gömlek";
            // 
            // Ceket
            // 
            this.Ceket.AutoSize = true;
            this.Ceket.Location = new System.Drawing.Point(480, 57);
            this.Ceket.Name = "Ceket";
            this.Ceket.Size = new System.Drawing.Size(35, 13);
            this.Ceket.TabIndex = 14;
            this.Ceket.Text = "Ceket";
            // 
            // Tişört
            // 
            this.Tişört.AutoSize = true;
            this.Tişört.Location = new System.Drawing.Point(253, 80);
            this.Tişört.Name = "Tişört";
            this.Tişört.Size = new System.Drawing.Size(33, 13);
            this.Tişört.TabIndex = 13;
            this.Tişört.Text = "Tişört";
            // 
            // Pantolon
            // 
            this.Pantolon.AutoSize = true;
            this.Pantolon.Location = new System.Drawing.Point(253, 57);
            this.Pantolon.Name = "Pantolon";
            this.Pantolon.Size = new System.Drawing.Size(49, 13);
            this.Pantolon.TabIndex = 12;
            this.Pantolon.Text = "Pantolon";
            // 
            // Elbise
            // 
            this.Elbise.AutoSize = true;
            this.Elbise.Location = new System.Drawing.Point(41, 80);
            this.Elbise.Name = "Elbise";
            this.Elbise.Size = new System.Drawing.Size(35, 13);
            this.Elbise.TabIndex = 11;
            this.Elbise.Text = "Elbise";
            // 
            // Etek
            // 
            this.Etek.AutoSize = true;
            this.Etek.Location = new System.Drawing.Point(41, 57);
            this.Etek.Name = "Etek";
            this.Etek.Size = new System.Drawing.Size(29, 13);
            this.Etek.TabIndex = 10;
            this.Etek.Text = "Etek";
            // 
            // btnKıyafetKaydet
            // 
            this.btnKıyafetKaydet.Location = new System.Drawing.Point(303, 118);
            this.btnKıyafetKaydet.Name = "btnKıyafetKaydet";
            this.btnKıyafetKaydet.Size = new System.Drawing.Size(92, 30);
            this.btnKıyafetKaydet.TabIndex = 9;
            this.btnKıyafetKaydet.Text = "Kıyafet Kaydet";
            this.btnKıyafetKaydet.UseVisualStyleBackColor = true;
            // 
            // tbÖlçüNo1
            // 
            this.tbÖlçüNo1.Location = new System.Drawing.Point(96, 25);
            this.tbÖlçüNo1.Name = "tbÖlçüNo1";
            this.tbÖlçüNo1.Size = new System.Drawing.Size(64, 20);
            this.tbÖlçüNo1.TabIndex = 8;
            // 
            // lblÖlçüNo1
            // 
            this.lblÖlçüNo1.AutoSize = true;
            this.lblÖlçüNo1.Location = new System.Drawing.Point(41, 28);
            this.lblÖlçüNo1.Name = "lblÖlçüNo1";
            this.lblÖlçüNo1.Size = new System.Drawing.Size(46, 13);
            this.lblÖlçüNo1.TabIndex = 7;
            this.lblÖlçüNo1.Text = "Ölçü No";
            // 
            // frmKıyafetler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 336);
            this.Controls.Add(this.gbKıyafetKaydet);
            this.Controls.Add(this.dgKıyafetler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKıyafetler";
            this.Text = "frmKıyafetler";
            ((System.ComponentModel.ISupportInitialize)(this.dgKıyafetler)).EndInit();
            this.gbKıyafetKaydet.ResumeLayout(false);
            this.gbKıyafetKaydet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgKıyafetler;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kıyafet_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOlcu_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEtek;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmElbise;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPantolon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTisört;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCeket;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGömlek;
        private System.Windows.Forms.GroupBox gbKıyafetKaydet;
        private System.Windows.Forms.Button btnKıyafetKaydet;
        private System.Windows.Forms.Label lblÖlçüNo1;
        private System.Windows.Forms.TextBox tbPantolon;
        private System.Windows.Forms.TextBox tbElbise;
        private System.Windows.Forms.TextBox tbEtek;
        private System.Windows.Forms.Label Gömlek;
        private System.Windows.Forms.Label Ceket;
        private System.Windows.Forms.Label Tişört;
        private System.Windows.Forms.Label Pantolon;
        private System.Windows.Forms.Label Elbise;
        private System.Windows.Forms.Label Etek;
        private System.Windows.Forms.TextBox tbÖlçüNo1;
        private System.Windows.Forms.TextBox tbGömlek;
        private System.Windows.Forms.TextBox tbCeket;
        private System.Windows.Forms.TextBox tbTişört;
    }
}