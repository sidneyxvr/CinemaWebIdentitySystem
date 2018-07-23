using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CinemaWebIdentitySystem.ViewModels
{
    public class AssentoViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(3, MinimumLength = 1)]
        [RegularExpression(@"[a-zA-Z]+")]
        public string Fila { get; set; }

        [Required]
        [Range(1, 100)]
        [Display(Name = "Número")]
        public int Numero { get; set; }

        [Required]
        [Display(Name = "Sala")]
        public int SalaId { get; set; }
        public SalaViewModel Sala { get; set; }

        public bool Ativa { get; set; } = true;

        public ICollection<IngressoViewModel> Ingressos { get; set; }
    }
}
