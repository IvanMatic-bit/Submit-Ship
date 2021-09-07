using Submit_Ship.Model;
using Submit_Ship.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Submit_Ship.Mobile.ViewModels
{
    public class IsporukeViewModel
    {
        #region Variable
        private  APIService _isporuke = new APIService("isporuka");
        IEnumerable<Isporuka> list;

        #endregion  Variable
        #region Public Property
        public ICommand InitCommand { get; set; }
        public ObservableCollection<Isporuka> IsporukaList { get; set; } = new ObservableCollection<Isporuka>();

        #endregion Public Property


        #region Constructor
        public IsporukeViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        #endregion Constructor

        #region Command

        public async Task Init()
        {
            IsporukaSearchRequest search;
            if(APIService.Uloga.Equals("Klijent"))
            {
                 search = new IsporukaSearchRequest()
                {
                    KlijentId = APIService.Id
                };
            }
            else
            {
                 search = new IsporukaSearchRequest()
                {
                    VozacID = APIService.Id
                };
            }

            list = await _isporuke.Get<List<Isporuka>>(search);
            AddToList();
        }

        private void AddToList()
        {
            IsporukaList.Clear();
            foreach(var isporuka in list)
            {
                IsporukaList.Add(isporuka);
            }
        }

        public void SortirajNajstarijiDatum()
        {
           list =  list.OrderBy(x => x.DatumIsporuke);
            AddToList();
        }
        public void SortirajNajnovijiDatum()
        {
            list = list.OrderByDescending(x => x.DatumIsporuke);
            AddToList();
        }

        public void SortirajNajnizaCijena()
        {
            list = list.OrderBy(x => x.Cijena);
            AddToList();
        }
        public void SortirajNajvisaCijena()
        {
           list = list.OrderByDescending(x => x.Cijena);
            AddToList();
        }
        #endregion Command
    }
}
