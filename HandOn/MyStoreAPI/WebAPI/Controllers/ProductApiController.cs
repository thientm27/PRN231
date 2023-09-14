using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Services;
using Services.Services;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductApiController : ControllerBase
    {
        IProductService productService = new ProductService();

        [HttpGet(Name = "GetProduct")]
        public IEnumerable<Product> Get()
        {
             return productService.Get().ToArray();
        }
    }
}
