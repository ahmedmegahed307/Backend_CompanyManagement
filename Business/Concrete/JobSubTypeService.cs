using AutoMapper;
using Business.Abstract;
using DataAccess.Abstract.IEntityFramework;
using Entities.Concrete;
using Entities.DTOs.JobSubType;
using Entities.DTOs.Resolution;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class JobSubTypeService : IJobSubTypeService
    {
        private readonly IJobSubTypeDal _jobSubTypeDal;
        private readonly IMapper _mapper;
      

        public JobSubTypeService( IJobSubTypeDal jobSubTypeDal, IMapper mapper)
        {
            this._jobSubTypeDal = jobSubTypeDal;
            this._mapper = mapper;
        }

        public void AddJobSubType(AddJobSubTypeDTO JobSubTypeDTO)
        {
            var addedJobSubType = _mapper.Map<JobSubType>(JobSubTypeDTO);

            addedJobSubType.CreatedAt = DateTime.Now;
            addedJobSubType.UpdatedAt = DateTime.Now;
            addedJobSubType.IsActive = true;

            _jobSubTypeDal.Add(addedJobSubType);
        }

        public void DeleteJobSubType(int id)
        {
            var JobSubType = _jobSubTypeDal.Get(a => a.Id == id);
            _jobSubTypeDal.Delete(JobSubType);

        }

        public List<JobSubTypeListDTO> GetAllJobSubTypes()
        {
            var JobSubTypes = _jobSubTypeDal.GetAll(a => a.IsActive == true);
            var JobSubTypeDTOs = _mapper.Map<List<JobSubTypeListDTO>>(JobSubTypes);
            return JobSubTypeDTOs;
        }



        public void UpdateJobSubType(int id, UpdateJobSubTypeDTO updatedJobSubType)
        {
            var existingJobSubType = _jobSubTypeDal.Get(a => a.Id == id);
            var updateJobSubType = _mapper.Map(updatedJobSubType, existingJobSubType);

            _jobSubTypeDal.Update(updateJobSubType);
        }


    }
}
