using AutoMapper;
using legendary_garbanzo.DTOs;
using legendary_garbanzo.Models;

#pragma warning disable 1591 /*XML Doc String Warning*/

namespace legendary_garbanzo.Profiles
{
    public class CategoriesProfile : Profile
    {
        public CategoriesProfile()
        {
            CreateMap<Category, CategoryRead>();
            CreateMap<CategoryCreate, Category>();
            CreateMap<CategoryUpdate, Category>();
        }
    }
}