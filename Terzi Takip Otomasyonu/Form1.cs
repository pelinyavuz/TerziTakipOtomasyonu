using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Terzi_Takip_Otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKıyafetler_Click(object sender, EventArgs e)
        {
            foreach (Form Item in this.MdiChildren)
                Item.Dispose();
                  
            

            frmKıyafetler frm = new frmKıyafetler();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            frm.Location = new Point(0, 0);
          

        }

        private void btnMüşteriler_Click(object sender, EventArgs e)
        {
            foreach (Form Item in this.MdiChildren)
               Item.Dispose();

            frmMüsteriler frm = new frmMüsteriler();
            frm.MdiParent = this;
            frm.Show();
            frm.Location = new Point(0, 0);



        }

        private void btnÇıkış_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnÖdeme_Click(object sender, EventArgs e)
        {
            foreach (Form Item in this.MdiChildren)
                Item.Dispose();

            frmÖdeme frm = new frmÖdeme();
            frm.MdiParent = this;
            frm.Show();
            frm.Location = new Point(0, 0);


        }

        private void btnIslem_Click(object sender, EventArgs e)
        {
            foreach (Form Item in this.MdiChildren)
                Item.Dispose();

            Islem frm = new Islem();
            frm.MdiParent = this;
            frm.Show();
            frm.Location = new Point(0, 0);

        }

        private void btnAdres_Click(object sender, EventArgs e)
        {
            foreach (Form Item in this.MdiChildren)
                Item.Dispose();

            Adres frm = new Adres();
            frm.MdiParent = this;
            frm.Show();
            frm.Location = new Point(0, 0);
        }

        private void bynOlcu_Click(object sender, EventArgs e)
        {

            foreach (Form Item in this.MdiChildren)
                Item.Dispose();

            Ölçü frm = new Ölçü();
            frm.MdiParent = this;
            frm.Show();
            frm.Location = new Point(0, 0);
        }
    }
}
