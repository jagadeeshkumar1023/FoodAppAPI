using FoodAppAPI.Data;
using FoodAppAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace FoodAppAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FoodController : ControllerBase
    {
        private readonly AppDbContext _context;

        public FoodController(AppDbContext context)
        {
            _context = context;
        }
        
        
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_context.FoodItems.ToList());
        }

        [HttpPost]
        public IActionResult Add(FoodItem Food)
        {
            _context.FoodItems.Add(Food);
            _context.SaveChanges();
            return Ok(Food);
        }
    }
}
