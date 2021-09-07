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
    public class KamionController : BaseCRUDController<Model.Kamion, object, KamionUpsertRequest, KamionUpsertRequest>
    {
        private protected ICRUDService<Kamion, object, KamionUpsertRequest, KamionUpsertRequest> _service;
       
        public KamionController(ICRUDService<Kamion, object, KamionUpsertRequest, KamionUpsertRequest> service) : base(service)
        {
            _service = service;
        }

        [Authorize(Roles ="Administrator")]
        [HttpPost]
        public override Kamion Insert(KamionUpsertRequest request)
        {
            return _service.Insert(request);
        }

        [Authorize(Roles = "Administrator")]
        [HttpPut("{id}")]
        public override Kamion Update(int id, KamionUpsertRequest request)
        {
            return _service.Update(id, request);
        }
        [Authorize(Roles = "Administrator")]
        [HttpDelete("{id}")]
        public override Kamion Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}
