namespace Terzi_Takip_Otomasyonu
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bynOlcu = new System.Windows.Forms.Button();
            this.btnAdres = new System.Windows.Forms.Button();
            this.btnIslem = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnÇıkış = new System.Windows.Forms.Button();
            this.btnÖdeme = new System.Windows.Forms.Button();
            this.btnMüşteriler = new System.Windows.Forms.Button();
            this.btnKıyafetler = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.bynOlcu);
            this.panel1.Controls.Add(this.btnAdres);
            this.panel1.Controls.Add(this.btnIslem);
            this.panel1.Controls.Add(this.pbLogo);
            this.panel1.Controls.Add(this.btnÇıkış);
            this.panel1.Controls.Add(this.btnÖdeme);
            this.panel1.Controls.Add(this.btnMüşteriler);
            this.panel1.Controls.Add(this.btnKıyafetler);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(959, 120);
            this.panel1.TabIndex = 0;
            // 
            // bynOlcu
            // 
            this.bynOlcu.Location = new System.Drawing.Point(733, 31);
            this.bynOlcu.Name = "bynOlcu";
            this.bynOlcu.Size = new System.Drawing.Size(97, 46);
            this.bynOlcu.TabIndex = 7;
            this.bynOlcu.Text = "Olcu";
            this.bynOlcu.UseVisualStyleBackColor = true;
            this.bynOlcu.Click += new System.EventHandler(this.bynOlcu_Click);
            // 
            // btnAdres
            // 
            this.btnAdres.Location = new System.Drawing.Point(632, 31);
            this.btnAdres.Name = "btnAdres";
            this.btnAdres.Size = new System.Drawing.Size(97, 46);
            this.btnAdres.TabIndex = 6;
            this.btnAdres.Text = "Adres";
            this.btnAdres.UseVisualStyleBackColor = true;
            this.btnAdres.Click += new System.EventHandler(this.btnAdres_Click);
            // 
            // btnIslem
            // 
            this.btnIslem.Location = new System.Drawing.Point(529, 31);
            this.btnIslem.Name = "btnIslem";
            this.btnIslem.Size = new System.Drawing.Size(97, 46);
            this.btnIslem.TabIndex = 5;
            this.btnIslem.Text = "İşlem";
            this.btnIslem.UseVisualStyleBackColor = true;
            this.btnIslem.Click += new System.EventHandler(this.btnIslem_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.White;
            this.pbLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLogo.BackgroundImage")));
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(200, 120);
            this.pbLogo.TabIndex = 4;
            this.pbLogo.TabStop = false;
            // 
            // btnÇıkış
            // 
            this.btnÇıkış.Location = new System.Drawing.Point(836, 31);
            this.btnÇıkış.Name = "btnÇıkış";
            this.btnÇıkış.Size = new System.Drawing.Size(94, 46);
            this.btnÇıkış.TabIndex = 3;
            this.btnÇıkış.Text = "Çıkış";
            this.btnÇıkış.UseVisualStyleBackColor = true;
            this.btnÇıkış.Click += new System.EventHandler(this.btnÇıkış_Click);
            // 
            // btnÖdeme
            // 
            this.btnÖdeme.Location = new System.Drawing.Point(426, 31);
            this.btnÖdeme.Name = "btnÖdeme";
            this.btnÖdeme.Size = new System.Drawing.Size(97, 46);
            this.btnÖdeme.TabIndex = 2;
            this.btnÖdeme.Text = "Ödeme";
            this.btnÖdeme.UseVisualStyleBackColor = true;
            this.btnÖdeme.Click += new System.EventHandler(this.btnÖdeme_Click);
            // 
            // btnMüşteriler
            // 
            this.btnMüşteriler.Location = new System.Drawing.Point(326, 31);
            this.btnMüşteriler.Name = "btnMüşteriler";
            this.btnMüşteriler.Size = new System.Drawing.Size(94, 46);
            this.btnMüşteriler.TabIndex = 1;
            this.btnMüşteriler.Text = "Müşteriler";
            this.btnMüşteriler.UseVisualStyleBackColor = true;
            this.btnMüşteriler.Click += new System.EventHandler(this.btnMüşteriler_Click);
            // 
            // btnKıyafetler
            // 
            this.btnKıyafetler.Location = new System.Drawing.Point(219, 31);
            this.btnKıyafetler.Name = "btnKıyafetler";
            this.btnKıyafetler.Size = new System.Drawing.Size(101, 46);
            this.btnKıyafetler.TabIndex = 0;
            this.btnKıyafetler.Text = "Kıyafetler";
            this.btnKıyafetler.UseVisualStyleBackColor = true;
            this.btnKıyafetler.Click += new System.EventHandler(this.btnKıyafetler_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 340);
            this.panel2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 460);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Terzi Takip Otomasyonu";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnÇıkış;
        private System.Windows.Forms.Button btnÖdeme;
        private System.Windows.Forms.Button btnMüşteriler;
        private System.Windows.Forms.Button btnKıyafetler;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnIslem;
        private System.Windows.Forms.Button btnAdres;
        private System.Windows.Forms.Button bynOlcu;
    }
}

