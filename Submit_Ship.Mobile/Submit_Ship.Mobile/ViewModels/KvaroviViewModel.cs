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
    public class KvaroviViewModel : BaseViewModel
    {

        #region Variable
        private APIService _kvarovi = new APIService("kvar");
        public ICommand InitCommand { get; set; }
        #endregion Variable

        #region Public Property
        public ObservableCollection<Kvar> KvaroviList { get; set; } = new ObservableCollection<Kvar>();

        #endregion Public Property

        #region Constructor
        public KvaroviViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        #endregion Constructor

        #region Command
        public async Task Init()
        {
            try
            {
                var search = new KvarSearchRequest()
                {
                    VozacId = APIService.Id
                };
                var list = await _kvarovi.Get<List<Kvar>>(search);
                KvaroviList.Clear();
                if (list != null)
                {
                    foreach (var kvar in list)
                    {
                        KvaroviList.Add(kvar);
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

      
        #endregion Command
    }

}
