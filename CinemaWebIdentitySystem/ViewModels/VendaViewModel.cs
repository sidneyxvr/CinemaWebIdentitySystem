using CinemaWebIdentitySystem.Models.AccountViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CinemaWebIdentitySystem.ViewModels
{
    public class VendaViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Cartão")]
        public int Cartao { get; set; }

        [Range(0, 4)]
        public int Quantidade { get; set; }

        [Display(Name = "Valor Total")]
        [DataType(DataType.Currency)]
        public decimal ValorTotal { get; set; }

        [DataType(DataType.Date)]
        public DateTime Data { get; set; }

        [Display(Name = "Usuário")]
        public Guid ApplicationUserId { get; set; }
        public RegisterViewModel Usuario { get; set; }

        [Display(Name = "Sessao")]
        public int SessaoId { get; set; }
        public SessaoViewModel Sessao { get; set; }

        public ICollection<IngressoViewModel> Ingressos { get; set; }
    }
}