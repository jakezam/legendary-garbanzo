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
            CreateMap<Provider, ProviderRead>();
            CreateMap<ProviderCreate, Provider>()
                .ForMember(p => p.Rating,
                    opt => opt.MapFrom(src => 0));
            CreateMap<ProviderUpdate, Provider>();
        }
    }
}