using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace RetailerWebApplication.Models
{
    public class CustomerContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;
        public CustomerContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("ConStr");
        }

        public IDbConnection CreateConnection()
            => new SqlConnection(_connectionString);
       
    }
}
