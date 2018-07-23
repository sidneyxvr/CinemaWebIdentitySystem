using System.ComponentModel.DataAnnotations;

namespace CinemaWebIdentitySystem.ViewModels
{
    public class IngressoViewModel
    {
        [Key]
        public int Id { get; set; }

        public int SessaoId { get; set; }
        public SessaoViewModel Sessao { get; set; }

        public int AssentoId { get; set; }
        public AssentoViewModel Assento { get; set; }

        public int VendaId { get; set; }
        public VendaViewModel Venda { get; set; }

        public bool Estudante { get; set; }
    }
}