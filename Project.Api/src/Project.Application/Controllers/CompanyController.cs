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
    public class CompanyController : ControllerBase
    {
        private readonly ICompany _company;
        
        public CompanyController(ICompany company){
            _company = company;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CompanyEntity companyValue)
        {   
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            try {
                var result = await _company.Post(companyValue);
                
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
        public async Task<ActionResult> Put([FromBody] CompanyEntity companyValue)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _company.Put(companyValue);
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