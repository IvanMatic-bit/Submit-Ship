using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Submit_Ship.Model.Requests
{
   public class GradUpsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string Naziv { get; set; }

        [Required]
        public int DrzavaId { get; set; }
    }
}
