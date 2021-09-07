using Submit_Ship.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Submit_Ship.WinUI.Korisnik
{
    public partial class frmKorisnik : Form
    {
        private readonly APIService _korisnik = new APIService("korisnik");
        private readonly APIService _uloga = new APIService("uloga");
        private List<Model.Korisnik> result;
        public frmKorisnik()
        {
            InitializeComponent();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            result = await _korisnik.Get<List<Model.Korisnik>>(new BaseSearchRequest
            {
                SearchValue = txtPretraga.Text
            }
            );
            dgvKorisnici.DataSource = result;
        }

        private async  void frmKorisnik_Load(object sender, EventArgs e)
        {
            dgvKorisnici.AutoGenerateColumns = false;
            var uloge = await _uloga.Get<List<Model.Uloga>>(null);
            uloge.Insert(0, new Model.Uloga());
            cmbUloga.DataSource = uloge;
            cmbUloga.DisplayMember = "Naziv";
            cmbUloga.ValueMember = "Id";
        }

        private void cmbUloga_SelectedValueChanged(object sender, EventArgs e)
        {

            if (cmbUloga.SelectedIndex == 0)
            {
                dgvKorisnici.DataSource = result;
            }
            else
            {
                dgvKorisnici.DataSource = result.Where(x => x.UlogaId == int.Parse(cmbUloga.SelectedValue.ToString())).ToList();
            }
        }

        private void dgvKorisnici_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = int.Parse(dgvKorisnici.SelectedRows[0].Cells[0].Value.ToString());
            frmKorisnikDetalji frm = new frmKorisnikDetalji(id);
            frm.Show();
           
        }
    }
}
