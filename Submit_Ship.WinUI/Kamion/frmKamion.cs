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
    public partial class frmKamion : Form
    {
        private readonly APIService _apiService = new APIService("kamion");
        List<Model.Kamion> result;
        public frmKamion()
        {
            InitializeComponent();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            result = await _apiService.Get<List<Model.Kamion>>(null);
            dgvKamioni.DataSource = result;

        }

        private void dgvKamioni_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvKamioni.SelectedRows[0].Cells[0].Value;
            frmKamionDetalji frm = new frmKamionDetalji(int.Parse(id.ToString()));
            frm.Show();
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbFilter.SelectedIndex!=0)
            {
                var temp = result.Where(x => x.Proizvodac.Equals(cmbFilter.SelectedItem)).ToList();
                dgvKamioni.DataSource = temp;
            }
            else
            {
                dgvKamioni.DataSource = result;
            }
        }

        private async void frmKamion_Load(object sender, EventArgs e)
        {
            await loadKamion();
            loadFilter();

        }

        private async Task loadKamion()
        {
            result = await _apiService.Get<List<Model.Kamion>>(null);
            dgvKamioni.DataSource = result;
        }
        private void loadFilter()
        {
            var proizvodaci = result.Select(x => x.Proizvodac).Distinct().ToList();
            proizvodaci.Insert(0,"");
            cmbFilter.DataSource = proizvodaci;
            
        }
    }
}
