

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
        public Product Product { get; set; } = new Product();
        

        public async Task<ServiceResponse<Product>> GetProductById(int Id)
        {
            var result =
                   await http.GetFromJsonAsync<ServiceResponse<Product>>("api/product/ById?Id=" + Id );
            return result;
        }

        public async Task GetProducts()
        {
            var result =
                await http.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product");
            if (result!= null && result.Data != null)
            {
                Products = result.Data;
            }
          
           
        }
    }
}
