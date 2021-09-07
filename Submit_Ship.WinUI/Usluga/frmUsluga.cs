using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl.Http;
using Flurl;

namespace Submit_Ship.WinUI.Usluga
{
    public partial class frmUsluga : Form
    {
        private readonly APIService _apiService = new APIService("usluga");
        public frmUsluga()
        {
            InitializeComponent();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var result = await _apiService.Get<List<Model.Usluga>>(null);
            dgvUsluga.AutoGenerateColumns = false;
            dgvUsluga.DataSource = result;
        }

        private void dgvUsluga_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvUsluga.SelectedRows[0].Cells[0].Value;
            frmUslugaDetalji frm = new frmUslugaDetalji(int.Parse(id.ToString()));
            frm.Show();
        }
    }
}
