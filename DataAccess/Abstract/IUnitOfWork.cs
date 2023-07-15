using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IUnitOfWork :IDisposable
    {
        CompanyContext Context { get; }
        IBaseRepository<Resolution> Resolutions {  get; }
        IBaseRepository<Client> Clients {  get; }
        IBaseRepository<User> Users{  get; }
        void Save();
    }
}
