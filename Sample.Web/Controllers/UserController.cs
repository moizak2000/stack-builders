using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sample.Entity;
using Sample.Service.Contracts;

namespace Sample.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<User>> Insert()
        {
            var user = new User { UserId = 1, FirstName = "Moiz", LastName = "Akhter", Email = "moizak2000@yahoo.com", CreatationDate = DateTime.UtcNow };
            return await _userService.AddAsyn(user);

        }
    }
}