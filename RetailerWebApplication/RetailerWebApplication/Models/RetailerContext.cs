using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetailerWebApplication.Models
{
    public class RetailerContext:DbContext
    {
        public RetailerContext(DbContextOptions options) : base(options)
        {
          
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        public DbSet<Retailer> Retailer { get; set; }
        public DbSet<Customer> Customer { get; set; }



    }
}
