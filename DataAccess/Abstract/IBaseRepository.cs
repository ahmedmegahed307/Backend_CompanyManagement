using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IBaseRepository<T> where T : class,new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);   
    }
}
