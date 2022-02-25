using Dapper;
using Newtonsoft.Json;
using RetailerWebApplication.Interface;
using RetailerWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace RetailerWebApplication.Implementation
{
    public class CustomerService : ICustomerService
    {
        private readonly CustomerContext _custDapContext;
        public CustomerService(CustomerContext custDapContext)
        {
            _custDapContext = custDapContext;
        }

        public async Task<IEnumerable<Customer>> GetAllCustomer()
        {
            var query = "Select * from Customer";
            using(var connection = _custDapContext.CreateConnection())
            {
                var customers = await connection.QueryAsync<Customer>(query);
                return customers.ToList();
            }

        }

        public async Task<Customer> GetCustomerById(int id)
        {
            var query = "Select * from Customer where Id=@id";
            using (var connection = _custDapContext.CreateConnection())
            {
                var customer =await connection.QuerySingleOrDefaultAsync<Customer>(query,new { id });
                return customer;
            }
        }

        public async Task<Customer> Get(int id)
        {
            var query = "Select * from Customer where Id =@id";
            using(var conn = _custDapContext.CreateConnection())
            {
                var customer =await conn.QuerySingleOrDefaultAsync<Customer>(query, new { id });
                return customer;
            }
        }

        public async Task<int> CreateCustomer(Customer customer)
        {
            var query = "Insert into Customer (CustomerName,Address,MobileNumber) VALUES (@CustomerName,@Address,@MobileNumber)";
             var Parameter = new DynamicParameters();
            Parameter.Add("Name", customer.CustomerName, DbType.String);
            Parameter.Add("Address", customer.Address, DbType.String);
            Parameter.Add("MobilNumber", customer.MobileNumber, DbType.String);

            using (var conn = _custDapContext.CreateConnection())
            {
               int result = await conn.ExecuteAsync(query, customer);
                return result;
            }

        }

        public async Task UpdateCustomer(int id,Customer customer)
        {
            var query = "Update Cusomer SET CustomerName=@CustomerName,Address=@Address,MobileNumber=@MobileNumber WHERE Id =@id";
            var parameter = new DynamicParameters();
            parameter.Add("CustomerName", customer.CustomerName, DbType.String);
            parameter.Add("CustomerAddress", customer.Address, DbType.String);
            parameter.Add("MobileNumber", customer.MobileNumber, DbType.String);

            using(var conn = _custDapContext.CreateConnection())
            {
                await conn.ExecuteAsync(query, parameter);
            }
        }

     }
}
