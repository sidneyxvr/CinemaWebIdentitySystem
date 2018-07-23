using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CinemaWebIdentitySystem.ViewModels
{
    public class SessaoViewModel
    {
        [Key]
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
        public FilmeViewModel Filme { get; set; }

        [Required]
        [Display(Name = "Sala")]
        public int SalaId { get; set; }
        public SalaViewModel Sala { get; set; }

        [Required]
        [Display(Name = "Cinema")]
        public int CinemaId { get; set; }
        public CinemaViewModel Cinema { get; set; }

        public virtual ICollection<VendaViewModel> Vendas { get; set; }
        public virtual ICollection<IngressoViewModel> Ingressos { get; set; }
    }
}