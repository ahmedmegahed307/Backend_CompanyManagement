using Business.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CompanyManagement.Controllers
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
        [Route("ResolutionList")]
        public  IEnumerable<Resolution> GetAllResolutions()
        {
            return  _resolutionService.GetAllResolutions();

        } 





        // GET: api/<ResolutionController>
        [HttpGet] 
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ResolutionController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ResolutionController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ResolutionController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ResolutionController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
