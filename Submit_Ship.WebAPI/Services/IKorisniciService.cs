using Submit_Ship.Model;
using Submit_Ship.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Submit_Ship.WebAPI.Services
{
    public interface IKorisniciService
    {
        List<Model.Korisnik> Get(BaseSearchRequest request);
        Model.Korisnik GetById(int id);

        Model.Korisnik Insert(KorisnikUpsertRequest request);
        Model.Korisnik Update(int id, KorisnikUpsertRequest request);
        Model.Korisnik Authenticiraj(string username, string pass);
    }
}
