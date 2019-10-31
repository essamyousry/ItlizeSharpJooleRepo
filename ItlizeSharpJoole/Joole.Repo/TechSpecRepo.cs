using Joole.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joole.Repo
{
    public class TechSpecRepo : Repository<TechSpec>, ITechSpecRepo
    {
        public TechSpecRepo(JooleDatabaseEntities2 context) : base(context) { }
        public IEnumerable<TechSpec> GetIndividualTechSpecPropertiesBySubCategory(int sub)
        {
            return this.GetMany(x => x.SubCategoryID == sub);
        }

        public IEnumerable<TechSpec> GetIndividualTechSpecPropertiesBySubCategoryAndProduct(int sub, int product)
        {
            return this.GetMany(x => x.SubCategoryID == sub && x.ProductID == product);
        }
    }
}
