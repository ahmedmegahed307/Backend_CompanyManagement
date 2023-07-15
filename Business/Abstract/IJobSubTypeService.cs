using Entities.DTOs.JobSubType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IJobSubTypeService
    {
        List<JobSubTypeListDTO> GetAllJobSubTypes();
        void AddJobSubType(AddJobSubTypeDTO JobSubTypeDTO);
        void DeleteJobSubType(int id);
        void UpdateJobSubType(int id, UpdateJobSubTypeDTO updatedJobSubType);
    }
}
