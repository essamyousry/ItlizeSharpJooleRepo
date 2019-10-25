using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Joole.DAL;

namespace Joole.Repo
{
    public class Context : DbContext
    {
        readonly JooleDatabaseEntities2 context;
        public Context()
        {
            context = new JooleDatabaseEntities2();
        }
        public JooleDatabaseEntities2 Init()
        {
            return context;
        }
        protected void SaveAll()
        {
            context.SaveChanges();
        }

        protected void DisposeAll()
        {
            context.Dispose();
        }
    }
}
