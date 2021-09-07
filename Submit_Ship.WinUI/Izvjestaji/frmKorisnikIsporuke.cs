using Microsoft.Reporting.WinForms;
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

namespace Submit_Ship.WinUI.Izvjestaji
{
    public partial class frmKorisnikIsporuke : Form
    {
        private APIService _korisnik = new APIService("korisnik");
        private APIService _isporuka = new APIService("isporuka");
        private List<Model.Korisnik> korisnici;
        public frmKorisnikIsporuke()
        {
            InitializeComponent();
            SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);
        }

        private async  void frmKorisnikIsporuke_Load(object sender, EventArgs e)
        {
            await LoadKorisnici();
            this.rvIsporuke.RefreshReport();

        }
        private async Task LoadKorisnici()
        {
            korisnici = await _korisnik.Get<List<Model.Korisnik>>(null);           
            cmbKorisnik.DataSource = korisnici;
            cmbKorisnik.DisplayMember = "ImePrezime";
            cmbKorisnik.ValueMember = "Id";
        }

        private async void btnIzvjestaj_Click(object sender, EventArgs e)
        {
            if (cmbKorisnik.SelectedIndex != 0)
            {
                int _id = int.Parse(cmbKorisnik.SelectedValue.ToString());
                IsporukaSearchRequest request = new IsporukaSearchRequest()
                {
                    KlijentId = _id,
                    DatumDo = dtpDatumDo.Value,
                    DatumOd = dtpDatumOd.Value,
                    
                };
                var list = await _isporuka.Get<List<Model.Isporuka>>(request);
                

                bsIsporuka.DataSource = list;
                ReportDataSource rds = new ReportDataSource("dsIsporuke", bsIsporuka);
                this.rvIsporuke.LocalReport.DataSources.Add(rds);

                var parametri = new List<ReportParameter>();
                parametri.Add(new ReportParameter("Ime", korisnici.Where(x => x.Id == _id).Select(x => x.Ime + x.Prezime).FirstOrDefault()));
                parametri.Add(new ReportParameter("DatumDo", dtpDatumDo.Value.ToString()));
                parametri.Add(new ReportParameter("DatumOd", dtpDatumOd.Value.ToString()));
                rvIsporuke.LocalReport.SetParameters(parametri);
                this.rvIsporuke.RefreshReport();
            }
        }
    }
}
