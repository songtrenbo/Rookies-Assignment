using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class SeedingDataOrderRate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Subtotal",
                table: "OrderDetails",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "OrderDate", "OrderTotal", "ShippingDate", "Status", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 2, 15, 5, 35, 51, 0, DateTimeKind.Unspecified), 335.0, new DateTime(2022, 2, 18, 5, 35, 51, 0, DateTimeKind.Unspecified), 3, 2 },
                    { 2, new DateTime(2022, 2, 15, 5, 35, 51, 0, DateTimeKind.Unspecified), 167.5, new DateTime(2022, 2, 18, 5, 35, 51, 0, DateTimeKind.Unspecified), 3, 2 },
                    { 3, new DateTime(2022, 2, 15, 5, 35, 51, 0, DateTimeKind.Unspecified), 167.5, new DateTime(2022, 2, 18, 5, 35, 51, 0, DateTimeKind.Unspecified), 3, 2 },
                    { 4, new DateTime(2022, 2, 15, 5, 35, 51, 0, DateTimeKind.Unspecified), 167.5, new DateTime(2022, 2, 18, 5, 35, 51, 0, DateTimeKind.Unspecified), 3, 3 },
                    { 5, new DateTime(2022, 2, 15, 5, 35, 51, 0, DateTimeKind.Unspecified), 325.0, new DateTime(2022, 2, 18, 5, 35, 51, 0, DateTimeKind.Unspecified), 3, 3 },
                    { 6, new DateTime(2022, 2, 15, 5, 35, 51, 0, DateTimeKind.Unspecified), 74.950000000000003, new DateTime(2022, 3, 15, 5, 35, 51, 0, DateTimeKind.Unspecified), 3, 3 },
                    { 7, new DateTime(2022, 2, 15, 5, 35, 51, 0, DateTimeKind.Unspecified), 74.950000000000003, new DateTime(2022, 2, 18, 5, 35, 51, 0, DateTimeKind.Unspecified), 1, 3 },
                    { 8, new DateTime(2022, 2, 15, 5, 35, 51, 0, DateTimeKind.Unspecified), 224.84999999999999, new DateTime(2022, 2, 18, 5, 35, 51, 0, DateTimeKind.Unspecified), 3, 4 },
                    { 9, new DateTime(2022, 2, 15, 5, 35, 51, 0, DateTimeKind.Unspecified), 150.97999999999999, new DateTime(2022, 2, 18, 5, 35, 51, 0, DateTimeKind.Unspecified), 3, 4 },
                    { 10, new DateTime(2022, 2, 15, 5, 35, 51, 0, DateTimeKind.Unspecified), 150.97999999999999, new DateTime(2022, 2, 18, 5, 35, 51, 0, DateTimeKind.Unspecified), 3, 4 }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderDetailsId", "OrderId", "ProductId", "ProductPrice", "ProductQty", "Subtotal" },
                values: new object[,]
                {
                    { 1, 1, 1, 167.5, 2, 335.0 },
                    { 2, 2, 1, 167.5, 1, 167.5 },
                    { 9, 9, 3, 75.489999999999995, 2, 150.97999999999999 },
                    { 3, 3, 1, 167.5, 1, 167.5 },
                    { 4, 4, 1, 167.5, 1, 167.5 },
                    { 8, 8, 2, 74.950000000000003, 3, 224.84999999999999 },
                    { 5, 5, 1, 167.5, 2, 335.0 },
                    { 10, 10, 3, 75.489999999999995, 2, 150.97999999999999 },
                    { 6, 6, 2, 74.950000000000003, 1, 74.950000000000003 },
                    { 7, 7, 2, 74.950000000000003, 1, 74.950000000000003 }
                });

            migrationBuilder.InsertData(
                table: "Rates",
                columns: new[] { "RateId", "Content", "CreateDate", "IsDeleted", "OrderId", "Points", "ProductId", "UpdateDate", "UserId" },
                values: new object[,]
                {
                    { 9, "Ohhhh this shoes is lovely. You guys should buy this one!", new DateTime(2022, 2, 18, 5, 35, 51, 0, DateTimeKind.Unspecified), false, 9, 4, 3, new DateTime(2022, 2, 18, 5, 35, 51, 0, DateTimeKind.Unspecified), 4 },
                    { 8, "I think this shoes is ok with me", new DateTime(2022, 2, 18, 5, 35, 51, 0, DateTimeKind.Unspecified), false, 8, 3, 2, new DateTime(2022, 2, 18, 5, 35, 51, 0, DateTimeKind.Unspecified), 4 },
                    { 7, "What is this? How can i wear this shoes? It look so difference than the picture on the shop!", new DateTime(2022, 2, 18, 5, 35, 51, 0, DateTimeKind.Unspecified), false, 7, 1, 2, new DateTime(2022, 2, 18, 5, 35, 51, 0, DateTimeKind.Unspecified), 3 },
                    { 5, "Amazing, Good shoes, good style", new DateTime(2022, 2, 18, 5, 35, 51, 0, DateTimeKind.Unspecified), false, 5, 5, 1, new DateTime(2022, 2, 18, 5, 35, 51, 0, DateTimeKind.Unspecified), 3 },
                    { 4, "Good shoes but i don't really like this shoes style", new DateTime(2022, 2, 18, 5, 35, 51, 0, DateTimeKind.Unspecified), false, 4, 3, 1, new DateTime(2022, 2, 18, 5, 35, 51, 0, DateTimeKind.Unspecified), 3 },
                    { 3, "Wow, what a nice shoes!!!", new DateTime(2022, 2, 18, 5, 35, 51, 0, DateTimeKind.Unspecified), false, 3, 4, 1, new DateTime(2022, 2, 18, 5, 35, 51, 0, DateTimeKind.Unspecified), 2 },
                    { 2, "I'm really like this shoes", new DateTime(2022, 2, 18, 5, 35, 51, 0, DateTimeKind.Unspecified), false, 2, 4, 1, new DateTime(2022, 2, 18, 5, 35, 51, 0, DateTimeKind.Unspecified), 2 },
                    { 1, "Nice shoes, i love it", new DateTime(2022, 2, 18, 5, 35, 51, 0, DateTimeKind.Unspecified), false, 1, 5, 1, new DateTime(2022, 2, 18, 5, 35, 51, 0, DateTimeKind.Unspecified), 2 },
                    { 6, "Is this a joke? I bought this shoes and it took about 1 month to get to me, Why? And why it got dirty everywhere on my shoes?", new DateTime(2022, 2, 18, 5, 35, 51, 0, DateTimeKind.Unspecified), false, 6, 1, 2, new DateTime(2022, 2, 18, 5, 35, 51, 0, DateTimeKind.Unspecified), 3 },
                    { 10, "It good but i don't like it!!!", new DateTime(2022, 2, 18, 5, 35, 51, 0, DateTimeKind.Unspecified), false, 10, 2, 3, new DateTime(2022, 2, 18, 5, 35, 51, 0, DateTimeKind.Unspecified), 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailsId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailsId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailsId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailsId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailsId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailsId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailsId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailsId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailsId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailsId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumn: "RateId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumn: "RateId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumn: "RateId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumn: "RateId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumn: "RateId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumn: "RateId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumn: "RateId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumn: "RateId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumn: "RateId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumn: "RateId",
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

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10);

            migrationBuilder.AlterColumn<int>(
                name: "Subtotal",
                table: "OrderDetails",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
