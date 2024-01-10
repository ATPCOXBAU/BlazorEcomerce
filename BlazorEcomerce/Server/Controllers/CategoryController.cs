using BlazorEcomerce.Server.Services.CategoryService;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEcomerce.Server.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {


        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;

        }

        [HttpGet]
        public async Task<ServiceResponse<List<Category>>> GetCategories()
        {

            var result = await _categoryService.GetCategories();
            return result;
        }

        [HttpGet]
        [Route("ById")]
        public async Task<ServiceResponse<List<Product>>> GetProductsByCategory(int Id)
        {
            var result = await _categoryService.GetProductsByCategory(Id);
            return result;
        }

    }
}
