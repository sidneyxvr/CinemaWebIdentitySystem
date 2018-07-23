using CinemaWebIdentitySystem.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWebIdentitySystem.Data.EntityConfig
{
    public class AssentoEntityConfig : IEntityTypeConfiguration<Assento>
    {
        public void Configure(EntityTypeBuilder<Assento> builder)
        {
            builder.ToTable("Assento");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                   .ValueGeneratedOnAdd();

            builder.Property(c => c.Fila)
                   .HasColumnType("varchar(3)")
                   .IsRequired();

            builder.Property(c => c.Numero)
                   .IsRequired();

            builder.Property(c => c.Ativa)
                   .HasDefaultValue(true);

            builder.HasOne(c => c.Sala)
                   .WithMany(s => s.Assentos)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
