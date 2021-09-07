using Submit_Ship.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Submit_Ship.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ZahtjeviPage : ContentPage
    {
        private ZahtjeviViewModel _model = null;
        public ZahtjeviPage()
        {
            InitializeComponent();
            BindingContext = _model = new ZahtjeviViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
           await _model.Init();
        }

        private async void DodajButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DodajZahtjevPage());
        }

        private async void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            await _model.GetZahtjevi();
        }
    }
}