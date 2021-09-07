using System;
using System.Collections.Generic;
using System.Text;

namespace Submit_Ship.Model.Requests
{
    public class ZahtjevSearchRequest
    {
        public int KlijentID { get; set; }
        public string SearchValue { get; set; }
        public int StatusId { get; set; }
    }
}
