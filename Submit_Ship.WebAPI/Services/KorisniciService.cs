using AutoMapper;
using Submit_Ship.Model;
using Submit_Ship.Model.Requests;
using Submit_Ship.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;
using Submit_Ship.WebAPI.Helper;

namespace Submit_Ship.WebAPI.Services
{
    public class KorisniciService : IKorisniciService
    {
        private readonly SubmitShipContext _context;
        private readonly IMapper _mapper;

        public KorisniciService(SubmitShipContext context, IMapper maper)
        {
            _context = context;
            _mapper = maper;
        }


        public Model.Korisnik Authenticiraj(string username, string pass)
        {
            var user = _context.Korisniks.Include("Uloga").FirstOrDefault(x => x.KorisnickoIme == username);

            if (user != null)
            {
                var newHash = HashGenerator.GenerateHash(user.LozinkaSalt, pass);

                if (newHash == user.LozinkaHash)
                {
                    return _mapper.Map<Model.Korisnik>(user);
                }
            }
            return null;
        }

        //public static string GenerateSalt()
        //{
        //    var buf = new byte[16];
        //    (new RNGCryptoServiceProvider()).GetBytes(buf);
        //    return Convert.ToBase64String(buf);
        //}

        //public static string GenerateHash(string salt, string password)
        //{
        //    byte[] src = Convert.FromBase64String(salt);
        //    byte[] bytes = Encoding.Unicode.GetBytes(password);
        //    byte[] dst = new byte[src.Length + bytes.Length];

        //    System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
        //    System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

        //    HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
        //    byte[] inArray = algorithm.ComputeHash(dst);
        //    return Convert.ToBase64String(inArray);
        //}

        public List<Model.Korisnik> Get(BaseSearchRequest request)
        {
            var query = _context.Korisniks.Include("Uloga").AsQueryable();
            if(!string.IsNullOrWhiteSpace(request?.SearchValue))
            {
                query = query.Where(x => x.Ime.StartsWith(request.SearchValue) || x.Prezime.StartsWith(request.SearchValue));
            }
           
            var list = query.ToList();
            return _mapper.Map<List<Model.Korisnik>>(list);
        }

        public Model.Korisnik GetById(int id)
        {
            var entity = _context.Korisniks.Find(id);
            return _mapper.Map<Model.Korisnik>(entity);
        }

        public Model.Korisnik Insert(KorisnikUpsertRequest request)
        {
            var entity = _mapper.Map<Database.Korisnik>(request);
            if(request.Password != request.PotvrdiPassword)
            {
                throw new Exception("Passwordi se ne slažu");
            }

            entity.LozinkaSalt = HashGenerator.GenerateSalt();
            entity.LozinkaHash = HashGenerator.GenerateHash(entity.LozinkaSalt, request.Password);


            _context.Korisniks.Add(entity);
            _context.SaveChanges();
            return _mapper.Map<Model.Korisnik>(entity);
        }

        public Model.Korisnik Update(int id, KorisnikUpsertRequest request)
        {
            var entity = _context.Korisniks.Find(id);
            _context.Korisniks.Attach(entity);
            _context.Korisniks.Update(entity);

            if(!string.IsNullOrWhiteSpace(request.Password))
            {
                if(request.Password != request.PotvrdiPassword)
                {
                    throw new Exception("Passwordi se ne poklapaju");
                }
                entity.LozinkaSalt = HashGenerator.GenerateSalt();
                entity.LozinkaHash = HashGenerator.GenerateHash(entity.LozinkaSalt, request.Password);
            }

            _mapper.Map(request, entity);
            _context.SaveChanges();
            return _mapper.Map<Model.Korisnik>(entity);
        }
    }
}
