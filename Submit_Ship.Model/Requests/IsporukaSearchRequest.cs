using System;
using System.Collections.Generic;
using System.Text;

namespace Submit_Ship.Model.Requests
{
   public class IsporukaSearchRequest
    {
        public int KlijentId { get; set; }
        public int VozacID { get; set; }
        public int StatusId { get; set; }
        public string SearchValue { get; set; }
        public DateTime? DatumOd { get; set; }
        public DateTime? DatumDo { get; set; }
    }
}
