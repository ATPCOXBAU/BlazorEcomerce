namespace BlazorEcomerce.Server.Services.ProductService
{
    public interface IProductService
    {
        Task<ServiceResponse<Product>> GetProductById(int Id);
        Task<ServiceResponse<List<Product>>> GetProductsAsync();
    }
}
