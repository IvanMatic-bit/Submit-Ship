using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Submit_Ship.Model.Requests
{
    public class KvarUpsertRequest
    {
        [Required]
        public int KamionId { get; set; }
        [Required(AllowEmptyStrings =false)]
        public string Sadrzaj { get; set; }
        //Komentar unosi mehaničar i nije obavezan prilikom unosa kvara
        public string Komentar { get; set; }
        [Required]
        public int VozacId { get; set; }

    }
}
