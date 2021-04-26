using System;
using AutoMapper;
using legendary_garbanzo.DTOs;
using legendary_garbanzo.Models;

namespace legendary_garbanzo.Profiles
{
    public class ProvidersProfile : Profile
    {
        public ProvidersProfile()
        {
            // We use automapper, this can map access types to models //
            CreateMap<Provider, ProviderRead>();
            CreateMap<ProviderCreate, Provider>()
                .ForMember(p => p.Rating,
                    opt => opt.MapFrom(src => 0))
                .ForMember(p => p.CreatedDate,
                    opt => opt.MapFrom(src => DateTime.Now));
            CreateMap<ProviderUpdate, Provider>();
        }
    }
}