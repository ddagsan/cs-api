using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brand",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brand", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Color",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Color", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    DiscountRatio = table.Column<double>(type: "float", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Brand_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brand",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_Color_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Color",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cart_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cart_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brand",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Samsung" },
                    { 2, "Nokia" },
                    { 3, "Apple" },
                    { 4, "LG" },
                    { 5, "Huawei" },
                    { 6, "Xiaomi" },
                    { 7, "General Mobile" },
                    { 8, "Oppo" },
                    { 9, "Vivo" },
                    { 10, "HTC" },
                    { 11, "Unknown" }
                });

            migrationBuilder.InsertData(
                table: "Color",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Lacivert" },
                    { 2, "Sarı" },
                    { 3, "Siyah" },
                    { 4, "Beyaz" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "BrandId", "ColorId", "DiscountRatio", "Name", "Price" },
                values: new object[,]
                {
                    { 12, 3, 1, 1.0, "Apple Telefon", 1000.0 },
                    { 1, 3, 4, 1.0, "Apple iPhone 11 Pro Maxi Phone 11 Pro Max iPhone 11 (Max 2 Line)", 1000.0 },
                    { 5, 1, 4, 1.0, "Samsung Telefon 1", 1000.0 },
                    { 8, 11, 4, 1.0, "Oppo Reno Telefon", 1000.0 },
                    { 11, 5, 4, 1.0, "Huawei Telefon", 1000.0 },
                    { 15, 11, 4, 1.0, "HTC Desire 20 Pro", 1000.0 },
                    { 18, 11, 4, 1.0, "HTC Telefon", 1000.0 },
                    { 22, 11, 4, 1.0, "General Mobile", 1000.0 },
                    { 29, 1, 3, 1.0, "Samsung Telefon", 1000.0 },
                    { 26, 11, 4, 1.0, "ViVo Telefon", 1000.0 },
                    { 31, 11, 4, 1.0, "Oppo Reno Telefon", 1000.0 },
                    { 32, 1, 4, 1.0, "Samsung Telefon", 1000.0 },
                    { 33, 11, 4, 1.0, "HTC Telefon", 1000.0 },
                    { 34, 11, 4, 1.0, "HTC Telefon 2", 1000.0 },
                    { 35, 11, 4, 1.0, "HTC Phone 4", 1000.0 },
                    { 37, 11, 4, 1.0, "Samsung Telefon", 1000.0 },
                    { 38, 11, 4, 1.0, "HTC Telefon 50", 1000.0 },
                    { 30, 4, 4, 1.0, "LG Telefon", 1000.0 },
                    { 25, 11, 3, 1.0, "Xiaomı Telefon", 1000.0 },
                    { 21, 11, 3, 1.0, "Sonny Telefon", 1000.0 },
                    { 17, 3, 3, 1.0, "Apple Telefon", 1000.0 },
                    { 19, 11, 1, 1.0, "Oppo Reno Telefon", 1000.0 },
                    { 23, 11, 1, 1.0, "Tecno Spark Telefon", 1000.0 },
                    { 27, 5, 1, 1.0, "Huawei Telefon", 1000.0 },
                    { 2, 3, 2, 1.0, "Apple iPhone 11", 1000.0 },
                    { 3, 3, 2, 1.0, "iPhone 11 Kırmızı Kılıf", 1000.0 },
                    { 4, 1, 2, 1.0, "Samsung Telefon", 1000.0 },
                    { 6, 5, 2, 1.0, "Huawei Telefon", 1000.0 },
                    { 9, 11, 2, 1.0, "Xiomi Telefon", 1000.0 },
                    { 13, 5, 2, 1.0, "Huawei Telefon", 1000.0 },
                    { 16, 5, 2, 1.0, "Huawei Telefon", 1000.0 },
                    { 20, 4, 2, 1.0, "LG Telefon", 1000.0 },
                    { 24, 1, 2, 1.0, "Samsung Telefon", 1000.0 },
                    { 28, 3, 2, 1.0, "Apple Telefon", 1000.0 },
                    { 36, 11, 2, 1.0, "HTC teleFON 9", 1000.0 },
                    { 7, 11, 3, 1.0, "Xiaomi Redmi Note 10S 128 GB 6 GB Ram", 1000.0 },
                    { 10, 11, 3, 1.0, "Oppo Reno 5 Lite 128 GB", 1000.0 },
                    { 14, 5, 3, 1.0, "Huawei Telefon", 1000.0 },
                    { 39, 11, 4, 1.0, "HTC Telefon 98", 1000.0 },
                    { 40, 11, 4, 1.0, "HTC Telefon 100", 1000.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cart_ProductId",
                table: "Cart",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_UserId",
                table: "Cart",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_BrandId",
                table: "Product",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ColorId",
                table: "Product",
                column: "ColorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Brand");

            migrationBuilder.DropTable(
                name: "Color");
        }
    }
}
