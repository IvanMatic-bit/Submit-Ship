using Microsoft.AspNetCore.Mvc;
using Submit_Ship.Model;
using Submit_Ship.Model.Requests;
using Submit_Ship.WebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ubiety.Dns.Core;

namespace Submit_Ship.WebAPI.Controllers
{
    public class AdresaController : BaseCRUDController<Model.Adresa, object, AdresaUpsertRequest, AdresaUpsertRequest>
    {
        public AdresaController(ICRUDService<Adresa, object, AdresaUpsertRequest, AdresaUpsertRequest> service) : base(service)
        {

        }
    }
}
