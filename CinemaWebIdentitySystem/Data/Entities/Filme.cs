using System.Collections.Generic;

namespace CinemaWebIdentitySystem.Data.Entities
{
    public class Filme
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Imagem { get; set; }
        public int Classificacao { get; set; }
        public int GeneroId { get; set; }
        public Genero Genero { get; set; }
        public bool Ativa { get; set; }
        public ICollection<Sessao> Sessoes { get; set; }
    }
}