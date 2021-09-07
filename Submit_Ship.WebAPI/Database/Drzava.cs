using System;
using System.Collections.Generic;

#nullable disable

namespace Submit_Ship.WebAPI.Database
{
    public partial class Drzava
    {
        public Drzava()
        {
            Grads = new HashSet<Grad>();
        }

        public int Id { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Grad> Grads { get; set; }
    }
}
