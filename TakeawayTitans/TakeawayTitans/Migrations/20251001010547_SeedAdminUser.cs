using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TakeawayTitans.Migrations
{
    /// <inheritdoc />
    public partial class SeedAdminUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "ImageUrl", "LastName", "PasswordHash", "Role" },
                values: new object[] { new Guid("1d552dd2-5ace-4314-ba51-2795d2d2584a"), new DateTime(2025, 10, 1, 1, 5, 47, 369, DateTimeKind.Utc).AddTicks(1640), "test@gmail.com", "Test", "https://picsum.photos/id/64/200", "User", "$2a$11$pOUbOI0hMwLbfPj9m31Kw.VoTLcW0BaizL0yoMdztlr.1nyUVb3we", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1d552dd2-5ace-4314-ba51-2795d2d2584a"));
        }
    }
}
