using Joole.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joole.Repo
{
    public interface IPropertyRepo
    {
        IEnumerable<Property> GetProperties();
        Property GetProperty(int id);
        IEnumerable<Property> GetPropertiesByTechSpec();
    }
}
