using System;
using AutoMapper;
using legendary_garbanzo.DTOs;
using legendary_garbanzo.Models;

#pragma warning disable 1591 /*XML Doc String Warning*/

namespace legendary_garbanzo.Profiles
{
    public class UsersProfile : Profile
    {
        public UsersProfile()
        {
            CreateMap<User, UserRead>();
            CreateMap<UserCreate, User>()
                .ForMember(u => u.CreatedDate,
                    opt => opt.MapFrom(src => DateTime.Now));
            CreateMap<UserUpdate, User>();
        }
    }
}