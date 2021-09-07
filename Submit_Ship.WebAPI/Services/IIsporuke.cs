using Submit_Ship.Model;
using Submit_Ship.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Submit_Ship.WebAPI.Services
{
    interface IIsporuke
    {
        List<Isporuka> Get(IsporukaSearchRequest search);
        Isporuka GetById(int id);
    }
}
