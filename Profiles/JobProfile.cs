using AutoMapper;
using legendary_garbanzo.DTOs;
using legendary_garbanzo.Models;

namespace legendary_garbanzo.Profiles
{
    public class JobProfile : Profile
    {
        public JobProfile()
        {
            // We use automapper, this can map access types to models //
            CreateMap<Job, JobRead>();
            CreateMap<JobCreate, Job>()
                .ForMember(j => j.JobAccepted,
                    opt => opt.MapFrom(src => false));
            CreateMap<JobUpdate, Job>();
        }
    }
}