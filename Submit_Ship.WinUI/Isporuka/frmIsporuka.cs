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

namespace Submit_Ship.WinUI.Isporuka
{
    public partial class frmIsporuka : Form
    {
        private readonly APIService _isporuka = new APIService("isporuka");
        private readonly APIService _statusIsporuke = new APIService("statusIsporuke");
        List<Model.Isporuka> result;
        public frmIsporuka()
        {
            InitializeComponent();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            await loadIsporuka();

        }

        private async Task loadIsporuka()
        {
            IsporukaSearchRequest search = new IsporukaSearchRequest
            {
                SearchValue = txtPretraga.Text,
            };
            if(cmbStatus.SelectedIndex !=0)
            {
                search.StatusId = int.Parse(cmbStatus.SelectedValue.ToString());
            }
            result = await _isporuka.Get<List<Model.Isporuka>>(search);
            dgvIsporuke.DataSource = result;
        }

        private async void frmIsporuka_Load(object sender, EventArgs e)
        {
            dgvIsporuke.AutoGenerateColumns = false;
            var statusi = await _statusIsporuke.Get<List<Model.StatusIsporuke>>(null);
            statusi.Insert(0, new Model.StatusIsporuke());
            cmbStatus.DataSource = statusi;
            cmbStatus.DisplayMember = "Naziv";
            cmbStatus.ValueMember = "Id";
        }

        private void dgvIsporuke_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = int.Parse(dgvIsporuke.SelectedRows[0].Cells[0].Value.ToString());
            frmIsporukaDetalji frm = new frmIsporukaDetalji(id);
            frm.Show();
        }

        private async void cmbStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            await loadIsporuka();
        }
    }
}
