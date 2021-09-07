using System;
using System.Collections.Generic;

#nullable disable

namespace Submit_Ship.WebAPI.Database
{
    public partial class Kamion
    {
        public Kamion()
        {
            Isporukas = new HashSet<Isporuka>();
            Kvars = new HashSet<Kvar>();
        }

        public int Id { get; set; }
        public string Proizvodac { get; set; }
        public string Model { get; set; }
        public double Nosivost { get; set; }
        public DateTime DatumRegistracije { get; set; }
        public bool Reduktor { get; set; }
        public bool SpavacaKabina { get; set; }
        public bool Kiper { get; set; }
        public bool Hladnjaca { get; set; }
        public bool Cerada { get; set; }

        public virtual ICollection<Isporuka> Isporukas { get; set; }
        public virtual ICollection<Kvar> Kvars { get; set; }
    }
}
