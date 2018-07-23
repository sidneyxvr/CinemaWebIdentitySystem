using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CinemaWebIdentitySystem.Data.Entities
{
    public class Cinema
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cep { get; set; }
        public int Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public bool Ativa { get; set; }
        public virtual ICollection<Sala> Salas { get; set; }
        public virtual ICollection<Sessao> Sessoes { get; set; }
    }
}