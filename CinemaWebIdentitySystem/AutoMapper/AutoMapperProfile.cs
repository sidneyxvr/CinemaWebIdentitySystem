using AutoMapper;
using CinemaWebIdentitySystem.Data.Entities;
using CinemaWebIdentitySystem.ViewModels;

namespace CinemaWebIdentitySystem.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        //usando mapper
        //https://github.com/EduardoPires/EquinoxProject/blob/master/src/Equinox.Application/Services/CustomerAppService.cs
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(config => {
                config.AddProfile(new EntityToViewModelMappingProfile());
                config.AddProfile(new ViewModelToEntityMappingProfile());
            });
        }
    }
}
