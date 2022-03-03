using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class SeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 2,
                column: "BrandName",
                value: "COLUMBIA");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 5,
                column: "BrandName",
                value: "ASICS");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 6,
                column: "BrandName",
                value: "KEEN");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "CategoryName",
                value: "WATERPROOF");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 4,
                column: "Path",
                value: "https://m.media-amazon.com/images/I/71PV-QiFPhL._AC_UX675_.jpg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 5,
                column: "Path",
                value: "https://m.media-amazon.com/images/I/313tJ9vvzjL._AC_UX395_.jpg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 6,
                column: "Path",
                value: "https://m.media-amazon.com/images/I/31aP6ud6tIL._AC_UX395_.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ProductDesc",
                value: "Designed by Bruce Kilgore in 1982 with the idea of ​​taking its name from the AIR FORCE ONE, the AF1 quickly became a revolutionary shoe in the sneaker world, selling out in one day. record time. Although nearly 40 years have passed, NIKE AIR FORCE 1 still brings in hundreds of millions of dollars annually for NIKE.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ProductName",
                value: "Nike Roshe Run for Men");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "ProductDesc",
                value: "Hit the pools or just get things done in comfort and ease sliding on the PUMA® Cool Cat BX. These slip-on shoes are constructed with a wide logo padded strap and a textured, cushioned footbed to provide all-day comfort making them your new favorite slides.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "ProductDesc",
                value: "Forge your own path and take it with confidence in the ECCO® Sport Offroad Sandal.Leather and synthetic upper materials.");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BrandId", "CategoryId", "CreateDate", "Price", "ProductDesc", "ProductName", "Stock", "UpdateDate" },
                values: new object[,]
                {
                    { 35, 1, 1, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 69.959999999999994, "Nike Men's Sneaker Gymnastics Shoes Nike Men's Sneaker Gymnastics Shoes are a great choice for athletes who are always on the go. These shoes are made of durable leather and rubber to help keep your feet safe from injury. The leather upper is breathable and will stretch with your foot, while the rubber sole will provide grip and comfort. These shoes are perfect for the gym, outdoor workouts, or just everyday wear.", "Nike Men's Sneaker Gymnastics Shoes", 18, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 34, 1, 5, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 74.510000000000005, "It's not just about what you wear on the course. It's about how you play. With Nike Lunar Control Vapor golf shoes, you'll get a level of comfort and performance that will have you playing your best. These shoes feature a lightweight and breathable upper with a stretchy, synthetic mesh tongue for the perfect fit. The lightweight mesh and mesh lining provide added comfort.", "Nike Lunar Control Vapor White-Solar Red-Laser Orange 849979-102 Women's Waterproof Golf Cleats 8 US", 16, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 33, 3, 4, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 112.98, "Made for men who enjoy being on the rock, the Climbing Shoes from adidas are made with a breathable mesh upper and supportive midsole. With a lightweight construction, these shoes offer a snug fit and a rubber outsole for superior grip.", "Adidas Men's Climbing Shoes, US:10.5", 9, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 32, 3, 1, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 48.340000000000003, "This new sneaker from adidas is made for the modern day athlete. The Advantage Sneaker features a sock-like fit with a flexible construction for a snug, comfortable feel. The shoe is made with soft and breathable materials, and has a mesh lining to keep your feet cool and dry.", "Adidas Men's Advantage Sneaker", 5, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 31, 2, 4, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 42.5, "Columbia Men's Ivo Trail Breeze Walking, Hiking. -Cotton twill fabric -UPF 30 -Non-binding elastic cuffs -Water-resistant fabric -Lined with mesh for breathability -Cargo pockets -Two side pockets -Adjustable waist -Zipper and Velcro closure -Velcro tabs at ankles A sporty, lightweight hiking and walking shoe for a day on the trails. ", "Columbia Men's Ivo Trail Breeze Walking, Hiking", 11, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 30, 2, 5, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 39.979999999999997, "These shoes are the perfect shoe for any outdoor adventure. With a rugged outsole, these shoes will protect your feet from any terrain. They are made with a waterproof and breathable membrane that will keep your feet dry. The durable upper and lining will also provide protection and durability. The Columbia Crestwood Waterproof Hiking Shoe is the perfect shoe for any outdoor adventure.", "Columbia Men's Crestwood Waterproof Hiking Shoe", 15, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 29, 2, 5, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 53.490000000000002, "No matter the terrain, these men's hiking shoes are ready to take on any adventure. Designed with a full-length waterproof membrane, they're ready for a downpour and a quick rinse in the river. The Gore-Tex membrane will keep your feet dry and comfortable no matter the conditions. These shoes are lightweight and versatile, and offer a secure fit that's perfect for all-day wear.", "Columbia Men's Pivot Mid Waterproof Hiking Shoe", 17, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 28, 2, 4, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 43.100000000000001, "The Columbia Men's Bahama Vent PFG Boat Shoe is the perfect shoe for summer. The breathable mesh lining allows your feet to breathe and keep cool while the Vent System on the sole will help keep your feet dry. These shoes are perfect for everyday wear and are even water resistant. They are made with synthetic leather, rubber, and mesh.", "Columbia Men's Bahama Vent PFG Boat Shoe", 23, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 27, 4, 1, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 48.590000000000003, "This is a good-looking shoe with a simple design that makes it a great addition to any outfit. It is available in a variety of colors and has a synthetic upper, synthetic lining, and rubber sole. The shoe is water-resistant and provides traction and support, so it is perfect for wearing during any activity.", "PUMA Men's 19451405 Running Shoe", 0, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 25, 6, 2, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 64.900000000000006, "The Keen Women's Damaya Ankle Sterling Blue is a water-resistant shoe with a high-top silhouette. The shoe is made with Keen's proprietary KEEN.DRY membrane that provides an impermeable barrier against the elements.", "Keen Women's Damaya Ankle Sterling Blue Dress Blue", 11, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 10, 1, 3, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 75.239999999999995, "Nike Air Max Torch 3 Men's Running Shoes This running shoe has a mix of leather and mesh to provide a lightweight and breathable feel. The shoe is designed with a lightweight and responsive foam midsole that delivers a plush, energy-returning ride. The outsole is designed with a herringbone pattern for a stable, smooth ride.", "Nike Air Max Torch 3 Men's Running Shoes", 14, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 11, 1, 3, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 94.349999999999994, "Nike's Men's Race Running Shoe is the perfect shoe for all your race day needs. Made with lightweight mesh, this shoe is breathable and flexible. The shoe also features a carbon rubber outsole for optimal traction. With a 3mm heel-to-toe drop, this shoe is perfect for marathon runners.", "Nike Men's Race Running Shoe", 21, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 12, 7, 1, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 107.62, "These men's sneakers are designed to be worn all day long. The soft and durable leather upper with mesh inserts ensures breathability and a secure fit. The anatomically shaped ECCO Fitsole construction provides extra cushioning and arch support.", "ECCO Men's Soft 7 Sneaker", 11, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 13, 7, 3, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 105.59999999999999, "The ECCO Men's Biom Aex Trainer Running Shoe is designed for a man who needs a comfortable shoe that also offers support. The Biom Aex Trainer features a 3D-shaped midsole, providing a secure and supportive fit. The shoe is constructed with a lightweight, breathable mesh upper, which helps keep the foot cool and dry.", "ECCO Men's Biom Aex Trainer Running Shoe", 9, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 14, 5, 4, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 79.950000000000003, "Asics Dynablast running shoes are designed for the perfect combination of stability and flexibility. This shoe is designed to provide enough stability for runners with a wide range of foot types. The Dynablast is the perfect running shoe for a person who is looking for a balance of stability and flexibility.", "ASICS Men's Dynablast Running Shoes", 18, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 15, 5, 4, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 44.899999999999999, "ASICS Men's Hyper LD 5 Shoe ASICS Men's Hyper LD 5 Shoe is a comfortable, durable running shoe with great support and a natural feel. ASICS Men's Hyper LD 5 Shoe has a soft-cushioned sole that provides all-day comfort, a mesh upper for increased breathability, and GEL cushioning system for the ultimate in shock absorption.", "ASICS Men's Hyper LD 5 Shoe", 7, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 16, 5, 4, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 59.520000000000003, "Designed for comfort and style, the ASICS Men's Gel-Kayano 5 OG Sportstyle Shoes are perfect for the everyday runner. With a traditional lace-up closure, these shoes have a wide, cushioned footbed and gel cushioning to provide maximum comfort. In addition, these shoes have a soft suede upper and leather lining for extra durability.", "ASICS Men's Gel-Kayano 5 OG Sportstyle Shoes", 10, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 17, 5, 3, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 99.950000000000003, "ASICS Matflex 5 Wrestling Shoe: The ASICS Matflex 5 Wrestling Shoe is the latest evolution of the Matflex shoe. This wrestling shoe is made for the wrestler that is looking for a shoe that will not only last through the toughest of matches, but also has a lightweight feel that is flexible enough to get the job done. ", "ASICS Men's Matflex 5 Wrestling Shoe", 17, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 18, 5, 1, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 82.349999999999994, "The ASICS Men's GT-2000 8 Running Shoes are an excellent choice for runners looking for a shoe that will provide them with a lightweight, well-cushioned ride. This shoe has a mesh upper that is breathable and comfortable, as well as a removable insole that will provide extra cushioning. The GEL cushioning system, as well as the AHAR rubber outsole.", "ASICS Men's GT-2000 8 Running Shoes", 11, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 19, 5, 3, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 149.94999999999999, "Innovative design and a brand-new ASICS GEL® technology make the Gel-Resolution 8 the ultimate in shock absorption and comfort. The updated ASICS GEL® Cushioning System features a rearfoot and forefoot GEL® unit for maximum shock absorption", "ASICS Men's Gel-Resolution 8 Tennis Shoes", 12, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 20, 5, 4, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 119.0, "When you're in the mood for a new pair of running shoes, the ASICS Men's Gel-Kayano 28 Running Shoes are the perfect choice. These shoes have a durable, lightweight construction and a comfortable fit that is ideal for long-distance running. The Dynamic DuoMax Support System will make your feet feel better than ever. The flexible upper mesh gives your feet plenty of ventilation", "ASICS Men's Gel-Kayano 28 Running Shoes", 24, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 21, 6, 2, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 83.969999999999999, "With KEEN's patented, lightweight rubber sole, the SOLR sandal will make you feel like you're walking on air. They have a microfiber upper that is water-resistant and comfortable. The water-resistant, closed-toe design is perfect for warm weather activities. The 3mm KEEN rubber outsole is lightweight and flexible, making these shoes ideal for any terrain.", "KEEN Women's SOLR High Performance Sport Closed Toe Water Sandal", 17, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 22, 6, 2, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 78.319999999999993, "The KEEN Women's Rose Casual Closed Toe Sandal is a sandal made of soft, supple leather. It has a closed toe design and a rubber sole. The KEEN Women's Rose Casual Closed Toe Sandal can be worn to the office, at the beach, or out on the town. It has a light, flexible feel and is easy to clean.", "KEEN Women's Rose Casual Closed Toe Sandal", 21, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 23, 6, 2, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 110.58, "These KEEN Women's Zerraport II Fashion Sandals are perfect for everyday wear. These sandals are made with KEEN.Dry technology, which is a patented waterproof membrane that keeps your feet dry and comfortable. These sandals also have KEEN.Comfort footbeds, which are anatomically designed to cradle your feet for maximum comfort.", "KEEN Women's Zerraport Ii Fashion Sandal", 3, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 24, 6, 2, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 105.28, "The KEEN Women's Whisper Closed Toe Sport Sandal is perfect for your outdoor adventures. With a quick-dry microfiber upper, the KEEN Women's Whisper Closed Toe Sport Sandal is made to wick away moisture and keep your feet dry. The lightweight synthetic leather toe post.", "KEEN Women's Whisper Closed Toe Sport Sandal", 0, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 26, 4, 4, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 60.539999999999999, "The PUMA Men's Pacer Future Trail Sneaker is the perfect shoe for anyone who wants to get outside and explore. It features a sleek, modern design that's made to withstand all of the tough conditions. The PUMA Men's Pacer Future Trail Sneaker is made of a high-quality, durable material that's resistant to abrasion and is treated with PUMA's trusted, water-resistant coating..", "PUMA Men's Pacer Future Trail Sneaker", 14, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 9, 7, 3, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), 146.40000000000001, "PU Foam insert offers long-lasting comfort and support. Lightweight injection - molded EVA foam midsole provides lightweight cushioning. Phantom Liner interior has minimal seaming to help reduce irritation. Internal midsole shank adds midfoot structure and support", "New Balance Women's 608 V5 Casual Comfort Cross Trainer", 10, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageId", "CreateDate", "Path", "ProductId", "UpdateDate" },
                values: new object[,]
                {
                    { 26, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61alcr5GlXL._AC_UX695_.jpg", 9, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 95, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/81UAA9EIkaL._AC_UX500_.jpg", 29, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 66, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61HejuTQjAL._AC_UY695_.jpg", 20, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 65, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61i3ahDokML._AC_UX500_.jpg", 20, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 64, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71C3TmhbLgL._AC_UX500_.jpg", 20, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 96, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/81C0w4yEE-L._AC_UX500_.jpg", 29, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 97, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/81pBO4xZVAL._AC_UX500_.jpg", 29, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 98, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/8168xklonDL._AC_UX500_.jpg", 29, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 63, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61--1IEj-QL._AC_UY500_.jpg", 19, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 62, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/51NN9Q8f8pL._AC_UY500_.jpg", 19, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 61, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61C-nbfIYvL._AC_UY500_.jpg", 19, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 67, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71qfjMzU3FL._AC_UX500_.jpg", 21, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 99, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/81Dp6J7W16L._AC_UX500_.jpg", 30, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 100, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/81p7VGYaa-L._AC_UX500_.jpg", 30, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 101, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/81aTENbc4dL._AC_UX500_.jpg", 30, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 59, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/719XXYFVBRL._AC_UX500_.jpg", 17, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 58, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71ehIGd8LLL._AC_UY625_.jpg", 17, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 57, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/81DUO6ppq5L._AC_UX500_.jpg", 17, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 84, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/81j92FSiv3L._AC_UX695_.jpg", 26, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 102, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61sNtbP0xZL._AC_UX500_.jpg", 31, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 103, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61VjNuYDB2L._AC_UY500_.jpg", 31, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 56, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61M5sonJ-2L._AC_UX500_.jpg", 16, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 55, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61jvQ0KH8fL._AC_UX500_.jpg", 16, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 60, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71jBHYlEtKL._AC_UX695_.jpg", 18, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 54, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61UckOg5ScL._AC_UX500_.jpg", 16, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 68, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71VkDhfV-1L._AC_UX500_.jpg", 21, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 70, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/710tfLKOiwL._AC_UX500_.jpg", 21, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 86, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/81IJc60BqJL._AC_UX500_.jpg", 26, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 87, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/81mA4XkSPfL._AC_UX500_.jpg", 26, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 83, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71pQ16I86YS._AC_UY500_.jpg", 25, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 82, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61ldv19scaS._AC_UY500_.jpg", 25, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 81, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61C+d7XKYfS._AC_UY500_.jpg", 25, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 88, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71m-HrkrGVL._AC_UX500_.jpg", 27, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 89, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71s7IYm+DvL._AC_UX500_.jpg", 27, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 80, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71pI4R8LAJL._AC_UX500_.jpg", 24, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 79, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71Pc+pI6xcL._AC_UX500_.jpg", 24, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 78, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71hlP8+14gL._AC_UX500_.jpg", 24, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 69, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/618UTqPoQ4L._AC_UX500_.jpg", 21, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 90, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71tygOpNCfL._AC_UX500_.jpg", 27, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 76, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71nqJ8JAPkL._AC_UX535_.jpg", 23, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 75, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/715neAl9WnL._AC_UX535_.jpg", 23, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 91, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71ub1DieNoL._AC_UX500_.jpg", 28, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageId", "CreateDate", "Path", "ProductId", "UpdateDate" },
                values: new object[,]
                {
                    { 92, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71KGQTAqwcL._AC_UX500_.jpg", 28, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 74, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61+h0YWusfL._AC_UX500_.jpg", 22, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 73, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71WmBb6su8L._AC_UX500_.jpg", 22, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 72, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71N4iPnYjFL._AC_UX500_.jpg", 22, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 71, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61Ax+nPgexL._AC_UX500_.jpg", 22, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 93, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/81A-D9WqwkL._AC_UX500_.jpg", 28, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 94, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71XtjeYRTxL._AC_UX500_.jpg", 28, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 77, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71SJxMKoL5L._AC_UX535_.jpg", 23, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 104, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61EHWLS4jZL._AC_UY500_.jpg", 31, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 85, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71CehSqfjYL._AC_UX500_.jpg", 26, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 40, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/81QU0-K6SSL._AC_UY500_.jpg", 12, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 44, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61quwbKmUpS._AC_UY625_.jpg", 13, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 43, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71UgZGCsL-S._AC_UY575_.jpg", 13, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 42, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71rpzIS5ChS._AC_UX695_.jpg", 13, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 109, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71B+jujVaJL._AC_UX675_.jpg", 33, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 113, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/81FpRIxhYML._AC_SX500._SX._UX._SY._UY_.jpg", 35, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 31, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71wbXtpEwQL._AC_UY500_.jpg", 10, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 32, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61FN6BWhc3L._AC_UY395_.jpg", 10, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 41, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61gVySL0COL._AC_UY500_.jpg", 12, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 33, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71P+O+GmbIL._AC_UY395_.jpg", 10, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 39, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/81tubh4kJtL._AC_UY500_.jpg", 12, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 38, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71PutuAFLxL._AC_UY575_.jpg", 12, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 34, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61CbQbErg1L._AC_UY395_.jpg", 10, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 110, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61AHVQEbcXL._AC_UX500_.jpg", 34, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 112, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71+8kiZWiAL._AC_SX500._SX._UX._SY._UY_.jpg", 35, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 111, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61jM+GkDAeL._AC_SX500._SX._UX._SY._UY_.jpg", 35, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 37, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/51mx9nf2wAL._AC_UX395_.jpg", 11, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 36, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61IYtSgvJmL._AC_UX395_.jpg", 11, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 45, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/81UClieXbJS._AC_UX500_.jpg", 13, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 35, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/6168hsA9bSL._AC_UX575_.jpg", 11, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 114, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/81elz8mIVhL._AC_SX500._SX._UX._SY._UY_.jpg", 35, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 47, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61NzpXnXCsL._AC_UX500_.jpg", 14, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 107, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61VCN2iVWhS._AC_UX500_.jpg", 32, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 50, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61g1NlfdqML._AC_UX500_.jpg", 15, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 51, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61ArMmiww0L._AC_UX500_.jpg", 15, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 28, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/615fDqJiotL._AC_UY500_.jpg", 9, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 49, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71mLwuFyfvL._AC_UX500_.jpg", 14, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 48, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61HAme7md2L._AC_UX500_.jpg", 14, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 106, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/51w+UH35KNS._AC_UX500_.jpg", 32, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 105, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/6151xNOvo5S._AC_UX500_.jpg", 32, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 29, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71hSg0ahhBL._AC_UX395_.jpg", 9, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 46, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61cKqcMqVJL._AC_UX625_.jpg", 14, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageId", "CreateDate", "Path", "ProductId", "UpdateDate" },
                values: new object[,]
                {
                    { 108, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/611Tna756OS._AC_UX500_.jpg", 32, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 30, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71SfTEUzMrL._AC_UX395_.jpg", 9, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 53, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61jTBO8P4IL._AC_UX500_.jpg", 15, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 27, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/61vClQIDKML._AC_UY500_.jpg", 9, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 52, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/51wG7gQKKxL._AC_UX500_.jpg", 15, new DateTime(2022, 1, 5, 5, 35, 51, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "SizeProducts",
                columns: new[] { "SizeProductId", "ProductId", "SizeId" },
                values: new object[,]
                {
                    { 117, 35, 14 },
                    { 89, 27, 13 },
                    { 90, 27, 15 },
                    { 88, 26, 14 },
                    { 86, 26, 11 },
                    { 118, 35, 15 },
                    { 87, 26, 12 },
                    { 91, 27, 16 },
                    { 92, 27, 17 },
                    { 104, 31, 7 },
                    { 115, 34, 12 },
                    { 103, 31, 1 },
                    { 101, 30, 4 },
                    { 100, 30, 3 },
                    { 99, 30, 2 },
                    { 106, 32, 3 },
                    { 107, 32, 4 },
                    { 98, 29, 9 },
                    { 97, 29, 8 },
                    { 96, 29, 7 },
                    { 116, 34, 13 },
                    { 108, 32, 5 },
                    { 110, 33, 7 },
                    { 111, 33, 8 },
                    { 95, 28, 15 },
                    { 94, 28, 13 },
                    { 105, 31, 8 },
                    { 112, 33, 9 },
                    { 93, 28, 10 },
                    { 113, 34, 10 },
                    { 114, 34, 11 },
                    { 109, 33, 6 },
                    { 102, 30, 5 },
                    { 71, 21, 17 },
                    { 84, 25, 2 },
                    { 51, 16, 12 },
                    { 50, 15, 10 }
                });

            migrationBuilder.InsertData(
                table: "SizeProducts",
                columns: new[] { "SizeProductId", "ProductId", "SizeId" },
                values: new object[,]
                {
                    { 49, 15, 8 },
                    { 48, 15, 7 },
                    { 47, 15, 6 },
                    { 46, 14, 17 },
                    { 45, 14, 14 },
                    { 44, 14, 13 },
                    { 43, 13, 14 },
                    { 42, 13, 11 },
                    { 41, 13, 10 },
                    { 40, 13, 7 },
                    { 39, 12, 4 },
                    { 52, 16, 13 },
                    { 38, 12, 3 },
                    { 36, 12, 1 },
                    { 35, 11, 11 },
                    { 34, 11, 8 },
                    { 33, 11, 5 },
                    { 32, 11, 4 },
                    { 31, 10, 17 },
                    { 30, 10, 16 },
                    { 29, 10, 15 },
                    { 28, 10, 14 },
                    { 27, 9, 15 },
                    { 26, 9, 14 },
                    { 25, 9, 13 },
                    { 24, 9, 12 },
                    { 37, 12, 2 },
                    { 85, 25, 3 },
                    { 53, 16, 14 },
                    { 55, 17, 4 },
                    { 83, 25, 1 },
                    { 82, 24, 6 },
                    { 81, 24, 5 },
                    { 80, 24, 4 },
                    { 79, 24, 3 },
                    { 78, 23, 9 },
                    { 77, 23, 8 },
                    { 76, 23, 7 },
                    { 75, 23, 5 },
                    { 74, 22, 6 },
                    { 73, 22, 4 },
                    { 72, 22, 3 }
                });

            migrationBuilder.InsertData(
                table: "SizeProducts",
                columns: new[] { "SizeProductId", "ProductId", "SizeId" },
                values: new object[,]
                {
                    { 119, 35, 16 },
                    { 54, 16, 15 },
                    { 70, 21, 16 },
                    { 68, 20, 15 },
                    { 67, 20, 9 },
                    { 66, 20, 7 },
                    { 65, 19, 4 },
                    { 64, 19, 3 },
                    { 63, 19, 2 },
                    { 62, 18, 17 },
                    { 61, 18, 15 },
                    { 60, 18, 13 },
                    { 59, 18, 11 },
                    { 58, 17, 16 },
                    { 57, 17, 9 },
                    { 56, 17, 5 },
                    { 69, 21, 13 },
                    { 120, 35, 17 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "SizeProducts",
                keyColumn: "SizeProductId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 35);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 2,
                column: "BrandName",
                value: "AIR JORDAN");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 5,
                column: "BrandName",
                value: "DANSKO");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 6,
                column: "BrandName",
                value: "MLB");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "CategoryName",
                value: "SLIPPERS");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 4,
                column: "Path",
                value: "http://purchaze.com/pictures/nike-wmns-roshe-two-black-black-844931-004.jpg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 5,
                column: "Path",
                value: "http://purchaze.com/pictures/nike-wmns-roshe-two-black-black-844931-004_1.jpg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 6,
                column: "Path",
                value: "http://purchaze.com/pictures/nike-wmns-roshe-two-black-black-844931-004_2.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ProductDesc",
                value: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ProductName",
                value: "Roshe Two Black");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "ProductDesc",
                value: "fabric");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "ProductDesc",
                value: "fabric");
        }
    }
}
