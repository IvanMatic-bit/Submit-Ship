using Submit_Ship.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Submit_Ship.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistracijaPage : ContentPage
    {
        private RegistracijaViewModel _model = null;
        
        public RegistracijaPage()
        {
            InitializeComponent();
            BindingContext = _model = new RegistracijaViewModel();
         
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            if(APIService.Id != 0)
            {
                await _model.Init();
            }
            
        }
        private async void saveButton_Clicked(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                await _model.Snimi();
                if (APIService.Id == 0)
                {
                    await Navigation.PushAsync(new LoginPage());
                }
            }
         
        }

        private bool ValidateForm()
        {
            bool flag = true;
            if(!_model.ValidateIme())
            {
                ValidateIme.IsVisible = true;
                flag = false;
            }
            else
            {
                ValidateIme.IsVisible = false;
            }
            if (!_model.ValidatePrezime())
            {
                ValidatePrezime.IsVisible = true;
                flag = false;

            }
            else
            {
                ValidatePrezime.IsVisible = false;
            }
            if (!_model.ValidateEmail())
            {
                ValidateEmail.IsVisible = true;
                flag = false;

            }
            else
            {
                ValidateEmail.IsVisible = false;
            }
            if (!_model.ValidateTelefon())
            {
                ValidateTelefon.IsVisible = true;
                flag = false;

            }
            else
            {
                ValidateTelefon.IsVisible = false;
            }
            if (!_model.ValidateKorisnickoIme())
            {
                ValidateKorisnickoIme.IsVisible = true;
                flag = false;

            }
            else
            {
                ValidateKorisnickoIme.IsVisible = false;
            }
            if (!_model.ValidateLozinka())
            {
                ValidateLozinka.IsVisible = true;
                flag = false;
            }
            else
            {
                ValidateLozinka.IsVisible = false;
            }
            if (!_model.ValidatePotvrdiLozinka())
            {
                ValidatePotvrdiLozinka.IsVisible = true;
                flag = false;
            }
            else
            {
                ValidatePotvrdiLozinka.IsVisible = false;
            }
            if(!_model.LozinkaMatch())
            {
                LozinkaMatch.IsVisible = true;
                flag = false;
            }
            else
            {
                LozinkaMatch.IsVisible = false;
            }
            return flag;
        }

        private void Potvratak_Clicked(object sender, EventArgs e)
        {
            _model.PovratakLogin();
        }
    }
}