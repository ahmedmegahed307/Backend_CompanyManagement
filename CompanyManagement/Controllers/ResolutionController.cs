    using Business.Abstract;
    using DataAccess.Concrete.EntityFramework;
    using Entities.Concrete;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;


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
            public  List<Resolution> GetAllResolutions()
            {
                return  _resolutionService.GetAllResolutions();

            } 





        
        }
    }
