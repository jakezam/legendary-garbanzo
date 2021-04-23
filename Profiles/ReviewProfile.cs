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
            CreateMap<Review, ReviewRead>();
            CreateMap<ReviewCreate, Review>()
                .ForMember(r => r.CreatedDate,
                    opt => opt.MapFrom(src => DateTime.Now));
            CreateMap<ReviewUpdate, Review>();
        }
    }
}