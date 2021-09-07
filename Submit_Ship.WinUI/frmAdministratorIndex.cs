using Submit_Ship.WinUI.Kamion;
using Submit_Ship.WinUI.Korisnik;
using Submit_Ship.WinUI.Usluga;
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
    public partial class frmAdministratorIndex : Form
    {
        private int childFormNumber = 0;

        public frmAdministratorIndex()
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

        private void pregledKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKorisnik frm = new frmKorisnik();
            frm.MdiParent = this;
            frm.Show();
        }

        private void noviKorisnikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKorisnikDetalji frm = new frmKorisnikDetalji();
            frm.MdiParent = this;
            frm.Show();
        }

        private void pregledKamionaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKamion frm = new frmKamion();
            frm.MdiParent = this;
            frm.Show();
        }

        private void pretragaKamionaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKamionDetalji frm = new frmKamionDetalji();
            frm.MdiParent = this;
            frm.Show();
        }

        private void pregledCjenovnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsluga frm = new frmUsluga();
            frm.MdiParent = this;
            frm.Show();
        }

        private void noviCjenovnikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUslugaDetalji frm = new frmUslugaDetalji();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mojiPodaciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKorisnikDetalji frm = new frmKorisnikDetalji(APIService.Id);
            frm.MdiParent = this;
            frm.Show();
        }

        private void odjaviSeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            APIService.Username = "";
            APIService.Password = "";
            APIService.Id = 0;
            APIService.Uloga = "";
            Close();
        }
    }
}
