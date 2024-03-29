﻿namespace BlazorEcomerce.Client.Services.CategoryService
{
    public interface ICategoryService
    {
        List<Category> Categories { get; set; }
        Task GetCategories();

        Task<ServiceResponse<List<Product>>> GetProductsByCategory(int id);

    }
}
