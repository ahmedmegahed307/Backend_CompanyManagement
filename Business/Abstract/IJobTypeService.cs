using Entities.DTOs.JobType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IJobTypeService
    {
        List<JobTypeListDTO> GetAllJobTypes();
        void AddJobType(AddJobTypeDTO JobTypeDTO);
        void DeleteJobType(int id);
        void UpdateJobType(int id, UpdateJobTypeDTO updatedJobType);
    }
}
