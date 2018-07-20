using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaWebIdentitySystem.Models
{
    public class Genero
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Gênero")]
        [StringLength(25, MinimumLength = 1)]
        public string Descricao { get; set; }

        public virtual ICollection<Filme> Filmes { get; set; }
    }
}