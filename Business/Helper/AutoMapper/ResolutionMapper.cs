using AutoMapper;
using Entities.Concrete;
using Entities.DTOs.Resolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Helper.AutoMapper
{
    public class ResolutionMapper : Profile
    {
        public ResolutionMapper() {

            CreateMap<Resolution, ResolutionListDTO>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name)).ReverseMap();

            CreateMap<Resolution, AddResolutionDTO>().ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name)).ReverseMap();
            CreateMap<Resolution, UpdateResolutionDTO>().ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                
                .ReverseMap();

        }
    }
}
