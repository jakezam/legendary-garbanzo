using AutoMapper;
using legendary_garbanzo.DTOs;
using legendary_garbanzo.Models;

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