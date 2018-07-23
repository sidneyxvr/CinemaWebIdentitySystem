using System.Collections.Generic;

namespace CinemaWebIdentitySystem.Data.Entities
{
    public class Genero
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<Filme> Filmes { get; set; }
    }
}