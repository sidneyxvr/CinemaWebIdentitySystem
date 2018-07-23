using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CinemaWebIdentitySystem.Data.Entities
{
    public class Sala
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int QuantidadeAssentos { get; set; }
        public bool Ativa { get; set; } 
        public int CinemaId { get; set; }
        public Cinema Cinema { get; set; }
        public ICollection<Assento> Assentos { get; set; }
        public ICollection<Sessao> Sessoes { get; set; }
    }
}