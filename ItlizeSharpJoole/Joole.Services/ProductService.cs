using Joole.DAL;
using Joole.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Joole.Services
{
    public class ProductService
    {
        private readonly UnitOfWork unitOfWork;

        public ProductService(UnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<Product> GetProducts()
        {
            return unitOfWork.productRepo.GetProducts();
        }

        public Product GetProductIDFromName(string name)
        {
            return unitOfWork.productRepo.Get(x => x.ProductName == name);
        }

        public Product GetProduct(int id)
        {
            return unitOfWork.productRepo.GetProductByID(id);
        }
    }
}