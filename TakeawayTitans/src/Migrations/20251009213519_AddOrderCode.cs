using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TakeawayTitans.Migrations
{
    /// <inheritdoc />
    public partial class AddOrderCode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OrderCode",
                table: "Orders",
                type: "character varying(4)",
                maxLength: 4,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderCode",
                value: "4821");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderCode",
                value: "1734");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "OrderCode",
                value: "9056");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4,
                column: "OrderCode",
                value: "6243");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5,
                column: "OrderCode",
                value: "2189");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 10, 9, 21, 35, 18, 928, DateTimeKind.Utc).AddTicks(5000), "$2a$11$zn/p2depDN/E3UmHU.ZK6ua9K5rxSiSDXyi1UerVx.IW5yYQT.AOe" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 10, 9, 21, 35, 18, 928, DateTimeKind.Utc).AddTicks(5000), "$2a$11$zn/p2depDN/E3UmHU.ZK6ua9K5rxSiSDXyi1UerVx.IW5yYQT.AOe" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 10, 9, 21, 35, 18, 928, DateTimeKind.Utc).AddTicks(5010), "$2a$11$zn/p2depDN/E3UmHU.ZK6ua9K5rxSiSDXyi1UerVx.IW5yYQT.AOe" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 10, 9, 21, 35, 18, 928, DateTimeKind.Utc).AddTicks(5010), "$2a$11$zn/p2depDN/E3UmHU.ZK6ua9K5rxSiSDXyi1UerVx.IW5yYQT.AOe" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 10, 9, 21, 35, 18, 928, DateTimeKind.Utc).AddTicks(5020), "$2a$11$zn/p2depDN/E3UmHU.ZK6ua9K5rxSiSDXyi1UerVx.IW5yYQT.AOe" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderCode",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 10, 9, 20, 56, 41, 848, DateTimeKind.Utc).AddTicks(140), "$2a$11$e6NGDp1tYhMxmAJOyqgl2eIG5WSYdESXpLFFlrMvvHWCIsGItW/6W" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 10, 9, 20, 56, 41, 848, DateTimeKind.Utc).AddTicks(150), "$2a$11$e6NGDp1tYhMxmAJOyqgl2eIG5WSYdESXpLFFlrMvvHWCIsGItW/6W" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 10, 9, 20, 56, 41, 848, DateTimeKind.Utc).AddTicks(150), "$2a$11$e6NGDp1tYhMxmAJOyqgl2eIG5WSYdESXpLFFlrMvvHWCIsGItW/6W" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 10, 9, 20, 56, 41, 848, DateTimeKind.Utc).AddTicks(150), "$2a$11$e6NGDp1tYhMxmAJOyqgl2eIG5WSYdESXpLFFlrMvvHWCIsGItW/6W" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 10, 9, 20, 56, 41, 848, DateTimeKind.Utc).AddTicks(160), "$2a$11$e6NGDp1tYhMxmAJOyqgl2eIG5WSYdESXpLFFlrMvvHWCIsGItW/6W" });
        }
    }
}
