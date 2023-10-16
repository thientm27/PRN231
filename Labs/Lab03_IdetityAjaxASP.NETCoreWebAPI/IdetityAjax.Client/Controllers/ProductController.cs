using System.Net.Http.Headers;
using System.Text.Json;
using IdetityAjax.BOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IdentityAjaxClient.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        private readonly HttpClient _httpClient;
        private string ProductApiUrl;
        private string CategoryApiUrl;

        public ProductController()
        {
            _httpClient = new HttpClient();
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            _httpClient.DefaultRequestHeaders.Accept.Add(contentType);
            ProductApiUrl = "https://localhost:7183/api/Products";
            CategoryApiUrl = "https://localhost:7183/api/Category";
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewData["Category"] = await GetCategories();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct([FromForm] Product product)
         {
            int categoryId = product.CategoryId;

            using (var respone = await _httpClient.PostAsJsonAsync(ProductApiUrl, product))
            {
                string apiResponse = await respone.Content.ReadAsStringAsync();
            }
            return Redirect("/Product/Index");
        }

        public async Task<IActionResult> EditProduct([FromForm] Product product)
        {
            using (var respone = await _httpClient.PutAsJsonAsync(ProductApiUrl + "/id?id=" + product.ProductId, product))
            {
                string apiResponse = await respone.Content.ReadAsStringAsync();
            }
            return Redirect("/Product/Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {

            ViewData["Category"] = await GetCategories();
            List<Product> products = await GetProducts();
            Product product = products.FirstOrDefault(p => p.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            List<Product> products = await GetProducts();
            Product product = products.FirstOrDefault(p => p.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);

        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            List<Product> products = await GetProducts();
            Product product = products.FirstOrDefault(p => p.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }
            String url = ProductApiUrl + "/id?id=" + id;
            await _httpClient.DeleteAsync(url);
            return Redirect("/Product/Index");
        }

        private async Task<List<Category>> GetCategories()
        {
            HttpResponseMessage response = await _httpClient.GetAsync(CategoryApiUrl);
            string strData = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            return JsonSerializer.Deserialize<List<Category>>(strData, options);
        }

        private async Task<List<Product>> GetProducts()
        {
            HttpResponseMessage response = await _httpClient.GetAsync(ProductApiUrl);
            string strData = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            return JsonSerializer.Deserialize<List<Product>>(strData, options);
        }
    }
}
