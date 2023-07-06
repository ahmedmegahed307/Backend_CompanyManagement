using Entities.Concrete;
using Entities.DTOs.Resolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IResolutionService
    {

        List<ResolutionListDTO> GetAllResolutions();
        void AddResolution(AddResolutionDTO resolutionDTO);
        void DeleteResolution(int id);
        void UpdateResolution(UpdateResolutionDTO resolutionDTO);
    }
}
