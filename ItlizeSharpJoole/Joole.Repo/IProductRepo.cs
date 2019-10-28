using Joole.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joole.Repo
{
    public interface IProductRepo
    {
        IEnumerable<Product> GetProducts();
        Product GetProductByID(int id);
        IEnumerable<Product> GetProductsByModelYear(int year1, int year2);
    }
}
