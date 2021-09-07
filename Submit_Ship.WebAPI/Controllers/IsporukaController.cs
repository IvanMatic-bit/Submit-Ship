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
    [Authorize(Roles ="Klijent, Menadžer, Vozač")]
    public class IsporukaController : BaseCRUDController<Model.Isporuka, IsporukaSearchRequest, IsporukaUpsertRequest, IsporukaUpsertRequest>
    {
        private protected ICRUDService<Isporuka, IsporukaSearchRequest, IsporukaUpsertRequest, IsporukaUpsertRequest> _service;
      
        public IsporukaController(ICRUDService<Isporuka, IsporukaSearchRequest, IsporukaUpsertRequest, IsporukaUpsertRequest> service) : base(service)
        {
            _service = service;
        }

        [Authorize(Roles ="Menadžer")]
        [HttpPost]
        public override Isporuka Insert(IsporukaUpsertRequest request)
        {
           
            return _service.Insert(request);
        }

        [Authorize(Roles ="Menadžer, Vozač, Klijent")]
        [HttpPut("{id}")]
        public override Isporuka Update(int id, IsporukaUpsertRequest request)
        {
            return _service.Update(id, request);
        }
    }
}
