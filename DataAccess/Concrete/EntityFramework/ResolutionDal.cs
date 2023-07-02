using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class ResolutionDal : IResolutionDal
    {
        private readonly CompanyContext _context;
        public ResolutionDal(CompanyContext context)
        {
            this._context = context;
        }
        public List<Resolution> GetAll()
        {
            return _context.Resolutions.ToList();
        }
    }
}
