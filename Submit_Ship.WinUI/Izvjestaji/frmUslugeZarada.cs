using Microsoft.Reporting.WinForms;
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
    public partial class frmUslugeZarada : Form
    {
        private APIService _isporuka = new APIService("isporuka");
        public frmUslugeZarada()
        {
            SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);
            InitializeComponent();
        }

        private async void frmUslugeZarada_Load(object sender, EventArgs e)
        {
            var result = await _isporuka.Get<List<Model.Isporuka>>(null);
            bsIsporuka.DataSource = result;
            ReportDataSource rds = new ReportDataSource("dsUsluge", bsIsporuka);
            this.rvUsluge.LocalReport.DataSources.Add(rds);
            this.rvUsluge.RefreshReport();
        }
    }
}
