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
    public partial class frmZahtjevDetalji : Form
    {
        private APIService _apiService = new APIService("zahtjev");
        private int _id;
        Model.Zahtjev result;
        public frmZahtjevDetalji(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmZahtjevDetalji_Load(object sender, EventArgs e)
        {
            
            try
            {
                result = await  _apiService.GetById<Model.Zahtjev>(_id);
                txtNaslov.Text = result.Naslov;
                dtpDatum.Value = result.DatumVrijemeZahtjeva;
                txtStatus.Text = result.StatusZahtjeva;
                txtKlijent.Text = result.Klijent;
                rtbSadrzaj.Text = result.Sadrzaj;

                if (result.StatusZahtjeva == "Novi") //Korisnik može da prihvati ili 
                {                                 //odbije samo nove zahtjeve
                    btnOdbij.Visible = true;      //Novi zahtjev = 1
                    btnPrihvati.Visible = true;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private async void btnPrihvati_Click(object sender, EventArgs e)
        {
            ZahtjevUpsertRequest request = new ZahtjevUpsertRequest()
            {
                DatumVrijemeZahtjeva = result.DatumVrijemeZahtjeva,
                KlijentId = result.KLijentId,
                Naslov = result.Naslov,
                Sadrzaj = result.Sadrzaj,
                StatusZahtjevaId = 2
            };
            if(result.StatusZahtjeva == "Novi")
            {
                await _apiService.Update<Model.Zahtjev>(_id, request);
                MessageBox.Show("Zahtjev uspješno prihvaćen");
                HideButtons();
            }
            else
            {
                MessageBox.Show("Nije moguće prihvatiti zahtjev");
               
            }

        }

        private async void btnOdbij_Click(object sender, EventArgs e)
        {
            ZahtjevUpsertRequest request = new ZahtjevUpsertRequest()
            {
                DatumVrijemeZahtjeva = result.DatumVrijemeZahtjeva,
                KlijentId = result.KLijentId,
                Naslov = result.Naslov,
                Sadrzaj = result.Sadrzaj,
                StatusZahtjevaId = 3
            };
            if (result.StatusZahtjeva == "Novi")
            {
                await _apiService.Update<Model.Zahtjev>(_id, request);
                MessageBox.Show("Zahtjev odbijen");
                HideButtons();
            }
            else
            {
                MessageBox.Show("Nije moguće odbiti zahtjev");
            }
        }

        private void HideButtons()
        {
            btnOdbij.Visible = false;
            btnPrihvati.Visible = false;
        }
    }
}
