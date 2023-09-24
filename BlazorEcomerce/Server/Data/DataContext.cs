

namespace BlazorEcomerce.Server.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options)
        { 

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Epson, LQ-590II, Impresora Matriz De Punto Para Entornos De Impresión Exigentes",
                    Description = "La serie Epson LQ-590II ofrece la durabilidad y la facilidad de uso para requisitos críticos de impresión diaria.",
                    ImageUrl = @$"https://electronicapanamericana.com/wp-content/uploads/L3210.jpg",
                    Price = 3090m

                },
            new Product
            {
                Id = 2,
                Title = "Tablet Apple IPad 9, De 10.2 Pulgadas, 64GB, WiFi, Pantalla Retina, Multitouch",
                Description = "Marca: Appple",
                ImageUrl = @$"https://ishop.gt/cdn/shop/products/Sin_titulo_2_4c515b86-0190-4695-9343-fe1e0668e962_1200x.jpg?v=1669418179",
                Price = 2899m

            },
            new Product
            {
                Id = 3,
                Title = "Tablet Apple IPad 9, De 10.2 Pulgadas, 64GB, WiFi, Pantalla Retina, Multitouch",
                Description = "Marca: Appple",
                ImageUrl = @$"https://ishop.gt/cdn/shop/products/Sin_titulo_2_4c515b86-0190-4695-9343-fe1e0668e962_1200x.jpg?v=1669418179",
                Price = 2899m

            },
            new Product
            {
                Id = 4,
                Title = "Consola Nintendo Switch Neon Version 2, JoyCon Azul/Rojo",
                Description = "Nintendo Switch combina la potencia de una consola para el hogar con la movilidad de una consola portátil. Una nueva era para los videojuegos que te ofrece nuevas maneras de jugar, donde quieras, como quieras, cuando quieras.",
                ImageUrl = @$"https://assets.nintendo.com/image/upload/f_auto/q_auto/dpr_2.0/c_scale,w_400/ncom/en_US/switch/split-cta-system",
                Price = 3324m

            } );
        }
        public DbSet<Product> Products { get; set; }
    }
}
