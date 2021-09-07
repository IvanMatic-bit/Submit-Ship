using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Submit_Ship.Model;
using Submit_Ship.Model.Requests;
using Submit_Ship.WebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Submit_Ship.WebAPI.Controllers
{
    [Authorize(Roles = "Klijent, Menadžer")]
     public class ZahtjevController : BaseCRUDController<Model.Zahtjev, ZahtjevSearchRequest, ZahtjevUpsertRequest, ZahtjevUpsertRequest>
    {
        private readonly ICRUDService<Zahtjev, ZahtjevSearchRequest, ZahtjevUpsertRequest, ZahtjevUpsertRequest> _service;
        public ZahtjevController(ICRUDService<Zahtjev, ZahtjevSearchRequest, ZahtjevUpsertRequest, ZahtjevUpsertRequest> service) : base(service)
        {
            _service = service;
        }

      
        [Authorize(Roles ="Klijent")]
        [HttpPost]
        public override Zahtjev Insert(ZahtjevUpsertRequest request)
        {
            return _service.Insert(request);
        }


    }
}
