using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TShop.Infrascture.DataBase.EF.Migrations
{
    public partial class addseedproduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "InsertDate", "Name", "UpdateDate" },
                values: new object[,]
                {
                    { (byte)1, new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), "Tshirt", new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { (byte)2, new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), "Shoes", new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { (byte)3, new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), "Jeans", new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { (byte)4, new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), "Dress", new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Available", "Category_ID", "InsertDate", "LongDescription", "NewPrice", "OldPrice", "Rank", "ShortDescription", "Title", "UpdateDate" },
                values: new object[] { 1L, 0, (byte)1, new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), "Sed ut eros felis. Vestibulum rutrum imperdiet nunc a interdum. In scelerisque libero ut elit porttitor commodo. Suspendisse laoreet magna nec urna fringilla viverra.100% Cotton", 50m, 70m, (byte)4, "Vestibulum rutrum imperdiet nunc a interdum", "Product Name", new DateTime(2019, 4, 9, 7, 25, 10, 489, DateTimeKind.Local).AddTicks(7023) });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ID", "InsertDate", "Name", "Product_ID", "UpdateDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), "Red", 1L, new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 2L, new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), "Blue", 1L, new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 3L, new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), "Pink", 1L, new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ID", "FileName", "InsertDate", "Product_ID", "UpdateDate" },
                values: new object[,]
                {
                    { 1L, "a3.jpg", new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), 1L, new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 2L, "1.jpg", new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), 1L, new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 3L, "2.jpg", new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), 1L, new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 4L, "3.jpg", new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), 1L, new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "ID", "InsertDate", "Name", "Product_ID", "UpdateDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), "S", 1L, new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 2L, new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), "M", 1L, new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 3L, new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), "L", 1L, new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: (byte)2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: (byte)3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: (byte)4);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: (byte)1);
        }
    }
}
