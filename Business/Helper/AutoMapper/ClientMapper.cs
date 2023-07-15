using AutoMapper;
using Entities.Concrete;
using Entities.DTOs.Client;
using Entities.DTOs.Resolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Helper.AutoMapper
{
    public class ClientMapper : Profile
    {
        public ClientMapper()
        {

            CreateMap<Client, ClientListDTO>().ReverseMap();
            CreateMap<Client, AddClientDTO>().ReverseMap();
            CreateMap<Client, UpdateClientDTO>().ReverseMap();

        }
    }
}
