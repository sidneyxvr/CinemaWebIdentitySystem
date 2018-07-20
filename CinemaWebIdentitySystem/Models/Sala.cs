using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaWebIdentitySystem.Models
{
    public class Sala
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
        public Cinema Cinema { get; set; }

        public ICollection<Assento> Assentos { get; set; }
        public ICollection<Sessao> Sessoes { get; set; }
    }
}