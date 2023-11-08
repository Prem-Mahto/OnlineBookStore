using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStore.Data.Migrations
{
    /// <inheritdoc />
    public partial class Seed_data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "GenreID", "GenreName" },
                values: new object[,]
                {
                    { 1, "Magazine" },
                    { 2, "Self-help" },
                    { 3, "Romantic" },
                    { 4, "Mystery" },
                    { 5, "Lierature" }
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookID", "Author", "CoverImage", "Description", "GenreID", "ISBN", "Price", "PublicationDate", "Quantity", "Title" },
                values: new object[,]
                {
                    { 1, "Autocar", "/images/magazine/autocar-india-oct-2023.webp", "Autocar India Oct 2023 Magazine", 1, "101", 100m, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Autocar India Oct 2023 Magazine" },
                    { 2, "World 360", "/images/magazine/world-360-original.webp", "World 360 Magazine", 1, "102", 100m, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "World 360 Magazine" },
                    { 3, "Dubai", "/images/magazine/dubai-original.webp", "Dubai Magazine", 1, "103", 100m, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Dubai Magazine" },
                    { 4, "Galamour Era", "/images/magazine/glamaour-era-original.webp", "Galamour Era Magazine", 1, "104", 100m, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Galamour Era Magazine" },
                    { 5, "Agriculture Magazine", "/images/magazine/journal-of-eco-friendly-agriculture-original.webp", "Galamour Era Magazine", 1, "105", 100m, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Journal of Eco Friendly Agriculture Magazine" },
                    { 6, "Naruto", "/images/magazine/naruto-vol-38-original.webp", "Naruto Magazine", 1, "106", 100m, new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Naruto Magazine" },
                    { 7, "Agriculture Magazine", "/images/magazine/organic-sunrise-natural-original.webp", "Organic Sunrise Magazine Magazine", 1, "107", 100m, new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Organic Sunrise Magazine" },
                    { 8, "Pshycologs", "/images/magazine/psychologs-magazine-september-2023-original.webp", "Phycologs Magazine", 1, "108", 100m, new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Pshycologs Magazine" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 1);
        }
    }
}
