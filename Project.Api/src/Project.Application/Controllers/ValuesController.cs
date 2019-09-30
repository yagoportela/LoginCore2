using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project.Domain.Entities;
using Project.Domain.Enum;
using Project.Domain.Interfaces.Services.User;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ICompany _company;
        private readonly IUser _user;
        private readonly IAddress _address;

        public ValuesController(ICompany company , IUser user, IAddress address){
            _company = company;
            _user = user;
            _address = address;
        }

        [HttpPost]
        public async Task<ActionResult> Get([FromBody] CompanyEntity company)
        {            
            
            try {
                /*var userEntity = new UserEntity();
                    userEntity.Id = Guid.NewGuid();
                    userEntity.ImgPerfil = "NovosTeses.png";
                    userEntity.Tipo = typeUsers.Cliente;          

                var addressEntity = new AddressEntity();
                    addressEntity.Id = Guid.NewGuid();
                    addressEntity.Countries = "teste";
                    addressEntity.State = "teste";
                    addressEntity.City = "teste";
                    addressEntity.District = "teste";
                    addressEntity.Street = "teste";
                    addressEntity.Number = "teste";
                    addressEntity.Complement = "teste";
                    addressEntity.ZipCode = "teste";
                    addressEntity.Longitude = "teste";
                    addressEntity.Altitude = "teste";
                    addressEntity.Obs = "teste";
                
                var companyEntity = new CompanyEntity();
                    companyEntity.Id = Guid.NewGuid();
                    companyEntity.CNPJ = "098979869807";
                    companyEntity.RazaoSocial = "Testette";
                    companyEntity.NomeFantasia = "novostestes";
                    companyEntity.Phone1 = "768975";
                    companyEntity.Phone2 = "768975";
                    companyEntity.Address = addressEntity;
                    companyEntity.User = userEntity;*/

                var userEntity = new UserEntity();
                var addressEntity = new AddressEntity();
                var companyEntity = new CompanyEntity();

                //var InsertCompany = _company.Post(companyEntity);
                
                return Ok(await _company.GetAll());
            }
            catch (ArgumentException ex) {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

    }
}
