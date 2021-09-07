using Submit_Ship.Mobile.ViewModels;
using Submit_Ship.Model;
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
    public partial class IsporukeDetaljiPage : ContentPage
    {
        
        private IsporukeDetaljiViewModel _model;
        public int _id;
        public IsporukeDetaljiPage(int id)
        {
            InitializeComponent();
            _id = id;
            BindingContext = _model = new IsporukeDetaljiViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await _model.Init(_id);
            if(APIService.Uloga.Equals("Vozač"))
            {
                PlatiButton.IsVisible = false;
            }
            else
            {
                if(_model._isporuka.Placeno)
                {
                    PlatiButton.IsEnabled = false;
                }
                saveButton.IsVisible = false;
                StatusPicker.IsVisible = false;
               
            }
        }

        private async void saveButton_Clicked(object sender, EventArgs e)
        {
            if(_model.ValidateStatus())
            {
                try
                {
                    await _model.Snimi();
                    await Application.Current.MainPage.DisplayAlert("Info", "Status isporuke uspješno promijenjen", "Ok");
                   
                }
                catch (Exception ex)
                {
                    await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
                }
            }
           
        }
        private async void platiButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new PlacanjePage(_id));

        }

        public async void OnListViewItemSelected(object sender, ItemTappedEventArgs args)
        {
            var item = args.Item as Isporuka;
            if (item == null)
            { return; }
            await Navigation.PushModalAsync(new IsporukeDetaljiPage(item.Id));

        }

        private async void btnPovratak_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}