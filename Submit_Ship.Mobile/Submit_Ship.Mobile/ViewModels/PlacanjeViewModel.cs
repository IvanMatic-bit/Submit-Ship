using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Acr.UserDialogs;
using Prism.Commands;
using Prism.Mvvm;
using Stripe;
using Submit_Ship.Mobile.Models;
using Submit_Ship.Mobile.Views;
using Submit_Ship.Model;
using Submit_Ship.Model.Requests;
using Xamarin.Forms;
using Application = Xamarin.Forms.Application;

namespace Submit_Ship.Mobile.ViewModels
{
    public class PlacanjeViewModel : BindableBase
    {
        #region Variable
        private readonly APIService _service = new APIService("isporuka");
        private readonly APIService _korisnik = new APIService("korisnik");
        private int _id;
        private Isporuka _isporuka;
        private decimal _cijena;
        private string _naslov;
        private Korisnik _klijent;
        private KreditnaKarticaModel _kreditnaKarticaModel;
        private TokenService TokenService;
        private Token _stripeToken;
        private bool _isCardValid;
        private bool _isTransactionSuccess;
        private string _expMonth;
        private string _expYear;
        private string _title;

        private string StripeAPIKey = "sk_test_51J4kMCGMdg5wj1iWIuN4mVOHx9Jd6hFSea49GGSa6vhuxm2r8ScV2PuXLMcbJJESKaRQYQouL6iORahZmKD8pDjR007kzfeukg";
        
        #endregion Variable

        #region Public Property


        public Isporuka Isporuka
        {
            get { return _isporuka; }
            set { SetProperty(ref _isporuka, value); }
        }
        public Korisnik Klijent
        {
            get { return _klijent; }
            set { SetProperty(ref _klijent, value); }
        }
        public KreditnaKarticaModel KreditnaKartica
        {
            get { return _kreditnaKarticaModel; }
            set { SetProperty(ref _kreditnaKarticaModel, value); }
        }
        public bool IsCardValid
        {
            get { return _isCardValid; }
            set { SetProperty(ref _isCardValid, value); }
        }

        public bool IsTransactionSuccess
        {
            get { return _isTransactionSuccess; }
            set { SetProperty(ref _isTransactionSuccess, value); }
        }

        public string ExpMonth
        {
            get { return _expMonth; }
            set { SetProperty(ref _expMonth, value); }
        }
        
        public string ExpYear
        {
            get { return _expYear; }
            set { SetProperty(ref _expYear, value); }
        }
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public string Naslov
        {
            get { return _naslov; }
            set { SetProperty(ref _naslov, value); }
        }
        public decimal Cijena
        {
            get { return _cijena; }
            set { SetProperty(ref _cijena, value); }
        }
        #endregion Public Property
        #region Constructor

        public PlacanjeViewModel()
        {
            KreditnaKartica = new KreditnaKarticaModel();
            Title = "Card details";
                      
        }
        #endregion Constructor

        #region Command

        public async Task Init(int id)
        {
            _id = id;
            _isporuka = await _service.GetById<Isporuka>(_id);
            _klijent = await _korisnik.GetById<Korisnik>(APIService.Id);
            Cijena = _isporuka.Cijena;
            Naslov = _isporuka.Naslov;
        }

        public DelegateCommand SubmitCommand => new DelegateCommand(async () =>
        {

            KreditnaKartica.ExpMonth = Convert.ToInt64(ExpMonth);
            KreditnaKartica.ExpYear = Convert.ToInt64(ExpYear);
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;
            try
            {
                UserDialogs.Instance.ShowLoading("Izvršavanje uplate...");
                await Task.Run(() =>
                {

                    var Token = CreateToken();
                    Console.Write("Izvršavanje uplate" + "Token :" + Token);
                    if (Token != null)
                    {
                        IsTransactionSuccess = MakePayment(Token);
                    }
                    else
                    {
                        UserDialogs.Instance.Alert("Unesite ispravne podatke o kartici", null, "OK");
                    }
                });
            }
            catch (Exception ex)
            {
                IsTransactionSuccess = false;
                UserDialogs.Instance.HideLoading();
                UserDialogs.Instance.Alert(ex.Message, null, "OK");
                Console.Write("Izvršavanje uplate" + ex.Message);
            }
            finally
            {
                if (IsTransactionSuccess)
                {
                    Console.Write("Izvršavanje uplate" + "Uspješno uplaćeno");
                  
                    
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
                        StatusIsporukeId = Isporuka.StatusIsporukeId,
                        UslugaId = Isporuka.UslugaId,
                        ZaposlenikId = Isporuka.ZaposlenikId,
                        DatumPlacanja = DateTime.Now,
                        Placeno = true
                    };
                   await _service.Update<Isporuka>(_id, request);


                    UserDialogs.Instance.Alert("Uspješno ste izvršili uplatu", "OK", "OK");
                    UserDialogs.Instance.HideLoading();
                }
                else
                {
                    UserDialogs.Instance.HideLoading();
                    UserDialogs.Instance.Alert("Uplata nije izvršena", "Greška", "OK");
                    Console.Write("Plaćanje" + "Uplata neuspješna ");
                }
            }

        });

        #endregion Command

        #region Method

        private string CreateToken()
        {
            try
            {
                StripeConfiguration.ApiKey = StripeAPIKey;
                var service = new ChargeService();
                var Tokenoptions = new TokenCreateOptions
                {
                    Card = new TokenCardOptions
                    {
                        Number = KreditnaKartica.Broj,
                        ExpYear = KreditnaKartica.ExpYear,
                        ExpMonth = KreditnaKartica.ExpMonth,
                        Cvc = KreditnaKartica.Cvc,
                        Name = _klijent.Ime+" "+_klijent.Prezime,
                        //AddressCity = "Sarajevo",
                        //AddressCountry = "BiH",
                        Currency = "bam",
                        
                    }
                };

                TokenService = new TokenService();
                _stripeToken = TokenService.Create(Tokenoptions);
                return _stripeToken.Id;
            }
            catch (Exception ex)
            {
                UserDialogs.Instance.Alert("Greška prilikom plaćanja "+ ex.Message, "OK", "OK");

                throw ex;
            }
        }

        public bool MakePayment(string token)
        {
            try
            {
                StripeConfiguration.ApiKey = StripeAPIKey;

                var options = new ChargeCreateOptions
                {
                    Amount = (long)Isporuka.Cijena * 100,
                    Currency = "bam",
                    Description = "Uplata na ime: " + _klijent.Ime+" "+_klijent.Prezime,
                    Source = _stripeToken.Id,
                    StatementDescriptor = "Custom descriptor",
                    Capture = true,
                    ReceiptEmail = _klijent.Email,
                };

                var service = new ChargeService();
                Charge charge = service.Create(options);
                return true;
            }
            catch (Exception ex)
            {
                Console.Write("Payment Gatway (CreateCharge)" + ex.Message);
                return false;
            }
        }

        private bool ValidateCard()
        {
            if (KreditnaKartica.Broj.Length == 16 && ExpMonth.Length == 2 && ExpYear.Length == 2 && KreditnaKartica.Cvc.Length == 3)
            {
                return true;
            }
            return false;
        }

        #endregion Method

    }
}
