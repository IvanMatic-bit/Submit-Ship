using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Submit_Ship.Model.Requests;
using Submit_Ship.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Submit_Ship.WebAPI.Services
{
    public class KvaroviService : BaseCRUDService<Model.Kvar, KvarSearchRequest, Database.Kvar, KvarUpsertRequest, KvarUpsertRequest>
    {
        public KvaroviService(SubmitShipContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override List<Model.Kvar> Get(KvarSearchRequest search)
        {
            var query = _context.Set<Database.Kvar>().Include(i => i.Kamion).Include(i => i.Vozac).AsQueryable();
            if(search.KamionId != 0)
            {                               
                query = query.Where(x => x.KamionId == search.KamionId);
            }
            var list = query.ToList();
            return _mapper.Map<List<Model.Kvar>>(list);
           
        }

        public override Model.Kvar GetById(int id)
        {
            var result = _context.Set<Database.Kvar>().Include(i => i.Kamion).Include(i => i.Vozac).Where(x => x.Id == id).FirstOrDefault();
            return _mapper.Map<Model.Kvar>(result);
        }
    }
}
