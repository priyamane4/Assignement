using RetailerWebApplication.Interface;
using RetailerWebApplication.Models;
using RetailerWebApplication.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetailerWebApplication.Implementation
{
    public class RetailerService:IRetailerService
    {
        private RetailerContext _context;
       public RetailerService(RetailerContext context)
        {
            _context = context;
        }

        public List<Retailer> GetRetailerList()
        {
            List<Retailer> RetailerList;
            try
            {                
                RetailerList = _context.Set<Retailer>().ToList();
            }
            catch(Exception)
            {
                throw;
            }
            return RetailerList;
        }

        public Retailer GetRetailerDetailById(int RetailerId)
        {
            Retailer Retailer;
            try
            {
                Retailer = _context.Find<Retailer>(RetailerId);
            }
            catch(Exception)
            {
                throw;
            }
            return Retailer;
        }

        public ResponseModel SaveRetailer(Retailer RetailerModel)
        {
            ResponseModel response = new ResponseModel();
            try
            {
                _context.Add<Retailer>(RetailerModel);
                response.Message="Record Saved Successfully";
                _context.SaveChanges();
                response.IsSuccess = true;
            }
            catch(Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Error: " + ex.Message;
            }
            return response;
        }

       public ResponseModel DeleteRetailer(int RetailerId)
        {
            ResponseModel Response = new ResponseModel();
            try
            {
                Retailer _temp = GetRetailerDetailById(RetailerId);
                if(_temp != null)
                {
                    _context.Remove<Retailer>(_temp);
                    _context.SaveChanges();
                    Response.Message = "Retailer Deleted successfully";
                    Response.IsSuccess = true;
                }
                else
                {
                    Response.IsSuccess = false;
                    Response.Message = "Retailer Not Found";
                }
            }
            catch(Exception ex)
            {
                Response.IsSuccess = false;
                Response.Message = "Error : " + ex.Message;
            }
            return Response;
        }

        public ResponseModel UpdateRetailer(Retailer RetailerModel)
        {
            Retailer retailer = new Retailer();
            ResponseModel Response = new ResponseModel();
            try
            {
               if(RetailerModel.RetailerId != null)
                {
                    retailer.RetailerFirstName = RetailerModel.RetailerFirstName;
                    retailer.RetailerLastName = RetailerModel.RetailerLastName;
                    retailer.RetailerShopAddres = RetailerModel.RetailerShopAddres;
                    retailer.MobileNo = RetailerModel.MobileNo;

                    _context.Update<Retailer>(RetailerModel);
                    _context.SaveChanges();
                     Response.Message = "Record Updated successfully";
                    Response.IsSuccess = true;
                }
                else
                {
                    Response.IsSuccess = false;
                    Response.Message = "Record Not Updated";
                }
            }
            catch (Exception ex)
            {
                Response.Message = "Error :" + ex.Message;
                Response.IsSuccess = false;
            }
            return Response;
        }
    }
}
