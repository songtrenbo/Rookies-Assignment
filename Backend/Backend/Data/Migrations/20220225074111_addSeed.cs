using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class addSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandId", "BrandName" },
                values: new object[,]
                {
                    { 1, "NIKE" },
                    { 2, "AIR JORDAN" },
                    { 3, "ADIDAS" },
                    { 4, "PUMA" },
                    { 5, "DANSKO" },
                    { 6, "MLB" },
                    { 7, "ECCO" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 5, "SLIPPERS" },
                    { 3, "ATHLETIC" },
                    { 4, "OUTDOOR" },
                    { 1, "SNEAKER" },
                    { 2, "SANDALS" }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "PermissionId", "PermissionName" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "Customer" }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "SizeId", "SizeName" },
                values: new object[,]
                {
                    { 10, 40.0 },
                    { 15, 44.0 },
                    { 14, 43.0 },
                    { 13, 42.0 },
                    { 12, 41.0 },
                    { 11, 40.5 },
                    { 9, 39.5 },
                    { 2, 36.0 },
                    { 7, 38.5 },
                    { 6, 38.0 },
                    { 5, 37.5 },
                    { 4, 37.0 },
                    { 3, 36.5 },
                    { 16, 45.0 },
                    { 1, 35.5 },
                    { 8, 39.0 },
                    { 17, 46.0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BrandId", "CategoryId", "CreateDate", "Price", "ProductDesc", "ProductName", "Stock", "UpdateDate" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 167.5, "", "Air Force 1 Low LXX \"Serema Summit White\"", 10, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, 1, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 74.950000000000003, "Bootie construction delivers a snug, comfortable fit / Padded collar provides plush cushioning / Sockliner made of slow-recovery foam enhances comfort and cushioning", "Roshe Two Black", 11, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 3, 1, 1, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 75.489999999999995, "Bootie construction delivers a snug, comfortable fit / Padded collar provides plush cushioning / Sockliner made of slow-recovery foam enhances comfort and cushioning", "Running React Element 87", 12, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 4, 3, 2, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 69.939999999999998, "100% Synthetic, Imported, Rubber sole, Shaft measures approximately 6-12 inches from arch, Platform measures approximately 0-3 inches, Boot opening measures approximately 0-3 inches around, Regular fit", "Adidas Unisex-Adult Adissage Slides Sandal", 24, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 5, 4, 2, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 38.759999999999998, "Imported, Rubber sole, Casual Athletic Sneaker, Leadcat", "PUMA Unisex-Adult Leadcat Slide Sandal", 10, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 6, 4, 2, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 67.450000000000003, "fabric", "PUMA Cool Cat Dark Prismatic", 18, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 7, 7, 2, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 143.94999999999999, "fabric", "ECCO Women X-trinsic Textile Strap Sandal", 13, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 8, 5, 2, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 109.65000000000001, "Made in the USA or Imported, Ethylene Vinyl Acetate sole, Platform measures approximately 1, Multiple points of adjustability, Recycled webbings", "Dansko Womens Racquel Sport Sandals - lightweight sandals with arch support", 19, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Address", "FirstName", "LastName", "Password", "PermissionId", "Phone", "UserEmail" },
                values: new object[,]
                {
                    { 1, "772 North Dr Villa Ridge, Missouri(MO), 63089", "Sam", "GoodMan", "Admin", 1, "7169379740", "Admin" },
                    { 2, "124 Damon Rd Needham Heights, Massachusetts(MA), 02494", "Smith", "Nico", "123456", 2, "9226852630", "nico.smith29@gmail.com" },
                    { 3, "121 W Main St Pottstown, Pennsylvania(PA), 19465", "Megane", "Conroy", "123456", 2, "5547714494", "megane_conroy@gmail.com" },
                    { 4, "6910 Middle Rd 4 Racine, Wisconsin(WI), 53402", "Wilber", "Stafford", "123456", 2, "3388576230", "wilber73@gmail.com" },
                    { 5, "123456', N'173 Candlewood Trailer Park Danbury, Connecticut(CT), 06811", "Timothy", "Zulauf", "123456", 2, "3643898217", "timothy.zulauf84@gmail.com" },
                    { 6, "1025 Meadow Dr Cottage Hills, Illinois(IL), 62018", "Derek", "Levy", "123456", 2, "9799644643", "customer1@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageId", "CreateDate", "Path", "ProductId", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://cdn.shopify.com/s/files/1/2358/2817/products/nike-air-force-1-low-lxx-serena-summit-white_300x.png?v=1643803817", 1, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 25, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61w-vJBt1JL._AC_UY575_.jpg", 8, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 24, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61UjkEy3z+L._AC_UY575_.jpg", 8, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 23, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61pql62AGKL._AC_UY575_.jpg", 8, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 22, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71zg2Y4-9+L._AC_UY575_.jpg", 8, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 21, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61ZrxFvudzL._AC_UX575_.jpg", 7, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 20, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61ju+hAFY3L._AC_UY625_.jpg", 7, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 19, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61FGZx9tVtL._AC_UY675_.jpg", 7, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 18, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71Hm60lorWL._AC_UX575_.jpg", 7, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 17, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/510MaQWslcL._AC_.jpg", 6, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 16, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/41lyjznmaSL._AC_.jpg", 6, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 15, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71ADbn83HWS._AC_UX575_.jpg", 5, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 14, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/715R0-wRKeS._AC_UX575_.jpg", 5, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 12, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71uHDLaWGXL._AC_UX575_.jpg", 4, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 11, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61qqMFxGxyL._AC_UX575_.jpg", 4, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 10, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71o4uSF26YL._AC_UX575_.jpg", 4, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 13, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71M2oxWCjkS._AC_UX575_.jpg", 5, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://cdn.shopify.com/s/files/1/2358/2817/products/nike-air-force-1-low-lxx-serena-summit-white-2_300x.png?v=1643803817", 1, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://cdn.shopify.com/s/files/1/2358/2817/products/nike-air-force-1-low-lxx-serena-summit-white-3_300x.png?v=1643803817", 1, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 9, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://static.nike.com/a/images/t_prod_ss/w_640,c_limit,f_auto/rdim8o3ryfqkzc7anrpd/nike-react-element-87-sail-rush-orange-release-date.jpg", 3, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 8, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://static.nike.com/a/images/t_prod_ss/w_640,c_limit,f_auto/w20texhnqyxylva0xbgl/nike-react-element-87-sail-rush-orange-release-date.jpg", 3, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "http://purchaze.com/pictures/nike-wmns-roshe-two-black-black-844931-004.jpg", 2, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://static.nike.com/a/images/t_prod_ss/w_640,c_limit,f_auto/ktfan65igkw4nb8c3jvs/nike-react-element-87-sail-rush-orange-release-date.jpg", 3, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "http://purchaze.com/pictures/nike-wmns-roshe-two-black-black-844931-004_1.jpg", 2, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "http://purchaze.com/pictures/nike-wmns-roshe-two-black-black-844931-004_2.jpg", 2, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "SizeProducts",
                columns: new[] { "SizeProductId", "ProductId", "SizeId" },
                values: new object[,]
                {
                    { 6, 3, 1 },
                    { 21, 8, 14 },
                    { 1, 1, 4 },
                    { 2, 1, 5 },
                    { 20, 7, 13 },
                    { 19, 7, 12 },
                    { 18, 7, 11 },
                    { 3, 2, 6 },
                    { 16, 6, 9 },
                    { 7, 3, 2 },
                    { 15, 6, 8 },
                    { 4, 2, 6 },
                    { 14, 5, 7 },
                    { 13, 5, 6 },
                    { 12, 5, 5 },
                    { 22, 8, 15 },
                    { 11, 4, 3 }
                });

            migrationBuilder.InsertData(
                table: "SizeProducts",
                columns: new[] { "SizeProductId", "ProductId", "SizeId" },
                values: new object[,]
                {
                    { 10, 4, 2 },
                    { 9, 4, 1 },
                    { 8, 4, 3 },
                    { 5, 3, 7 },
                    { 17, 6, 10 },
                    { 23, 8, 16 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);
        }
    }
}
