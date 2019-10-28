using Joole.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joole.Repo
{
    public class ProductRepo : Repository<Product>, IProductRepo
    {
        public ProductRepo(JooleDatabaseEntities2 context) : base(context) { }
        public Product GetProductByID(int id)
        {
            return this.getByID(id);
        }

        public IEnumerable<Product> GetProducts()
        {
            return this.GetAll();
        }

        public IEnumerable<Product> GetProductsByModelYear(int year1, int year2)
        {
            return this.GetMany(x => x.ModelYear >= year1 && x.ModelYear <= year2);
        }
    }
}
