using Business.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs.Resolution;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Controllers.Settings
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResolutionController : ControllerBase
    {

        private readonly IResolutionService _resolutionService;


        public ResolutionController(IResolutionService resolutionService)
        {
            _resolutionService = resolutionService;
        }

        [HttpGet]
        [Route("resolutions")]
        public List<ResolutionListDTO> GetAllResolutions()
        {
            return _resolutionService.GetAllResolutions();

        }

        [HttpPost]
        [Route("add")]
        public void AddResolution(AddResolutionDTO resolutionDTO)
        {
            _resolutionService.AddResolution(resolutionDTO);
            

        }

        //[HttpPost]
        //[Route("UpdateResolution")]
        //public void UpdateResolution(UpdateResolutionDTO resolutionDTO)
        //{
        //    _resolutionService.UpdateResolution(resolutionDTO);

        //}


        // PUT /api/resolutions/{id}
        [HttpPut("{id}")]

        public IActionResult UpdateResolution(int id,UpdateResolutionDTO updatedResolution)
        {
            _resolutionService.UpdateResolution(id,updatedResolution);
            return Ok();

        }
        [HttpDelete("{id}")]
       
        public void DeleteResolution(int id)
        {
            _resolutionService.DeleteResolution(id);

        }







    }
}
