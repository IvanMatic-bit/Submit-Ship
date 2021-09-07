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

namespace Submit_Ship.WinUI.Kvar
{
    public partial class frmKvarDetalji : Form
    {
        private readonly APIService _apiService = new APIService("kvar");
        private readonly int _id;
        public frmKvarDetalji(int id)
        {
            InitializeComponent();
            _id = id;
            AutoValidate = AutoValidate.Disable;
        }

        private async void frmKvarDetalji_Load(object sender, EventArgs e)
        {
            var result = await _apiService.GetById<Model.Kvar>(_id);
            txtId.Text = result.Id.ToString();
            txtKamion.Text = result.KamionId.ToString();
            txtVozac.Text = result.VozacId.ToString();
            rtbProblem.Text = result.Sadrzaj;
            rtbKomentar.Text = result.Komentar;
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            
            var request = new KvarUpsertRequest()
            {
                KamionId = int.Parse(txtKamion.Text),
                VozacId = int.Parse(txtVozac.Text),
                Sadrzaj = rtbProblem.Text,
                Komentar = rtbKomentar.Text
            };
            await _apiService.Update<Model.Kvar>(_id, request);
            MessageBox.Show("Komentar uspješno sačuvan");
            this.Close();

        }
    }
}
