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
    public class UserDal : BaseRepository<User, CompanyContext>, IUserDal
    {
        public UserDal(CompanyContext context) : base()
        {
        }

        public List<User> GetAllUsersWithRoles()
        {
            using (var context = new CompanyContext())
            {
                return context.Users
                    .Include(u => u.UserRoles)
                    .ThenInclude(ur => ur.Role)
                    .ToList();
            }
        }
    }
}
