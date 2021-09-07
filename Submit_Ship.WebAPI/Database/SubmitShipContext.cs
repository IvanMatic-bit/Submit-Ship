using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Submit_Ship.WebAPI.Database
{
    public partial class SubmitShipContext : DbContext
    {
        public SubmitShipContext()
        {
        }

        public SubmitShipContext(DbContextOptions<SubmitShipContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Adresa> Adresas { get; set; }
        public virtual DbSet<Drzava> Drzavas { get; set; }
        public virtual DbSet<Grad> Grads { get; set; }
        public virtual DbSet<Isporuka> Isporukas { get; set; }
        public virtual DbSet<Kamion> Kamions { get; set; }
        public virtual DbSet<Korisnik> Korisniks { get; set; }
        public virtual DbSet<Kvar> Kvars { get; set; }
        public virtual DbSet<StatusIsporuke> StatusIsporukes { get; set; }
        public virtual DbSet<StatusZahtjeva> StatusZahtjevas { get; set; }
        public virtual DbSet<Uloga> Ulogas { get; set; }
        public virtual DbSet<Usluga> Uslugas { get; set; }
        public virtual DbSet<Zahtjev> Zahtjevs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=Submit&Ship;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Bosnian_Latin_100_BIN");

            modelBuilder.Entity<Adresa>(entity =>
            {
                entity.ToTable("Adresa");

                entity.Property(e => e.GradId).HasColumnName("GradID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.HasOne(d => d.Grad)
                    .WithMany(p => p.Adresas)
                    .HasForeignKey(d => d.GradId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GradID");
            });

            modelBuilder.Entity<Drzava>(entity =>
            {
                entity.ToTable("Drzava");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<Grad>(entity =>
            {
                entity.ToTable("Grad");

                entity.Property(e => e.DrzavaId).HasColumnName("DrzavaID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.HasOne(d => d.Drzava)
                    .WithMany(p => p.Grads)
                    .HasForeignKey(d => d.DrzavaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DrzavaID");
            });

            modelBuilder.Entity<Isporuka>(entity =>
            {
                entity.ToTable("Isporuka");

                entity.Property(e => e.Cijena).HasColumnType("money");

                entity.Property(e => e.DatumIsporuke).HasColumnType("date");

                entity.Property(e => e.DatumKreiranja).HasColumnType("datetime");

                entity.Property(e => e.DatumPlacanja).HasColumnType("datetime");

                entity.Property(e => e.Naslov)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OpisIsporuke)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.AdresaIstovara)
                    .WithMany(p => p.IsporukaAdresaIstovaras)
                    .HasForeignKey(d => d.AdresaIstovaraId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AdresaItovara");

                entity.HasOne(d => d.AdresaUtovara)
                    .WithMany(p => p.IsporukaAdresaUtovaras)
                    .HasForeignKey(d => d.AdresaUtovaraId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AdresaUtovara");

                entity.HasOne(d => d.Kamion)
                    .WithMany(p => p.Isporukas)
                    .HasForeignKey(d => d.KamionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IsporukaKamion");

                entity.HasOne(d => d.Klijent)
                    .WithMany(p => p.IsporukaKlijents)
                    .HasForeignKey(d => d.KlijentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IsporukaKlijent");

                entity.HasOne(d => d.StatusIsporuke)
                    .WithMany(p => p.Isporukas)
                    .HasForeignKey(d => d.StatusIsporukeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IsporukaStatus");

                entity.HasOne(d => d.Usluga)
                    .WithMany(p => p.Isporukas)
                    .HasForeignKey(d => d.UslugaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IsporukaUsluga");

                entity.HasOne(d => d.Zaposlenik)
                    .WithMany(p => p.IsporukaZaposleniks)
                    .HasForeignKey(d => d.ZaposlenikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IsporukaVozac");
            });

            modelBuilder.Entity<Kamion>(entity =>
            {
                entity.ToTable("Kamion");

                entity.Property(e => e.DatumRegistracije).HasColumnType("date");

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Proizvodac)
                    .IsRequired()
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Korisnik>(entity =>
            {
                entity.ToTable("Korisnik");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.KorisnickoIme)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LozinkaHash)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LozinkaSalt)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Telefon)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.HasOne(d => d.Uloga)
                    .WithMany(p => p.Korisniks)
                    .HasForeignKey(d => d.UlogaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UlogaZaposlenik");
            });

            modelBuilder.Entity<Kvar>(entity =>
            {
                entity.ToTable("Kvar");

                entity.Property(e => e.Komentar).HasMaxLength(200);

                entity.Property(e => e.Sadrzaj)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Kamion)
                    .WithMany(p => p.Kvars)
                    .HasForeignKey(d => d.KamionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KvarKamion");

                entity.HasOne(d => d.Vozac)
                    .WithMany(p => p.Kvars)
                    .HasForeignKey(d => d.VozacId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KvarVozac");
            });

            modelBuilder.Entity<StatusIsporuke>(entity =>
            {
                entity.ToTable("StatusIsporuke");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<StatusZahtjeva>(entity =>
            {
                entity.ToTable("StatusZahtjeva");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Uloga>(entity =>
            {
                entity.ToTable("Uloga");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Usluga>(entity =>
            {
                entity.ToTable("Usluga");

                entity.Property(e => e.Cijena).HasColumnType("money");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Opis)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Zahtjev>(entity =>
            {
                entity.ToTable("Zahtjev");

                entity.Property(e => e.DatumVrijemeZahtjeva).HasColumnType("datetime");

                entity.Property(e => e.Naslov)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Sadrzaj)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.Klijent)
                    .WithMany(p => p.Zahtjevs)
                    .HasForeignKey(d => d.KlijentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ZahtjevKlijent");

                entity.HasOne(d => d.StatusZahtjeva)
                    .WithMany(p => p.Zahtjevs)
                    .HasForeignKey(d => d.StatusZahtjevaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StatusZahtjeva");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
