using System;
using System.Collections.Generic;

#nullable disable

namespace Submit_Ship.WebAPI.Database
{
    public partial class Korisnik
    {
        public Korisnik()
        {
            IsporukaKlijents = new HashSet<Isporuka>();
            IsporukaZaposleniks = new HashSet<Isporuka>();
            Kvars = new HashSet<Kvar>();
            Zahtjevs = new HashSet<Zahtjev>();
        }

        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public int UlogaId { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public bool Status { get; set; }

        public virtual Uloga Uloga { get; set; }
        public virtual ICollection<Isporuka> IsporukaKlijents { get; set; }
        public virtual ICollection<Isporuka> IsporukaZaposleniks { get; set; }
        public virtual ICollection<Kvar> Kvars { get; set; }
        public virtual ICollection<Zahtjev> Zahtjevs { get; set; }
    }
}
