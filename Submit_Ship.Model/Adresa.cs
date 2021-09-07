using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Submit_Ship.Model
{
    public class Adresa
    {
        public int Id { get; set; }
        public string Naziv { get; set; }       
        public string Grad { get; set; }      
        public int GradId { get; set; }

    }
}
