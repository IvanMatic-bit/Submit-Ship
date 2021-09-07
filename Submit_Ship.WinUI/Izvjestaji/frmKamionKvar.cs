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
    public partial class frmKamionKvar : Form
    {
        private APIService _kamioni = new APIService("kamion");
        private APIService _kvar = new APIService("kvar");

        public frmKamionKvar()
        {
            InitializeComponent();
        }

        private async void frmKamionKvar_Load(object sender, EventArgs e)
        {
            await LoadKamioni();
            this.rvKamionKvar.RefreshReport();
            SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);
        }

        private async Task LoadKamioni()
        {
            var result = await _kamioni.Get<List<Model.Kamion>>(null);
            result.Insert(0, new Model.Kamion());
            cmbKamion.DataSource = result;
            cmbKamion.DisplayMember = "ProizvodacModel";
            cmbKamion.ValueMember = "Id";
        }        

        private async void cmbKamion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbKamion.SelectedIndex != 0)
            {
                int _id = int.Parse(cmbKamion.SelectedValue.ToString());
                KvarSearchRequest request = new KvarSearchRequest()
                {
                    KamionId = _id
                };
                var list = await _kvar.Get<List<Model.Kvar>>(request);                
                bsKvarovi.DataSource = list;
                ReportDataSource rds = new ReportDataSource("DataSet1", bsKvarovi);
                Model.Kamion kamion = await _kamioni.GetById<Model.Kamion>(_id);
                this.rvKamionKvar.LocalReport.DataSources.Add(rds);

                var parametri = new List<ReportParameter>();
                parametri.Add(new ReportParameter("KamionId", _id.ToString()));
                parametri.Add(new ReportParameter("Proizvodac", kamion.Proizvodac));
                parametri.Add(new ReportParameter("Model", kamion.Model));
                rvKamionKvar.LocalReport.SetParameters(parametri);
                this.rvKamionKvar.RefreshReport();
            }

                
            
        }
    }
}
