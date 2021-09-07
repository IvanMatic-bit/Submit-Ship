using Submit_Ship.WinUI.Adresa;
using Submit_Ship.WinUI.Drzava;
using Submit_Ship.WinUI.Grad;
using Submit_Ship.WinUI.Isporuka;
using Submit_Ship.WinUI.Izvjestaji;
using Submit_Ship.WinUI.Kamion;
using Submit_Ship.WinUI.Korisnik;
using Submit_Ship.WinUI.Kvar;
using Submit_Ship.WinUI.Usluga;
using Submit_Ship.WinUI.Zahtjev;
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
    public partial class frmIndex : Form
    {
        private int childFormNumber = 0;

        public frmIndex()
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

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
         //   toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
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

        private void pretragaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsluga frm = new frmUsluga();
            frm.MdiParent = this;
            frm.Show();
        }

        private void novaUslugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUslugaDetalji frm = new frmUslugaDetalji();
            frm.MdiParent = this;
            frm.Show();
        }

        private void državaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDrzavaInsert frm = new frmDrzavaInsert();
            frm.MdiParent = this;
            frm.Show();
        }

        private void gradToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGrad frm = new frmGrad();
            frm.MdiParent = this;
            frm.Show();
        }

        private void adresaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAdresa frm = new frmAdresa();
            frm.MdiParent = this;
            frm.Show();
        }

        private void novaAdresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdresaDetalji frm = new frmAdresaDetalji();
            frm.MdiParent = this;
            frm.Show();
        }

        private void pretragaKamionaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKamion frm = new frmKamion();
            frm.MdiParent = this;
            frm.Show();
        }

        private void noviKamionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKamionDetalji frm = new frmKamionDetalji();
            frm.MdiParent = this;
            frm.Show();
        }

        private void pretragaZahtjevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmZahtjev frm = new frmZahtjev();
            frm.MdiParent = this;
            frm.Show();
        }

        private void pretragaKvarovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKvar frm = new frmKvar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void pretragaIsporukaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIsporuka frm = new frmIsporuka();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmIsporukaDetalji frm = new frmIsporukaDetalji();
            frm.MdiParent = this;
            frm.Show();
        }

        private void pretragaKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKorisnik frm = new frmKorisnik();
            frm.MdiParent = this;
            frm.Show();
        }

        private void noviKorisnikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKorisnikDetalji frm = new frmKorisnikDetalji();
            frm.Show();
        }

        private void kamionKvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKamionKvar frm = new frmKamionKvar();
            frm.Show();
        }

        private void korisnikIsporukeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKorisnikIsporuke frm = new frmKorisnikIsporuke();
            frm.Show();
        }

        private void uslugeZaradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUslugeZarada frm = new frmUslugeZarada();
            frm.Show();
        }
    }
}
