using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
    public class RecommenderController : ControllerBase
    {
        private readonly IRecommenderService _service;
        public RecommenderController(IRecommenderService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Isporuka> Get([FromQuery]RecommendationRequest request)
        {
            return _service.Get(request);
        }
    }
}
