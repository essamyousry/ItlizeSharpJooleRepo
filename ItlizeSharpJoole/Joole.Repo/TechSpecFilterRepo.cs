using Joole.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joole.Repo
{
    public class TechSpecFilterRepo : Repository<TechSpecFilter>, ITechSpecFilterRepo
    {
        public TechSpecFilterRepo(JooleDatabaseEntities2 context) : base(context) { }
        public List<TechSpecFilter> GetGeneralTechSpecPropertiesBySubCategory(int sub)
        {
            return this.GetMany(x => x.SubCategoryID == sub).ToList();
        }
        public IEnumerable<TechSpecFilter> GetGeneralTechSpecPropertiesBySub(int sub)
        {
            return this.GetMany(x => x.SubCategoryID == sub);
        }
        public TechSpecFilter GetByPropertyAndSubCategory(int prop, int sub)
        {
            return this.Get(x => x.PropertyID == prop && x.SubCategoryID == sub);
        }

        public TechSpecFilter GetBySubCategory(int sub)
        {
            return this.Get(x => x.SubCategoryID == sub);
        }

    }
}
