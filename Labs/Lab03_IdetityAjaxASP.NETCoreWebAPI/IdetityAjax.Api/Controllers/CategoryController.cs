using Microsoft.AspNetCore.Mvc;
using IdetityAjax.Repositories;
using IdetityAjax.BOs;
using BusinessObjects.Dtos;
using AutoMapper;

namespace IdetityAjax.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private IProductRepository productsRepository = new ProductRepository();

        private readonly IMapper _mapper;

        public CategoryController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public List<CategoryDto> GetProducts() => _mapper.Map<List<CategoryDto>>(productsRepository.GetCategories());
    }
}
