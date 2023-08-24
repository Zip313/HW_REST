using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Services;

namespace WebApi.Controllers
{
    [Route("customers")]
    public class CustomerController : Controller
    {
        private ICustomerService _customerService { get; }

        public CustomerController(ICustomerService customerService)
        {
            this._customerService = customerService;
        }

        [HttpGet("{id:long}")]   
        public async Task<ActionResult> GetCustomerAsync([FromRoute] long id)
        {
            try
            {
                var customer = await _customerService.GetCustomerAsync(id);
                return Ok(customer);
            }
            catch (KeyNotFoundException ex)
            {

                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("")]   
        public async Task<ActionResult> CreateCustomerAsync([FromBody] Customer customer)
        {
            try
            {
                var newCustomerId = await _customerService.CreateCustomerAsync(customer);
                return Ok(newCustomerId);
            }
            catch (ArgumentException ex)
            {
                return Conflict(ex.Message);
            } 
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}