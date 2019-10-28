using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Joole.DAL;

namespace Joole.Repo
{
    public class Repository<T> : IRepository<T> where T : class
    {
        //readonly Context context = new Context();
        readonly JooleDatabaseEntities2 _DbContext;
        private readonly DbSet<T> entities;

        public Repository(JooleDatabaseEntities2 context)
        {
            //JooleDB = context.Init();
            this._DbContext = context;
            entities = _DbContext.Set<T>();
        }
        
        public T Get(Expression<Func<T, bool>> where) {
            return entities.Where(where).FirstOrDefault<T>();
        }
        public T getByID(int id)
        {
            return entities.Find(id);
        }
        public IEnumerable<T> GetAll()
        {
            return entities.ToList();
        }
        public IEnumerable<T> GetMany(Expression<Func<T, bool>> where)
        {
            return entities.Where(where).ToList();
        }
    }
}