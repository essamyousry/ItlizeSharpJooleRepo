using Joole.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Joole.Repo
{
    public class CategoryRepo : Repository<Category> , ICategoryRepo
    {
        public CategoryRepo()
        {

        }
        public IEnumerable<Category> GetCategoryNames()
        {
            return this.GetAll();
        }

        public Category GetCategory(int id)
        {
            return this.getByID(id);
        }
    }
}