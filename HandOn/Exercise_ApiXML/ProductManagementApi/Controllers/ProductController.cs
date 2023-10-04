using BusinessObjects;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace ProductManagementApi.Controllers;

[Route("api/product/[action]")]
[ApiController]
public class ProductsControllers : ControllerBase
{
    private IProductRepository repository = new ProductRepository();

    [HttpGet]
    [Produces("application/xml")]
    public ActionResult<IEnumerable<Product>> GetProducts()
    {
     return   repository.GetProducts();
    }

    [HttpGet]
    [Produces("application/xml")]
    public ActionResult<IEnumerable<Category>> GetCategories() => repository.GetCategories();

    [HttpGet("id")]
    [Produces("application/xml")]
    public ActionResult<Product> GetProductById(int id) => repository.GetProductById(id);

    [HttpPost]
    public IActionResult PostProduct(Product p)
    {
        var product = repository.GetProductById(p.ProductId);
        if (p == null)
        {
            return NoContent();
        }
        repository.SaveProduct(p);
        return NoContent();
    }

    [HttpDelete("id")]
    public IActionResult DeleteProduct(int id)
    {
        var p = repository.GetProductById(id);
        if (p == null)
        {
            return NotFound();
        }

        repository.DeleteProduct(p);
        return NoContent();
    }

    [HttpPut("id")]
    public IActionResult UpdateProduct(int id, Product p)
    {
        var pTmp = repository.GetProductById(id);
        if (p == null)
        {
            return NotFound();
        }

        repository.UpdateProduct(p);
        return NoContent();
    }
}
