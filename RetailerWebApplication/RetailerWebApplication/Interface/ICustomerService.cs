using RetailerWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetailerWebApplication.Interface
{
   public interface ICustomerService
    {
        public Task<IEnumerable<Customer>> GetAllCustomer();

        public Task<Customer> GetCustomerById(int id);

        public Task<Customer> Get(int id);

        public Task<int> CreateCustomer(Customer customer);

        public Task UpdateCustomer(int id,Customer customer);
    }
}
