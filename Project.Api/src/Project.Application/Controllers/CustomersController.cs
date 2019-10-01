using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project.Domain.Entities;
using Project.Domain.Interfaces.Services.User;

namespace Project.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomers _customers;

        public CustomersController(ICustomers customers){
            _customers = customers;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CustomersEntity customersValue)
        {   
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            try {
                var result = await _customers.Post(customersValue);

                if (result != null)
                {
                    return Created(new Uri(Url.Link("GetWithId", new { id = result.Id })), result);
                }
                else
                {
                    return BadRequest();
                }
                
            }
            catch (ArgumentException ex) {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] CustomersEntity customersValue)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _customers.Put(customersValue);
                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                    return BadRequest();
                }

            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}