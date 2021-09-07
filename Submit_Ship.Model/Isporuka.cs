using System;
using System.Collections.Generic;
using System.Text;

namespace Submit_Ship.Model
{
    public class Isporuka
    {
        public int Id { get; set; }
        public string Naslov { get; set; }
        public string OpisIsporuke { get; set; }
        public DateTime DatumKreiranja { get; set; }
        public DateTime DatumIsporuke { get; set; }
        public int KlijentId { get; set; }
        public string Klijent { get; set; }
        public int AdresaUtovaraId { get; set; }
        public string AdresaUtovaraNaziv { get; set; }
        public int AdresaIstovaraId { get; set; }
        public string AdresaIstovaraNaziv { get; set; }
        public int KamionId { get; set; }
        public string Kamion { get; set; }
        public int StatusIsporukeId { get; set; }
        public string StatusIsporukeNaziv { get; set; }
        public decimal Cijena { get; set; }
        public int ZaposlenikId { get; set; }
        public string Zaposlenik { get; set; }
        public int UslugaId { get; set; }
        public string UslugaNaziv { get; set; }
        
        public bool Placeno { get; set; }
        public DateTime? DatumPlacanja { get; set; }
    }
}
