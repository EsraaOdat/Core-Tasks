using CoreTask_.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoreTask_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ECommerceContext _dbContext;

        public CategoriesController(ECommerceContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet("getAllCategories")]
        public IActionResult  GetAllCategories()
        {
            return Ok( _dbContext.Categories.ToList());
        }

        [HttpGet("GetCategoryById/{id}")]
        public IActionResult GetCategoryById(int id)
        {
            var category = _dbContext.Categories.Find(id);
            if (category == null)
            {
                return NotFound(); // Return 404 if category is not found
            }
            return Ok(category);
        }

    }
}

