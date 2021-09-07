using Microsoft.AspNetCore.Mvc;
using Submit_Ship.Model;
using Submit_Ship.WebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Submit_Ship.WebAPI.Controllers
{
    public class UlogaController : BaseController<Model.Uloga, object>
    {
        public UlogaController(IService<Uloga, object> service) : base(service)
        {
        }
    }
}
