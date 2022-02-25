using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RetailerWebApplication.Interface;
using RetailerWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetailerWebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RetailerController : ControllerBase
    {
        private IRetailerService _retailerService;
        public RetailerController(IRetailerService retailerService)
        {
            _retailerService = retailerService;
        }

        [HttpGet]
        [Route("[Action]")]
        public ActionResult GetAllRetailer()
        {
            try
            {
                var retailer = _retailerService.GetRetailerList();
                if(retailer == null)
                {
                    return NotFound();
                }
                return Ok(retailer);
            }
            catch(Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("[action]/id")]
        public IActionResult GeRetailerById(int retailId)
        {
            try
            {
                var retailer = _retailerService.GetRetailerDetailById(retailId);
                if (retailId == null)
                    return NotFound();
                else
                    return Ok(retailer);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("AddRetailer")]

        public IActionResult SaveRetailer(Retailer retailer)
        {
            try
            {
                var model = _retailerService.SaveRetailer(retailer);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPut]
        [Route("[action]")]
      
        public IActionResult UpdateRetail(Retailer UpdateRetailer)
        {
            try
            {
                var updateValue = _retailerService.UpdateRetailer(UpdateRetailer);
                return Ok(updateValue);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        [Route("[action]")]
        public IActionResult DeleteRetailer(int retailerId)
        {
            try
            {
                var retailer = _retailerService.DeleteRetailer(retailerId);
                return Ok(retailer);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
