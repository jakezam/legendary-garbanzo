using System;
using AutoMapper;
using legendary_garbanzo.DTOs;
using legendary_garbanzo.Models;

namespace legendary_garbanzo.Profiles
{
    public class ReviewProfile : Profile
    {
        public ReviewProfile()
        {
            // We use automapper, this can map access types to models //
            CreateMap<Review, ReviewRead>();
            CreateMap<ReviewCreate, Review>()
                .ForMember(r => r.CreatedDate,
                    opt => opt.MapFrom(src => DateTime.Now));
            CreateMap<ReviewUpdate, Review>();
        }
    }
}