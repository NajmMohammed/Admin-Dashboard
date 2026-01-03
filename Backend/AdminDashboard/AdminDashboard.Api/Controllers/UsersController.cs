using AdminDashboard.Api.Data;
using AdminDashboard.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdminDashboard.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public UsersController( AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = _dbContext.Users.ToList();
            return Ok(users);
        }

    }
}
