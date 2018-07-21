using AutoMapper;
using CinemaWebIdentitySystem.Data.Entities;
using CinemaWebIdentitySystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWebIdentitySystem.AutoMapper
{
    public class ViewModelToEntityMappingProfile : Profile
    {
        public ViewModelToEntityMappingProfile()
        {
            CreateMap<FilmeViewModel, Filme>();   
        }
    }
}
