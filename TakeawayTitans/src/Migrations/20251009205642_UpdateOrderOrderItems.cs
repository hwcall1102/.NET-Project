using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TakeawayTitans.Migrations
{
    /// <inheritdoc />
    public partial class UpdateOrderOrderItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCompleted",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "SessionId",
                table: "Orders");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Orders",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "Received",
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldMaxLength: 20);

            migrationBuilder.AddColumn<DateTime>(
                name: "CanceledAt",
                table: "Orders",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CompletedAt",
                table: "Orders",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PreparingAt",
                table: "Orders",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReadyAt",
                table: "Orders",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReceivedAt",
                table: "Orders",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Customization",
                table: "OrderItems",
                type: "character varying(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "CanceledAt", "CompletedAt", "CreatedAt", "CustomerEmail", "CustomerName", "CustomerPhone", "PreparingAt", "ReadyAt", "ReceivedAt" },
                values: new object[] { 1, null, null, new DateTime(2025, 10, 3, 10, 0, 0, 0, DateTimeKind.Utc), "morgan.park@example.com", "Morgan Park", "555-0912", null, null, new DateTime(2025, 10, 3, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "CanceledAt", "CompletedAt", "CreatedAt", "CustomerEmail", "CustomerName", "CustomerPhone", "PreparingAt", "ReadyAt", "ReceivedAt", "Status" },
                values: new object[,]
                {
                    { 2, null, null, new DateTime(2025, 10, 1, 15, 30, 0, 0, DateTimeKind.Utc), "jamie.johnson@example.com", "Jamie Johnson", "555-0134", new DateTime(2025, 10, 1, 15, 30, 0, 0, DateTimeKind.Utc), null, new DateTime(2025, 10, 1, 15, 15, 0, 0, DateTimeKind.Utc), "Preparing" },
                    { 3, null, null, new DateTime(2025, 10, 2, 11, 15, 0, 0, DateTimeKind.Utc), "taylor.nguyen@example.com", "Taylor Nguyen", "555-0456", new DateTime(2025, 10, 2, 11, 5, 0, 0, DateTimeKind.Utc), new DateTime(2025, 10, 2, 11, 15, 0, 0, DateTimeKind.Utc), new DateTime(2025, 10, 2, 11, 0, 0, 0, DateTimeKind.Utc), "Ready" },
                    { 4, null, new DateTime(2025, 10, 3, 11, 30, 0, 0, DateTimeKind.Utc), new DateTime(2025, 10, 3, 11, 30, 0, 0, DateTimeKind.Utc), "riley.santos@example.com", "Riley Santos", "555-0933", new DateTime(2025, 10, 3, 11, 15, 0, 0, DateTimeKind.Utc), new DateTime(2025, 10, 3, 11, 25, 0, 0, DateTimeKind.Utc), new DateTime(2025, 10, 3, 11, 10, 0, 0, DateTimeKind.Utc), "Completed" },
                    { 5, new DateTime(2025, 10, 3, 12, 45, 0, 0, DateTimeKind.Utc), null, new DateTime(2025, 10, 3, 12, 45, 0, 0, DateTimeKind.Utc), "jordan.lee@example.com", "Jordan Lee", "555-0977", new DateTime(2025, 10, 3, 12, 35, 0, 0, DateTimeKind.Utc), null, new DateTime(2025, 10, 3, 12, 30, 0, 0, DateTimeKind.Utc), "Canceled" }
                });

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

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Customization", "MenuItemId", "OrderId", "Quantity" },
                values: new object[,]
                {
                    { 1, "No croutons", 1, 1, 2 },
                    { 2, "Extra strawberries", 6, 1, 1 },
                    { 3, "Add grilled chicken", 4, 2, 1 },
                    { 4, null, 9, 2, 2 },
                    { 5, "Light dressing", 1, 3, 1 },
                    { 6, null, 9, 3, 2 },
                    { 7, "No onions", 4, 4, 1 },
                    { 8, "Extra strawberries", 6, 4, 1 },
                    { 9, "No croutons", 1, 5, 1 },
                    { 10, "Add grilled chicken", 4, 5, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "CanceledAt",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CompletedAt",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PreparingAt",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ReadyAt",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ReceivedAt",
                table: "Orders");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Orders",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldMaxLength: 20,
                oldDefaultValue: "Received");

            migrationBuilder.AddColumn<bool>(
                name: "IsCompleted",
                table: "Orders",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SessionId",
                table: "Orders",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Customization",
                table: "OrderItems",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 10, 8, 18, 55, 31, 679, DateTimeKind.Utc).AddTicks(3870), "$2a$11$LM5NJRQk71/OmMCvNtiTi.6hfPXgCRG9tjh6VTV7vrsFhLFGoFI4u" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 10, 8, 18, 55, 31, 679, DateTimeKind.Utc).AddTicks(3880), "$2a$11$LM5NJRQk71/OmMCvNtiTi.6hfPXgCRG9tjh6VTV7vrsFhLFGoFI4u" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 10, 8, 18, 55, 31, 679, DateTimeKind.Utc).AddTicks(3910), "$2a$11$LM5NJRQk71/OmMCvNtiTi.6hfPXgCRG9tjh6VTV7vrsFhLFGoFI4u" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 10, 8, 18, 55, 31, 679, DateTimeKind.Utc).AddTicks(3930), "$2a$11$LM5NJRQk71/OmMCvNtiTi.6hfPXgCRG9tjh6VTV7vrsFhLFGoFI4u" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 10, 8, 18, 55, 31, 679, DateTimeKind.Utc).AddTicks(3930), "$2a$11$LM5NJRQk71/OmMCvNtiTi.6hfPXgCRG9tjh6VTV7vrsFhLFGoFI4u" });
        }
    }
}
