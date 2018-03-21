using System;
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data
{
    public class DataCtx : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        public DataCtx(DbContextOptions<DataCtx> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Person>(ConfigurePerson);
        }

        private void ConfigurePerson(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("Persons");

            builder.Property(ci => ci.First)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(ci => ci.Last)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(ci => ci.Phone)
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(ci => ci.Version).IsRowVersion();
        }
    }
}
