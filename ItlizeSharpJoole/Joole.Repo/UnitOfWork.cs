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
        private readonly JooleDatabaseEntities2 context;
        public CategoryRepo categoryRepo;
        public SubCategoryRepo subCategoryRepo;
        public PropertyRepo propertyRepo;
        public ProductRepo productRepo;
        public TechSpecRepo techSpecRepo;
        public TechSpecFilterRepo techSpecFilterRepo;
        
        public UnitOfWork(JooleDatabaseEntities2 context, CategoryRepo categoryRepo, SubCategoryRepo subCategoryRepo, PropertyRepo propertyRepo, ProductRepo productRepo, TechSpecRepo techSpecRepo, TechSpecFilterRepo techSpecFilterRepo)
        {
            this.context = context;
            this.categoryRepo = categoryRepo;
            this.subCategoryRepo = subCategoryRepo;
            this.productRepo = productRepo;
            this.propertyRepo = propertyRepo;
            this.techSpecFilterRepo = techSpecFilterRepo;
            this.techSpecRepo = techSpecRepo;
        }
        
        public void SaveAll()
        {
            context.SaveChanges();
        }

        public void DisposeAll()
        {
            context.Dispose();
        }

    }
}
