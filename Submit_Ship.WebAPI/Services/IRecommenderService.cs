using Submit_Ship.Model;
using Submit_Ship.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Submit_Ship.WebAPI.Services
{
    public interface IRecommenderService
    {
        List<Model.Isporuka> Get(RecommendationRequest request);
    }
}
