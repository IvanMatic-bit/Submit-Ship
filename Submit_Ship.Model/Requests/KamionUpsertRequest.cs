using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Submit_Ship.Model.Requests
{
    public class KamionUpsertRequest
    {
        [Required(AllowEmptyStrings =false)]
        public string Proizvodac { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Model { get; set; }
        [Required]
        public double Nosivost { get; set; }
        public DateTime DatumRegistracije { get; set; }
        public bool Reduktor { get; set; }
        public bool SpavacaKabina { get; set; }
        public bool Kiper { get; set; }
        public bool Hladnjaca { get; set; }
        public bool Cerada { get; set; }
    }
}
