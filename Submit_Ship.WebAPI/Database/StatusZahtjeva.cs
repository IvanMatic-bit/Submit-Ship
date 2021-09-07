using System;
using System.Collections.Generic;

#nullable disable

namespace Submit_Ship.WebAPI.Database
{
    public partial class StatusZahtjeva
    {
        public StatusZahtjeva()
        {
            Zahtjevs = new HashSet<Zahtjev>();
        }

        public int Id { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Zahtjev> Zahtjevs { get; set; }
    }
}
