using System;
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
                    CustomerName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    CustomerPhone = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    CustomerEmail = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Status = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsCompleted = table.Column<bool>(type: "boolean", nullable: false)
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
                    Email = table.Column<string>(type: "text", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    Role = table.Column<int>(type: "integer", nullable: false),
                    ImageUrl = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "ImageUrl", "LastName", "PasswordHash", "Role" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 10, 8, 18, 9, 23, 88, DateTimeKind.Utc).AddTicks(4460), "test@gmail.com", "Test", "https://picsum.photos/id/64/200", "User", "$2a$11$kHZwgzIn.1zBKAcY751BAu.4.xUifrRPuaxcSErOo.WgpF14D4cCa", 1 },
                    { 2, new DateTime(2025, 10, 8, 18, 9, 23, 88, DateTimeKind.Utc).AddTicks(4510), "alice.johnson@example.com", "Alice", "https://picsum.photos/id/101/200", "Johnson", "$2a$11$kHZwgzIn.1zBKAcY751BAu.4.xUifrRPuaxcSErOo.WgpF14D4cCa", 1 },
                    { 3, new DateTime(2025, 10, 8, 18, 9, 23, 88, DateTimeKind.Utc).AddTicks(4560), "bob.smith@example.com", "Bob", "https://picsum.photos/id/102/200", "Smith", "$2a$11$kHZwgzIn.1zBKAcY751BAu.4.xUifrRPuaxcSErOo.WgpF14D4cCa", 1 },
                    { 4, new DateTime(2025, 10, 8, 18, 9, 23, 88, DateTimeKind.Utc).AddTicks(4580), "carol.davis@example.com", "Carol", "https://picsum.photos/id/103/200", "Davis", "$2a$11$kHZwgzIn.1zBKAcY751BAu.4.xUifrRPuaxcSErOo.WgpF14D4cCa", 0 },
                    { 5, new DateTime(2025, 10, 8, 18, 9, 23, 88, DateTimeKind.Utc).AddTicks(4580), "david.martinez@example.com", "David", "https://picsum.photos/id/104/200", "Martinez", "$2a$11$kHZwgzIn.1zBKAcY751BAu.4.xUifrRPuaxcSErOo.WgpF14D4cCa", 0 }
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
