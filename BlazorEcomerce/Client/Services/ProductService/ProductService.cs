

namespace BlazorEcomerce.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient http;

        public ProductService(HttpClient http)
        {
            this.http = http;
        }
        public  List<Product> Products { get; set; } = new List<Product>();
        

        public async Task<ServiceResponse<Product>> GetProductById(int Id)
        {
            var result =
                   await http.GetFromJsonAsync<ServiceResponse<Product>>(ApiRoutes.ProductById + Id);
            return result;
        }

        public async Task GetProducts()
        {
            var result =
                await http.GetFromJsonAsync<ServiceResponse<List<Product>>>(ApiRoutes.Products);
            if (result != null && result.Data != null)
            {
                Products = result.Data;
            }
        }

        public async Task SearchProducts(string searchText)
        {
            var result =
                await http.GetFromJsonAsync<ServiceResponse<List<Product>>>(ApiRoutes.ProductSearch + searchText);
            if (result != null && result.Data != null)
            {
                Products = result.Data;
            }
        }
    }
}
