using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private IBaseRepository<Resolution> resolutions = null;

        public readonly CompanyContext context;

       
        public IBaseRepository<Resolution> Resolutions
        {
            get
            {
                if (resolutions == null)
                {
                    resolutions = new BaseRepository<Resolution, CompanyContext>();

                }
                return resolutions;
            }
        }

        public void Dispose()
        {
            if(this.context != null)
            {
                this.context.Dispose();
            }
        }
        public CompanyContext Context
        {
            get
            {
                return context;
            }
        }
        public void Save()
        {
            context.SaveChanges();
        }
    }
}
