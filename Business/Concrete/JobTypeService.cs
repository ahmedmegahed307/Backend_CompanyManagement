using AutoMapper;
using Business.Abstract;
using DataAccess.Abstract.IEntityFramework;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs.JobType;
using Entities.DTOs.Resolution;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class JobTypeService : IJobTypeService
    {
        private readonly IJobTypeDal _jobTypeDal;
        private readonly IMapper _mapper;
        private readonly IJobSubTypeDal _jobSubTypeDal;

        public JobTypeService(IJobTypeDal _JobTypeDal, IJobSubTypeDal jobSubTypeDal, IMapper mapper)
        {
            this._jobTypeDal = _JobTypeDal;
            this._jobSubTypeDal = jobSubTypeDal;
            this._mapper = mapper;
           
        }

        public void AddJobType(AddJobTypeDTO JobTypeDTO)
        {
            var addedJobType = _mapper.Map<JobType>(JobTypeDTO);




            addedJobType.CreatedAt = DateTime.Now;
            addedJobType.UpdatedAt = DateTime.Now;

            _jobTypeDal.Add(addedJobType);
        }

        public void DeleteJobType(int id)
        {
            var JobType = _jobTypeDal.Get(a => a.Id == id);
            _jobTypeDal.Delete(JobType);

        }

        public List<JobTypeListDTO> GetAllJobTypes()
        {

            var jobTypes = _jobTypeDal.GetAllJobTypes();

                var jobTypeDTOs = _mapper.Map<List<JobTypeListDTO>>(jobTypes);
                return jobTypeDTOs;
            
        }



        public void UpdateJobType(int id, UpdateJobTypeDTO updatedJobType)
        {
            var existingJobType = _jobTypeDal.Get(a => a.Id == id);
            var updateJobType = _mapper.Map(updatedJobType, existingJobType);

            _jobTypeDal.Update(updateJobType);
        }


    }
}
