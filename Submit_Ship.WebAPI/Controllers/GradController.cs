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
    public class GradController : BaseCRUDController<Model.Grad, object, GradUpsertRequest, GradUpsertRequest>
    {
        public GradController(ICRUDService<Grad, object, GradUpsertRequest, GradUpsertRequest> service) : base(service)
        {

        }
    }
}
