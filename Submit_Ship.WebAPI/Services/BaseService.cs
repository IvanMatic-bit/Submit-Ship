using AutoMapper;
using Submit_Ship.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Submit_Ship.WebAPI.Services
{
    public class BaseService<TModel, TSearch, TDatabase> : IService<TModel, TSearch> where TDatabase: class
    {
        protected readonly SubmitShipContext _context;
        protected readonly IMapper _mapper;

        public BaseService(SubmitShipContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public virtual List<TModel> Get(TSearch search)
        {
            var list = _context.Set<TDatabase>().ToList();
            return _mapper.Map<List<TModel>>(list);
        }

        public virtual TModel GetById(int id)
        {
            var entity = _context.Set<TDatabase>().Find(id);
            return _mapper.Map<TModel>(entity);
        }
    }
}
