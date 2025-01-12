﻿using Microsoft.AspNetCore.Mvc;
using sna_Data.Entities;
using sna_Data.Services;

namespace sna_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController(UserService service) : ControllerBase
    {
        [HttpGet]
        public List<User> GetUser()
        {
            return service.GetAll();
        }
    }
}
