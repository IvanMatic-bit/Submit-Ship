using System;
using System.Collections.Generic;

#nullable disable

namespace Submit_Ship.WebAPI.Database
{
    public partial class Isporuka
    {
        public int Id { get; set; }
        public string Naslov { get; set; }
        public string OpisIsporuke { get; set; }
        public DateTime DatumKreiranja { get; set; }
        public DateTime DatumIsporuke { get; set; }
        public int KlijentId { get; set; }
        public int AdresaUtovaraId { get; set; }
        public int AdresaIstovaraId { get; set; }
        public int KamionId { get; set; }
        public int StatusIsporukeId { get; set; }
        public decimal Cijena { get; set; }
        public int ZaposlenikId { get; set; }
        public int UslugaId { get; set; }
        public bool Placeno { get; set; }
        public DateTime? DatumPlacanja { get; set; }

        public virtual Adresa AdresaIstovara { get; set; }
        public virtual Adresa AdresaUtovara { get; set; }
        public virtual Kamion Kamion { get; set; }
        public virtual Korisnik Klijent { get; set; }
        public virtual StatusIsporuke StatusIsporuke { get; set; }
        public virtual Usluga Usluga { get; set; }
        public virtual Korisnik Zaposlenik { get; set; }
    }
}
