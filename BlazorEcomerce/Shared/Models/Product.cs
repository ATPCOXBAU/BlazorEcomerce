using System;
using System.Collections.Generic;

namespace BlazorEcomerce.Shared;

public partial class Product
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string ImageUrl { get; set; } = null!;

    public decimal Price { get; set; }
}
