using AutoMapper;
using CinemaWebIdentitySystem.Data.Entities;
using CinemaWebIdentitySystem.ViewModels;

namespace CinemaWebIdentitySystem.AutoMapper
{
    public class EntityToViewModelMappingProfile : Profile
    {
        public EntityToViewModelMappingProfile()
        {
            CreateMap<Filme, FilmeViewModel>();
            CreateMap<Assento, AssentoViewModel>();
            CreateMap<Cinema, CinemaViewModel>();
            CreateMap<Genero, GeneroViewModel>();
            CreateMap<Ingresso, IngressoViewModel>();
            CreateMap<Sala, SalaViewModel>();
            CreateMap<Sessao, SessaoViewModel>();
            CreateMap<Venda, VendaViewModel>();
        }
    }
}
