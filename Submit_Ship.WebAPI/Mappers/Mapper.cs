using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Submit_Ship.WebAPI.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Database.Drzava, Model.Drzava>().ReverseMap();
            CreateMap<Database.Drzava, Model.DrzavaInsertRequest>().ReverseMap();

            CreateMap<Database.Adresa, Model.Adresa>()
                .ForMember(dto => dto.Grad, conf => conf.MapFrom(g => g.Grad.Naziv));
            CreateMap<Database.Adresa, Model.Requests.AdresaUpsertRequest>().ReverseMap();

            CreateMap<Database.Grad, Model.Grad>();
            CreateMap<Database.Grad, Model.Requests.GradUpsertRequest>().ReverseMap();

            CreateMap<Database.Isporuka, Model.Isporuka>()
                .ForMember(dto => dto.Kamion, conf => conf.MapFrom(k => k.Kamion.Proizvodac + " " + k.Kamion.Model))
                .ForMember(dto => dto.Klijent, conf => conf.MapFrom(k => k.Klijent.Ime + " " + k.Klijent.Prezime))
                .ForMember(dto => dto.Zaposlenik, conf => conf.MapFrom(z => z.Zaposlenik.Ime + " " + z.Zaposlenik.Prezime)).ReverseMap();               
            CreateMap<Database.Isporuka, Model.Requests.IsporukaUpsertRequest>().ReverseMap();

            CreateMap<Database.Kamion, Model.Kamion>()
                .ForMember(dto => dto.ProizvodacModel, conf => conf.MapFrom(k => k.Proizvodac+" "+k.Model));
            CreateMap<Database.Kamion, Model.Requests.KamionUpsertRequest>().ReverseMap();

            CreateMap<Database.Usluga, Model.Usluga>();
            CreateMap<Database.Usluga, Model.Requests.UslugaUpsertRequest>().ReverseMap();

            CreateMap<Database.Zahtjev, Model.Zahtjev>()
                .ForMember(z => z.StatusZahtjeva, opt => opt.MapFrom(s => s.StatusZahtjeva.Naziv))
                .ForMember(z => z.Klijent, conf => conf.MapFrom(k => k.Klijent.Ime + " "+k.Klijent.Prezime))
                .ReverseMap();
            CreateMap<Database.Zahtjev, Model.Requests.ZahtjevUpsertRequest>().ReverseMap();

            CreateMap<Database.Korisnik, Model.Korisnik>()
                .ForMember(i => i.ImePrezime, conf => conf.MapFrom(x => x.Ime+" "+x.Prezime))
                .ReverseMap();
            CreateMap<Database.Korisnik, Model.Requests.KorisnikUpsertRequest>().ReverseMap();

            CreateMap<Database.Kvar, Model.Kvar>().ReverseMap();
            CreateMap<Database.Kvar, Model.Requests.KvarUpsertRequest>().ReverseMap();
            CreateMap<Database.StatusIsporuke, Model.StatusIsporuke>().ReverseMap();
            CreateMap<Database.StatusZahtjeva, Model.StatusZahtjeva>().ReverseMap();
            CreateMap<Database.Uloga, Model.Uloga>().ReverseMap();

        }
    }
}
