using RetailerWebApplication.Models;
using RetailerWebApplication.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetailerWebApplication.Interface
{
    public interface IRetailerService
    {
       public List<Retailer> GetRetailerList();
       public  Retailer GetRetailerDetailById(int RetailerId);

        ResponseModel SaveRetailer(Retailer RetailerModel);

        ResponseModel DeleteRetailer(int RetailerId);

        ResponseModel UpdateRetailer(Retailer RetailerModel);

    }
}
