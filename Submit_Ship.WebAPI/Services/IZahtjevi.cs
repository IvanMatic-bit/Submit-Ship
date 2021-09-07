﻿using Submit_Ship.Model;
using Submit_Ship.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Submit_Ship.WebAPI.Services
{
    public interface IZahtjevi
    {
       List<Zahtjev> Get(ZahtjevSearchRequest search);
       Zahtjev GetById(int id);
    }
}
