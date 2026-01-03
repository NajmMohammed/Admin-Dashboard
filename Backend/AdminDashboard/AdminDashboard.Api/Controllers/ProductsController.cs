using AdminDashboard.Api.Data;
using AdminDashboard.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdminDashboard.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public ProductsController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = _dbContext.Products.ToList();
            return Ok(products);
        }
    }
}
