namespace BlazorEcomerce.Server.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<ServiceResponse<List<Category>>> GetCategories();
        Task<ServiceResponse<List<Product?>>> GetProductsByCategory( int id);
    }
}
