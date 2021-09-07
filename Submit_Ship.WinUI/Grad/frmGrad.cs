using Submit_Ship.Model.Requests;
using Submit_Ship.WinUI.Drzava;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Submit_Ship.WinUI.Grad
{
    public partial class frmGrad : Form
    {
        private readonly APIService _drzava = new APIService("drzava");
        private readonly APIService _grad = new APIService("grad");


        public frmGrad()
        {
            InitializeComponent();
            AutoValidate = AutoValidate.Disable;
        }

        private async void frmGrad_Load(object sender, EventArgs e)
        {
            await LoadDrzave();
        }

        private async Task LoadDrzave()
        {
            var result = await _drzava.Get<List<Model.Drzava>>(null);           
            cmbDrzava.DisplayMember = "Naziv";
            cmbDrzava.ValueMember = "Id";
            cmbDrzava.DataSource = result;
        }

        private void btnDrzavaDodaj_Click(object sender, EventArgs e)
        {
            frmDrzavaInsert frm = new frmDrzavaInsert();
            frm.Show();
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if(this.ValidateChildren())
            {
                GradUpsertRequest request = new GradUpsertRequest()
                {
                    Naziv = txtNaziv.Text,
                    DrzavaId = int.Parse(cmbDrzava.SelectedValue.ToString())
                };
                try
                {
                    await _grad.Insert<Model.Grad>(request);
                    MessageBox.Show("Novi grad uspješno dodan");
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Greška prilikom upisa grada");
                   
                }
               
            }
        }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtNaziv, Properties.Resources.Validation_RequiredField);

            }
            else
            {
                errorProvider.SetError(txtNaziv, null);
            }
        }

        private void cmbDrzava_Validating(object sender, CancelEventArgs e)
        {
            if (cmbDrzava.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(cmbDrzava, Properties.Resources.Validation_RequiredField);
            }
            else
            {
                errorProvider.SetError(cmbDrzava, null);
            }
        }
    }
}
