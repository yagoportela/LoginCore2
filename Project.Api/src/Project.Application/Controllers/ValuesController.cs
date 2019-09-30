using System;
using System.Net;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project.Domain.Entities;
using Project.Domain.Interfaces.Services.User;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ICompany _company;

        public ValuesController(ICompany company){
            _company = company;
        }

        [HttpPost]
        public async Task<ActionResult> Get([FromBody] CompanyEntity companyValue)
        {   if(!ModelState.IsValid)
                return BadRequest(ModelState);

            try {
                var InsertCompany = await _company.Post(companyValue);
                
                return Ok(InsertCompany);
            }
            catch (ArgumentException ex) {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

    }
}
