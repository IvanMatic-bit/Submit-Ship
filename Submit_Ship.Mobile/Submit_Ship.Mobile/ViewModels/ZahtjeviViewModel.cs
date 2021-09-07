using Submit_Ship.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Flurl;
using Flurl.Http;
using Submit_Ship.Model.Requests;
using Submit_Ship.Mobile.Views;

namespace Submit_Ship.Mobile.ViewModels
{
   public class ZahtjeviViewModel : BaseViewModel
    {

        #region Variable
        private APIService _zahtjevi = new APIService("zahtjev");
        private APIService _statusi = new APIService("statusZahtjeva");
        StatusZahtjeva _SelectedStatusZahtjeva = null;
        public ICommand InitCommand { get; set; }
        List<Zahtjev> list;
        #endregion Variable 

        #region Public Property
        public ObservableCollection<Zahtjev> ZahtjeviList { get; set; } = new ObservableCollection<Zahtjev>();
        public ObservableCollection<StatusZahtjeva> StatusiList { get; set; } = new ObservableCollection<StatusZahtjeva>();



        public StatusZahtjeva SelectedStatusZahtjeva
        {
            get { return _SelectedStatusZahtjeva; }
            set
            {  
                SetProperty(ref _SelectedStatusZahtjeva, value);
            }
        }
        #endregion Public Property


        #region Constructor
        public ZahtjeviViewModel()
        {
            InitCommand = new Command(async () => await Init());            
        }

        #endregion Constructor

        #region Command
        public async Task Init()
        {
           if(StatusiList.Count == 0)
            {
                StatusiList.Add(new StatusZahtjeva { Id = 0, Naziv = "Svi" });

                var statusiZahtjevaList = await _statusi.Get<List<StatusZahtjeva>>(null);
                foreach (var status in statusiZahtjevaList)
                {
                    StatusiList.Add(status);
                }
            }
            await GetZahtjevi();                       
        }

        public async Task GetZahtjevi()
        {
            ZahtjevSearchRequest request = new ZahtjevSearchRequest()
            {
                KlijentID = APIService.Id
            };
            if (SelectedStatusZahtjeva != null)
            {
                request.StatusId = SelectedStatusZahtjeva.Id;
            }
            list = await _zahtjevi.Get<List<Zahtjev>>(request);
            ZahtjeviList.Clear();
            foreach (var zahtjev in list)
            {
                ZahtjeviList.Add(zahtjev);

            }
        }
       
        #endregion Command
    }
}
