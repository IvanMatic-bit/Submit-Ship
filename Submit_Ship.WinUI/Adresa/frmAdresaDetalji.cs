using Submit_Ship.Model.Requests;
using Submit_Ship.WinUI.Grad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Submit_Ship.WinUI.Adresa
{
    public partial class frmAdresaDetalji : Form
    {
        private readonly APIService _grad = new APIService("grad");
        private readonly APIService _adresa = new APIService("adresa");
        private int? _id = null;

        public frmAdresaDetalji(int? adresaId=null)
        {
          
            InitializeComponent();
            _id = adresaId;
            AutoValidate = AutoValidate.Disable;
        }

        private void btnGrad_Click(object sender, EventArgs e)
        {
            frmGrad frm = new frmGrad();
            frm.Show();
        }

        private async void frmAdresaDetalji_Load(object sender, EventArgs e)
        {
            if(_id.HasValue)
            {
                var adresa = await _adresa.GetById<Model.Adresa>(_id);
                txtAdresa.Text = adresa.Naziv;
                cmbGrad.SelectedIndex = adresa.GradId;
            }
            await LoadGradovi();
        }

        private async Task LoadGradovi()
        {
            var result = await _grad.Get<List<Model.Grad>>(null);           
            cmbGrad.ValueMember = "Id";
            cmbGrad.DisplayMember = "Naziv";
            cmbGrad.DataSource = result;
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
                return;
            
                var request = new AdresaUpsertRequest()
                {
                    Naziv = txtAdresa.Text,
                    GradId =int.Parse(cmbGrad.SelectedValue.ToString())
                };

                if(_id.HasValue)
                {
                    await _adresa.Update<Model.Adresa>(_id, request);
                }
                else
                {
                    await _adresa.Insert<Model.Adresa>(request);
                }
                MessageBox.Show("Operacija uspješna");
            this.Close();
            
        }

        private void txtAdresa_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtAdresa.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtAdresa, Properties.Resources.Validation_RequiredField);
                
            }
            else
            {
                errorProvider.SetError(txtAdresa, null);
            }
        }
    }
}
