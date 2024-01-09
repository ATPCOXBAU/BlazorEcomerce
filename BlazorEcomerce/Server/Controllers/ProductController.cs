using BlazorEcomerce.Server.Services.ProductService;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEcomerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService) {
            _productService = productService;
            
        }  
        [HttpGet]
        public async Task<ServiceResponse<List<Product>>> GetProduct()
        {
            var result = await _productService.GetProductsAsync();
            return result;
        }

        [HttpGet]
        [Route ("ById")]
        public async Task<ServiceResponse<Product>> GetProductId(int Id)
        {
            var result = await _productService.GetProductById(Id);
            return result;
        }
    }
}
