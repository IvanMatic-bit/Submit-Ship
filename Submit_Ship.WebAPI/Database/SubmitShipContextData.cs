using Microsoft.EntityFrameworkCore;
using Submit_Ship.WebAPI.Helper;
using Submit_Ship.WebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Submit_Ship.WebAPI.Database
{
    public partial class SubmitShipContext
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Uloga>().HasData(new Database.Uloga()
            {
                Id = 1,
                Naziv = "Administrator"
            });
            modelBuilder.Entity<Uloga>().HasData(new Database.Uloga()
            {
                Id = 2,
                Naziv = "Vozač"
            });
            modelBuilder.Entity<Uloga>().HasData(new Database.Uloga()
            {
                Id = 3,
                Naziv = "Menadžer"
            });
            modelBuilder.Entity<Uloga>().HasData(new Database.Uloga()
            {
                Id = 4,
                Naziv = "Mehaničar"
            });
            modelBuilder.Entity<Uloga>().HasData(new Database.Uloga()
            {
                Id = 5,
                Naziv = "Klijent"
            });

            modelBuilder.Entity<StatusZahtjeva>().HasData(new Database.StatusZahtjeva()
            {
                Id = 1,
                Naziv = "Novi"
            });
            modelBuilder.Entity<StatusZahtjeva>().HasData(new Database.StatusZahtjeva()
            {
                Id = 2,
                Naziv = "Odobren"
            });
            modelBuilder.Entity<StatusZahtjeva>().HasData(new Database.StatusZahtjeva()
            {
                Id = 3,
                Naziv = "Odbijen"
            });

            modelBuilder.Entity<StatusIsporuke>().HasData(new Database.StatusIsporuke()
            {
                Id = 1,
                Naziv = "Isporučuje se"
            });
            modelBuilder.Entity<StatusIsporuke>().HasData(new Database.StatusIsporuke()
            {
                Id = 2,
                Naziv = "Isporučeno"
            });
            modelBuilder.Entity<StatusIsporuke>().HasData(new Database.StatusIsporuke()
            {
                Id = 3,
                Naziv = "Novo"
            });
            modelBuilder.Entity<StatusIsporuke>().HasData(new Database.StatusIsporuke()
            {
                Id = 4,
                Naziv = "Prekinuto"
            });
            modelBuilder.Entity<StatusIsporuke>().HasData(new Database.StatusIsporuke()
            {
                Id = 5,
                Naziv = "Utovara se"
            });
            modelBuilder.Entity<StatusIsporuke>().HasData(new Database.StatusIsporuke()
            {
                Id = 6,
                Naziv = "Istovara se"
            });

            modelBuilder.Entity<Drzava>().HasData(new Database.Drzava()
            {
                Id = 1,
                Naziv = "Bosna i Hercgovina"            
            });
            modelBuilder.Entity<Drzava>().HasData(new Database.Drzava()
            {
                Id = 2,
                Naziv = "Hrvatska"
            });
            modelBuilder.Entity<Drzava>().HasData(new Database.Drzava()
            {
                Id = 3,
                Naziv = "Slovenija"
            });
            modelBuilder.Entity<Drzava>().HasData(new Database.Drzava()
            {
                Id = 4,
                Naziv = "Srbija"
            });
            modelBuilder.Entity<Drzava>().HasData(new Database.Drzava()
            {
                Id = 5,
                Naziv = "Crna Gora"
            });

            modelBuilder.Entity<Grad>().HasData(new Database.Grad()
            {
                Id = 1,
                Naziv = "Sarajevo",
                DrzavaId = 1
            });
            modelBuilder.Entity<Grad>().HasData(new Database.Grad()
            {
                Id = 2,
                Naziv = "Zagreb",
                DrzavaId = 2
            });
            modelBuilder.Entity<Grad>().HasData(new Database.Grad()
            {
                Id = 3,
                Naziv = "Podgorica",
                DrzavaId = 5
            });


            modelBuilder.Entity<Adresa>().HasData(new Database.Adresa()
            {
                Id = 1,
                Naziv = "Adresa 1",
                GradId = 1
            });
            modelBuilder.Entity<Adresa>().HasData(new Database.Adresa()
            {
                Id = 2,
                Naziv = "Ulica 15",
                GradId = 2
            });
            modelBuilder.Entity<Adresa>().HasData(new Database.Adresa()
            {
                Id = 3,
                Naziv = "Neka druga ulica 7A",
                GradId = 2
            });
            modelBuilder.Entity<Adresa>().HasData(new Database.Adresa()
            {
                Id = 4,
                Naziv = "Adresa stanovanja 35",
                GradId = 2
            });
            modelBuilder.Entity<Adresa>().HasData(new Database.Adresa()
            {
                Id = 5,
                Naziv = "Ulica 2",
                GradId = 3
            });
            modelBuilder.Entity<Adresa>().HasData(new Database.Adresa()
            {
                Id = 6,
                Naziv = "Druga ulica bb",
                GradId = 3
            });
            modelBuilder.Entity<Adresa>().HasData(new Database.Adresa()
            {
                Id = 7,
                Naziv = "Pedeseta ulica 1",
                GradId = 1
            });

            modelBuilder.Entity<Usluga>().HasData(new Database.Usluga()
            {
                Id = 1,
                Naziv = "Građa",
                Opis = "Stubovi, grede, daske",
                Cijena = 250
            });
            modelBuilder.Entity<Usluga>().HasData(new Database.Usluga()
            {
                Id = 2,
                Naziv = "Računari i oprema",
                Opis = "Kompjuteri, printeri, monitori",
                Cijena = 350
            });
            modelBuilder.Entity<Usluga>().HasData(new Database.Usluga()
            {
                Id = 3,
                Naziv = "Staklo",
                Opis = "Prozori i lako lomljivi teret",
                Cijena = 400
            });
            modelBuilder.Entity<Usluga>().HasData(new Database.Usluga()
            {
                Id = 4,
                Naziv = "Namještaj",
                Opis = "Inventar restorana ili poslovnih prostora",
                Cijena = 200
            });

            modelBuilder.Entity<Kamion>().HasData(new Database.Kamion()
            {
                Id = 1,
                Proizvodac = "MAN",
                Model = "TXG",
                Nosivost = 5,
                DatumRegistracije = new DateTime(2021, 05, 16),
                Reduktor = false,
                SpavacaKabina = true,
                Kiper = true,
                Hladnjaca = true,
                Cerada = false
            });
            modelBuilder.Entity<Kamion>().HasData(new Database.Kamion()
            {
                Id = 2,
                Proizvodac = "Mercedes",
                Model = "Actros",
                Nosivost = 11,
                DatumRegistracije = new DateTime(2021, 04, 05),
                Reduktor = true,
                SpavacaKabina = true,
                Kiper = false,
                Hladnjaca = false,
                Cerada = false
            });
            modelBuilder.Entity<Kamion>().HasData(new Database.Kamion()
            {
                Id = 3,
                Proizvodac = "Volvo",
                Model = "XT",
                Nosivost = 3,
                DatumRegistracije = new DateTime(2020, 12, 17),
                Reduktor = false,
                SpavacaKabina = true,
                Kiper = true,
                Hladnjaca = true,
                Cerada = false
            });

            Korisnik a1 = new Korisnik()
            {
                Id = 1,
                Ime = "Administrator",
                Prezime = "Administrator",
                Email = "administrator@email",
                Telefon = "061111",
                UlogaId = 1,
                KorisnickoIme = "administrator",
                Status = true
               
            };
            a1.LozinkaSalt = HashGenerator.GenerateSalt();
            a1.LozinkaHash = HashGenerator.GenerateHash(a1.LozinkaSalt, "administrator");
            modelBuilder.Entity<Korisnik>().HasData(a1);

            Korisnik a2 = new Korisnik()
            {
                Id = 2,
                Ime = "Vozač",
                Prezime = "Vozač",
                Email = "vozac@email.com",
                Telefon = "061222",
                UlogaId = 2,
                KorisnickoIme = "vozac",
                Status = true
            };
            a2.LozinkaSalt = HashGenerator.GenerateSalt();
            a2.LozinkaHash = HashGenerator.GenerateHash(a2.LozinkaSalt, "vozac");
            modelBuilder.Entity<Korisnik>().HasData(a2);

            Korisnik a3 = new Korisnik()
            {
                Id = 3,
                Ime = "Menadžer",
                Prezime = "Menadžer",
                Email = "menadzer@email.com",
                Telefon = "061333",
                UlogaId = 3,
                KorisnickoIme = "menadzer",
                Status = true
            };
            a3.LozinkaSalt = HashGenerator.GenerateSalt();
            a3.LozinkaHash = HashGenerator.GenerateHash(a3.LozinkaSalt, "menadzer");
            modelBuilder.Entity<Korisnik>().HasData(a3);

            Korisnik a4 = new Korisnik()
            {
                Id = 4,
                Ime = "Mehaničar",
                Prezime = "Mehaničar",
                Email = "mehanicar@email.com",
                Telefon = "061444",
                UlogaId = 4,
                KorisnickoIme = "mehanicar",
                Status = true
            };
            a4.LozinkaSalt = HashGenerator.GenerateSalt();
            a4.LozinkaHash = HashGenerator.GenerateHash(a4.LozinkaSalt, "mehanicar");
            modelBuilder.Entity<Korisnik>().HasData(a4);

            Korisnik a5 = new Korisnik()
            {
                Id = 5,
                Ime = "Klijent",
                Prezime = "Klijent",
                Email = "klijent@email.com",
                Telefon = "061555",
                UlogaId = 5,
                KorisnickoIme = "klijent",
                Status = true
            };
            a5.LozinkaSalt = HashGenerator.GenerateSalt();
            a5.LozinkaHash = HashGenerator.GenerateHash(a5.LozinkaSalt, "klijent");
            modelBuilder.Entity<Korisnik>().HasData(a5);

            Korisnik a6 = new Korisnik()
            {
                Id = 6,
                Ime = "Drugi",
                Prezime = "Klijent",
                Email = "kldrugi@email.com",
                Telefon = "061555",
                UlogaId = 5,
                KorisnickoIme = "drugiklijent",
                Status = true
            };
            a6.LozinkaSalt = HashGenerator.GenerateSalt();
            a6.LozinkaHash = HashGenerator.GenerateHash(a6.LozinkaSalt, "drugiklijent");
            modelBuilder.Entity<Korisnik>().HasData(a6);


            modelBuilder.Entity<Kvar>().HasData(new Database.Kvar()
            {
                Id = 1,
                KamionId = 2,
                Sadrzaj = "Problem sa mjenjačem",
                Komentar = "Potrebo nasuti ulje",
                VozacId = 2
            });

            modelBuilder.Entity<Kvar>().HasData(new Database.Kvar()
            {
                Id = 2,
                KamionId = 3,
                Sadrzaj = "Problem sa pritiskom ulja",
                VozacId = 2
            });

            modelBuilder.Entity<Kvar>().HasData(new Database.Kvar()
            {
                Id = 3,
                KamionId = 2,
                Sadrzaj = "Kamion teško pali zimi",
                Komentar = "Potrebno zamijeniti grijače",
                VozacId = 2
            });

            modelBuilder.Entity<Kvar>().HasData(new Database.Kvar()
            {
                Id = 4,
                KamionId = 1,
                Sadrzaj = "Volan se trese prilikom kočenja",
                VozacId = 2
            });

            modelBuilder.Entity<Kvar>().HasData(new Database.Kvar()
            {
                Id = 5,
                KamionId = 2,
                Sadrzaj = "Problem sa servo pumpom",
                Komentar = "Potrebo nasuti ulje",
                VozacId = 2
            });


            modelBuilder.Entity<Zahtjev>().HasData(new Database.Zahtjev()
            {
                Id = 1,
                DatumVrijemeZahtjeva = new DateTime(2021, 08, 11),
                Naslov = "Računarska oprema",
                Sadrzaj = "Potreban prijevoz 50 računara dana 2.8.2021 sa adrese Adresa 1,Sarajevo do Druga ulica bb",
                StatusZahtjevaId = 2,
                KlijentId = 5
            });
            modelBuilder.Entity<Zahtjev>().HasData(new Database.Zahtjev()
            {
                Id = 2,
                DatumVrijemeZahtjeva = new DateTime(2021, 08, 15),
                Naslov = "Krov",
                Sadrzaj = "Potrebna dostava građe od Neka druga ulica, Zagreb do Pedeseta ulica,Sarajevo",
                StatusZahtjevaId = 2,
                KlijentId = 5
            });
            modelBuilder.Entity<Zahtjev>().HasData(new Database.Zahtjev()
            {
                Id = 3,
                DatumVrijemeZahtjeva = new DateTime(2021, 10, 10),
                Naslov = "Računarska oprema",
                Sadrzaj = "Potreban prijevoz 50 računara dana  do Druga ulica bb",
                StatusZahtjevaId = 3,
                KlijentId = 5
            });

            modelBuilder.Entity<Zahtjev>().HasData(new Database.Zahtjev()
            {
                Id = 4,
                DatumVrijemeZahtjeva = new DateTime(2021, 08, 15),
                Naslov = "Krov",
                Sadrzaj = "Potrebna dostava građe od Pedeseta ulica Sarajevo do Ulica 2, Podgorica",
                StatusZahtjevaId = 2,
                KlijentId = 5
            });

            modelBuilder.Entity<Zahtjev>().HasData(new Database.Zahtjev()
            {
                Id = 5,
                DatumVrijemeZahtjeva = new DateTime(2021, 10, 17),
                Naslov = "Računarska oprema",
                Sadrzaj = "Potreban prijevoz 5 kopir aparata",
                StatusZahtjevaId = 1,
                KlijentId = 5
            });
            modelBuilder.Entity<Zahtjev>().HasData(new Database.Zahtjev()
            {
                Id = 6,
                DatumVrijemeZahtjeva = new DateTime(2021, 10, 17),
                Naslov = "Računarska oprema",
                Sadrzaj = "Potreban prijevoz 5 kopir aparata dana 08.09.2021. Adresa preuzimanja adresa1, Sarajevo, adresa dostave Ulica 15 Sarajevo",
                StatusZahtjevaId = 1,
                KlijentId = 6
            });
            modelBuilder.Entity<Zahtjev>().HasData(new Database.Zahtjev()
            {
                Id = 7,
                DatumVrijemeZahtjeva = new DateTime(2021, 08, 15),
                Naslov = "Krov",
                Sadrzaj = "Potrebna dostava građe od Pedeseta ulica Sarajevo do Ulica 2, Podgorica datuma 08.10.2021",
                StatusZahtjevaId = 2,
                KlijentId = 5
            });

            modelBuilder.Entity<Isporuka>().HasData(new Database.Isporuka()
            {
                Id = 1,
                AdresaUtovaraId = 1,
                AdresaIstovaraId = 6,
                Cijena = 300,
                KamionId = 1,
                KlijentId = 5,
                Placeno = false,
                DatumIsporuke = new DateTime(2021, 8, 2),
                StatusIsporukeId = 1,
                ZaposlenikId = 2,
                DatumKreiranja = new DateTime(2021, 7, 2),
                Naslov = "Računarska oprema",
                OpisIsporuke = "Prijevoz 50 računara",
                UslugaId = 2
            });
            modelBuilder.Entity<Isporuka>().HasData(new Database.Isporuka()
            {
                Id = 2,
                AdresaUtovaraId = 3,
                AdresaIstovaraId = 4,
                Cijena = 350,
                KamionId = 2,
                KlijentId = 5,
                Placeno = true,
                DatumPlacanja = new DateTime(2021, 8, 16),
                DatumIsporuke = new DateTime(2021, 8, 16),
                StatusIsporukeId = 2,
                ZaposlenikId = 2,
                DatumKreiranja = new DateTime(2021, 7, 2),
                Naslov = "Krov",
                OpisIsporuke = "Dostava građe za krov",
                UslugaId = 1
            });
            modelBuilder.Entity<Isporuka>().HasData(new Database.Isporuka()
            {
                Id = 3,
                AdresaUtovaraId = 1,
                AdresaIstovaraId = 6,
                Cijena = 300,
                KamionId = 1,
                KlijentId = 5,
                Placeno = false,
                DatumIsporuke = new DateTime(2021, 8, 2),
                StatusIsporukeId = 1,
                ZaposlenikId = 2,
                DatumKreiranja = new DateTime(2021, 7, 2),
                Naslov = "Računarska oprema",
                OpisIsporuke = "50 računara",
                UslugaId = 2
            });
            modelBuilder.Entity<Isporuka>().HasData(new Database.Isporuka()
            {
                Id = 4,
                AdresaUtovaraId = 7,
                AdresaIstovaraId = 5,
                Cijena = 300,
                KamionId = 1,
                KlijentId = 5,
                Placeno = false,
                DatumIsporuke = new DateTime(2021, 8, 2),
                StatusIsporukeId = 3,
                ZaposlenikId = 2,
                DatumKreiranja = new DateTime(2021, 7, 2),
                Naslov = "Računarska oprema",
                OpisIsporuke = "Prijevoz 5 kopir aparata",
                UslugaId = 2
            });
            modelBuilder.Entity<Isporuka>().HasData(new Database.Isporuka()
            {
                Id = 5,
                AdresaUtovaraId = 1,
                AdresaIstovaraId = 6,
                Cijena = 300,
                KamionId = 1,
                KlijentId = 6,
                Placeno = false,
                DatumIsporuke = new DateTime(2021, 8, 10),
                StatusIsporukeId = 1,
                ZaposlenikId = 2,
                DatumKreiranja = new DateTime(2021, 8, 2),
                Naslov = "Građa",
                OpisIsporuke = "Prijevoz građe za krov",
                UslugaId = 2
            });
        }
    }

}
