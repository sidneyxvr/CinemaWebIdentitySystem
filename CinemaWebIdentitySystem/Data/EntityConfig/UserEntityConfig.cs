using CinemaWebIdentitySystem.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWebIdentitySystem.Data.EntityConfig
{
    public class UserEntityConfig : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.ToTable("Usuario");

            builder.Property(c => c.Nome)
                   .HasColumnType("varchar(100)")
                   .IsRequired();

            builder.Property(c => c.Sobrenome)
                   .HasColumnType("varchar(100)")
                   .IsRequired();

            builder.Property(c => c.Estudante)
                   .IsRequired();

            builder.Property(c => c.DataNascimento)
                   .IsRequired();

            builder.Property(c => c.Ativa)
                   .HasDefaultValue(true);
        }
    }
}
