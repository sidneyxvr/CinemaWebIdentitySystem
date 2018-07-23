using CinemaWebIdentitySystem.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWebIdentitySystem.Data.EntityConfig
{
    public class SessaoEntityConfig : IEntityTypeConfiguration<Sessao>
    {
        public void Configure(EntityTypeBuilder<Sessao> builder)
        {
            builder.ToTable("Sessao");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                   .ValueGeneratedOnAdd();

            builder.Property(c => c.Preco)
                   .HasColumnType("decimal(6,2)");

            builder.Property(c => c.Ativa)
                   .HasDefaultValue(true);

            builder.HasOne(c => c.Cinema)
                   .WithMany(s => s.Sessoes)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Filme)
                   .WithMany(s => s.Sessoes)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Sala)
                   .WithMany(s => s.Sessoes)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
