using Acr.UserDialogs;
using Submit_Ship.Mobile.Views;
using Submit_Ship.Model;
using Submit_Ship.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Submit_Ship.Mobile.ViewModels
{
    public class KvaroviDodajViewModel : BaseViewModel
    {

        #region Variable
        private APIService _kvar = new APIService("kvar");
        private APIService _kamion = new APIService("kamion");
        public ICommand SnimiCommand { get; set; }
        public ICommand InitCommand { get; set; }
        private KvarUpsertRequest model;
        string _sadrzaj = string.Empty;
        Kamion _selectedKamion = null;
        #endregion Variable

        #region Public Property
        public ObservableCollection<Kamion> KamioniList { get; set; } = new ObservableCollection<Kamion>();

        public string Sadrzaj
        {
            get { return _sadrzaj; }
            set { SetProperty(ref _sadrzaj, value); }
        }

        public Kamion SelectedKamion
        {
            get { return _selectedKamion; }
            set { SetProperty(ref _selectedKamion, value); }
        }
        #endregion Public Property

        #region Constructor
        public KvaroviDodajViewModel()
        {
            SnimiCommand = new Command(async () => await Snimi());
            InitCommand = new Command(async () => await Init());
        }
        #endregion Constructor

        #region Command


        public async Task Init()
        {
            try
            {
                var list = await _kamion.Get<List<Kamion>>(null);
                foreach(var kamion in list)
                {
                    KamioniList.Add(kamion);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task Snimi()
        {
            try
            {
                model = new KvarUpsertRequest()
                {
                    KamionId = SelectedKamion.Id,
                    Sadrzaj = Sadrzaj,
                    VozacId = APIService.Id
                };

                await _kvar.Insert<Kvar>(model);
                await Application.Current.MainPage.DisplayAlert("Info", "Kvar uspješno prijavljen", "Ok");

            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");


            }


        }
        #endregion Command

        #region Validacija
        public bool ValidateForm()
        {
            if(string.IsNullOrEmpty(Sadrzaj))
            {
                return false;
                
            }
            if (SelectedKamion == null)
            {
                return false; 
            }
            return true;

        }
        #endregion Validacija
    }
}
