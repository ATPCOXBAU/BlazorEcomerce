﻿using System;
using System.Collections.Generic;

namespace BlazorEcomerce.Shared;

public partial class Product
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public string? ImageUrl { get; set; }

    public double? Price { get; set; }

    public int? CategoryId { get; set; }

    public virtual Category? Category { get; set; }
}
