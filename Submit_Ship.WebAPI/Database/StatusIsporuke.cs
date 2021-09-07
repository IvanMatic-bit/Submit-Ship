using System;
using System.Collections.Generic;

#nullable disable

namespace Submit_Ship.WebAPI.Database
{
    public partial class StatusIsporuke
    {
        public StatusIsporuke()
        {
            Isporukas = new HashSet<Isporuka>();
        }

        public int Id { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Isporuka> Isporukas { get; set; }
    }
}
