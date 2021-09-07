using Submit_Ship.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Submit_Ship.WebAPI.Services
{
    public interface IKvarovi
    {
        List<Kvar> Get();
        Kvar GetById(int id);
    } 
}
