
using BlazorEcomerce.Shared;

namespace BlazorEcomerce.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService

    {
        private readonly HttpClient http;

        public CategoryService(HttpClient http)
        {
            this.http = http;
        }

        public List<Category> Categories { get; set; } = new List<Category>();

        public async Task GetCategories()
        {
            var result =
                await http.GetFromJsonAsync<ServiceResponse<List<Category>>>("api/category");
            if (result != null && result.Data != null)
            {
                Categories = result.Data;
            }
        }

        public async  Task<List<Product>?> GetProductsByCategory(int id)
        {
            var result = await http.GetFromJsonAsync<ServiceResponse<List<Product>>>($"api/category/ById?Id={id}");
            if (result != null && result.Data != null)
            {
                return result.Data;
            }
            else
            {
                return null;
            }
        }
    }
}
