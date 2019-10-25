using Joole.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joole.Repo
{
    public class UnitOfWork
    {
        private readonly Context context;
        //private JooleDatabaseEntities db;

        public UnitOfWork(Context context)
        {
            this.context = context;
        }
        /*
        public JooleDatabaseEntities dbContext
        {
            get { return db; }
        }
        */
        public void SaveAll()
        {
            context.SaveChanges();
        }

    }
}
