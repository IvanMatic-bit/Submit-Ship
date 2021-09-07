using System;
using System.Collections.Generic;
using System.Text;

namespace Submit_Ship.Model
{
    public class Zahtjev
    {
        public int Id { get; set; }
        public DateTime DatumVrijemeZahtjeva { get; set; }
        public string Naslov { get; set; }
        public string Sadrzaj { get; set; }
        public string Klijent { get; set; }
        public int KLijentId { get; set; }
        public string StatusZahtjeva { get; set; }
        public int StatusZahtjevaId { get; set; }
    }
}
