using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaWebIdentitySystem.Data.Entities
{
    public class Sessao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Data e Horário da Sessão")]
        [DataType(DataType.DateTime)]
        public DateTime Horario { get; set; }

        [DataType(DataType.Currency)]
        public decimal Preco { get; set; }

        public bool Ativa { get; set; } = true;

        [Required]
        [Display(Name = "Filme")]
        public int FilmeId { get; set; }
        public Filme Filme { get; set; }

        [Required]
        [Display(Name = "Sala")]
        public int SalaId { get; set; }
        public Sala Sala { get; set; }

        [Required]
        [Display(Name = "Cinema")]
        public int CinemaId { get; set; }
        public Cinema Cinema { get; set; }

        public virtual ICollection<Venda> Vendas { get; set; }
        public virtual ICollection<Ingresso> Ingressos { get; set; }
    }
}