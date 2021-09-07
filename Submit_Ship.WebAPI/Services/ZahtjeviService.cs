using AutoMapper;
using Submit_Ship.Model.Requests;
using Submit_Ship.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Submit_Ship.Model;
using Microsoft.EntityFrameworkCore;

namespace Submit_Ship.WebAPI.Services
{
    public class ZahtjeviService : BaseCRUDService<Model.Zahtjev, ZahtjevSearchRequest, Database.Zahtjev, ZahtjevUpsertRequest, ZahtjevUpsertRequest>
    {
        public ZahtjeviService(SubmitShipContext context, IMapper mapper): base(context, mapper)
        {

        }

        public override List<Model.Zahtjev> Get(ZahtjevSearchRequest search)
        {
            var query = _context.Set<Database.Zahtjev>().Include(i => i.StatusZahtjeva).Include(i => i.Klijent).AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.SearchValue))
            {
                query = query.Where(x => x.Naslov.Contains(search.SearchValue) || x.Sadrzaj.Contains(search.SearchValue));
            }
            if (search.KlijentID != 0)
            {
                query = query.Where(x => x.KlijentId == search.KlijentID);
            }
            if(search.StatusId !=0)
            {
                query = query.Where(x => x.StatusZahtjevaId == search.StatusId);
            }
           
            var list = query.ToList();
            return _mapper.Map<List<Model.Zahtjev>>(list);
        }

        public override Model.Zahtjev GetById(int id)
        {
            var result =  _context.Set<Database.Zahtjev>()
                                  .Include(i => i.Klijent)
                                  .Include(i => i.StatusZahtjeva)
                                  .Where(x => x.Id == id).FirstOrDefault();
            return _mapper.Map<Model.Zahtjev>(result);
        }
    }
}
