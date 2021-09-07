using System;
using System.Collections.Generic;

#nullable disable

namespace Submit_Ship.WebAPI.Database
{
    public partial class Uloga
    {
        public Uloga()
        {
            Korisniks = new HashSet<Korisnik>();
        }

        public int Id { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Korisnik> Korisniks { get; set; }
    }
}
