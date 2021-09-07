using Submit_Ship.Mobile.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Submit_Ship.Mobile.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}