using System;
using System.Collections.Generic;
using System.Text;

namespace Submit_Ship.Model
{
    public class Kvar
    {
        public int Id { get; set; }
        public string KamionProizvodac { get; set; }
        public int KamionId { get; set; }
        public string Sadrzaj { get; set; }
        public string Komentar { get; set; }
        public int VozacId { get; set; }
        public string VozacImePrezime { get; set; }

    }
}
