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
    public partial class frmKvar : Form
    {
        private APIService _kvarovi = new APIService("kvar");

        public frmKvar()
        {
            InitializeComponent();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
          
           
            var result = await _kvarovi.Get<List<Model.Kvar>>(null);
            dgvKvar.DataSource = result;
        }

        private void dgvKvar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvKvar.SelectedRows[0].Cells[0].Value.ToString();
            frmKvarDetalji frm = new frmKvarDetalji(int.Parse(id));
            frm.Show();
        }
    }
}
