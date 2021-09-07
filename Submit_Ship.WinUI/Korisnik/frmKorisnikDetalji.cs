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
    public partial class frmKorisnikDetalji : Form
    {
        private readonly APIService _uloge = new APIService("uloga");
        private readonly APIService _korisnik = new APIService("korisnik");
        private int? _id = null;
        public frmKorisnikDetalji(int? id = null)
        {
            InitializeComponent();
            _id = id;
            AutoValidate = AutoValidate.Disable;
        }

        private async  void frmKorisnikDetalji_Load(object sender, EventArgs e)
        {
            await loadUloge();
            if(_id.HasValue)
            {
                await loadKorisnik();
            }
           if(APIService.Uloga != "Administrator")
            {
                cmbUloga.Enabled = false;
               
            }
        }

        private async Task loadUloge()
        {
            var result = await _uloge.Get<List<Model.Uloga>>(null);
            cmbUloga.ValueMember = "Id";
            cmbUloga.DisplayMember = "Naziv";
            cmbUloga.DataSource = result;
        }

        private async Task loadKorisnik()
        {
           
                var result = await _korisnik.GetById<Model.Korisnik>(_id);
                txtIme.Text = result.Ime;
                txtPrezime.Text = result.Prezime;
                txtEmail.Text = result.Email;
                txtTelefon.Text = result.Telefon.ToString();                
                cmbUloga.SelectedValue = result.UlogaId;
            cmbUloga.Enabled = false;
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if(this.ValidateChildren())
            {
                KorisnikUpsertRequest request = new KorisnikUpsertRequest
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    Email = txtEmail.Text,
                    Telefon = txtTelefon.Text, 
                    KorisnickoIme = txtKorisnickoIme.Text,
                    Password = txtLozinka.Text,
                    PotvrdiPassword = txtPotvrdiLozinka.Text,
                    Status = true,
                    UlogaId = int.Parse(cmbUloga.SelectedValue.ToString())

                };

                if (_id.HasValue)
                {
                    try
                    {
                        await _korisnik.Update<Model.Korisnik>(_id, request);
                        MessageBox.Show("Podaci o korisniku uspješno izmjenjeni");
                        this.Close();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Izmjene podataka o korisniku nisu uspjele");
                    }



                }
                else
                {
                    try
                    {
                        await _korisnik.Insert<Model.Korisnik>(request);
                        MessageBox.Show("Novi korisnik upsješno dodan");
                        this.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Greška prilikom kreiranja korisnika");
                    }

                }
            }    
           
            
        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtIme, Properties.Resources.Validation_RequiredField);

            }
            else
            {
                errorProvider.SetError(txtIme, null);
            }
        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtPrezime, Properties.Resources.Validation_RequiredField);

            }
            else
            {
                errorProvider.SetError(txtPrezime, null);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtEmail, Properties.Resources.Validation_RequiredField);

            }
            else
            {
                errorProvider.SetError(txtEmail, null);
            }
        }

        private void txtTelefon_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTelefon.Text) || txtTelefon.Text.Length >15)
            {
                e.Cancel = true;
                errorProvider.SetError(txtTelefon, Properties.Resources.Validation_RequiredField);

            }
            else
            {
                errorProvider.SetError(txtTelefon, null);
            }
        }

        private void txtKorisnickoIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKorisnickoIme.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtKorisnickoIme, Properties.Resources.Validation_RequiredField);

            }
            else
            {
                errorProvider.SetError(txtKorisnickoIme, null);
            }
        }

        private void txtLozinka_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLozinka.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtLozinka, Properties.Resources.Validation_RequiredField);

            }
            else
            {
                errorProvider.SetError(txtLozinka, null);
            }
        }

        private void txtPotvrdiLozinka_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPotvrdiLozinka.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtPotvrdiLozinka, Properties.Resources.Validation_RequiredField);

            }
            else
            {
                errorProvider.SetError(txtPotvrdiLozinka, null);
            }
        }

        private void cmbUloga_Validating(object sender, CancelEventArgs e)
        {
            if(cmbUloga.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(cmbUloga, Properties.Resources.Validation_RequiredField);
            }
            else
            {
                errorProvider.SetError(cmbUloga, null);
            }
        }
    }
}
