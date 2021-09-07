using System;
using System.Collections.Generic;

#nullable disable

namespace Submit_Ship.WebAPI.Database
{
    public partial class Kvar
    {
        public int Id { get; set; }
        public int KamionId { get; set; }
        public string Sadrzaj { get; set; }
        public string Komentar { get; set; }
        public int VozacId { get; set; }

        public virtual Kamion Kamion { get; set; }
        public virtual Korisnik Vozac { get; set; }
    }
}
