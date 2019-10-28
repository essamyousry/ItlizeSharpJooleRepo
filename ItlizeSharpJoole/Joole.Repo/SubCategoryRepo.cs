using Joole.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Joole.Repo
{
    public class SubCategoryRepo : Repository<SubCategory>, ISubCategoryRepo
    {
        public SubCategoryRepo(JooleDatabaseEntities2 context) : base(context) { }
        public IEnumerable<SubCategory> GetSubCategories()
        {
            return this.GetAll();
        }

        public SubCategory GetSubCategory(int id)
        {
            return this.getByID(id);
        }
        
        public IEnumerable<SubCategory> getSubforCategory(int id)
        {
            return this.GetMany(X => X.CategoryID == id);
        }
        
    }
}
