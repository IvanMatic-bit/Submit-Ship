using Submit_Ship.Model;
using Submit_Ship.Model.Requests;
using Submit_Ship.WebAPI.Database;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Submit_Ship.WebAPI.Services
{
    public class RecommenderService : IRecommenderService
    {
        private readonly SubmitShipContext _context;
        private readonly IMapper _mapper;

        public RecommenderService(SubmitShipContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<Model.Isporuka> Get(RecommendationRequest request)
        {
            var Isporuka = _context.Set<Database.Isporuka>().Find(request.IsporukaId);
            int korisnikId = Isporuka.KlijentId;
            var ostaleIsporuke = _context.Isporukas
                  .Include(i => i.StatusIsporuke)
                                  .Include(i => i.Klijent)
                                  .Include(i => i.Kamion)
                                  .Include(i => i.AdresaIstovara)
                                  .Include(i => i.AdresaIstovara)
                                  .Include(i => i.Usluga)
                                  .Include(i => i.Zaposlenik)
                .Where(x => x.KlijentId == korisnikId && x.Id != request.IsporukaId)
                .ToList();
            List<Database.Isporuka> slicneIsporuke = new List<Database.Isporuka>();

            foreach(var isporuka in ostaleIsporuke)
            {
                if(IzracunajSlicnost(isporuka, Isporuka))
                {
                    slicneIsporuke.Add(isporuka);
                }
            }
            return _mapper.Map<List<Model.Isporuka>>(slicneIsporuke);

        }

        private bool IzracunajSlicnost(Database.Isporuka isporuka1, Database.Isporuka isporuka2)
        {
            int slicnostBrojac = 0;
            if (isporuka1.AdresaIstovaraId == isporuka2.AdresaIstovaraId)
                slicnostBrojac++;
            if (isporuka1.AdresaUtovaraId == isporuka2.AdresaUtovaraId)
                slicnostBrojac++;
            if (isporuka1.UslugaId == isporuka1.UslugaId)
                slicnostBrojac++;
            if (Math.Abs((isporuka1.Cijena - isporuka2.Cijena)) <= 50)//ako su približne cijene
                slicnostBrojac++;
            //Zbog malog broja isporuka sličnost je postavljena na 1
            if (slicnostBrojac <= 1)
                return false;
            else
                return true;
            
        }
    }
}
