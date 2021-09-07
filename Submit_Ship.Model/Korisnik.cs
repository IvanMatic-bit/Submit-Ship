using System;
using System.Collections.Generic;
using System.Text;

namespace Submit_Ship.Model
{
    public class Korisnik
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public int UlogaId { get; set; }
        public string UlogaNaziv { get; set; }
        public string KorisnickoIme { get; set; }
        public bool Status { get; set; }
        public string ImePrezime { get; set; }
        public Uloga Uloga { get; set; }

    }
}
