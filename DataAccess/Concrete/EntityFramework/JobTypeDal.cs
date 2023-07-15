using DataAccess.Abstract.IEntityFramework;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class JobTypeDal : BaseRepository<JobType, CompanyContext>, IJobTypeDal
    {
        public JobTypeDal(CompanyContext context) : base()
        {
        }

        public List<JobType> GetAllJobTypes()
        {
            using (var context = new CompanyContext())
            {
                return context.JobTypes
                    .Include(u => u.JobSubType)
                    .ToList();
            }
        }
    }
}
