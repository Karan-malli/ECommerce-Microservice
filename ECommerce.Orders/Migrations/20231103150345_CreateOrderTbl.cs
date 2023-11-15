using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ECommerce.Orders.Migrations
{
    /// <inheritdoc />
    public partial class CreateOrderTbl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OrderItem_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "ID", "CustomerID", "OrderDate", "TotalPrice" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 11, 3, 8, 3, 44, 879, DateTimeKind.Local).AddTicks(1479), 100m },
                    { 2, 1, new DateTime(2023, 11, 2, 8, 3, 44, 879, DateTimeKind.Local).AddTicks(1531), 100m },
                    { 3, 2, new DateTime(2023, 11, 3, 8, 3, 44, 879, DateTimeKind.Local).AddTicks(1537), 100m }
                });

            migrationBuilder.InsertData(
                table: "OrderItem",
                columns: new[] { "ID", "OrderID", "Price", "ProductID", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 10m, 1, 10 },
                    { 2, 1, 20m, 2, 20 },
                    { 3, 1, 30m, 3, 30 },
                    { 4, 2, 210m, 2, 2 },
                    { 5, 3, 310m, 3, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderID",
                table: "OrderItem",
                column: "OrderID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
