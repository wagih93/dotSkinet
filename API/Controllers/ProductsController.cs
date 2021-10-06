using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
//using API.Models;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext _context;
        public ProductsController(StoreContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts() => await _context.Products.ToListAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProductById(int id) => await _context.Products.FindAsync(id);
     

        [HttpPost("")]
        public ActionResult<Product> PostProduct(Product product)
        {
            return null;
        }

        [HttpPut("{id}")]
        public IActionResult PutProduct(int id, Product product)
        {
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult<Product> DeleteProductsById(int id)
        {
            return null;
        }
    }
}