
using BlazorEcomerce.Server.Data;

namespace BlazorEcomerce.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService

    {
        private readonly DataContext _context;
        public CategoryService(DataContext context)
        {
            _context = context;

        }

        public async Task<ServiceResponse<List<Category>>> GetCategories()
        {
            var response = new ServiceResponse<List<Category>>
            {
                Data = await _context.Categories.ToListAsync()
            };
            return response;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductsByCategory( int id)
        {
            var response = new ServiceResponse<List<Product>>
            {
                Data = await _context.Products.Where(p=> p.CategoryId == id).ToListAsync()
            };

            return response;
        }
    }
}
