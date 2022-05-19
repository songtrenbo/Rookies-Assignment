using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class addDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    BrandId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandName = table.Column<string>(type: "nvarchar(250)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.BrandId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(250)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    PermissionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PermissionName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.PermissionId);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    SizeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SizeName = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.SizeId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    ProductDesc = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: true),
                    Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "BrandId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermissionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Permissions_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permissions",
                        principalColumn: "PermissionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ImageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Path = table.Column<string>(type: "nvarchar(500)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ImageId);
                    table.ForeignKey(
                        name: "FK_Images_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SizeProducts",
                columns: table => new
                {
                    SizeProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SizeId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SizeProducts", x => x.SizeProductId);
                    table.ForeignKey(
                        name: "FK_SizeProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SizeProducts_Sizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Sizes",
                        principalColumn: "SizeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: true),
                    OrderTotal = table.Column<double>(type: "float", nullable: true),
                    ShippingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductPrice = table.Column<double>(type: "float", nullable: false),
                    ProductQty = table.Column<int>(type: "int", nullable: false),
                    Subtotal = table.Column<double>(type: "float", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailsId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rates",
                columns: table => new
                {
                    RateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    Points = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(500)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rates", x => x.RateId);
                    table.ForeignKey(
                        name: "FK_Rates_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rates_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rates_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandId", "BrandName" },
                values: new object[,]
                {
                    { 1, "NIKE" },
                    { 2, "COLUMBIA" },
                    { 3, "ADIDAS" },
                    { 4, "PUMA" },
                    { 5, "ASICS" },
                    { 6, "KEEN" },
                    { 7, "ECCO" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 5, "WATERPROOF" },
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
                    { 1, 1, 1, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 167.5, "Designed by Bruce Kilgore in 1982 with the idea of ​​taking its name from the AIR FORCE ONE, the AF1 quickly became a revolutionary shoe in the sneaker world, selling out in one day. record time. Although nearly 40 years have passed, NIKE AIR FORCE 1 still brings in hundreds of millions of dollars annually for NIKE.", "Air Force 1 Low LXX \"Serema Summit White\"", 10, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 7, 3, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 105.59999999999999, "The ECCO Men's Biom Aex Trainer Running Shoe is designed for a man who needs a comfortable shoe that also offers support. The Biom Aex Trainer features a 3D-shaped midsole, providing a secure and supportive fit. The shoe is constructed with a lightweight, breathable mesh upper, which helps keep the foot cool and dry.", "ECCO Men's Biom Aex Trainer Running Shoe", 9, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 17, 5, 3, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 99.950000000000003, "ASICS Matflex 5 Wrestling Shoe: The ASICS Matflex 5 Wrestling Shoe is the latest evolution of the Matflex shoe. This wrestling shoe is made for the wrestler that is looking for a shoe that will not only last through the toughest of matches, but also has a lightweight feel that is flexible enough to get the job done. ", "ASICS Men's Matflex 5 Wrestling Shoe", 17, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 19, 5, 3, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 149.94999999999999, "Innovative design and a brand-new ASICS GEL® technology make the Gel-Resolution 8 the ultimate in shock absorption and comfort. The updated ASICS GEL® Cushioning System features a rearfoot and forefoot GEL® unit for maximum shock absorption", "ASICS Men's Gel-Resolution 8 Tennis Shoes", 12, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 14, 5, 4, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 79.950000000000003, "Asics Dynablast running shoes are designed for the perfect combination of stability and flexibility. This shoe is designed to provide enough stability for runners with a wide range of foot types. The Dynablast is the perfect running shoe for a person who is looking for a balance of stability and flexibility.", "ASICS Men's Dynablast Running Shoes", 18, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 15, 5, 4, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 44.899999999999999, "ASICS Men's Hyper LD 5 Shoe ASICS Men's Hyper LD 5 Shoe is a comfortable, durable running shoe with great support and a natural feel. ASICS Men's Hyper LD 5 Shoe has a soft-cushioned sole that provides all-day comfort, a mesh upper for increased breathability, and GEL cushioning system for the ultimate in shock absorption.", "ASICS Men's Hyper LD 5 Shoe", 7, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 16, 5, 4, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 59.520000000000003, "Designed for comfort and style, the ASICS Men's Gel-Kayano 5 OG Sportstyle Shoes are perfect for the everyday runner. With a traditional lace-up closure, these shoes have a wide, cushioned footbed and gel cushioning to provide maximum comfort. In addition, these shoes have a soft suede upper and leather lining for extra durability.", "ASICS Men's Gel-Kayano 5 OG Sportstyle Shoes", 10, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 10, 1, 3, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 75.239999999999995, "Nike Air Max Torch 3 Men's Running Shoes This running shoe has a mix of leather and mesh to provide a lightweight and breathable feel. The shoe is designed with a lightweight and responsive foam midsole that delivers a plush, energy-returning ride. The outsole is designed with a herringbone pattern for a stable, smooth ride.", "Nike Air Max Torch 3 Men's Running Shoes", 14, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 20, 5, 4, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 119.0, "When you're in the mood for a new pair of running shoes, the ASICS Men's Gel-Kayano 28 Running Shoes are the perfect choice. These shoes have a durable, lightweight construction and a comfortable fit that is ideal for long-distance running. The Dynamic DuoMax Support System will make your feet feel better than ever. The flexible upper mesh gives your feet plenty of ventilation", "ASICS Men's Gel-Kayano 28 Running Shoes", 24, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 28, 2, 4, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 43.100000000000001, "The Columbia Men's Bahama Vent PFG Boat Shoe is the perfect shoe for summer. The breathable mesh lining allows your feet to breathe and keep cool while the Vent System on the sole will help keep your feet dry. These shoes are perfect for everyday wear and are even water resistant. They are made with synthetic leather, rubber, and mesh.", "Columbia Men's Bahama Vent PFG Boat Shoe", 23, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 31, 2, 4, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 42.5, "Columbia Men's Ivo Trail Breeze Walking, Hiking. -Cotton twill fabric -UPF 30 -Non-binding elastic cuffs -Water-resistant fabric -Lined with mesh for breathability -Cargo pockets -Two side pockets -Adjustable waist -Zipper and Velcro closure -Velcro tabs at ankles A sporty, lightweight hiking and walking shoe for a day on the trails. ", "Columbia Men's Ivo Trail Breeze Walking, Hiking", 11, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 33, 3, 4, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 112.98, "Made for men who enjoy being on the rock, the Climbing Shoes from adidas are made with a breathable mesh upper and supportive midsole. With a lightweight construction, these shoes offer a snug fit and a rubber outsole for superior grip.", "Adidas Men's Climbing Shoes, US:10.5", 9, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 29, 2, 5, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 53.490000000000002, "No matter the terrain, these men's hiking shoes are ready to take on any adventure. Designed with a full-length waterproof membrane, they're ready for a downpour and a quick rinse in the river. The Gore-Tex membrane will keep your feet dry and comfortable no matter the conditions. These shoes are lightweight and versatile, and offer a secure fit that's perfect for all-day wear.", "Columbia Men's Pivot Mid Waterproof Hiking Shoe", 17, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 30, 2, 5, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 39.979999999999997, "These shoes are the perfect shoe for any outdoor adventure. With a rugged outsole, these shoes will protect your feet from any terrain. They are made with a waterproof and breathable membrane that will keep your feet dry. The durable upper and lining will also provide protection and durability. The Columbia Crestwood Waterproof Hiking Shoe is the perfect shoe for any outdoor adventure.", "Columbia Men's Crestwood Waterproof Hiking Shoe", 15, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 34, 1, 5, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 74.510000000000005, "It's not just about what you wear on the course. It's about how you play. With Nike Lunar Control Vapor golf shoes, you'll get a level of comfort and performance that will have you playing your best. These shoes feature a lightweight and breathable upper with a stretchy, synthetic mesh tongue for the perfect fit. The lightweight mesh and mesh lining provide added comfort.", "Nike Lunar Control Vapor White-Solar Red-Laser Orange 849979-102 Women's Waterproof Golf Cleats 8 US", 16, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 26, 4, 4, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 60.539999999999999, "The PUMA Men's Pacer Future Trail Sneaker is the perfect shoe for anyone who wants to get outside and explore. It features a sleek, modern design that's made to withstand all of the tough conditions. The PUMA Men's Pacer Future Trail Sneaker is made of a high-quality, durable material that's resistant to abrasion and is treated with PUMA's trusted, water-resistant coating..", "PUMA Men's Pacer Future Trail Sneaker", 14, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 9, 7, 3, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 146.40000000000001, "PU Foam insert offers long-lasting comfort and support. Lightweight injection - molded EVA foam midsole provides lightweight cushioning. Phantom Liner interior has minimal seaming to help reduce irritation. Internal midsole shank adds midfoot structure and support", "New Balance Women's 608 V5 Casual Comfort Cross Trainer", 10, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 11, 1, 3, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 94.349999999999994, "Nike's Men's Race Running Shoe is the perfect shoe for all your race day needs. Made with lightweight mesh, this shoe is breathable and flexible. The shoe also features a carbon rubber outsole for optimal traction. With a 3mm heel-to-toe drop, this shoe is perfect for marathon runners.", "Nike Men's Race Running Shoe", 21, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 24, 6, 2, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 105.28, "The KEEN Women's Whisper Closed Toe Sport Sandal is perfect for your outdoor adventures. With a quick-dry microfiber upper, the KEEN Women's Whisper Closed Toe Sport Sandal is made to wick away moisture and keep your feet dry. The lightweight synthetic leather toe post.", "KEEN Women's Whisper Closed Toe Sport Sandal", 0, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 2, 1, 1, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 74.950000000000003, "Bootie construction delivers a snug, comfortable fit / Padded collar provides plush cushioning / Sockliner made of slow-recovery foam enhances comfort and cushioning", "Nike Roshe Run for Men", 11, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 3, 1, 1, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 75.489999999999995, "Bootie construction delivers a snug, comfortable fit / Padded collar provides plush cushioning / Sockliner made of slow-recovery foam enhances comfort and cushioning", "Running React Element 87", 12, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 12, 7, 1, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 107.62, "These men's sneakers are designed to be worn all day long. The soft and durable leather upper with mesh inserts ensures breathability and a secure fit. The anatomically shaped ECCO Fitsole construction provides extra cushioning and arch support.", "ECCO Men's Soft 7 Sneaker", 11, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 18, 5, 1, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 82.349999999999994, "The ASICS Men's GT-2000 8 Running Shoes are an excellent choice for runners looking for a shoe that will provide them with a lightweight, well-cushioned ride. This shoe has a mesh upper that is breathable and comfortable, as well as a removable insole that will provide extra cushioning. The GEL cushioning system, as well as the AHAR rubber outsole.", "ASICS Men's GT-2000 8 Running Shoes", 11, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 27, 4, 1, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 48.590000000000003, "This is a good-looking shoe with a simple design that makes it a great addition to any outfit. It is available in a variety of colors and has a synthetic upper, synthetic lining, and rubber sole. The shoe is water-resistant and provides traction and support, so it is perfect for wearing during any activity.", "PUMA Men's 19451405 Running Shoe", 0, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 25, 6, 2, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 64.900000000000006, "The Keen Women's Damaya Ankle Sterling Blue is a water-resistant shoe with a high-top silhouette. The shoe is made with Keen's proprietary KEEN.DRY membrane that provides an impermeable barrier against the elements.", "Keen Women's Damaya Ankle Sterling Blue Dress Blue", 11, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 35, 1, 1, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 69.959999999999994, "Nike Men's Sneaker Gymnastics Shoes Nike Men's Sneaker Gymnastics Shoes are a great choice for athletes who are always on the go. These shoes are made of durable leather and rubber to help keep your feet safe from injury. The leather upper is breathable and will stretch with your foot, while the rubber sole will provide grip and comfort. These shoes are perfect for the gym, outdoor workouts, or just everyday wear.", "Nike Men's Sneaker Gymnastics Shoes", 18, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 4, 3, 2, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 69.939999999999998, "100% Synthetic, Imported, Rubber sole, Shaft measures approximately 6-12 inches from arch, Platform measures approximately 0-3 inches, Boot opening measures approximately 0-3 inches around, Regular fit", "Adidas Unisex-Adult Adissage Slides Sandal", 24, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 32, 3, 1, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 48.340000000000003, "This new sneaker from adidas is made for the modern day athlete. The Advantage Sneaker features a sock-like fit with a flexible construction for a snug, comfortable feel. The shoe is made with soft and breathable materials, and has a mesh lining to keep your feet cool and dry.", "Adidas Men's Advantage Sneaker", 5, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 6, 4, 2, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 67.450000000000003, "Hit the pools or just get things done in comfort and ease sliding on the PUMA® Cool Cat BX. These slip-on shoes are constructed with a wide logo padded strap and a textured, cushioned footbed to provide all-day comfort making them your new favorite slides.", "PUMA Cool Cat Dark Prismatic", 18, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 7, 7, 2, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 143.94999999999999, "Forge your own path and take it with confidence in the ECCO® Sport Offroad Sandal.Leather and synthetic upper materials.", "ECCO Women X-trinsic Textile Strap Sandal", 13, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 8, 5, 2, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 109.65000000000001, "Made in the USA or Imported, Ethylene Vinyl Acetate sole, Platform measures approximately 1, Multiple points of adjustability, Recycled webbings", "Dansko Womens Racquel Sport Sandals - lightweight sandals with arch support", 19, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 21, 6, 2, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 83.969999999999999, "With KEEN's patented, lightweight rubber sole, the SOLR sandal will make you feel like you're walking on air. They have a microfiber upper that is water-resistant and comfortable. The water-resistant, closed-toe design is perfect for warm weather activities. The 3mm KEEN rubber outsole is lightweight and flexible, making these shoes ideal for any terrain.", "KEEN Women's SOLR High Performance Sport Closed Toe Water Sandal", 17, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 22, 6, 2, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 78.319999999999993, "The KEEN Women's Rose Casual Closed Toe Sandal is a sandal made of soft, supple leather. It has a closed toe design and a rubber sole. The KEEN Women's Rose Casual Closed Toe Sandal can be worn to the office, at the beach, or out on the town. It has a light, flexible feel and is easy to clean.", "KEEN Women's Rose Casual Closed Toe Sandal", 21, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 23, 6, 2, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 110.58, "These KEEN Women's Zerraport II Fashion Sandals are perfect for everyday wear. These sandals are made with KEEN.Dry technology, which is a patented waterproof membrane that keeps your feet dry and comfortable. These sandals also have KEEN.Comfort footbeds, which are anatomically designed to cradle your feet for maximum comfort.", "KEEN Women's Zerraport Ii Fashion Sandal", 3, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 5, 4, 2, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 38.759999999999998, "Imported, Rubber sole, Casual Athletic Sneaker, Leadcat", "PUMA Unisex-Adult Leadcat Slide Sandal", 10, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Address", "FirstName", "LastName", "Password", "PermissionId", "Phone", "UserEmail", "UserName" },
                values: new object[,]
                {
                    { 5, "123456', N'173 Candlewood Trailer Park Danbury, Connecticut(CT), 06811", "Timothy", "Zulauf", "AQAAAAEAACcQAAAAECQC6LUoJbA/oPzQ+fZWc/uPt+8LyKE1FXNl30FKFAb1OBrg3qnowxX3VY+g0cw/kQ==", 2, "3643898217", "timothy.zulauf84@gmail.com", "user4" },
                    { 1, "772 North Dr Villa Ridge, Missouri(MO), 63089", "Sam", "GoodMan", "AQAAAAEAACcQAAAAEKABWC+tWrGThzLZD8hIFZF5Ou1/2c97DWP6ZxUe567a1qgSS2CnzANK+sbT9gABAQ==", 1, "7169379740", "Admin", "Admin" },
                    { 2, "124 Damon Rd Needham Heights, Massachusetts(MA), 02494", "Smith", "Nico", "AQAAAAEAACcQAAAAEFBN8zcn/LV+jWWL1b13zS4VeMGjBqznXoGrW8tD7SZs8GimlZ5aNDjXEUZiZLFEyg==", 2, "9226852630", "nico.smith29@gmail.com", "user1" },
                    { 3, "121 W Main St Pottstown, Pennsylvania(PA), 19465", "Megane", "Conroy", "AQAAAAEAACcQAAAAEBvEpWIjHiYroZpE8bMlN1xKCt4qaf8eOOB7f3OzrIdajbZG7MaQGjSoJ0/onMmLNQ==", 2, "5547714494", "megane_conroy@gmail.com", "user2" },
                    { 4, "6910 Middle Rd 4 Racine, Wisconsin(WI), 53402", "Wilber", "Stafford", "AQAAAAEAACcQAAAAEB33nWnII1V40Sqhb8SmN5RroJhs35jq7ay5b+aSxVR4RfRnTpgruZjIhqesbmY9hw==", 2, "3388576230", "wilber73@gmail.com", "user3" },
                    { 6, "1025 Meadow Dr Cottage Hills, Illinois(IL), 62018", "Derek", "Levy", "AQAAAAEAACcQAAAAELFyWK+9ozBFvh+jJnQ1krBsYBspU/uc9Em6arfJ7IlStqMlVOAxXBvOie4TiX24LQ==", 2, "9799644643", "customer1@gmail.com", "user5" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageId", "CreateDate", "Path", "ProductId", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://cdn.shopify.com/s/files/1/2358/2817/products/nike-air-force-1-low-lxx-serena-summit-white_300x.png?v=1643803817", 1, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 27, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61vClQIDKML._AC_UY500_.jpg", 9, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 28, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/615fDqJiotL._AC_UY500_.jpg", 9, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 29, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71hSg0ahhBL._AC_UX395_.jpg", 9, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 31, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71wbXtpEwQL._AC_UY500_.jpg", 10, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 32, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61FN6BWhc3L._AC_UY395_.jpg", 10, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 33, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71P+O+GmbIL._AC_UY395_.jpg", 10, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 34, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61CbQbErg1L._AC_UY395_.jpg", 10, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 35, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/6168hsA9bSL._AC_UX575_.jpg", 11, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 36, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61IYtSgvJmL._AC_UX395_.jpg", 11, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 37, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/51mx9nf2wAL._AC_UX395_.jpg", 11, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 42, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71rpzIS5ChS._AC_UX695_.jpg", 13, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 43, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71UgZGCsL-S._AC_UY575_.jpg", 13, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 44, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61quwbKmUpS._AC_UY625_.jpg", 13, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 45, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/81UClieXbJS._AC_UX500_.jpg", 13, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 57, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/81DUO6ppq5L._AC_UX500_.jpg", 17, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 26, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61alcr5GlXL._AC_UX695_.jpg", 9, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 58, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71ehIGd8LLL._AC_UY625_.jpg", 17, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 83, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71pQ16I86YS._AC_UY500_.jpg", 25, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 81, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61C+d7XKYfS._AC_UY500_.jpg", 25, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 25, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61w-vJBt1JL._AC_UY575_.jpg", 8, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 67, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71qfjMzU3FL._AC_UX500_.jpg", 21, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 68, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71VkDhfV-1L._AC_UX500_.jpg", 21, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 69, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/618UTqPoQ4L._AC_UX500_.jpg", 21, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 70, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/710tfLKOiwL._AC_UX500_.jpg", 21, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 71, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61Ax+nPgexL._AC_UX500_.jpg", 22, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 72, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71N4iPnYjFL._AC_UX500_.jpg", 22, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 73, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71WmBb6su8L._AC_UX500_.jpg", 22, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 74, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61+h0YWusfL._AC_UX500_.jpg", 22, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 75, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/715neAl9WnL._AC_UX535_.jpg", 23, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 76, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71nqJ8JAPkL._AC_UX535_.jpg", 23, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 77, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71SJxMKoL5L._AC_UX535_.jpg", 23, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 78, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71hlP8+14gL._AC_UX500_.jpg", 24, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 79, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71Pc+pI6xcL._AC_UX500_.jpg", 24, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 80, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71pI4R8LAJL._AC_UX500_.jpg", 24, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 82, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61ldv19scaS._AC_UY500_.jpg", 25, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 59, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/719XXYFVBRL._AC_UX500_.jpg", 17, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 61, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61C-nbfIYvL._AC_UY500_.jpg", 19, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 62, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/51NN9Q8f8pL._AC_UY500_.jpg", 19, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 92, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71KGQTAqwcL._AC_UX500_.jpg", 28, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 93, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/81A-D9WqwkL._AC_UX500_.jpg", 28, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 94, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71XtjeYRTxL._AC_UX500_.jpg", 28, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageId", "CreateDate", "Path", "ProductId", "UpdateDate" },
                values: new object[,]
                {
                    { 102, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61sNtbP0xZL._AC_UX500_.jpg", 31, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 103, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61VjNuYDB2L._AC_UY500_.jpg", 31, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 104, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61EHWLS4jZL._AC_UY500_.jpg", 31, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 109, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71B+jujVaJL._AC_UX675_.jpg", 33, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 95, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/81UAA9EIkaL._AC_UX500_.jpg", 29, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 96, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/81C0w4yEE-L._AC_UX500_.jpg", 29, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 97, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/81pBO4xZVAL._AC_UX500_.jpg", 29, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 98, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/8168xklonDL._AC_UX500_.jpg", 29, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 99, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/81Dp6J7W16L._AC_UX500_.jpg", 30, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 100, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/81p7VGYaa-L._AC_UX500_.jpg", 30, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 101, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/81aTENbc4dL._AC_UX500_.jpg", 30, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 110, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61AHVQEbcXL._AC_UX500_.jpg", 34, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 91, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71ub1DieNoL._AC_UX500_.jpg", 28, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 87, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/81mA4XkSPfL._AC_UX500_.jpg", 26, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 86, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/81IJc60BqJL._AC_UX500_.jpg", 26, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 85, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71CehSqfjYL._AC_UX500_.jpg", 26, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 63, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61--1IEj-QL._AC_UY500_.jpg", 19, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 46, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61cKqcMqVJL._AC_UX625_.jpg", 14, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 47, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61NzpXnXCsL._AC_UX500_.jpg", 14, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 48, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61HAme7md2L._AC_UX500_.jpg", 14, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 49, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71mLwuFyfvL._AC_UX500_.jpg", 14, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 50, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61g1NlfdqML._AC_UX500_.jpg", 15, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 51, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61ArMmiww0L._AC_UX500_.jpg", 15, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 24, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61UjkEy3z+L._AC_UY575_.jpg", 8, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 52, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/51wG7gQKKxL._AC_UX500_.jpg", 15, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 54, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61UckOg5ScL._AC_UX500_.jpg", 16, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 55, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61jvQ0KH8fL._AC_UX500_.jpg", 16, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 56, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61M5sonJ-2L._AC_UX500_.jpg", 16, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 64, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71C3TmhbLgL._AC_UX500_.jpg", 20, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 65, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61i3ahDokML._AC_UX500_.jpg", 20, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 66, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61HejuTQjAL._AC_UY695_.jpg", 20, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 84, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/81j92FSiv3L._AC_UX695_.jpg", 26, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 53, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61jTBO8P4IL._AC_UX500_.jpg", 15, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 23, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61pql62AGKL._AC_UY575_.jpg", 8, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 30, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71SfTEUzMrL._AC_UX395_.jpg", 9, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 105, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/6151xNOvo5S._AC_UX500_.jpg", 32, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 14, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/715R0-wRKeS._AC_UX575_.jpg", 5, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 111, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61jM+GkDAeL._AC_SX500._SX._UX._SY._UY_.jpg", 35, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71PV-QiFPhL._AC_UX675_.jpg", 2, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/313tJ9vvzjL._AC_UX395_.jpg", 2, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 13, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71M2oxWCjkS._AC_UX575_.jpg", 5, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/31aP6ud6tIL._AC_UX395_.jpg", 2, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageId", "CreateDate", "Path", "ProductId", "UpdateDate" },
                values: new object[,]
                {
                    { 106, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/51w+UH35KNS._AC_UX500_.jpg", 32, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 107, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61VCN2iVWhS._AC_UX500_.jpg", 32, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 12, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71uHDLaWGXL._AC_UX575_.jpg", 4, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 11, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61qqMFxGxyL._AC_UX575_.jpg", 4, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 15, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71ADbn83HWS._AC_UX575_.jpg", 5, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 108, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/611Tna756OS._AC_UX500_.jpg", 32, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://static.nike.com/a/images/t_prod_ss/w_640,c_limit,f_auto/ktfan65igkw4nb8c3jvs/nike-react-element-87-sail-rush-orange-release-date.jpg", 3, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 10, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71o4uSF26YL._AC_UX575_.jpg", 4, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 8, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://static.nike.com/a/images/t_prod_ss/w_640,c_limit,f_auto/w20texhnqyxylva0xbgl/nike-react-element-87-sail-rush-orange-release-date.jpg", 3, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 9, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://static.nike.com/a/images/t_prod_ss/w_640,c_limit,f_auto/rdim8o3ryfqkzc7anrpd/nike-react-element-87-sail-rush-orange-release-date.jpg", 3, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 41, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61gVySL0COL._AC_UY500_.jpg", 12, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 40, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/81QU0-K6SSL._AC_UY500_.jpg", 12, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 39, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/81tubh4kJtL._AC_UY500_.jpg", 12, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 114, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/81elz8mIVhL._AC_SX500._SX._UX._SY._UY_.jpg", 35, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 113, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/81FpRIxhYML._AC_SX500._SX._UX._SY._UY_.jpg", 35, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 38, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71PutuAFLxL._AC_UY575_.jpg", 12, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 88, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71m-HrkrGVL._AC_UX500_.jpg", 27, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 22, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71zg2Y4-9+L._AC_UY575_.jpg", 8, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 112, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71+8kiZWiAL._AC_SX500._SX._UX._SY._UY_.jpg", 35, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://cdn.shopify.com/s/files/1/2358/2817/products/nike-air-force-1-low-lxx-serena-summit-white-3_300x.png?v=1643803817", 1, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 60, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71jBHYlEtKL._AC_UX695_.jpg", 18, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 18, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71Hm60lorWL._AC_UX575_.jpg", 7, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 19, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61FGZx9tVtL._AC_UY675_.jpg", 7, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 16, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/41lyjznmaSL._AC_.jpg", 6, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 90, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71tygOpNCfL._AC_UX500_.jpg", 27, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://cdn.shopify.com/s/files/1/2358/2817/products/nike-air-force-1-low-lxx-serena-summit-white-2_300x.png?v=1643803817", 1, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 89, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71s7IYm+DvL._AC_UX500_.jpg", 27, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 17, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/510MaQWslcL._AC_.jpg", 6, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 21, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61ZrxFvudzL._AC_UX575_.jpg", 7, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 20, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61ju+hAFY3L._AC_UY625_.jpg", 7, new DateTime(2021, 11, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "OrderDate", "OrderTotal", "ShippingDate", "Status", "UserId" },
                values: new object[,]
                {
                    { 2, new DateTime(2022, 2, 15, 5, 35, 51, 0, DateTimeKind.Unspecified), 167.5, new DateTime(2022, 2, 18, 5, 35, 51, 0, DateTimeKind.Unspecified), 3, 2 },
                    { 3, new DateTime(2022, 2, 15, 5, 35, 51, 0, DateTimeKind.Unspecified), 167.5, new DateTime(2022, 2, 18, 5, 35, 51, 0, DateTimeKind.Unspecified), 3, 2 },
                    { 4, new DateTime(2022, 2, 15, 5, 35, 51, 0, DateTimeKind.Unspecified), 167.5, new DateTime(2022, 2, 18, 5, 35, 51, 0, DateTimeKind.Unspecified), 3, 3 },
                    { 6, new DateTime(2022, 2, 15, 5, 35, 51, 0, DateTimeKind.Unspecified), 74.950000000000003, new DateTime(2022, 3, 15, 5, 35, 51, 0, DateTimeKind.Unspecified), 3, 3 },
                    { 7, new DateTime(2022, 2, 15, 5, 35, 51, 0, DateTimeKind.Unspecified), 74.950000000000003, new DateTime(2022, 2, 18, 5, 35, 51, 0, DateTimeKind.Unspecified), 1, 3 },
                    { 8, new DateTime(2022, 2, 15, 5, 35, 51, 0, DateTimeKind.Unspecified), 224.84999999999999, new DateTime(2022, 2, 18, 5, 35, 51, 0, DateTimeKind.Unspecified), 3, 4 },
                    { 5, new DateTime(2022, 2, 15, 5, 35, 51, 0, DateTimeKind.Unspecified), 325.0, new DateTime(2022, 2, 18, 5, 35, 51, 0, DateTimeKind.Unspecified), 3, 3 },
                    { 1, new DateTime(2022, 2, 15, 5, 35, 51, 0, DateTimeKind.Unspecified), 335.0, new DateTime(2022, 2, 18, 5, 35, 51, 0, DateTimeKind.Unspecified), 3, 2 },
                    { 9, new DateTime(2022, 2, 15, 5, 35, 51, 0, DateTimeKind.Unspecified), 150.97999999999999, new DateTime(2022, 2, 18, 5, 35, 51, 0, DateTimeKind.Unspecified), 3, 4 },
                    { 10, new DateTime(2022, 2, 15, 5, 35, 51, 0, DateTimeKind.Unspecified), 150.97999999999999, new DateTime(2022, 2, 18, 5, 35, 51, 0, DateTimeKind.Unspecified), 3, 4 }
                });

            migrationBuilder.InsertData(
                table: "SizeProducts",
                columns: new[] { "SizeProductId", "ProductId", "SizeId" },
                values: new object[,]
                {
                    { 52, 16, 13 },
                    { 59, 18, 11 }
                });

            migrationBuilder.InsertData(
                table: "SizeProducts",
                columns: new[] { "SizeProductId", "ProductId", "SizeId" },
                values: new object[,]
                {
                    { 53, 16, 14 },
                    { 60, 18, 13 },
                    { 50, 15, 10 },
                    { 54, 16, 15 },
                    { 51, 16, 12 },
                    { 36, 12, 1 },
                    { 67, 20, 9 },
                    { 39, 12, 4 },
                    { 38, 12, 3 },
                    { 37, 12, 2 },
                    { 49, 15, 8 },
                    { 48, 15, 7 },
                    { 68, 20, 15 },
                    { 66, 20, 7 },
                    { 103, 31, 1 },
                    { 87, 26, 12 },
                    { 116, 34, 13 },
                    { 115, 34, 12 },
                    { 114, 34, 11 },
                    { 113, 34, 10 },
                    { 102, 30, 5 },
                    { 101, 30, 4 },
                    { 100, 30, 3 },
                    { 99, 30, 2 },
                    { 1, 1, 4 },
                    { 2, 1, 5 },
                    { 98, 29, 9 },
                    { 97, 29, 8 },
                    { 96, 29, 7 },
                    { 86, 26, 11 },
                    { 3, 2, 6 },
                    { 111, 33, 8 },
                    { 110, 33, 7 },
                    { 109, 33, 6 },
                    { 4, 2, 6 },
                    { 105, 31, 8 },
                    { 104, 31, 7 },
                    { 95, 28, 15 },
                    { 94, 28, 13 },
                    { 93, 28, 10 },
                    { 5, 3, 7 },
                    { 6, 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "SizeProducts",
                columns: new[] { "SizeProductId", "ProductId", "SizeId" },
                values: new object[,]
                {
                    { 7, 3, 2 },
                    { 88, 26, 14 },
                    { 112, 33, 9 },
                    { 47, 15, 6 },
                    { 64, 19, 3 },
                    { 62, 18, 17 },
                    { 77, 23, 8 },
                    { 78, 23, 9 },
                    { 12, 5, 5 },
                    { 79, 24, 3 },
                    { 80, 24, 4 },
                    { 81, 24, 5 },
                    { 76, 23, 7 },
                    { 82, 24, 6 },
                    { 10, 4, 2 },
                    { 83, 25, 1 },
                    { 84, 25, 2 },
                    { 85, 25, 3 },
                    { 9, 4, 1 },
                    { 8, 4, 3 },
                    { 11, 4, 3 },
                    { 24, 9, 12 },
                    { 75, 23, 5 },
                    { 14, 5, 7 },
                    { 19, 7, 12 },
                    { 18, 7, 11 },
                    { 21, 8, 14 },
                    { 22, 8, 15 },
                    { 23, 8, 16 },
                    { 69, 21, 13 },
                    { 13, 5, 6 },
                    { 70, 21, 16 },
                    { 17, 6, 10 },
                    { 16, 6, 9 },
                    { 15, 6, 8 },
                    { 72, 22, 3 },
                    { 73, 22, 4 },
                    { 74, 22, 6 },
                    { 71, 21, 17 },
                    { 61, 18, 15 },
                    { 25, 9, 13 },
                    { 27, 9, 15 }
                });

            migrationBuilder.InsertData(
                table: "SizeProducts",
                columns: new[] { "SizeProductId", "ProductId", "SizeId" },
                values: new object[,]
                {
                    { 106, 32, 3 },
                    { 55, 17, 4 },
                    { 56, 17, 5 },
                    { 57, 17, 9 },
                    { 58, 17, 16 },
                    { 92, 27, 17 },
                    { 43, 13, 14 },
                    { 63, 19, 2 },
                    { 91, 27, 16 },
                    { 90, 27, 15 },
                    { 89, 27, 13 },
                    { 44, 14, 13 },
                    { 45, 14, 14 },
                    { 46, 14, 17 },
                    { 65, 19, 4 },
                    { 26, 9, 14 },
                    { 42, 13, 11 },
                    { 40, 13, 7 },
                    { 120, 35, 17 },
                    { 119, 35, 16 },
                    { 118, 35, 15 },
                    { 28, 10, 14 },
                    { 29, 10, 15 },
                    { 30, 10, 16 },
                    { 41, 13, 10 },
                    { 31, 10, 17 },
                    { 32, 11, 4 },
                    { 33, 11, 5 },
                    { 34, 11, 8 },
                    { 35, 11, 11 },
                    { 108, 32, 5 },
                    { 107, 32, 4 },
                    { 117, 35, 14 },
                    { 20, 7, 13 }
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

            migrationBuilder.CreateIndex(
                name: "IX_Images_ProductId",
                table: "Images",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Rates_OrderId",
                table: "Rates",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Rates_ProductId",
                table: "Rates",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Rates_UserId",
                table: "Rates",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SizeProducts_ProductId",
                table: "SizeProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_SizeProducts_SizeId",
                table: "SizeProducts",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_PermissionId",
                table: "Users",
                column: "PermissionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Rates");

            migrationBuilder.DropTable(
                name: "SizeProducts");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Permissions");
        }
    }
}
