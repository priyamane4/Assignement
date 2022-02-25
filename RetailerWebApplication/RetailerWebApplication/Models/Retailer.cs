using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RetailerWebApplication.Models
{
    public class Retailer
    {
        [Key]
        public int RetailerId { get; set; }
        public string RetailerFirstName { get; set; }
        public string RetailerLastName { get; set; }
        public string RetailerShopAddres { get; set; }
        public string MobileNo { get; set; }
    }
}
