using Microsoft.AspNetCore.Mvc;
using IdetityAjax.Repositories;
using IdetityAjax.BOs;

namespace IdetityAjax.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private IProductRepository repo = new ProductRepository();

        [HttpGet]
        public ActionResult<IEnumerable<Category>> GetProducts() => (repo.GetCategories());
    }
}
