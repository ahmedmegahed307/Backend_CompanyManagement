using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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
        public ResolutionService(IResolutionDal _resolutionDal)
        {
            this._resolutionDal = _resolutionDal;
        }
        public List<Resolution> GetAllResolutions()
        {
            return _resolutionDal.GetAll();
        }
    }
}
