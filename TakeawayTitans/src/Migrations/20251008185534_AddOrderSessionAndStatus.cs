using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TakeawayTitans.Migrations
{
    /// <inheritdoc />
    public partial class AddOrderSessionAndStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SessionId",
                table: "Orders",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SessionId",
                table: "Orders");

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
    }
}
