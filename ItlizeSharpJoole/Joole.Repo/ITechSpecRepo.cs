using Joole.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joole.Repo
{
    public interface ITechSpecRepo
    {
        IEnumerable<TechSpec> GetIndividualTechSpecPropertiesBySubCategory(int sub);
        IEnumerable<TechSpec> GetIndividualTechSpecPropertiesBySubCategoryAndProduct(int sub, int product);
    }
}
