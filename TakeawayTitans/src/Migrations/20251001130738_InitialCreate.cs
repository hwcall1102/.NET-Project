using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TakeawayTitans.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MenuItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    Description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    ImageUrl = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CustomerName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CustomerPhone = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    CustomerEmail = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Status = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    LName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Username = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OrderId = table.Column<int>(type: "integer", nullable: false),
                    MenuItemId = table.Column<int>(type: "integer", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    Customization = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_MenuItems_MenuItemId",
                        column: x => x.MenuItemId,
                        principalTable: "MenuItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Crisp romaine with Caesar dressing.", "https://example.com/caesar-salad.jpg", "Caesar Salad", 7.25m },
                    { 2, "Tomatoes, cucumbers, feta, and olives.", "https://example.com/greek-salad.jpg", "Greek Salad", 7.50m },
                    { 3, "Fresh mixed greens with seasonal veggies.", "https://example.com/garden-salad.jpg", "Garden Salad", 6.99m },
                    { 4, "Baby spinach, strawberries, and almonds.", "https://example.com/spinach-salad.jpg", "Spinach Salad", 7.75m },
                    { 5, "Chicken, bacon, avocado, egg, and blue cheese.", "https://example.com/cobb-salad.jpg", "Cobb Salad", 8.50m },
                    { 6, "Fresh strawberries blended with yogurt.", "https://example.com/strawberry-smoothie.jpg", "Strawberry Smoothie", 5.50m },
                    { 7, "Ripe mangoes with orange juice.", "https://example.com/mango-smoothie.jpg", "Mango Smoothie", 5.75m },
                    { 8, "Banana, milk, and honey.", "https://example.com/banana-smoothie.jpg", "Banana Smoothie", 5.25m },
                    { 9, "Spinach, kale, apple, and banana.", "https://example.com/green-smoothie.jpg", "Green Smoothie", 6.00m },
                    { 10, "Mixed berries blended with yogurt.", "https://example.com/berry-blast-smoothie.jpg", "Berry Blast Smoothie", 6.25m }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FName", "LName", "Password", "Type", "Username" },
                values: new object[,]
                {
                    { 1, "Alice", "Johnson", "password", "admin", "admin1" },
                    { 2, "Bob", "Smith", "password", "admin", "admin2" },
                    { 3, "Carol", "Davis", "password", "admin", "admin3" },
                    { 4, "David", "Martinez", "password", "admin", "admin4" },
                    { 5, "Emma", "Wilson", "password", "admin", "admin5" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_MenuItemId",
                table: "OrderItems",
                column: "MenuItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "MenuItems");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
