using IdetityAjax.BOs;
using IdetityAjax.Repositories;
using Microsoft.AspNetCore.Mvc;


namespace IdetityAjax.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductRepository repo = new ProductRepository();


        //Get: api/Products
        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts() => (repo.GetProducts());


        //Post :ProductsController/Products
        [HttpPost]
        public IActionResult PostProduct([FromBody] Product product)
        {
           
            repo.SaveProduct(product);
            return NoContent();
        }

        //Get: ProductsController/Delete/5
        [HttpDelete("id")]
        public IActionResult DeleteProduct(int id)
        {
            var product = repo.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }
            repo.DeleteProduct(product);
            return NoContent();
        }


        //Get: ProductsController/Delete/5
        [HttpPut("id")]
        public IActionResult UpdateProduct(int id, [FromBody] Product product)
        {
            var p = repo.GetProductById(id);
            if (p == null)
            {
                return NotFound();
            }
            repo.UpdateProduct(p);
            return NoContent();
        }

    }
}
