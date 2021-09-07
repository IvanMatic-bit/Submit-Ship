using Acr.UserDialogs;
using Submit_Ship.Mobile.Views;
using Submit_Ship.Model;
using Submit_Ship.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Submit_Ship.Mobile.ViewModels
{
    public class ZahtjeviDodajViewModel : BaseViewModel
    {
        #region Variable
        private APIService _apiService = new APIService("zahtjev");
        private ZahtjevUpsertRequest model;
        string _naslov = string.Empty;
        string _sadrzaj = string.Empty;
        
        #endregion Variable

        #region Public Property

        public string Naslov
        {
            get { return _naslov; }
            set { SetProperty(ref _naslov, value); }
        }



        public string Sadrzaj
        {
            get { return _sadrzaj; }
            set { SetProperty(ref _sadrzaj, value); }
        }
        #endregion Public Property


        #region Constructor
        public ZahtjeviDodajViewModel()
        {

        }
        #endregion Constructor

        #region Command

        public async Task Snimi()
        {
            
            if (ValidateForm())
            {

                UserDialogs.Instance.ShowLoading("Kreiranje zahtjeva...");

                model = new ZahtjevUpsertRequest()
                {
                    Naslov = Naslov,
                    Sadrzaj = Sadrzaj,
                    DatumVrijemeZahtjeva = DateTime.Now,
                    KlijentId = APIService.Id,
                    StatusZahtjevaId = 1
                };
                try
                {
                    await _apiService.Insert<Zahtjev>(model);
                    UserDialogs.Instance.HideLoading();
                    UserDialogs.Instance.Alert("Novi zahtjev uspješno kreiran", null, "OK");
                    

                }
                catch (Exception)
                {

                    throw;
                }
            }
        }


        #endregion Command

        #region Validate
        public bool ValidateForm()
        {
            return !string.IsNullOrEmpty(Sadrzaj) && !string.IsNullOrEmpty(Naslov);
            
        }

        #endregion Validate
    }
}
