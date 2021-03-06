﻿using System.ComponentModel.DataAnnotations;

namespace CinemaWebIdentitySystem.Data.Entities
{
    public class Ingresso
    {
        public int Id { get; set; }
        public int SessaoId { get; set; }
        public Sessao Sessao { get; set; }
        public int AssentoId { get; set; }
        public Assento Assento { get; set; }
        public int VendaId { get; set; }
        public Venda Venda { get; set; }
        public bool Estudante { get; set; }
    }
}