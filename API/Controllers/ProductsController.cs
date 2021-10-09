using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _repo;
        public ProductsController(IProductRepository repo)
        {
            _repo = repo;

        }

        [HttpGet("")]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            return Ok(await _repo.GetProductsAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProductById(int id)
        {
            return Ok(await _repo.GetProductByIdAsync(id));
        }


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