using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace wsPruebaDedalus.Models
{
    public partial class sdhh_tempContext : DbContext
    {
        public sdhh_tempContext()
        {
        }

        public sdhh_tempContext(DbContextOptions<sdhh_tempContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CountryDatum> CountryData { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=10.212.160.6;Initial Catalog=sdhh_temp;Persist Security Info=True;User Id=testUser;Password=SuperSecretP4ssw0rd;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<CountryDatum>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CountryCapital)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("countryCapital");

                entity.Property(e => e.CountryIsoCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("countryIsoCode");

                entity.Property(e => e.CountryName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("countryName");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
