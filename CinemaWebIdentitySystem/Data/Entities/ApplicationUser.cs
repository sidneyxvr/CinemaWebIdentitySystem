using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace CinemaWebIdentitySystem.Data.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool Estudante { get; set; }
        public bool Ativa { get; set; } 
        public ICollection<Venda> Vendas { get; set; }
    }
}
