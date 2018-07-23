using CinemaWebIdentitySystem.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWebIdentitySystem.Data.EntityConfig
{
    public class SalaEntityConfig : IEntityTypeConfiguration<Sala>
    {
        public void Configure(EntityTypeBuilder<Sala> builder)
        {
            builder.ToTable("Sala");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                   .ValueGeneratedOnAdd();

            builder.Property(c => c.Nome)
                   .HasColumnType("varchar(5)")
                   .IsRequired();

            builder.Property(c => c.Ativa)
                   .HasDefaultValue(true);

            builder.HasOne(c => c.Cinema)
                   .WithMany(s => s.Salas)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
