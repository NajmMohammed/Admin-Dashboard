using AdminDashboard.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdminDashboard.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = new List<User>
            {
                new User { Id = 1 , Email = "Admin@test.com" , Role = Role.admin },
                new User { Id = 2 , Email = "user@test.com" , Role = Role.user }
            };
            return Ok(users);

        }
    }
}
