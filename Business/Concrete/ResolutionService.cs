using AutoMapper;
using Business.Abstract;
using Business.Helper.AutoMapper;
using DataAccess.Abstract.IEntityFramework;
using Entities.Concrete;
using Entities.DTOs.Resolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ResolutionService : IResolutionService
    {

        private readonly IResolutionDal _resolutionDal;
        private readonly IMapper _mapper;

        public ResolutionService(IResolutionDal _resolutionDal, IMapper mapper)
        {
            this._resolutionDal = _resolutionDal;
            this._mapper = mapper;
        }

        public void AddResolution(AddResolutionDTO resolutionDTO)
        {
            var addedResolution = _mapper.Map<Resolution>(resolutionDTO);

            addedResolution.CreatedAt = DateTime.Now;
            addedResolution.LastUpdatedAt = DateTime.Now;

            _resolutionDal.Add(addedResolution);
        }

        public void DeleteResolution(int id)
        {
            var resolution = _resolutionDal.Get(a => a.Id == id);
            _resolutionDal.Delete(resolution);

        }

        public List<ResolutionListDTO> GetAllResolutions()
        {
            var resolutions = _resolutionDal.GetAll();
            var resolutionDTOs = _mapper.Map<List<ResolutionListDTO>>(resolutions);
            return resolutionDTOs;
        }


        public void UpdateResolution(int  id, UpdateResolutionDTO updatedResolution)
        {
            var existingResolution = _resolutionDal.Get(a => a.Id == id);
            existingResolution.Name = updatedResolution.Name;

            _resolutionDal.Update(existingResolution);
        }
    }
}
