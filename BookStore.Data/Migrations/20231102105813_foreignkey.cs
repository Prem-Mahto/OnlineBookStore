using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStore.Data.Migrations
{
    /// <inheritdoc />
    public partial class foreignkey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Payment_OrderID",
                table: "Payment",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_BookID",
                table: "OrderItem",
                column: "BookID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderID",
                table: "OrderItem",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_UserID",
                table: "Order",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Book_GenreID",
                table: "Book",
                column: "GenreID");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Genre_GenreID",
                table: "Book",
                column: "GenreID",
                principalTable: "Genre",
                principalColumn: "GenreID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_User_UserID",
                table: "Order",
                column: "UserID",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Book_BookID",
                table: "OrderItem",
                column: "BookID",
                principalTable: "Book",
                principalColumn: "BookID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Order_OrderID",
                table: "OrderItem",
                column: "OrderID",
                principalTable: "Order",
                principalColumn: "OrderID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Order_OrderID",
                table: "Payment",
                column: "OrderID",
                principalTable: "Order",
                principalColumn: "OrderID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Genre_GenreID",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_User_UserID",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Book_BookID",
                table: "OrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Order_OrderID",
                table: "OrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Order_OrderID",
                table: "Payment");

            migrationBuilder.DropIndex(
                name: "IX_Payment_OrderID",
                table: "Payment");

            migrationBuilder.DropIndex(
                name: "IX_OrderItem_BookID",
                table: "OrderItem");

            migrationBuilder.DropIndex(
                name: "IX_OrderItem_OrderID",
                table: "OrderItem");

            migrationBuilder.DropIndex(
                name: "IX_Order_UserID",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Book_GenreID",
                table: "Book");
        }
    }
}
