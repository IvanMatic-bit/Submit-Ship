using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Submit_Ship.Model.Requests
{
   public  class KorisnikUpsertRequest
    {
        [Required(AllowEmptyStrings =false)]
        public string Ime { get; set; }
        [Required(AllowEmptyStrings = false)]

        public string Prezime { get; set; }
        [Required(AllowEmptyStrings = false)]

        public string Email { get; set; }

        [Required(AllowEmptyStrings =false)]
        [MaxLength(15)]
        public string Telefon { get; set; }
        [Required]

        public int UlogaId { get; set; }
        [Required(AllowEmptyStrings = false)]

        public string KorisnickoIme { get; set; }
        [Required(AllowEmptyStrings = false)]

        public string Password { get; set; }
        [Required(AllowEmptyStrings = false)]

        public string PotvrdiPassword { get; set; }

        public bool Status { get; set; }
    }
}
