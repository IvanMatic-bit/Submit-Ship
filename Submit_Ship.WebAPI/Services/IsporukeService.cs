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
    public class IsporukeService: BaseCRUDService<Model.Isporuka, IsporukaSearchRequest, Database.Isporuka, IsporukaUpsertRequest, IsporukaUpsertRequest>
    {
        public IsporukeService(SubmitShipContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override List<Model.Isporuka> Get(IsporukaSearchRequest search)
        {
            var query = _context.Set<Database.Isporuka>()
                .Include(i => i.StatusIsporuke)
                .Include(i => i.Klijent)
                .Include(i => i.Kamion)
                .Include(i => i.AdresaIstovara)
                .Include(i => i.AdresaUtovara)
                .Include(i => i.Usluga)
                .Include(i => i.Zaposlenik)
                .AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.SearchValue))
            {
                query = query.Where(x => x.Naslov.Contains(search.SearchValue) || x.OpisIsporuke.Contains(search.SearchValue));
            }

            if(search.KlijentId != 0)
            {
                query = query.Where(x => x.KlijentId == search.KlijentId);
            }
            if(search.VozacID != 0)
            {
                query = query.Where(x => x.ZaposlenikId == search.VozacID);
            }
            if(search?.DatumOd !=null && search?.DatumDo != null)
            {
                query = query.Where(x => x.DatumIsporuke >= search.DatumOd && x.DatumIsporuke <= search.DatumDo);
            }
            if(search.StatusId!=0)
            {
                query = query.Where(x => x.StatusIsporukeId == search.StatusId);
            }
            var list = query.ToList();
            return _mapper.Map<List<Model.Isporuka>>(list);
        }

        public override Model.Isporuka GetById(int id)
        {
            var result = _context.Set<Database.Isporuka>()
                                  .Include(i => i.StatusIsporuke)
                                  .Include(i => i.Klijent)
                                  .Include(i => i.Kamion)
                                  .Include(i => i.AdresaIstovara)
                                  .Include(i => i.AdresaUtovara)
                                  .Include(i => i.Usluga)
                                  .Include(i => i.Zaposlenik)
                                  .Where(x => x.Id == id).FirstOrDefault();
            return _mapper.Map<Model.Isporuka>(result);
        }
    }
}
