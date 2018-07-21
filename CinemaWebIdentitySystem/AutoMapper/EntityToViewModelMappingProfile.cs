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
        }
    }
}
