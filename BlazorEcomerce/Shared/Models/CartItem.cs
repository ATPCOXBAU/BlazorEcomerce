namespace BlazorEcomerce.Shared;

public class CartItem
{
    public int ProductId { get; set; }
    public string? Title { get; set; }
    public string? ImageUrl { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; } = 1;
}
