namespace BlazorEcomerce.Client.Services.ProductService
{
    public interface IProductService
    {
        List<Product> Products { get; set; } 
 
        Task<ServiceResponse<Product>> GetProductById(int Id);
        Task GetProducts();
    }
}
