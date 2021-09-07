using Acr.UserDialogs;
using Submit_Ship.Mobile.Views;
using Submit_Ship.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Submit_Ship.Mobile.ViewModels
{
    public class LoginViewModel: BaseViewModel
    {
        #region Variable
        private readonly APIService _service = new APIService("korisnik");
        string _username = string.Empty;
        string _uloga = string.Empty;
        string _password = string.Empty;
        int _id;
        public ICommand LoginCommand { get; set; }

        #endregion Variable

        #region Public Property
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }
        public string Uloga
        {
            get { return _uloga; }
            set { SetProperty(ref _uloga, value); }
        }
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        public int Id
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }
        }
        #endregion Public Property

        #region Constructor
        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await Login());
        }
        #endregion Constructor

        #region Command

        public async Task Login()
        {
            IsBusy = true;
            APIService.Username = Username;
            APIService.Password = Password;
            
            try
            {
                UserDialogs.Instance.ShowLoading("Prijava na sistem...");

                var korisnici = await _service.Get<List<Model.Korisnik>>(null);
                foreach (var korisnik in korisnici)
                {
                    if(korisnik.KorisnickoIme.Equals(APIService.Username))
                    {
                        APIService.Uloga = korisnik.UlogaNaziv;
                        APIService.Id = korisnik.Id;
                    }
                }           
                if(APIService.Uloga=="Klijent" || APIService.Uloga=="Vozač")
                {
                    Application.Current.MainPage = new NavigationPage(new AppShell());

                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Pristup", "Nemate pristup mobilnoj aplikaciji. Koristite desktop aplikaciju", "OK");
                }
                UserDialogs.Instance.HideLoading();
            }
            catch (Exception ex)
            {
                UserDialogs.Instance.HideLoading();
                UserDialogs.Instance.Alert("Neispravni podaci", "Greška", "OK");
            }
        }

        public void PrikaziRegistracija()
        {
             Application.Current.MainPage = new RegistracijaPage();
        }
        #endregion Command
    }
}
