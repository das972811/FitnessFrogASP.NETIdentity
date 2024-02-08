using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitnessFrogDb.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "Entry",
                type: "varchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldMaxLength: 200);

            migrationBuilder.InsertData(
                table: "Activity",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Basketball" },
                    { 2, "Biking" },
                    { 3, "Hiking" },
                    { 4, "Kayaking" },
                    { 5, "Pokemon Go" },
                    { 6, "Running" },
                    { 7, "Skiing" },
                    { 8, "Swimming" },
                    { 9, "Walking" },
                    { 10, "Weight Lifting" }
                });

            migrationBuilder.InsertData(
                table: "Entry",
                columns: new[] { "Id", "ActivityId", "Date", "Duration", "Exclude", "Intensity", "Notes" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.2m, false, 2, null },
                    { 2, 3, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 123.0m, false, 2, null },
                    { 3, 2, new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 32.2m, false, 2, null },
                    { 4, 9, new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.6m, false, 2, null },
                    { 5, 2, new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.2m, false, 2, null },
                    { 6, 2, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.2m, false, 2, null },
                    { 7, 9, new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 22.2m, false, 2, null },
                    { 8, 2, new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 17.0m, false, 2, null },
                    { 9, 5, new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.2m, false, 2, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Entry",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Entry",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Entry",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Entry",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Entry",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Entry",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Entry",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Entry",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Entry",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "Entry",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldMaxLength: 200,
                oldNullable: true);
        }
    }
}
