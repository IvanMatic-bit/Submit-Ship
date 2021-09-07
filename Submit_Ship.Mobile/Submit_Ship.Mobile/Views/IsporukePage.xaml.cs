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
    public partial class IsporukePage : ContentPage
    {
        IsporukeViewModel _model = null;
        public IsporukePage()
        {
            InitializeComponent();
            BindingContext = _model = new IsporukeViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await _model.Init();
        }

        public async void OnListViewItemSelected(object sender, ItemTappedEventArgs args)
        {
            var item = args.Item as Isporuka;
            if (item == null)
                return;
            await Navigation.PushModalAsync(new IsporukeDetaljiPage(item.Id));
            
        }

        private void SortPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(SortPicker.SelectedIndex !=-1)
            {
                switch (SortPicker.SelectedIndex)
                {
                    case 0: _model.SortirajNajstarijiDatum(); break;
                    case 1: _model.SortirajNajnovijiDatum(); break;
                    case 2: _model.SortirajNajnizaCijena(); break;
                    case 3:_model.SortirajNajvisaCijena(); break;
                    default:
                        break;
                }
            }
        }
    }

}