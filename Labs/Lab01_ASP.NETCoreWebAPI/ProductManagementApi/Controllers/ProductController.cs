using BusinessObjects;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace ProductManagementApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private IProductRepository _productRepository = new ProductRepository();

    [HttpGet]
    public ActionResult<IEnumerable<Products>> GetProducts()
    {
        return _productRepository.GetProducts();
    }
    
    [HttpPost]
    public IActionResult PostProduct(Products p)
    {
         _productRepository.SaveProduct(p);
         return Ok();
    }
    
    [HttpDelete("id")]
    public IActionResult DeleteProduct(int id)
    {
        var product = _productRepository.GetProductsById(id);
        if (product == null)
        {
            return NotFound();
        }
        _productRepository.DeleteProduct(product);
        return Ok();
    }
      
    [HttpPut("id")]
    public IActionResult UpdateProduct(int id, Products p)
    {
        var product = _productRepository.GetProductsById(id);
        if (product == null)
        {
            return NotFound();
        }
        _productRepository.UpdateProduct(p);
        return Ok();
    }
}