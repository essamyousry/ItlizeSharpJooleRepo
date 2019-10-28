using Joole.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joole.Repo
{
    public class PropertyRepo : Repository<Property>, IPropertyRepo
    {
        public PropertyRepo(JooleDatabaseEntities2 context) : base(context){ }
        public Property GetProperty(int id)
        {
            return this.getByID(id);
        }

        public IEnumerable<Property> GetProperties()
        {
            return this.GetAll();
        }

        public IEnumerable<Property> GetPropertiesByTechSpec()
        {
            return this.GetMany(x => x.IsTechSpec == true);
        }
    }
}
