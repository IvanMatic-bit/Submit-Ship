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

namespace Submit_Ship.WinUI.Zahtjev
{
    public partial class frmZahtjev : Form
    {
        private readonly APIService _zahtjev = new APIService("zahtjev");
        private readonly APIService _status = new APIService("statuszahtjeva");
        private List<Model.Zahtjev> result;

        public frmZahtjev()
        {
            InitializeComponent();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {

            await loadZahtevi();
           // cmbStatus.SelectedIndex = 0;
        }

        private async Task loadZahtevi()
        {
            dgvZahtjevi.AutoGenerateColumns = false;
            var search = new ZahtjevSearchRequest()
            {
                SearchValue = txtPretraga.Text
                
            };

            if(cmbStatus.SelectedIndex !=0)
            {
                search.StatusId = int.Parse(cmbStatus.SelectedValue.ToString());
            }
           var  resl = await _zahtjev.Get<List<Model.Zahtjev>>(search);
            result = resl;
            dgvZahtjevi.DataSource = resl;
        }

        private async void frmZahtjev_Load(object sender, EventArgs e)
        {
            
            await LoadStutusi();
        }

        private async Task LoadStutusi()
        {
            var statusi = await _status.Get<List<Model.StatusZahtjeva>>(null);
            statusi.Insert(0, new Model.StatusZahtjeva());
            cmbStatus.DataSource = statusi;            
            cmbStatus.DisplayMember = "Naziv";
            cmbStatus.ValueMember = "Id";
        }

        private async void cmbStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            await loadZahtevi();
                    
        }

        private void dgvZahtjevi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvZahtjevi.SelectedRows[0].Cells[0].Value;
            frmZahtjevDetalji frm = new frmZahtjevDetalji(int.Parse(id.ToString()));
            frm.Show();
        }
    }
}
