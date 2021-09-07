using System;
using System.Collections.Generic;

#nullable disable

namespace Submit_Ship.WebAPI.Database
{
    public partial class Zahtjev
    {
        public int Id { get; set; }
        public DateTime DatumVrijemeZahtjeva { get; set; }
        public string Naslov { get; set; }
        public string Sadrzaj { get; set; }
        public int StatusZahtjevaId { get; set; }
        public int KlijentId { get; set; }

        public virtual Korisnik Klijent { get; set; }
        public virtual StatusZahtjeva StatusZahtjeva { get; set; }
    }
}
