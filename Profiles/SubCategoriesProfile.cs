using AutoMapper;
using legendary_garbanzo.DTOs;
using legendary_garbanzo.Models;

namespace legendary_garbanzo.Profiles
{
    public class SubCategoriesProfile : Profile
    {
        public SubCategoriesProfile()
        {
            CreateMap<SubCategory, SubCategoryRead>();
            CreateMap<SubCategoryCreate, SubCategory>();
            CreateMap<SubCategoryUpdate, SubCategory>();
        }
    }
}