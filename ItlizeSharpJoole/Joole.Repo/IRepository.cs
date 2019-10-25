using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Joole.Repo
{
    public interface IRepository<T> where T : class
    {
        T getByID(int id);
        T Get(Expression<Func <T, bool>> where);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetMany(Expression<Func<T, bool>> where);

    }
}
