using System;
using System.Collections.Generic;

#nullable disable

namespace Submit_Ship.WebAPI.Database
{
    public partial class Grad
    {
        public Grad()
        {
            Adresas = new HashSet<Adresa>();
        }

        public int Id { get; set; }
        public string Naziv { get; set; }
        public int DrzavaId { get; set; }

        public virtual Drzava Drzava { get; set; }
        public virtual ICollection<Adresa> Adresas { get; set; }
    }
}
