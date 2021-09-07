using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Submit_Ship.Model.Requests
{
    public class AdresaUpsertRequest
    {
        [Required(AllowEmptyStrings =false)]
        public string Naziv { get; set; }
        [Required]
        public int GradId { get; set; }
    }
}
