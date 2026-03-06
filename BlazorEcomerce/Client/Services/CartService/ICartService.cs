namespace BlazorEcomerce.Client.Services.CartService
{
    public interface ICartService
    {
        event Action OnChange;
        Task<List<CartItem>> GetCartItems();
        Task AddToCart(Product product);
        Task RemoveFromCart(int productId);
        Task UpdateQuantity(int productId, int quantity);
        Task<bool> IsInCart(int productId);
        Task<int> GetCartCount();
        Task<double> GetCartTotal();
        Task ClearCart();
    }
}
