using Submit_Ship.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Submit_Ship.WinUI.Drzava
{
    public partial class frmDrzavaInsert : Form
    {
        private readonly APIService _apiService = new APIService("drzava");

        public frmDrzavaInsert()
        {
            AutoValidate = AutoValidate.Disable;
            InitializeComponent();
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if(this.ValidateChildren())
            {
                var request = new DrzavaInsertRequest()
                {
                    Naziv = txtNaziv.Text
                };
                await _apiService.Insert<Model.Drzava>(request);
                MessageBox.Show("Operacija uspješna");
                this.Close();
            }
        }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                errorProvider.SetError(txtNaziv, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtNaziv, null);
            }
        }
    }
}
