using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWebIdentitySystem.ViewModels
{
    public class FilmeViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Título")]
        [StringLength(60, MinimumLength = 1)]
        public string Titulo { get; set; }

        public byte[] Imagem { get; set; }

        [Required]
        [Display(Name = "Classificação Indicativa")]
        public int Classificacao { get; set; }

        [Required]
        [Display(Name = "Gênero")]
        public int GeneroId { get; set; }
        public GeneroViewModel Genero { get; set; }

        public bool Ativa { get; set; } = true;

        public virtual ICollection<SessaoViewModel> Sessoes { get; set; }
    }
}
