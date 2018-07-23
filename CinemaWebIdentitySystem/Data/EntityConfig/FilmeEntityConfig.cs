using CinemaWebIdentitySystem.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWebIdentitySystem.Data.EntityConfig
{
    public class FilmeEntityConfig : IEntityTypeConfiguration<Filme>
    {
        public void Configure(EntityTypeBuilder<Filme> builder)
        {
            builder.ToTable("Filme");

            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();

            builder.Property(c => c.Titulo)
                   .HasColumnType("varchar(100)")
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(c => c.Imagem)
                   .HasColumnType("varchar(100)")
                   .HasMaxLength(100);

            builder.Property(c => c.Classificacao)
                   .IsRequired();

            builder.Property(c => c.Ativa)
                   .HasDefaultValue(true);

            builder.HasOne(c => c.Genero)
                   .WithMany(s => s.Filmes)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
