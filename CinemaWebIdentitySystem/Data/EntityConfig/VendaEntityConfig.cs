using CinemaWebIdentitySystem.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWebIdentitySystem.Data.EntityConfig
{
    public class VendaEntityConfig : IEntityTypeConfiguration<Venda>
    {
        public void Configure(EntityTypeBuilder<Venda> builder)
        {
            builder.ToTable("Venda");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                   .ValueGeneratedOnAdd();

            builder.Property(c => c.ValorTotal)
                   .HasColumnType("decimal(6,2)");

            builder.HasOne(c => c.Sessao)
                   .WithMany(s => s.Vendas)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Usuario)
                   .WithMany(s => s.Vendas)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
