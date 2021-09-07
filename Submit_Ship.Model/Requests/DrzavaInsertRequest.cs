using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Submit_Ship.Model
{
   public class DrzavaInsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string Naziv { get; set; }
    }
}
