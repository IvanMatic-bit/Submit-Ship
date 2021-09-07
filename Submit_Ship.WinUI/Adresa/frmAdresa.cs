using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Submit_Ship.WinUI.Adresa
{
    public partial class frmAdresa : Form
    {
        private readonly APIService _apiService = new APIService("adresa");

        public frmAdresa()
        {
            InitializeComponent();
        }

        private async void frmAdresa_Load(object sender, EventArgs e)
        {
            await LoadAdresa();
        }

        private async Task LoadAdresa()
        {
            var result = await _apiService.Get<List<Model.Adresa>>(null);
            dgvAdresa.DataSource = result;
        }
    }
}
