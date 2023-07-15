using DataAccess.Abstract.IEntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class ClientDal : BaseRepository<Client,CompanyContext> , IClientDal
    {
        
    }
}
