using Submit_Ship.Mobile.ViewModels;
using Submit_Ship.Mobile.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Submit_Ship.Mobile
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            if(APIService.Uloga.Equals("Klijent"))
            {
                KvaroviItem.IsVisible = false;
                Routing.RegisterRoute(nameof(ZahtjeviPage), typeof(ZahtjeviPage));
            }
            else
            {
                ZahtjeviItem.IsVisible = false;
                Routing.RegisterRoute(nameof(KvaroviPage), typeof(KvaroviPage));

            }
            Routing.RegisterRoute(nameof(IsporukePage), typeof(IsporukePage));
            Routing.RegisterRoute(nameof(RegistracijaPage), typeof(RegistracijaPage));
        }

        private void OnMenuItemClicked(object sender, EventArgs e)
        {
            APIService.Id = 0;
            APIService.Uloga = "";
            APIService.Username = "";
            APIService.Password = "";
            //await Shell.Current.GoToAsync("//LoginPage");
            Application.Current.MainPage = new LoginPage();
        }
    }
}
