using Microsoft.AspNetCore.Mvc;
using Submit_Ship.Model;
using Submit_Ship.WebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Submit_Ship.WebAPI.Controllers
{
    public class StatusZahtjevaController : BaseController<Model.StatusZahtjeva, object>
    {
        public StatusZahtjevaController(IService<StatusZahtjeva, object> service) : base(service)
        {
        }
    }
}
