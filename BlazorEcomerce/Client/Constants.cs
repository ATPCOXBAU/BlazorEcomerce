namespace BlazorEcomerce.Client
{
    public static class ApiRoutes
    {
        public const string Products = "api/product";
        public const string ProductById = "api/product/ById?Id=";
        public const string ProductSearch = "api/product/search/";
        public const string Categories = "api/category";
        public const string ProductsByCategory = "api/category/ById?Id=";
    }

    public static class StorageKeys
    {
        public const string Cart = "cart";
    }
}
