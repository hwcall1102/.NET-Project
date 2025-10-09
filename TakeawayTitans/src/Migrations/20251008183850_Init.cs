using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TakeawayTitans.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/8251537/pexels-photo-8251537.jpeg");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://www.cookipedia.co.uk/wiki/images/8/87/Greek_salad_recipe.jpg");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQmzYDNf1qIDSjvZLHCi98piiao6gi6K7ZIyw&s");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/c/c4/Salad_with_strawberries.jpg");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://images.stockcake.com/public/6/f/6/6f6293cf-b710-40e3-b0c6-af329f49c182/hearty-cobb-salad-stockcake.jpg");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/8169597/pexels-photo-8169597.jpeg");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQEg03LIorRnJYimTc6rQ0rLUd_B9RrKp0GnA&s");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "https://images.rawpixel.com/image_social_landscape/czNmcy1wcml2YXRlL3Jhd3BpeGVsX2ltYWdlcy93ZWJzaXRlX2NvbnRlbnQvbHIvaXMxMTA0NS1pbWFnZS1rd3lzaTYwZC5qcGc.jpg");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "https://i1.pickpik.com/photos/153/22/476/green-smoothie-drink-healthy-preview.jpg");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "https://i1.pickpik.com/photos/585/986/375/smoothie-milkshake-mixed-berry-preview.jpg");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 10, 8, 18, 38, 49, 481, DateTimeKind.Utc).AddTicks(9230), "$2a$11$gxTGnjarIpLUg1pAet09WeyhxDpQpa4XdJGpS7ilCbLkD2g7HGTou" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 10, 8, 18, 38, 49, 481, DateTimeKind.Utc).AddTicks(9250), "$2a$11$gxTGnjarIpLUg1pAet09WeyhxDpQpa4XdJGpS7ilCbLkD2g7HGTou" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 10, 8, 18, 38, 49, 481, DateTimeKind.Utc).AddTicks(9290), "$2a$11$gxTGnjarIpLUg1pAet09WeyhxDpQpa4XdJGpS7ilCbLkD2g7HGTou" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 10, 8, 18, 38, 49, 481, DateTimeKind.Utc).AddTicks(9320), "$2a$11$gxTGnjarIpLUg1pAet09WeyhxDpQpa4XdJGpS7ilCbLkD2g7HGTou" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 10, 8, 18, 38, 49, 481, DateTimeKind.Utc).AddTicks(9320), "$2a$11$gxTGnjarIpLUg1pAet09WeyhxDpQpa4XdJGpS7ilCbLkD2g7HGTou" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://example.com/caesar-salad.jpg");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://example.com/greek-salad.jpg");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://example.com/garden-salad.jpg");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://example.com/spinach-salad.jpg");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://example.com/cobb-salad.jpg");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "https://example.com/strawberry-smoothie.jpg");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "https://example.com/mango-smoothie.jpg");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "https://example.com/banana-smoothie.jpg");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "https://example.com/green-smoothie.jpg");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "https://example.com/berry-blast-smoothie.jpg");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 10, 8, 18, 9, 23, 88, DateTimeKind.Utc).AddTicks(4460), "$2a$11$kHZwgzIn.1zBKAcY751BAu.4.xUifrRPuaxcSErOo.WgpF14D4cCa" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 10, 8, 18, 9, 23, 88, DateTimeKind.Utc).AddTicks(4510), "$2a$11$kHZwgzIn.1zBKAcY751BAu.4.xUifrRPuaxcSErOo.WgpF14D4cCa" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 10, 8, 18, 9, 23, 88, DateTimeKind.Utc).AddTicks(4560), "$2a$11$kHZwgzIn.1zBKAcY751BAu.4.xUifrRPuaxcSErOo.WgpF14D4cCa" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 10, 8, 18, 9, 23, 88, DateTimeKind.Utc).AddTicks(4580), "$2a$11$kHZwgzIn.1zBKAcY751BAu.4.xUifrRPuaxcSErOo.WgpF14D4cCa" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 10, 8, 18, 9, 23, 88, DateTimeKind.Utc).AddTicks(4580), "$2a$11$kHZwgzIn.1zBKAcY751BAu.4.xUifrRPuaxcSErOo.WgpF14D4cCa" });
        }
    }
}
