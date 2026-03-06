using Blazored.LocalStorage;

namespace BlazorEcomerce.Client.Services.CartService
{
    public class CartService : ICartService
    {
        private readonly ILocalStorageService _localStorage;
        private const string CartKey = "cart";

        public event Action OnChange;

        public CartService(ILocalStorageService localStorage)
        {
            _localStorage = localStorage;
        }

        public async Task<List<CartItem>> GetCartItems()
        {
            return await _localStorage.GetItemAsync<List<CartItem>>(CartKey) ?? new List<CartItem>();
        }

        public async Task AddToCart(Product product)
        {
            var cart = await GetCartItems();
            var existing = cart.FirstOrDefault(i => i.ProductId == product.Id);

            if (existing != null)
            {
                existing.Quantity++;
            }
            else
            {
                cart.Add(new CartItem
                {
                    ProductId = product.Id,
                    Title = product.Title,
                    ImageUrl = product.ImageUrl,
                    Price = product.Price ?? 0,
                    Quantity = 1
                });
            }

            await _localStorage.SetItemAsync(CartKey, cart);
            OnChange?.Invoke();
        }

        public async Task RemoveFromCart(int productId)
        {
            var cart = await GetCartItems();
            cart.RemoveAll(i => i.ProductId == productId);
            await _localStorage.SetItemAsync(CartKey, cart);
            OnChange?.Invoke();
        }

        public async Task UpdateQuantity(int productId, int quantity)
        {
            var cart = await GetCartItems();
            var item = cart.FirstOrDefault(i => i.ProductId == productId);
            if (item != null)
            {
                if (quantity <= 0)
                {
                    cart.Remove(item);
                }
                else
                {
                    item.Quantity = quantity;
                }
                await _localStorage.SetItemAsync(CartKey, cart);
                OnChange?.Invoke();
            }
        }

        public async Task<bool> IsInCart(int productId)
        {
            var cart = await GetCartItems();
            return cart.Any(i => i.ProductId == productId);
        }

        public async Task<int> GetCartCount()
        {
            var cart = await GetCartItems();
            return cart.Sum(i => i.Quantity);
        }

        public async Task<double> GetCartTotal()
        {
            var cart = await GetCartItems();
            return cart.Sum(i => i.Price * i.Quantity);
        }

        public async Task ClearCart()
        {
            await _localStorage.SetItemAsync(CartKey, new List<CartItem>());
            OnChange?.Invoke();
        }
    }
}
