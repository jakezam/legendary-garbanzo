using AutoMapper;
using legendary_garbanzo.DTOs;
using legendary_garbanzo.Models;

namespace legendary_garbanzo.Profiles
{
    public class CategoriesProfile : Profile
    {
        public CategoriesProfile()
        {
            // We use automapper, this can map access types to models //
            CreateMap<Category, CategoryRead>();
            CreateMap<CategoryCreate, Category>();
            CreateMap<CategoryUpdate, Category>();
        }
    }
}