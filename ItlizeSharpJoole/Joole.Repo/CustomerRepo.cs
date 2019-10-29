using Joole.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joole.Repo
{
    public class CustomerRepo : Repository<Customer>, ICustomerRepo
    {
        public CustomerRepo(JooleDatabaseEntities2 context) : base(context) { }

        public void AddCustomer(Customer customer)
        {
            this.Add(customer);
        }

        public void DeleteCustomer(Customer customer)
        {
            this.Delete(customer);
        }

        public Customer GetCustomerByID(int id)
        {
            return this.getByID(id);
        }

        public void UpdateCustomer(Customer customer)
        {
            this.Update(customer);
        }

        public IEnumerable<Customer> GetAllCustomer()
        {
            return this.GetAll();
        }
    }
}
