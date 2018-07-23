using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CinemaWebIdentitySystem.Data.Entities
{
    public class Sessao
    {
        public int Id { get; set; }
        public DateTime Horario { get; set; }
        public decimal Preco { get; set; }
        public bool Ativa { get; set; } 
        public int FilmeId { get; set; }
        public Filme Filme { get; set; }
        public int SalaId { get; set; }
        public Sala Sala { get; set; }
        public int CinemaId { get; set; }
        public Cinema Cinema { get; set; }
        public virtual ICollection<Venda> Vendas { get; set; }
        public virtual ICollection<Ingresso> Ingressos { get; set; }
    }
}