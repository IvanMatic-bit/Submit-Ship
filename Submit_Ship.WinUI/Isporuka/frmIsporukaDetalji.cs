using Submit_Ship.Model.Requests;
using Submit_Ship.WinUI.Adresa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Submit_Ship.WinUI.Isporuka
{
    public partial class frmIsporukaDetalji : Form
    {
        private readonly APIService _isporuka = new APIService("isporuka");
        private readonly APIService _adresa = new APIService("adresa");
        private readonly APIService _kamion = new APIService("kamion");
        private readonly APIService _korisnik = new APIService("korisnik");
        private readonly APIService _usluge = new APIService("usluga");
        private int? _id = null;
        public frmIsporukaDetalji(int? id=null)
        {
            InitializeComponent();
            _id = id;
            AutoValidate = AutoValidate.Disable;
        }

        private async void frmIsporukaDetalji_Load(object sender, EventArgs e)
        {
            await loadAdrese();
            await loadKamioni();
            await loadVozaci();
            await loadKlijenti();
            await loadUsluge();
            await loadDetalji();
        }

        private void btnAdresa_Click(object sender, EventArgs e)
        {
            frmAdresaDetalji frm = new frmAdresaDetalji();
            frm.Show();
        }

        private async Task loadAdrese()
        {
            var adreseUtovara = await _adresa.Get<List<Model.Adresa>>(null);
            adreseUtovara.Insert(0, new Model.Adresa());
            cmbAdresaUtovara.DataSource = adreseUtovara;
            cmbAdresaUtovara.DisplayMember = "Naziv";
            cmbAdresaUtovara.ValueMember = "Id";

            var adreseIstovara = await _adresa.Get<List<Model.Adresa>>(null);
            adreseIstovara.Insert(0, new Model.Adresa());
            cmbAdresaIstovara.DataSource = adreseIstovara;
            cmbAdresaIstovara.DisplayMember = "Naziv";
            cmbAdresaIstovara.ValueMember = "Id";
        }
        
        private async Task loadKamioni()
        {
            var kamioni = await _kamion.Get<List<Model.Kamion>>(null);
            kamioni.Insert(0, new Model.Kamion());
            cmbKamion.DataSource = kamioni;
            cmbKamion.DisplayMember = "ProizvodacModel";
            cmbKamion.ValueMember = "Id";
        }

        private async Task loadVozaci()
        {
            var vozaci = await _korisnik.Get<List<Model.Korisnik>>(null);
            vozaci.Insert(0, new Model.Korisnik());
            cmbVozac.DataSource = vozaci;
            cmbVozac.DisplayMember = "Ime";
            cmbVozac.ValueMember = "Id";
        }
        private async Task loadKlijenti()
        {
            var klijenti = await _korisnik.Get<List<Model.Korisnik>>(null);
            klijenti.Insert(0, new Model.Korisnik());
            cmbKlijent.DataSource = klijenti;
            cmbKlijent.DisplayMember = "Ime";
            cmbKlijent.ValueMember = "Id";
        }

        private async Task loadUsluge()
        {
            var usluge = await _usluge.Get<List<Model.Usluga>>(null);
            usluge.Insert(0, new Model.Usluga());
            cmbUsluga.DataSource = usluge;
            cmbUsluga.DisplayMember = "Naziv";
            cmbUsluga.ValueMember = "Id";
        }

        private async Task loadDetalji()
        {
            if(_id.HasValue)
            {
                var result = await _isporuka.GetById<Model.Isporuka>(_id);
                txtNaslov.Text = result.Naslov;
                txtCijena.Text = result.Cijena.ToString();               
                rtxtOpis.Text = result.OpisIsporuke;
                cmbAdresaIstovara.SelectedValue = result.AdresaIstovaraId;
                cmbAdresaUtovara.SelectedValue = result.AdresaUtovaraId;
                cmbKamion.SelectedValue = result.KamionId;
                cmbKlijent.SelectedValue = result.KlijentId;
                cmbVozac.SelectedValue = result.ZaposlenikId;
                cmbUsluga.SelectedValue = result.UslugaId;
                dtmDatum.Value = result.DatumIsporuke;
                
            }
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if(this.ValidateChildren())
            {
                var request = new IsporukaUpsertRequest()
                {
                    Naslov = txtNaslov.Text,
                    StatusIsporukeId = 3,//Novo
                    AdresaIstovaraId = int.Parse(cmbAdresaIstovara.SelectedValue.ToString()),
                    AdresaUtovaraId = int.Parse(cmbAdresaUtovara.SelectedValue.ToString()),
                    DatumIsporuke = dtmDatum.Value,
                    Cijena = decimal.Parse(txtCijena.Text),
                    DatumKreiranja = DateTime.Now,
                    KamionId = int.Parse(cmbKamion.SelectedValue.ToString()),
                    KlijentId = cmbKlijent.SelectedIndex,
                    ZaposlenikId = int.Parse(cmbVozac.SelectedValue.ToString()),
                    UslugaId = int.Parse(cmbUsluga.SelectedValue.ToString()),
                    OpisIsporuke = rtxtOpis.Text,
                    Placeno = false
                };

                if (_id.HasValue)
                {
                    await _isporuka.Update<Model.Isporuka>(_id, request);
                }
                else
                {
                    await _isporuka.Insert<Model.Isporuka>(request);
                }
                MessageBox.Show("Operacija uspješno izvršena");
                this.Close();
            }


        }

        private void txtNaslov_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtNaslov.Text) || txtNaslov.Text.Length>50)
            {
                errorProvider.SetError(txtNaslov, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtNaslov, null);
            }
        }

        private void rtxtOpis_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(rtxtOpis.Text) ||rtxtOpis.Text.Length >500)
            {
                errorProvider.SetError(rtxtOpis, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(rtxtOpis, null);
            }
        }

        private void cmbAdresaUtovara_Validating(object sender, CancelEventArgs e)
        {
            if(cmbAdresaUtovara.SelectedIndex == 0) //prvi model u listi je prazan 
            {
                errorProvider.SetError(cmbAdresaUtovara, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cmbAdresaUtovara, null);
            }
        }

        private void cmbAdresaIstovara_Validating(object sender, CancelEventArgs e)
        {
            if (cmbAdresaIstovara.SelectedIndex == 0)
            {
                errorProvider.SetError(cmbAdresaIstovara, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cmbAdresaIstovara, null);
            }
        }

        private void cmbKamion_Validating(object sender, CancelEventArgs e)
        {
            if(cmbKamion.SelectedIndex == 0)
            {
                errorProvider.SetError(cmbKamion, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cmbKamion, null);
            }
        }

        private void cmbVozac_Validating(object sender, CancelEventArgs e)
        {
            if(cmbVozac.SelectedIndex == 0)
            {
                errorProvider.SetError(cmbVozac, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cmbVozac, null);
            }    
        }

        private void cmbKlijent_Validating(object sender, CancelEventArgs e)
        {
            if(cmbKlijent.SelectedIndex == 0)
            {
                errorProvider.SetError(cmbKlijent, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cmbKlijent, null);
            }
        }

        private void cmbUsluga_Validating(object sender, CancelEventArgs e)
        {
            if(cmbUsluga.SelectedIndex ==0)
            {
                errorProvider.SetError(cmbUsluga, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cmbUsluga, null);
            }
        }

        

        private void txtCijena_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtCijena.Text))
            {
                errorProvider.SetError(txtCijena, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtCijena, null);
            }
        }
    }
}
