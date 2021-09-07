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
    public class IsporukeDetaljiViewModel : BaseViewModel
    {
        #region Variable
        private APIService _isporuke = new APIService("isporuka");
        private APIService _statusi = new APIService("statusIsporuke");
        private APIService _recommender = new APIService("recommender");
        public int _id;
        public Isporuka _isporuka;
        string _naslov = string.Empty;
        public ICommand SnimiCommand { get; set; }
        string _opis = string.Empty;
        DateTime _datum;
        string _adresaUtovara = string.Empty;
        string _adresaIstovara = string.Empty;
        string _vozac = string.Empty;
        string _status = string.Empty;
        decimal _cijena;
       
        string _usluga = string.Empty;
        StatusIsporuke _statusId;
        string _klijent;
        public Isporuka Isporuka { get { return _isporuka; } set { SetProperty(ref _isporuka, value); } }
        #endregion Variable

        #region Public Property
        public ObservableCollection<StatusIsporuke> statusiList { get; set; } = new ObservableCollection<StatusIsporuke>();
        public ObservableCollection<Isporuka> IsporukaList { get; set; } = new ObservableCollection<Isporuka>();
       

        public string Naslov
        {
            get { return _naslov; }
            set { SetProperty(ref _naslov, value); }
        }

        public string Opis
        {
            get { return _opis; }
            set { SetProperty(ref _opis, value); }
        }

        public DateTime Datum
        {
            get { return _datum; }
            set { SetProperty(ref _datum, value); }
        }

        public string AdresaUtovara
        {
            get { return _adresaUtovara; }
            set { SetProperty(ref _adresaUtovara, value); }
        }

        public string AdresaIstovara
        {
            get { return _adresaIstovara; }
            set { SetProperty(ref _adresaIstovara, value); }
        }

        public string Vozac
        {
            get { return _vozac; }
            set { SetProperty(ref _vozac, value); }
        }

        public string Status
        {
            get { return _status; }
            set { SetProperty(ref _status, value); }
        }

        public decimal Cijena
        {
            get { return _cijena; }
            set { SetProperty(ref _cijena, value); }
        }

        public string Usluga
        {
            get { return _usluga; }
            set { SetProperty(ref _usluga, value); }
        }

        public StatusIsporuke StatusId
        {
            get { return _statusId; }
            set { SetProperty(ref _statusId, value); }
        }

        public string Klijent
        {
            get { return _klijent; }
            set { SetProperty(ref _klijent, value); }
        }
        #endregion Public Property

        #region Constructor

        public IsporukeDetaljiViewModel() 
        {
            SnimiCommand = new Command(async () => await Snimi());
        }
        #endregion Constructor

        #region Command

        public async Task Init(int id)
        {
            _id = id;
            var list = await _statusi.Get<List<StatusIsporuke>>(null);
            foreach (var status in list)
            {
                statusiList.Add(status);
            }
            _isporuka = await _isporuke.GetById<Isporuka>(_id);
            Naslov = Isporuka.Naslov;
            Opis = Isporuka.OpisIsporuke;
            Datum = Isporuka.DatumIsporuke;
            AdresaUtovara = Isporuka.AdresaUtovaraNaziv;
            AdresaIstovara = Isporuka.AdresaIstovaraNaziv;
            Cijena = Isporuka.Cijena;
            Usluga = Isporuka.UslugaNaziv;
            Vozac = Isporuka.Zaposlenik;
            Status = Isporuka.StatusIsporukeNaziv;
            Klijent = Isporuka.Klijent;

            var request = new RecommendationRequest()
            {
                IsporukaId = _id
            };
            IsporukaList.Clear();
            var listRec = await _recommender.Get<List<Isporuka>>(request);
            foreach (var item in listRec)
            {
                IsporukaList.Add(item);
            }

        }

        public async Task Snimi()
        {
           
                var request = new IsporukaUpsertRequest()
                {
                    AdresaIstovaraId = Isporuka.AdresaIstovaraId,
                    AdresaUtovaraId = Isporuka.AdresaUtovaraId,
                    Cijena = Isporuka.Cijena,
                    DatumIsporuke = Isporuka.DatumIsporuke,
                    DatumKreiranja = Isporuka.DatumKreiranja,
                    KamionId = Isporuka.KamionId,
                    KlijentId = Isporuka.KlijentId,                  
                    Naslov = Isporuka.Naslov,
                    OpisIsporuke = Isporuka.OpisIsporuke,
                    StatusIsporukeId = StatusId.Id,
                    UslugaId = Isporuka.UslugaId,
                    ZaposlenikId = Isporuka.ZaposlenikId,
                    DatumPlacanja = Isporuka.DatumPlacanja,
                    Placeno = Isporuka.Placeno
                    
                };
                await _isporuke.Update<Isporuka>(_id, request);
           
        }
        #endregion Command
        #region Validacija
        public bool ValidateStatus()
        {
            return !(StatusId == null);
        }
        #endregion Validacija
    }
}
