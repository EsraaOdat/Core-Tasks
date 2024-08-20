using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CoreTask_.Models;  // Ensure you include the namespace where your models and context are defined

namespace CoreTask_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ECommerceContext _dbContext;  // Use your specific DbContext

        public ProductsController(ECommerceContext context)
        {
            _dbContext = context;
        }

        [HttpGet("getAllProducts")]
        public IActionResult GetAllProducts()
        {
            var products = _dbContext.Products.ToList();
            return Ok(products);
        }

        [HttpGet("GetProductById/{id}")]
        public IActionResult GetProductById(int id)
        {
            var product = _dbContext.Products.Find(id);
            if (product == null)
            {
                return NotFound();  // Return 404 if the product is not found
            }
            return Ok(product);
        }
    }
}
