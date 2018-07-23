using CinemaWebIdentitySystem.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWebIdentitySystem.Data.EntityConfig
{
    public class CinemaEntityConfig : IEntityTypeConfiguration<Cinema>
    {
        public void Configure(EntityTypeBuilder<Cinema> builder)
        {
            builder.ToTable("Cinema");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                   .ValueGeneratedOnAdd();

            builder.Property(c => c.Nome)
                   .HasColumnType("varchar(50)")
                   .IsRequired();

            builder.Property(c => c.Estado)
                   .IsRequired();

            builder.Property(c => c.Cidade)
                   .HasColumnType("varchar(50)")
                   .IsRequired();

            builder.Property(c => c.Bairro)
                   .HasColumnType("varchar(50)")
                   .IsRequired();

            builder.Property(c => c.Rua)
                   .HasColumnType("varchar(70)")
                   .IsRequired();

            builder.Property(c => c.Ativa)
                   .HasDefaultValue(true);
        }
    }
}
