using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorEcomerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class ProductSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "La serie Epson LQ-590II ofrece la durabilidad y la facilidad de uso para requisitos críticos de impresión diaria.", "https://electronicapanamericana.com/wp-content/uploads/L3210.jpg", 3090m, "Epson, LQ-590II, Impresora Matriz De Punto Para Entornos De Impresión Exigentes" },
                    { 2, "Marca: Appple", "https://ishop.gt/cdn/shop/products/Sin_titulo_2_4c515b86-0190-4695-9343-fe1e0668e962_1200x.jpg?v=1669418179", 2899m, "Tablet Apple IPad 9, De 10.2 Pulgadas, 64GB, WiFi, Pantalla Retina, Multitouch" },
                    { 3, "Marca: Appple", "https://ishop.gt/cdn/shop/products/Sin_titulo_2_4c515b86-0190-4695-9343-fe1e0668e962_1200x.jpg?v=1669418179", 2899m, "Tablet Apple IPad 9, De 10.2 Pulgadas, 64GB, WiFi, Pantalla Retina, Multitouch" },
                    { 4, "Nintendo Switch combina la potencia de una consola para el hogar con la movilidad de una consola portátil. Una nueva era para los videojuegos que te ofrece nuevas maneras de jugar, donde quieras, como quieras, cuando quieras.", "https://assets.nintendo.com/image/upload/f_auto/q_auto/dpr_2.0/c_scale,w_400/ncom/en_US/switch/split-cta-system", 3324m, "Consola Nintendo Switch Neon Version 2, JoyCon Azul/Rojo" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
