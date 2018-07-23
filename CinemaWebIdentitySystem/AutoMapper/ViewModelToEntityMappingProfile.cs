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
            CreateMap<AssentoViewModel, Assento>();
            CreateMap<CinemaViewModel, Cinema>();
            CreateMap<GeneroViewModel, Genero>();
            CreateMap<IngressoViewModel, Ingresso>();
            CreateMap<SalaViewModel, Sala>();
            CreateMap<SessaoViewModel, Sessao>();
            CreateMap<VendaViewModel, Venda>();
        }
    }
}
