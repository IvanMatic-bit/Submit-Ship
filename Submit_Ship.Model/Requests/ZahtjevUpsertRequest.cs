using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Submit_Ship.Model.Requests
{
    public class ZahtjevUpsertRequest
    {
        [Required]
        public DateTime DatumVrijemeZahtjeva { get; set; }
        [Required(AllowEmptyStrings =false)]
        [MaxLength(50)]
        public string Naslov { get; set; }
        [Required(AllowEmptyStrings = false)]
        [MaxLength(500)]
        public string Sadrzaj { get; set; }
        [Required]
        public int StatusZahtjevaId { get; set; }
        [Required]
        public int KlijentId { get; set; }
    }
}
