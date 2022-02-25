using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RetailerWebApplication.Interface;
using RetailerWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace RetailerWebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        public ICustomerService _custService;
        public CustomerController(ICustomerService custService)
        {
            _custService = custService;
        }
           
        [HttpGet]
        [Route("getAllCustomer")]
        public async Task<IActionResult> GetAllCustomer()
        {
            try
            {
                var customer = await _custService.GetAllCustomer();
                return Ok(customer);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        [Route("getById")]
        public async Task<IActionResult> GetCustomerById(int id)
        {
            try
            {
               var customer = await _custService.GetCustomerById(id);
               if(customer == null)
                {
                    return NotFound();
                }
                return Ok(customer);
            }
            catch(Exception ex)
            {
                return StatusCode(500,ex.Message);
            }

        }

        //[HttpGet]
        //[Route("get")]
        //public async Task<IActionResult> Get(int id)
        //{
        //    try
        //    {
        //        var customer =await _custService.Get(id);
        //        if(customer == null)
        //        {
        //            return NotFound();
        //        }
        //        return Ok(customer);
        //    }
        //    catch(Exception ex)
        //    {
        //        return StatusCode(500, ex.Message);
        //    }
        //}

        [HttpPost]
        [Route("AddCustomer")]
        public async Task<IActionResult> CreateCustomer(Customer customer)
        {
            try
            {
                var result = await _custService.CreateCustomer(customer);
                 if(result == null)
                {
                    return NotFound();
                }
                return Ok(result);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> UpdateCustomer(int id,Customer customer)
        {
            try
            {
                var result = await _custService.GetCustomerById(id);
                if (result == null)
                {
                    return NotFound();
                }
                await _custService.UpdateCustomer(id, customer);
                return NoContent();
            }
            catch(Exception ex)
            {
                return StatusCode(500,ex.Message) ;
            }
        }

       }
}
