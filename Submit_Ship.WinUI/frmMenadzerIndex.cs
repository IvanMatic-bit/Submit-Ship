using Submit_Ship.WinUI.Isporuka;
using Submit_Ship.WinUI.Izvjestaji;
using Submit_Ship.WinUI.Kamion;
using Submit_Ship.WinUI.Korisnik;
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
    public partial class frmMenadzerIndex : Form
    {
        private int childFormNumber = 0;

        public frmMenadzerIndex()
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


        private void pregledZahtjevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmZahtjev frm = new frmZahtjev();
            frm.MdiParent = this;
            frm.Show();
        }

        private void pregledIsporukaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIsporuka frm = new frmIsporuka();
            frm.MdiParent = this;
            frm.Show();
        }

        private void novaIsporukaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIsporukaDetalji frm = new frmIsporukaDetalji();
            frm.MdiParent = this;
            frm.Show();
        }

        private void pregledVozačaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKorisnik frm = new frmKorisnik();
            frm.MdiParent = this;
            frm.Show();
        }

        private void pregledCjenovnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsluga frm = new frmUsluga();
            frm.MdiParent = this;
            frm.Show();
        }

        private void pregledKamionaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKamion frm = new frmKamion();
            frm.MdiParent = this;
            frm.Show();
        }

        private void izvještajOZaradiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUslugeZarada frm = new frmUslugeZarada();
            frm.MdiParent = this;
            frm.Show();
        }

        private void izvještajOKvarovimaKamionaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKamionKvar frm = new frmKamionKvar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void izvještajOIsporukamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKorisnikIsporuke frm = new frmKorisnikIsporuke();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mojiPodaciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKorisnikDetalji frm = new frmKorisnikDetalji(APIService.Id);
            frm.MdiParent = this;
            frm.Show();
        }

        private void odjvaiSeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            APIService.Username = "";
            APIService.Password = "";
            APIService.Id = 0;
            APIService.Uloga = "";
            Close();
        }
    }
}
