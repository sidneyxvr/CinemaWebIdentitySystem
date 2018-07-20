using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaWebIdentitySystem.Models
{
    public class Assento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
        public Sala Sala { get; set; }

        public bool Ativa { get; set; } = true;

        public ICollection<Ingresso> Ingressos { get; set; }
    }
}