using Joole.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joole.Repo
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly JooleDatabaseEntities2 context;
        public CategoryRepo categoryRepo;
        public SubCategoryRepo subCategoryRepo;
        public PropertyRepo propertyRepo;
        public ProductRepo productRepo;
        public TechSpecRepo techSpecRepo;
        public TechSpecFilterRepo techSpecFilterRepo;
        public CustomerRepo customerRepo;
        
        public UnitOfWork(JooleDatabaseEntities2 context, CategoryRepo categoryRepo, SubCategoryRepo subCategoryRepo, PropertyRepo propertyRepo, ProductRepo productRepo, TechSpecRepo techSpecRepo, TechSpecFilterRepo techSpecFilterRepo, CustomerRepo customerRepo)
        {
            this.context = context;
            this.categoryRepo = categoryRepo;
            this.subCategoryRepo = subCategoryRepo;
            this.productRepo = productRepo;
            this.propertyRepo = propertyRepo;
            this.techSpecFilterRepo = techSpecFilterRepo;
            this.techSpecRepo = techSpecRepo;
            this.customerRepo = customerRepo;
        }
        
        public void SaveAll()
        {
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }

    }
}
