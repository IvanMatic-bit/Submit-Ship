using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Submit_Ship.Model.Requests
{
    public class IsporukaUpsertRequest
    {
        [Required(AllowEmptyStrings =false)]
        [MaxLength(50)]
        public string Naslov { get; set; }
        [Required(AllowEmptyStrings =false)]
        [MaxLength(500)]
        public string OpisIsporuke { get; set; }
        [Required]
        
        public DateTime DatumKreiranja { get; set; }
        [Required]
        public DateTime DatumIsporuke { get; set; }
        [Required]
        public int KlijentId { get; set; }
        [Required]
        public int AdresaUtovaraId { get; set; }
        [Required]
        public int AdresaIstovaraId { get; set; }
        [Required]
        public int KamionId { get; set; }
        [Required]
        public int StatusIsporukeId { get; set; }
        [Required]
        
        public decimal Cijena { get; set; }
        [Required]
        public int ZaposlenikId { get; set; }
        [Required]
        public int UslugaId { get; set; }
       
        [Required]
        public bool Placeno { get; set; }
        public DateTime? DatumPlacanja { get; set; }
    }
}
