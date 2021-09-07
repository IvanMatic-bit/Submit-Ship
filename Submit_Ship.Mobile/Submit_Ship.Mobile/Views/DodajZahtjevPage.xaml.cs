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
    public partial class DodajZahtjevPage : ContentPage
    {
        private ZahtjeviDodajViewModel _model = null;
        public DodajZahtjevPage()
        {
            InitializeComponent();
            BindingContext = _model = new ZahtjeviDodajViewModel();
           

        }


        private async void saveButton_Clicked(object sender, EventArgs e)
        {
            if (_model.ValidateForm())
            {
               await _model.Snimi();
                await Navigation.PopAsync();
            }
            else
            {
                ValidateNaslov.IsVisible = true;
                ValidateSadrzaj.IsVisible = true;
            }
        }
    }
}