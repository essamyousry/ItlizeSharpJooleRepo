using Joole.DAL;
using Joole.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joole.Services
{
    public class FilterService
    {
        private readonly CategoryRepo categoryRepo;
        private readonly UnitOfWork unitOfWork;

        public FilterService(CategoryRepo categoryRepo, UnitOfWork unitOfWork)
        {
            this.categoryRepo = categoryRepo;
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<Category> GetCategories()
        {
            return categoryRepo.GetCategoryNames();
        }

        public Category GetCategory(int id)
        {
            return categoryRepo.GetCategory(id);
        }

        public void SaveAll()
        {
            unitOfWork.SaveAll();
        }
    }
}
