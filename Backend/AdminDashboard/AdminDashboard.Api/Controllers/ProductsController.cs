using AdminDashboard.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdminDashboard.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = new List<Product>
            {
                new Models.Product { Id = 1 , Name = "Product 1" , Description = "Description for Product 1" , Price = 10.99m , Stock = 100 },
                new Models.Product { Id = 2 , Name = "Product 2" , Description = "Description for Product 2" , Price = 20.99m , Stock = 50 }
            };
            return Ok(products);
        }
    }
}
