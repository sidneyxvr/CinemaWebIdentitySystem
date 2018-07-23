using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CinemaWebIdentitySystem.ViewModels
{
    public class SalaViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Sala")]
        [StringLength(20, MinimumLength = 1)]
        public string Nome { get; set; }

        [Required]
        [Range(1, 1000)]
        [Display(Name = "Quantidade de Assentos")]
        public int QuantidadeAssentos { get; set; }

        public bool Ativa { get; set; } = true;

        [Required]
        [Display(Name = "Cinema")]
        public int CinemaId { get; set; }
        public CinemaViewModel Cinema { get; set; }

        public ICollection<AssentoViewModel> Assentos { get; set; }
        public ICollection<SessaoViewModel> Sessoes { get; set; }
    }
}