using System.Collections.Generic;

namespace CinemaWebIdentitySystem.Data.Entities
{
    public class Assento
    {
        public int Id { get; set; }
        public string Fila { get; set; }
        public int Numero { get; set; }
        public int SalaId { get; set; }
        public Sala Sala { get; set; }
        public bool Ativa { get; set; } 
        public ICollection<Ingresso> Ingressos { get; set; }
    }
}