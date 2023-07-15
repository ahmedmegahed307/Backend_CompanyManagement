using DataAccess.Abstract.IEntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class JobSubTypeDal : BaseRepository<JobSubType, CompanyContext>, IJobSubTypeDal
    {
    }
}
