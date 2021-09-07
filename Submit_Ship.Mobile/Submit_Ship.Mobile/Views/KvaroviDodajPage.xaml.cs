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
    public partial class KvaroviDodajPage : ContentPage
    {
        private KvaroviDodajViewModel _model = null;
        public KvaroviDodajPage()
        {
            InitializeComponent();
            BindingContext = _model = new KvaroviDodajViewModel();
           
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await _model.Init();
        }
        private async void saveButton_Clicked(object sender, EventArgs e)
        {
            if(_model.ValidateForm())
            {
               await _model.Snimi();
               await Navigation.PopAsync();
                
            }
            else
            {
                ValidateKamion.IsVisible = true;
                ValidateSadrzaj.IsVisible = true;
            }
           
        }
        
            
    }
}