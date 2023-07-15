using AutoMapper;
using Entities.Concrete;
using Entities.DTOs.JobSubType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Helper.AutoMapper
{
    public class JobSubTypeMapper : Profile
    {

        public JobSubTypeMapper()
        {

            CreateMap<JobSubType, JobSubTypeListDTO>().ReverseMap();
            CreateMap<JobSubType, AddJobSubTypeDTO>().ReverseMap();
            CreateMap<JobSubType, UpdateJobSubTypeDTO>().ReverseMap();

        }
    }
}
