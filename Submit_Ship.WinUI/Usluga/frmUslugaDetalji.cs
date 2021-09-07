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

namespace Submit_Ship.WinUI.Usluga
{
    public partial class frmUslugaDetalji : Form
    {
        private readonly APIService _apiService = new APIService("usluga");
        private int? _id = null;
        public frmUslugaDetalji(int? uslugaId = null)
        {
            InitializeComponent();
            _id = uslugaId;
            AutoValidate = AutoValidate.Disable;
        }

        private async void frmUslugaDetalji_Load(object sender, EventArgs e)
        {
            if(_id.HasValue)
            {
                var usluga = await _apiService.GetById<Model.Usluga>(_id);

                txtNaziv.Text = usluga.Naziv;
                txtCijena.Text = usluga.Cijena.ToString();
                rtxtOpis.Text = usluga.Opis;

            }
            if(!APIService.Uloga.Equals("Administrator"))
            {
                btnSnimi.Enabled = false;
            }
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if(this.ValidateChildren())
            {
                var request = new UslugaUpsertRequest()
                {
                    Naziv = txtNaziv.Text,
                    Cijena = decimal.Parse(txtCijena.Text),
                    Opis = rtxtOpis.Text
                };
                if (_id.HasValue)
                {
                    await _apiService.Update<Model.Usluga>(_id, request);
                }
                else
                {
                    await _apiService.Insert<Model.Usluga>(request);
                }
                MessageBox.Show("Operacija uspješna");
            }
          
        }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtNaziv.Text) || txtNaziv.Text.Length > 25)
            {
                errorProvider.SetError(txtNaziv, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtNaziv, null);
            }
        }

        private void txtCijena_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCijena.Text))
            {
                errorProvider.SetError(txtCijena, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtCijena, null);
            }
        }

        private void rtxtOpis_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtxtOpis.Text) || rtxtOpis.Text.Length > 100)
            {
                errorProvider.SetError(rtxtOpis, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(rtxtOpis, null);
            }
        }
    }
    
}
