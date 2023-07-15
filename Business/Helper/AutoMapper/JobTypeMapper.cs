using AutoMapper;
using Entities.Concrete;
using Entities.DTOs.JobType;
using Entities.DTOs.Resolution;
using Entities.DTOs.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Helper.AutoMapper
{
    public class JobTypeMapper : Profile
    {
        public JobTypeMapper()
        {
            CreateMap<JobType, JobTypeListDTO>()
               .ForMember(dest => dest.JobSubType, opt => opt.MapFrom(src => src.JobSubType.Name))
               .ReverseMap();
            CreateMap<JobType, UpdateJobTypeDTO>()
              .ForMember(dest => dest.JobSubTypeId, opt => opt.MapFrom(src => src.JobSubTypeId))
              .ReverseMap();

            CreateMap<JobType, AddJobTypeDTO>().ReverseMap();
            CreateMap<JobType, UpdateJobTypeDTO>().ReverseMap();

        }
    }
}
