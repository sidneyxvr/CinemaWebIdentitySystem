using System.Linq;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CinemaWebIdentitySystem.Data.Entities;
using CinemaWebIdentitySystem.Data.EntityConfig;
using CinemaWebIdentitySystem.ViewModels;

namespace CinemaWebIdentitySystem.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new FilmeEntityConfig());
            builder.ApplyConfiguration(new GeneroEntityConfig());
            builder.ApplyConfiguration(new UserEntityConfig());
            builder.ApplyConfiguration(new AssentoEntityConfig());
            builder.ApplyConfiguration(new CinemaEntityConfig());
            builder.ApplyConfiguration(new IngressoEntityConfig());
            builder.ApplyConfiguration(new SalaEntityConfig());
            builder.ApplyConfiguration(new SessaoEntityConfig());
            builder.ApplyConfiguration(new VendaEntityConfig());

            base.OnModelCreating(builder);
        }

        public DbSet<Assento> Assentos { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Ingresso> Ingressos { get; set; }
        public DbSet<Sala> Salas { get; set; }
        public DbSet<Sessao> Sessoes { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<CinemaWebIdentitySystem.ViewModels.GeneroViewModel> GeneroViewModel { get; set; }
    }
}
