using Business.Abstract;
using Entities.DTOs.JobType;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers.Settings
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobTypeController : ControllerBase
    {
        private readonly IJobTypeService _jobTypeService;


        public JobTypeController(IJobTypeService jobTypeService)
        {
            _jobTypeService = jobTypeService;
        }

        [HttpGet]
        [Route("jobtypes")]
        public List<JobTypeListDTO> GetAllJobTypes()
        {
            return _jobTypeService.GetAllJobTypes();

        }

        [HttpPost]
        [Route("add")]
        public void AddJobType(AddJobTypeDTO JobTypeDTO)
        {
            _jobTypeService.AddJobType(JobTypeDTO);


        }


        // PUT /api/JobTypes/{id}
        [HttpPut("{id}")]

        public IActionResult UpdateJobType(int id, UpdateJobTypeDTO updatedJobType)
        {
            _jobTypeService.UpdateJobType(id, updatedJobType);
            return Ok();

        }
        [HttpDelete("{id}")]

        public void DeleteJobType(int id)
        {
            _jobTypeService.DeleteJobType(id);

        }

    }
}
