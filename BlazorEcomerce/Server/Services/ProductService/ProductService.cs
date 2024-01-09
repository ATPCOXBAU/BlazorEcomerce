
using BlazorEcomerce.Server.Data;

namespace BlazorEcomerce.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;
        public ProductService(DataContext context)
        {
            _context = context;
            
        }

        public async Task<ServiceResponse<Product>> GetProductById(int Id)
        {
            var response = new ServiceResponse<Product>();
            var data = _context.Products.Where(p => p.Id == Id).FirstOrDefault();
    

            if (data != null)
            {
                response.Data = data;
            }
            else
            {
                response.Success = false;
                response.Message = "El producto no existe.";
            }
          
            return response;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
        {
            var response = new ServiceResponse<List<Product>> {
                Data = await _context.Products.ToListAsync()
            };
            return response;
        }
    }
}
