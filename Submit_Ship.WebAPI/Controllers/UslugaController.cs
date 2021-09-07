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
    [Authorize(Roles ="Administrator, Menadžer")]
    public class UslugaController : BaseCRUDController<Model.Usluga, object, UslugaUpsertRequest, UslugaUpsertRequest>
    {
        private readonly ICRUDService<Usluga, object, UslugaUpsertRequest, UslugaUpsertRequest> _service;

        public UslugaController(ICRUDService<Usluga, object, UslugaUpsertRequest, UslugaUpsertRequest> service) : base(service)
        {
            _service = service;
        }

        [Authorize(Roles ="Administrator")]
        [HttpPost]
        public override Usluga Insert(UslugaUpsertRequest request)
        {
            return _service.Insert(request);
        }

        [Authorize(Roles ="Administrator")]
        [HttpPut("{id}")]
        public override Usluga Update(int id, UslugaUpsertRequest request)
        {
            return _service.Update(id, request);
        }
    }
}
