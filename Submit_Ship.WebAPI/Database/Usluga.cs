using System;
using System.Collections.Generic;

#nullable disable

namespace Submit_Ship.WebAPI.Database
{
    public partial class Usluga
    {
        public Usluga()
        {
            Isporukas = new HashSet<Isporuka>();
        }

        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public decimal Cijena { get; set; }

        public virtual ICollection<Isporuka> Isporukas { get; set; }
    }
}
