using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract.IEntityFramework
{
    public interface IUserDal : IBaseRepository<User>
    {
        List<User> GetAllUsersWithRoles();
    }
}
