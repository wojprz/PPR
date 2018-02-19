namespace Projekt
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model11")
        {
        }

        public virtual DbSet<Owners> Owners { get; set; }
        public virtual DbSet<Rejestracje> Rejestracje { get; set; }
        public virtual DbSet<Samochody> Samochody { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Owners>()
                .Property(e => e.PESEL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Owners>()
                .Property(e => e.Nazwisko)
                .IsUnicode(false);

            modelBuilder.Entity<Owners>()
                .Property(e => e.Imie)
                .IsUnicode(false);

            modelBuilder.Entity<Owners>()
                .Property(e => e.Miejsce_zamieszkania)
                .IsUnicode(false);

            modelBuilder.Entity<Owners>()
                .HasMany(e => e.Samochody)
                .WithRequired(e => e.Owners)
                .HasForeignKey(e => e.PESEL_Własciciela)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Rejestracje>()
                .Property(e => e.Rejestracja)
                .IsUnicode(false);

            modelBuilder.Entity<Samochody>()
                .Property(e => e.PESEL_Własciciela)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Samochody>()
                .Property(e => e.Rejestracja)
                .IsUnicode(false);

            modelBuilder.Entity<Samochody>()
                .Property(e => e.Marka)
                .IsUnicode(false);

            modelBuilder.Entity<Samochody>()
                .Property(e => e.Model)
                .IsUnicode(false);

            modelBuilder.Entity<Samochody>()
                .Property(e => e.Przebieg)
                .IsUnicode(false);
        }
    }
}
