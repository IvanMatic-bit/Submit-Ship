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
    [Authorize(Roles ="Vozač, Mehaničar, Menadžer")]
    public class KvarController : BaseCRUDController<Kvar, KvarSearchRequest, KvarUpsertRequest, KvarUpsertRequest>
    {
        public KvarController(ICRUDService<Kvar, KvarSearchRequest, KvarUpsertRequest, KvarUpsertRequest> service) : base(service)
        {

        }
    }
}
