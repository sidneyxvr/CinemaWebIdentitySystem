using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CinemaWebIdentitySystem.ViewModels
{
    public class GeneroViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Gênero")]
        [StringLength(25, MinimumLength = 1)]
        public string Descricao { get; set; }

        public virtual ICollection<FilmeViewModel> Filmes { get; set; }
    }
}