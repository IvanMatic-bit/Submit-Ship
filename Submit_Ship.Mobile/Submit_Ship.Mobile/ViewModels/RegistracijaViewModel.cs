using Submit_Ship.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Submit_Ship.Model;
using Acr.UserDialogs;
using Submit_Ship.Mobile.Views;

namespace Submit_Ship.Mobile.ViewModels
{
    public class RegistracijaViewModel : BaseViewModel
    {
        #region Variable
        private APIService _korisnici = new APIService("korisnik");
        private KorisnikUpsertRequest model;
        public int _id=0;
        string _ime = string.Empty;
        string _prezime = string.Empty;
        string _telefon = string.Empty;
        string _email = string.Empty;
        string _korisnikoIme = string.Empty;
        string _lozinka = string.Empty;
        string _potvrdiLozinka = string.Empty;
        public ICommand SnimiCommand { get; set; }
        public ICommand InitCommand { get; set; }
        #endregion Variable

        #region Public Property
        public string Ime
        {
            get { return _ime; }
            set { SetProperty(ref _ime, value); }
        }
        public string Prezime
        {
            get { return _prezime; }
            set { SetProperty(ref _prezime, value); }
        }
        public string Telefon
        {
            get { return _telefon; }
            set { SetProperty(ref _telefon, value); }
        }
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }

        public string KorisnickoIme
        {
            get { return _korisnikoIme; }
            set { SetProperty(ref _korisnikoIme, value); }
        }

        public string Lozinka
        {
            get { return _lozinka; }
            set { SetProperty(ref _lozinka, value); }
        }
        public string PotvrdiLozinka
        {
            get { return _potvrdiLozinka; }
            set { SetProperty(ref _potvrdiLozinka, value); }
        }

        #endregion Public Property

        #region Constructor
        public RegistracijaViewModel()
        {
            
            SnimiCommand = new Command(async () => await Snimi());
            InitCommand = new Command(async () => await Init());
        }

        #endregion Constructor

        #region Command
        public async Task Init()
        {
                _id = APIService.Id;
                var korisnik = await _korisnici.GetById<Korisnik>(_id);
                Ime = korisnik.Ime;
                Prezime = korisnik.Prezime;
                Email = korisnik.Email;
                Telefon = korisnik.Telefon;
                KorisnickoIme = korisnik.KorisnickoIme;            
        }

        public async Task Snimi()
        {
            model = new KorisnikUpsertRequest()
            {
                Ime = Ime,
                Prezime = Prezime,
                Email = Email,
                KorisnickoIme = _korisnikoIme,
                Password = Lozinka,
                PotvrdiPassword = PotvrdiLozinka,
                Status = true,
                Telefon = Telefon,
                UlogaId = 5//Id Uloge klijent je uvijek 5
            };
            try
            {
                if(_id==0)
                {
                    await _korisnici.Insert<Korisnik>(model);
                    UserDialogs.Instance.Alert("Novi korisnik upješno kreiran", null, "OK");
                    Application.Current.MainPage = new LoginPage();
                }
                else
                {
                    await _korisnici.Update<Korisnik>(_id, model);
                    UserDialogs.Instance.Alert("Podaci uspješno promijenjeni", null, "OK");

                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void PovratakLogin()
        {
            Application.Current.MainPage = new LoginPage();

        }
        #endregion Command

        #region Validacija
        public bool ValidateIme()
        {
            return !string.IsNullOrEmpty(Ime);
        }
        public bool ValidatePrezime()
        {
            return !string.IsNullOrEmpty(Prezime);
        }
        public bool ValidateTelefon()
        {
            return !string.IsNullOrEmpty(Telefon);
        }
        public bool ValidateEmail()
        {
            return !string.IsNullOrEmpty(Email);
        }
        public bool ValidateKorisnickoIme()
        {
            return !string.IsNullOrEmpty(KorisnickoIme);
        }
        public bool ValidateLozinka()
        {
            return !string.IsNullOrEmpty(Lozinka);
        }
        public bool ValidatePotvrdiLozinka()
        {
            return !string.IsNullOrEmpty(PotvrdiLozinka);
        }

        public bool LozinkaMatch()
        {
            return Lozinka == PotvrdiLozinka;
        }
        #endregion Validacija

    }

}
