using System;
using System.Collections.Generic;
using System.Text;

namespace Submit_Ship.Model
{
    public class Kamion
    {
        public int Id { get; set; }
        public string ProizvodacModel { get; set; }
        public string Proizvodac { get; set; }

        public string Model { get; set; }
        public double Nosivost { get; set; }
        public DateTime DatumRegistracije { get; set; }
        public bool Reduktor { get; set; }
        public bool SpavacaKabina { get; set; }
        public bool Kiper { get; set; }
        public bool Hladnjaca { get; set; }
        public bool Cerada { get; set; }
    }
}
