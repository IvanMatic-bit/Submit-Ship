using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Submit_Ship.WinUI
{
    public partial class frmLogin : Form
    {

        private APIService _service = new APIService("korisnik");
        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnPrijava_Click(object sender, EventArgs e)
        {
            try
            {
                APIService.Username = txtKorisnickoIme.Text;
                APIService.Password = txtLozinka.Text;
                var result = await _service.Get<List<Model.Korisnik>>(null);

                foreach (var korisnik in result)
                {
                    if (korisnik.KorisnickoIme.Equals(APIService.Username))
                    {
                        APIService.Uloga = korisnik.UlogaNaziv;
                        APIService.Id = korisnik.Id;
                    }
                }
                if(APIService.Uloga.Equals("Administrator"))
                {
                    frmAdministratorIndex frm = new frmAdministratorIndex();
                    frm.Show();
                }
                else if (APIService.Uloga.Equals("Menadžer"))
                {
                    frmMenadzerIndex frm = new frmMenadzerIndex();
                    frm.Show();
                }
                else if (APIService.Uloga.Equals("Mehaničar"))
                {
                    frmMehanicarIndex frm = new frmMehanicarIndex();
                    frm.Show();
                }
                else
                {
                    //Ako se vozac pokusa login na desktop aplikcaiju
                    MessageBox.Show("Nemate pristup desktop aplikaciji");
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Authentikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
