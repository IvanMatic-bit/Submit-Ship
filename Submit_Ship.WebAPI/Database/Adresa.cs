using System;
using System.Collections.Generic;

#nullable disable

namespace Submit_Ship.WebAPI.Database
{
    public partial class Adresa
    {
        public Adresa()
        {
            IsporukaAdresaIstovaras = new HashSet<Isporuka>();
            IsporukaAdresaUtovaras = new HashSet<Isporuka>();
        }

        public int Id { get; set; }
        public string Naziv { get; set; }
        public int GradId { get; set; }

        public virtual Grad Grad { get; set; }
        public virtual ICollection<Isporuka> IsporukaAdresaIstovaras { get; set; }
        public virtual ICollection<Isporuka> IsporukaAdresaUtovaras { get; set; }
    }
}
