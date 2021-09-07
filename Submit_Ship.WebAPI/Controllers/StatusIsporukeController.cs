using Microsoft.AspNetCore.Mvc;
using Submit_Ship.Model;
using Submit_Ship.WebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Submit_Ship.WebAPI.Controllers
{
    public class StatusIsporukeController : BaseController<Model.StatusIsporuke, object>
    {
        public StatusIsporukeController(IService<StatusIsporuke, object> service) : base(service)
        {
        }


    }
}
