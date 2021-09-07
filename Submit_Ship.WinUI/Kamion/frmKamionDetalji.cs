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

namespace Submit_Ship.WinUI.Kamion
{
    public partial class frmKamionDetalji : Form
    {
        private readonly APIService _apiService = new APIService("kamion");
        private int? _id = null;
        public frmKamionDetalji(int? id = null)
        {
            InitializeComponent();
            _id = id;
            AutoValidate = AutoValidate.Disable;
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if(this.ValidateChildren())
            {
                var request = new KamionUpsertRequest()
                {
                    Proizvodac = txtProizvodac.Text,
                    Model = txtModel.Text,
                    DatumRegistracije = dtpDatumRegistracije.Value,
                    Reduktor = (bool)clbOprema.GetItemChecked(0),
                    SpavacaKabina = (bool)clbOprema.GetItemChecked(1),
                    Kiper = (bool)clbOprema.GetItemChecked(2),
                    Hladnjaca = (bool)clbOprema.GetItemChecked(3),
                    Cerada = (bool)clbOprema.GetItemChecked(4),
                    Nosivost = int.Parse(txtNosivost.Text)
                };
                if(_id.HasValue)
                {
                    await _apiService.Update<Model.Kamion>(_id, request);
                }
                else
                {
                    await _apiService.Insert<Model.Kamion>(request);
                }
                MessageBox.Show("Operacija uspješna");
                this.Close();
            }



        }

        private async void frmKamionDetalji_Load(object sender, EventArgs e)
        {
            if(!APIService.Uloga.Equals("Administrator"))
            {
                btnSnimi.Enabled = false;
            }
            if(_id.HasValue)
            {
                var kamion = await _apiService.GetById<Model.Kamion>(_id);

                txtProizvodac.Text = kamion.Proizvodac;
                txtModel.Text = kamion.Model;
                txtNosivost.Text = kamion.Nosivost.ToString();
                dtpDatumRegistracije.Value = kamion.DatumRegistracije;
                clbOprema.SetItemChecked(0 , kamion.Reduktor);
                clbOprema.SetItemChecked(1,   kamion.SpavacaKabina);
                clbOprema.SetItemChecked(2, kamion.Kiper);
                clbOprema.SetItemChecked(3, kamion.Hladnjaca);
                clbOprema.SetItemChecked(4, kamion.Cerada);               
            }
        }

        private void txtProizvodac_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtProizvodac.Text))
            {
                errorProvider.SetError(txtProizvodac, Properties.Resources.Validation_RequiredField);
                e.Cancel = true; 
            }
            else
            {
                errorProvider.SetError(txtProizvodac, null);
            }
        }

        private void txtModel_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtModel.Text))
            {
                errorProvider.SetError(txtModel, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtModel, null);
            }
        }

        private void txtNosivost_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtNosivost.Text))
            {
                errorProvider.SetError(txtNosivost, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;

            }
            else
            {
                errorProvider.SetError(txtNosivost, null);
            }
        }
    }
}
