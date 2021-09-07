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
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]

    public class KorisnikController : ControllerBase
    {
        private readonly IKorisniciService _service;

        public KorisnikController(IKorisniciService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Korisnik> Get([FromQuery]BaseSearchRequest request)
        {
            return _service.Get(request);
        }
        [AllowAnonymous]
        [HttpPost]
        public Model.Korisnik Insert(KorisnikUpsertRequest request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{id}")]
        public Model.Korisnik Update(int id, [FromBody]KorisnikUpsertRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpGet("{id}")]
        public Model.Korisnik GetById(int id)
        {
            return _service.GetById(id);
        }

    }
}
