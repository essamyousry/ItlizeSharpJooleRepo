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
        readonly Context context = new Context();
        readonly JooleDatabaseEntities2 JooleDB;
        private readonly DbSet<T> entities;

        public Repository()
        {
            JooleDB = context.Init();
            entities = JooleDB.Set<T>();
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