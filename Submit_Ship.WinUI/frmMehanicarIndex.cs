using Submit_Ship.WinUI.Kamion;
using Submit_Ship.WinUI.Korisnik;
using Submit_Ship.WinUI.Kvar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Submit_Ship.WinUI
{
    public partial class frmMehanicarIndex : Form
    {
        private int childFormNumber = 0;

        public frmMehanicarIndex()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }


        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void pregledKamionaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKamion frm = new frmKamion();
            frm.MdiParent = this;
            frm.Show();
        }

        private void kvaroviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKvar frm = new frmKvar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mojiPodaciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKorisnikDetalji frm = new frmKorisnikDetalji(APIService.Id);
            frm.MdiParent = this;
            frm.Show();
        }

        private void odjaviEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            APIService.Username = "";
            APIService.Password = "";
            APIService.Id = 0;
            APIService.Uloga = "";
            Close();
        }
    }
}
