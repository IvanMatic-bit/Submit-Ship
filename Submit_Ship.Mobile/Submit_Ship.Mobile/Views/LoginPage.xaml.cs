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
    public partial class LoginPage : ContentPage
    {
        private LoginViewModel _model;
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = _model = new LoginViewModel();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            _model.PrikaziRegistracija();
        }
    }
}