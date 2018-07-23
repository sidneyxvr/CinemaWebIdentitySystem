using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CinemaWebIdentitySystem.Data.Entities
{
    public class Venda
    {
        public int Id { get; set; }
        public int Cartao { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime Data { get; set; }
        public Guid ApplicationUserId { get; set; }
        public ApplicationUser Usuario { get; set; }
        public int SessaoId { get; set; }
        public Sessao Sessao { get; set; }
        public ICollection<Ingresso> Ingressos { get; set; }
    }
}