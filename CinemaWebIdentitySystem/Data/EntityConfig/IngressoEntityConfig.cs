using CinemaWebIdentitySystem.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWebIdentitySystem.Data.EntityConfig
{
    public class IngressoEntityConfig : IEntityTypeConfiguration<Ingresso>
    {
        public void Configure(EntityTypeBuilder<Ingresso> builder)
        {
            builder.ToTable("Ingresso");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                   .ValueGeneratedOnAdd();

            builder.HasOne(c => c.Sessao)
                   .WithMany(s => s.Ingressos)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Assento)
                   .WithMany(s => s.Ingressos)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Venda)
                   .WithMany(s => s.Ingressos)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
