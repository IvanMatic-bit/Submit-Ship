using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Submit_Ship.WebAPI.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drzava",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drzava", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kamion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Proizvodac = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Nosivost = table.Column<double>(type: "float", nullable: false),
                    DatumRegistracije = table.Column<DateTime>(type: "date", nullable: false),
                    Reduktor = table.Column<bool>(type: "bit", nullable: false),
                    SpavacaKabina = table.Column<bool>(type: "bit", nullable: false),
                    Kiper = table.Column<bool>(type: "bit", nullable: false),
                    Hladnjaca = table.Column<bool>(type: "bit", nullable: false),
                    Cerada = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kamion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StatusIsporuke",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusIsporuke", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StatusZahtjeva",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusZahtjeva", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Uloga",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uloga", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usluga",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Cijena = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usluga", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Grad",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    DrzavaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grad", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DrzavaID",
                        column: x => x.DrzavaID,
                        principalTable: "Drzava",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Korisnik",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Prezime = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    UlogaId = table.Column<int>(type: "int", nullable: false),
                    KorisnickoIme = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LozinkaHash = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LozinkaSalt = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnik", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UlogaZaposlenik",
                        column: x => x.UlogaId,
                        principalTable: "Uloga",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Adresa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    GradID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adresa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GradID",
                        column: x => x.GradID,
                        principalTable: "Grad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Kvar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KamionId = table.Column<int>(type: "int", nullable: false),
                    Sadrzaj = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Komentar = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    VozacId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kvar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KvarKamion",
                        column: x => x.KamionId,
                        principalTable: "Kamion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_KvarVozac",
                        column: x => x.VozacId,
                        principalTable: "Korisnik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Zahtjev",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumVrijemeZahtjeva = table.Column<DateTime>(type: "datetime", nullable: false),
                    Naslov = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Sadrzaj = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    StatusZahtjevaId = table.Column<int>(type: "int", nullable: false),
                    KlijentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zahtjev", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StatusZahtjeva",
                        column: x => x.StatusZahtjevaId,
                        principalTable: "StatusZahtjeva",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ZahtjevKlijent",
                        column: x => x.KlijentId,
                        principalTable: "Korisnik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Isporuka",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naslov = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OpisIsporuke = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    DatumKreiranja = table.Column<DateTime>(type: "datetime", nullable: false),
                    DatumIsporuke = table.Column<DateTime>(type: "date", nullable: false),
                    KlijentId = table.Column<int>(type: "int", nullable: false),
                    AdresaUtovaraId = table.Column<int>(type: "int", nullable: false),
                    AdresaIstovaraId = table.Column<int>(type: "int", nullable: false),
                    KamionId = table.Column<int>(type: "int", nullable: false),
                    StatusIsporukeId = table.Column<int>(type: "int", nullable: false),
                    Cijena = table.Column<decimal>(type: "money", nullable: false),
                    ZaposlenikId = table.Column<int>(type: "int", nullable: false),
                    UslugaId = table.Column<int>(type: "int", nullable: false),
                    Placeno = table.Column<bool>(type: "bit", nullable: false),
                    DatumPlacanja = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Isporuka", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdresaItovara",
                        column: x => x.AdresaIstovaraId,
                        principalTable: "Adresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AdresaUtovara",
                        column: x => x.AdresaUtovaraId,
                        principalTable: "Adresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IsporukaKamion",
                        column: x => x.KamionId,
                        principalTable: "Kamion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IsporukaKlijent",
                        column: x => x.KlijentId,
                        principalTable: "Korisnik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IsporukaStatus",
                        column: x => x.StatusIsporukeId,
                        principalTable: "StatusIsporuke",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IsporukaUsluga",
                        column: x => x.UslugaId,
                        principalTable: "Usluga",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IsporukaVozac",
                        column: x => x.ZaposlenikId,
                        principalTable: "Korisnik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Drzava",
                columns: new[] { "Id", "Naziv" },
                values: new object[,]
                {
                    { 1, "Bosna i Hercgovina" },
                    { 2, "Hrvatska" },
                    { 3, "Slovenija" },
                    { 4, "Srbija" },
                    { 5, "Crna Gora" }
                });

            migrationBuilder.InsertData(
                table: "Kamion",
                columns: new[] { "Id", "Cerada", "DatumRegistracije", "Hladnjaca", "Kiper", "Model", "Nosivost", "Proizvodac", "Reduktor", "SpavacaKabina" },
                values: new object[,]
                {
                    { 1, false, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, "TXG", 5.0, "MAN", false, true },
                    { 2, false, new DateTime(2021, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, "Actros", 11.0, "Mercedes", true, true },
                    { 3, false, new DateTime(2020, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, "XT", 3.0, "Volvo", false, true }
                });

            migrationBuilder.InsertData(
                table: "StatusIsporuke",
                columns: new[] { "Id", "Naziv" },
                values: new object[,]
                {
                    { 6, "Istovara se" },
                    { 4, "Prekinuto" },
                    { 5, "Utovara se" },
                    { 2, "Isporučeno" },
                    { 1, "Isporučuje se" },
                    { 3, "Novo" }
                });

            migrationBuilder.InsertData(
                table: "StatusZahtjeva",
                columns: new[] { "Id", "Naziv" },
                values: new object[,]
                {
                    { 1, "Novi" },
                    { 2, "Odobren" },
                    { 3, "Odbijen" }
                });

            migrationBuilder.InsertData(
                table: "Uloga",
                columns: new[] { "Id", "Naziv" },
                values: new object[,]
                {
                    { 1, "Administrator" },
                    { 2, "Vozač" },
                    { 3, "Menadžer" },
                    { 4, "Mehaničar" },
                    { 5, "Klijent" }
                });

            migrationBuilder.InsertData(
                table: "Usluga",
                columns: new[] { "Id", "Cijena", "Naziv", "Opis" },
                values: new object[,]
                {
                    { 3, 400m, "Staklo", "Prozori i lako lomljivi teret" },
                    { 1, 250m, "Građa", "Stubovi, grede, daske" },
                    { 2, 350m, "Računari i oprema", "Kompjuteri, printeri, monitori" },
                    { 4, 200m, "Namještaj", "Inventar restorana ili poslovnih prostora" }
                });

            migrationBuilder.InsertData(
                table: "Grad",
                columns: new[] { "Id", "DrzavaID", "Naziv" },
                values: new object[,]
                {
                    { 1, 1, "Sarajevo" },
                    { 2, 2, "Zagreb" },
                    { 3, 5, "Podgorica" }
                });

            migrationBuilder.InsertData(
                table: "Korisnik",
                columns: new[] { "Id", "Email", "Ime", "KorisnickoIme", "LozinkaHash", "LozinkaSalt", "Prezime", "Status", "Telefon", "UlogaId" },
                values: new object[,]
                {
                    { 1, "administrator@email", "Administrator", "administrator", "AQOLGG51+PLId3kLERGS0Tyeg2U=", "r7LG9jEjUkH99aEnX7ZWag==", "Administrator", true, "061111", 1 },
                    { 2, "vozac@email.com", "Vozač", "vozac", "8HlNBy94fXCNje4lhCwaTJdlwi4=", "HVhjHLl6KoazLHDfql3q+w==", "Vozač", true, "061222", 2 },
                    { 3, "menadzer@email.com", "Menadžer", "menadzer", "wAmf7OkWQK+4+3FRWKGL0UkRH6I=", "gi3Oh6JyZD+VMc2m9HTOXg==", "Menadžer", true, "061333", 3 },
                    { 4, "mehanicar@email.com", "Mehaničar", "mehanicar", "R+mN9HvnlM4aOrMAQvQsnEIetVQ=", "2H+NMGBsLKz67XTKTiju2Q==", "Mehaničar", true, "061444", 4 },
                    { 5, "klijent@email.com", "Klijent", "klijent", "hDUt/6Jce3t2Dh+mm9YV8EW/L1Q=", "4+RrG6jFYObobL4A3C4kxg==", "Klijent", true, "061555", 5 },
                    { 6, "kldrugi@email.com", "Drugi", "drugiklijent", "NawkUhItr4YrOTVIqDxrGmzVoj0=", "ShT7ywenue7fPAiHZ7DkkQ==", "Klijent", true, "061555", 5 }
                });

            migrationBuilder.InsertData(
                table: "Adresa",
                columns: new[] { "Id", "GradID", "Naziv" },
                values: new object[,]
                {
                    { 1, 1, "Adresa 1" },
                    { 7, 1, "Pedeseta ulica 1" },
                    { 2, 2, "Ulica 15" },
                    { 3, 2, "Neka druga ulica 7A" },
                    { 4, 2, "Adresa stanovanja 35" },
                    { 5, 3, "Ulica 2" },
                    { 6, 3, "Druga ulica bb" }
                });

            migrationBuilder.InsertData(
                table: "Kvar",
                columns: new[] { "Id", "KamionId", "Komentar", "Sadrzaj", "VozacId" },
                values: new object[,]
                {
                    { 5, 2, "Potrebo nasuti ulje", "Problem sa servo pumpom", 2 },
                    { 4, 1, null, "Volan se trese prilikom kočenja", 2 },
                    { 3, 2, "Potrebno zamijeniti grijače", "Kamion teško pali zimi", 2 },
                    { 2, 3, null, "Problem sa pritiskom ulja", 2 },
                    { 1, 2, "Potrebo nasuti ulje", "Problem sa mjenjačem", 2 }
                });

            migrationBuilder.InsertData(
                table: "Zahtjev",
                columns: new[] { "Id", "DatumVrijemeZahtjeva", "KlijentId", "Naslov", "Sadrzaj", "StatusZahtjevaId" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Računarska oprema", "Potreban prijevoz 50 računara dana 2.8.2021 sa adrese Adresa 1,Sarajevo do Druga ulica bb", 2 },
                    { 2, new DateTime(2021, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Krov", "Potrebna dostava građe od Neka druga ulica, Zagreb do Pedeseta ulica,Sarajevo", 2 },
                    { 3, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Računarska oprema", "Potreban prijevoz 50 računara dana  do Druga ulica bb", 3 },
                    { 4, new DateTime(2021, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Krov", "Potrebna dostava građe od Pedeseta ulica Sarajevo do Ulica 2, Podgorica", 2 },
                    { 5, new DateTime(2021, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Računarska oprema", "Potreban prijevoz 5 kopir aparata", 1 },
                    { 7, new DateTime(2021, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Krov", "Potrebna dostava građe od Pedeseta ulica Sarajevo do Ulica 2, Podgorica datuma 08.10.2021", 2 },
                    { 6, new DateTime(2021, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Računarska oprema", "Potreban prijevoz 5 kopir aparata dana 08.09.2021. Adresa preuzimanja adresa1, Sarajevo, adresa dostave Ulica 15 Sarajevo", 1 }
                });

            migrationBuilder.InsertData(
                table: "Isporuka",
                columns: new[] { "Id", "AdresaIstovaraId", "AdresaUtovaraId", "Cijena", "DatumIsporuke", "DatumKreiranja", "DatumPlacanja", "KamionId", "KlijentId", "Naslov", "OpisIsporuke", "Placeno", "StatusIsporukeId", "UslugaId", "ZaposlenikId" },
                values: new object[,]
                {
                    { 2, 4, 3, 350m, new DateTime(2021, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 5, "Krov", "Dostava građe za krov", true, 2, 1, 2 },
                    { 4, 5, 7, 300m, new DateTime(2021, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 5, "Računarska oprema", "Prijevoz 5 kopir aparata", false, 3, 2, 2 },
                    { 1, 6, 1, 300m, new DateTime(2021, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 5, "Računarska oprema", "Prijevoz 50 računara", false, 1, 2, 2 },
                    { 3, 6, 1, 300m, new DateTime(2021, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 5, "Računarska oprema", "50 računara", false, 1, 2, 2 },
                    { 5, 6, 1, 300m, new DateTime(2021, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 6, "Građa", "Prijevoz građe za krov", false, 1, 2, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adresa_GradID",
                table: "Adresa",
                column: "GradID");

            migrationBuilder.CreateIndex(
                name: "IX_Grad_DrzavaID",
                table: "Grad",
                column: "DrzavaID");

            migrationBuilder.CreateIndex(
                name: "IX_Isporuka_AdresaIstovaraId",
                table: "Isporuka",
                column: "AdresaIstovaraId");

            migrationBuilder.CreateIndex(
                name: "IX_Isporuka_AdresaUtovaraId",
                table: "Isporuka",
                column: "AdresaUtovaraId");

            migrationBuilder.CreateIndex(
                name: "IX_Isporuka_KamionId",
                table: "Isporuka",
                column: "KamionId");

            migrationBuilder.CreateIndex(
                name: "IX_Isporuka_KlijentId",
                table: "Isporuka",
                column: "KlijentId");

            migrationBuilder.CreateIndex(
                name: "IX_Isporuka_StatusIsporukeId",
                table: "Isporuka",
                column: "StatusIsporukeId");

            migrationBuilder.CreateIndex(
                name: "IX_Isporuka_UslugaId",
                table: "Isporuka",
                column: "UslugaId");

            migrationBuilder.CreateIndex(
                name: "IX_Isporuka_ZaposlenikId",
                table: "Isporuka",
                column: "ZaposlenikId");

            migrationBuilder.CreateIndex(
                name: "IX_Korisnik_UlogaId",
                table: "Korisnik",
                column: "UlogaId");

            migrationBuilder.CreateIndex(
                name: "IX_Kvar_KamionId",
                table: "Kvar",
                column: "KamionId");

            migrationBuilder.CreateIndex(
                name: "IX_Kvar_VozacId",
                table: "Kvar",
                column: "VozacId");

            migrationBuilder.CreateIndex(
                name: "IX_Zahtjev_KlijentId",
                table: "Zahtjev",
                column: "KlijentId");

            migrationBuilder.CreateIndex(
                name: "IX_Zahtjev_StatusZahtjevaId",
                table: "Zahtjev",
                column: "StatusZahtjevaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Isporuka");

            migrationBuilder.DropTable(
                name: "Kvar");

            migrationBuilder.DropTable(
                name: "Zahtjev");

            migrationBuilder.DropTable(
                name: "Adresa");

            migrationBuilder.DropTable(
                name: "StatusIsporuke");

            migrationBuilder.DropTable(
                name: "Usluga");

            migrationBuilder.DropTable(
                name: "Kamion");

            migrationBuilder.DropTable(
                name: "StatusZahtjeva");

            migrationBuilder.DropTable(
                name: "Korisnik");

            migrationBuilder.DropTable(
                name: "Grad");

            migrationBuilder.DropTable(
                name: "Uloga");

            migrationBuilder.DropTable(
                name: "Drzava");
        }
    }
}
