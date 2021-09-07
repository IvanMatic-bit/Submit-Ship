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
    public partial class KvaroviPage : ContentPage
    {
        private KvaroviViewModel model = null;
        public KvaroviPage()
        {
            InitializeComponent();
            BindingContext = model = new KvaroviViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void NoviKvarButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new KvaroviDodajPage());
        }
    }
}