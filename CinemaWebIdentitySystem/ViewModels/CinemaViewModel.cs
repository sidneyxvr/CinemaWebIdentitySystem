using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CinemaWebIdentitySystem.ViewModels
{
    public class CinemaViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Cinema")]
        [StringLength(50, MinimumLength = 1)]
        public string Nome { get; set; }

        [DataType(DataType.PostalCode)]
        public string Cep { get; set; }

        [Required]
        public int Estado { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Cidade { get; set; }

        [Display(Name = "Bairro")]
        [StringLength(50, MinimumLength = 3)]
        public string Bairro { get; set; }

        [Display(Name = "Rua")]
        [StringLength(50, MinimumLength = 3)]
        public string Rua { get; set; }

        [Display(Name = "Número")]
        public int Numero { get; set; }

        public bool Ativa { get; set; } = true;

        public virtual ICollection<SalaViewModel> Salas { get; set; }
        public virtual ICollection<SessaoViewModel> Sessoes { get; set; }
    }
}
