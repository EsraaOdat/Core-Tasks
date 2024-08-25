using core11.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace core11.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private readonly MyDbContext _db;
        public ValuesController(MyDbContext db)
        {
            _db = db;
                
        }


        [HttpGet]
        public IActionResult Get()
        {

            var x = _db.Categories.ToList();
            return Ok(x);
        }
    }
}
