using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Submit_Ship.Model.Requests
{
    public class UslugaUpsertRequest
    {
        [Required(AllowEmptyStrings =false)]
        [MaxLength(25)]
        public string Naziv { get; set; }

        [Required(AllowEmptyStrings =false)]
        [MaxLength(100)]
        public string Opis { get; set; }

        [Required]
        public decimal Cijena { get; set; }
    }
}
