using AutoMapper;
using BusinessObjects.Dtos;
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


        private readonly IMapper _mapper;

        public ProductsController(IMapper mapper)
        {
            _mapper = mapper;
        }

        //Get: api/Products
        [HttpGet]
        public List<ProductDto> GetProducts() => _mapper.Map<List<ProductDto>>(repo.GetProducts());



        //Post :ProductsController/Products
        [HttpPost]
        public IActionResult PostProduct( Product product)
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
        public IActionResult UpdateProduct(int id, Product product)
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
