using Business.Abstract;
using Entities.DTOs.JobSubType;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers.Settings
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobSubTypeController : ControllerBase
    {
        private readonly IJobSubTypeService _JobSubTypeService;


        public JobSubTypeController(IJobSubTypeService JobSubTypeService)
        {
            _JobSubTypeService = JobSubTypeService;
        }

        [HttpGet]
        [Route("jobsubtypes")]
        public List<JobSubTypeListDTO> GetAllJobSubTypes()
        {
            return _JobSubTypeService.GetAllJobSubTypes();

        }

        [HttpPost]
        [Route("add")]
        public void AddJobSubType(AddJobSubTypeDTO JobSubTypeDTO)
        {
            _JobSubTypeService.AddJobSubType(JobSubTypeDTO);


        }


        // PUT /api/JobSubTypes/{id}
        [HttpPut("{id}")]

        public IActionResult UpdateJobSubType(int id, UpdateJobSubTypeDTO updatedJobSubType)
        {
            _JobSubTypeService.UpdateJobSubType(id, updatedJobSubType);
            return Ok();

        }
        [HttpDelete("{id}")]

        public void DeleteJobSubType(int id)
        {
            _JobSubTypeService.DeleteJobSubType(id);

        }

    }
}
