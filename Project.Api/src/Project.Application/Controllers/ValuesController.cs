﻿using System;
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
        private readonly IUser _user;

        public ValuesController(IUser user){
            _user = user;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            if(!ModelState.IsValid)            
                return BadRequest(ModelState);
            
            
            try {
                var userEntity = new UserEntity();
                userEntity.Id = Guid.NewGuid();
                userEntity.ImgPerfil = "aggdjsgfdsjfds.png";
                userEntity.Tipo = typeUsers.Cliente;
                var inserir = _user.Post(userEntity);
                return Ok(await _user.GetAll());
            }
            catch (ArgumentException ex) {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

    }
}
