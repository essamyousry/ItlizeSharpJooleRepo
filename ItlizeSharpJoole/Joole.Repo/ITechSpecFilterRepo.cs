using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Joole.DAL;

namespace Joole.Repo
{
    public interface ITechSpecFilterRepo
    {
        List<TechSpecFilter> GetGeneralTechSpecPropertiesBySubCategory(int sub);
        TechSpecFilter GetByPropertyAndSubCategory(int prop, int sub);
    }
}