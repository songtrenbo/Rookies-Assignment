using Backend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Data.SeedData
{
    public static class ShoesSeedingData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //Data of Brand
            modelBuilder.Entity<Brand>().HasData(
                new Brand { BrandId = 1, BrandName = "NIKE" },
                new Brand { BrandId = 2, BrandName = "AIR JORDAN" },
                new Brand { BrandId = 3, BrandName = "ADIDAS" },
                new Brand { BrandId = 4, BrandName = "PUMA" },
                new Brand { BrandId = 5, BrandName = "DANSKO" },
                new Brand { BrandId = 6, BrandName = "MLB" },
                new Brand { BrandId = 7, BrandName = "ECCO" }
           );

            //Data of Permission
            modelBuilder.Entity<Permission>().HasData(
                new Permission { PermissionId = 1, PermissionName = "Admin" },
                new Permission { PermissionId = 2, PermissionName = "Customer" }
                );

            //Data of User
            modelBuilder.Entity<User>().HasData(
                new User { UserId = 1, UserEmail = "Admin", Password = "Admin", FirstName = "Sam", LastName = "GoodMan", Address = "772 North Dr Villa Ridge, Missouri(MO), 63089", Phone = "7169379740", PermissionId = 1 },
                new User { UserId = 2, UserEmail = "nico.smith29@gmail.com", Password = "123456", FirstName = "Smith", LastName = "Nico", Address = "124 Damon Rd Needham Heights, Massachusetts(MA), 02494", Phone = "9226852630", PermissionId = 2 },
                new User { UserId = 3, UserEmail = "megane_conroy@gmail.com", Password = "123456", FirstName = "Megane", LastName = "Conroy", Address = "121 W Main St Pottstown, Pennsylvania(PA), 19465", Phone = "5547714494", PermissionId = 2 },
                new User { UserId = 4, UserEmail = "wilber73@gmail.com", Password = "123456", FirstName = "Wilber", LastName = "Stafford", Address = "6910 Middle Rd 4 Racine, Wisconsin(WI), 53402", Phone = "3388576230", PermissionId = 2 },
                new User { UserId = 5, UserEmail = "timothy.zulauf84@gmail.com", Password = "123456", FirstName = "Timothy", LastName = "Zulauf", Address = "123456', N'173 Candlewood Trailer Park Danbury, Connecticut(CT), 06811", Phone = "3643898217", PermissionId = 2 },
                new User { UserId = 6, UserEmail = "customer1@gmail.com", Password = "123456", FirstName = "Derek", LastName = "Levy", Address = "1025 Meadow Dr Cottage Hills, Illinois(IL), 62018", Phone = "9799644643", PermissionId = 2 }
                );

            //Data of Category
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "SNEAKER" },
                new Category { CategoryId = 2, CategoryName = "SANDALS" },
                new Category { CategoryId = 3, CategoryName = "ATHLETIC" },
                new Category { CategoryId = 4, CategoryName = "OUTDOOR" },
                new Category { CategoryId = 5, CategoryName = "SLIPPERS" }
                );

            //Data of product
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, ProductName = "Air Force 1 Low LXX \"Serema Summit White\"", ProductDesc = "", Price = 167.5, CreateDate = DateTime.Parse("2021/11/05"), UpdateDate = DateTime.Parse("2021/11/05"), CategoryId = 1, BrandId = 1, Stock = 10 },
                new Product { ProductId = 2, ProductName = "Roshe Two Black", ProductDesc = "Bootie construction delivers a snug, comfortable fit / Padded collar provides plush cushioning / Sockliner made of slow-recovery foam enhances comfort and cushioning", Price = 74.95, CreateDate = DateTime.Parse("2021-11-05 05:35:51"), UpdateDate = DateTime.Parse("2021-11-05 05:35:51"), CategoryId = 1, BrandId = 1, Stock = 11 },
                new Product { ProductId = 3, ProductName = "Running React Element 87", ProductDesc = "Bootie construction delivers a snug, comfortable fit / Padded collar provides plush cushioning / Sockliner made of slow-recovery foam enhances comfort and cushioning", Price = 75.49, CreateDate = DateTime.Parse("2021-11-05 05:35:51"), UpdateDate = DateTime.Parse("2021-11-05 05:35:51"), CategoryId = 1, BrandId = 1, Stock = 12 },
                new Product { ProductId = 4, ProductName = "Adidas Unisex-Adult Adissage Slides Sandal", ProductDesc = "100% Synthetic, Imported, Rubber sole, Shaft measures approximately 6-12 inches from arch, Platform measures approximately 0-3 inches, Boot opening measures approximately 0-3 inches around, Regular fit", Price = 69.94, CreateDate = DateTime.Parse("2021-11-05 05:35:51"), UpdateDate = DateTime.Parse("2021-11-05 05:35:51"), CategoryId = 2, BrandId = 3, Stock = 24 },
                new Product { ProductId = 5, ProductName = "PUMA Unisex-Adult Leadcat Slide Sandal", ProductDesc = "Imported, Rubber sole, Casual Athletic Sneaker, Leadcat", Price = 38.76, CreateDate = DateTime.Parse("2021-11-05 05:35:51"), UpdateDate = DateTime.Parse("2021-11-05 05:35:51"), CategoryId = 2, BrandId = 4, Stock = 10 },
                new Product { ProductId = 6, ProductName = "PUMA Cool Cat Dark Prismatic", ProductDesc = "fabric", Price = 67.45, CreateDate = DateTime.Parse("2021-11-05 05:35:51"), UpdateDate = DateTime.Parse("2021-11-05 05:35:51"), CategoryId = 2, BrandId = 4, Stock = 18 },
                new Product { ProductId = 7, ProductName = "ECCO Women X-trinsic Textile Strap Sandal", ProductDesc = "fabric", Price = 143.95, CreateDate = DateTime.Parse("2021-11-05 05:35:51"), UpdateDate = DateTime.Parse("2021-11-05 05:35:51"), CategoryId = 2, BrandId = 7, Stock = 13 },
                new Product { ProductId = 8, ProductName = "Dansko Womens Racquel Sport Sandals - lightweight sandals with arch support", ProductDesc = "Made in the USA or Imported, Ethylene Vinyl Acetate sole, Platform measures approximately 1, Multiple points of adjustability, Recycled webbings", Price = 109.65, CreateDate = DateTime.Parse("2021-11-05 05:35:51"), UpdateDate = DateTime.Parse("2021-11-05 05:35:51"), CategoryId = 2, BrandId = 5, Stock = 19 }

                );

            //Data of Size
            modelBuilder.Entity<Size>().HasData(
                new Size { SizeId = 1, SizeName = 35.5 },
                new Size { SizeId = 2, SizeName = 36.0 },
                new Size { SizeId = 3, SizeName = 36.5 },
                new Size { SizeId = 4, SizeName = 37.0 },
                new Size { SizeId = 5, SizeName = 37.5 },
                new Size { SizeId = 6, SizeName = 38.0 },
                new Size { SizeId = 7, SizeName = 38.5 },
                new Size { SizeId = 8, SizeName = 39.0 },
                new Size { SizeId = 9, SizeName = 39.5 },
                new Size { SizeId = 10, SizeName = 40.0 },
                new Size { SizeId = 11, SizeName = 40.5 },
                new Size { SizeId = 12, SizeName = 41.0 },
                new Size { SizeId = 13, SizeName = 42.0 },
                new Size { SizeId = 14, SizeName = 43.0 },
                new Size { SizeId = 15, SizeName = 44.0 },
                new Size { SizeId = 16, SizeName = 45.0 },
                new Size { SizeId = 17, SizeName = 46.0 }
                );

            //Data if Size_Product
            modelBuilder.Entity<SizeProduct>().HasData(
                new SizeProduct { SizeProductId = 1, SizeId = 4, ProductId = 1 },
                new SizeProduct { SizeProductId = 2, SizeId = 5, ProductId = 1 },
                new SizeProduct { SizeProductId = 3, SizeId = 6, ProductId = 2 },
                new SizeProduct { SizeProductId = 4, SizeId = 6, ProductId = 2 },
                new SizeProduct { SizeProductId = 5, SizeId = 7, ProductId = 3 },
                new SizeProduct { SizeProductId = 6, SizeId = 1, ProductId = 3 },
                new SizeProduct { SizeProductId = 7, SizeId = 2, ProductId = 3 },
                new SizeProduct { SizeProductId = 8, SizeId = 3, ProductId = 4 },
                new SizeProduct { SizeProductId = 9, SizeId = 1, ProductId = 4 },
                new SizeProduct { SizeProductId = 10, SizeId = 2, ProductId = 4 },
                new SizeProduct { SizeProductId = 11, SizeId = 3, ProductId = 4 },
                new SizeProduct { SizeProductId = 12, SizeId = 5, ProductId = 5 },
                new SizeProduct { SizeProductId = 13, SizeId = 6, ProductId = 5 },
                new SizeProduct { SizeProductId = 14, SizeId = 7, ProductId = 5 },
                new SizeProduct { SizeProductId = 15, SizeId = 8, ProductId = 6 },
                new SizeProduct { SizeProductId = 16, SizeId = 9, ProductId = 6 },
                new SizeProduct { SizeProductId = 17, SizeId = 10, ProductId = 6 },
                new SizeProduct { SizeProductId = 18, SizeId = 11, ProductId = 7 },
                new SizeProduct { SizeProductId = 19, SizeId = 12, ProductId = 7 },
                new SizeProduct { SizeProductId = 20, SizeId = 13, ProductId = 7 },
                new SizeProduct { SizeProductId = 21, SizeId = 14, ProductId = 8 },
                new SizeProduct { SizeProductId = 22, SizeId = 15, ProductId = 8 },
                new SizeProduct { SizeProductId = 23, SizeId = 16, ProductId = 8 }
                );

            //Data of image
            modelBuilder.Entity<Image>().HasData(
                new Image { ImageId = 1, CreateDate = DateTime.Parse("2021-11-05 05:35:51"), UpdateDate = DateTime.Parse("2021-11-05 05:35:51"), ProductId = 1, Path = "https://cdn.shopify.com/s/files/1/2358/2817/products/nike-air-force-1-low-lxx-serena-summit-white_300x.png?v=1643803817" },
                new Image { ImageId = 2, CreateDate = DateTime.Parse("2021-11-05 05:35:51"), UpdateDate = DateTime.Parse("2021-11-05 05:35:51"), ProductId = 1, Path = "https://cdn.shopify.com/s/files/1/2358/2817/products/nike-air-force-1-low-lxx-serena-summit-white-2_300x.png?v=1643803817" },
                new Image { ImageId = 3, CreateDate = DateTime.Parse("2021-11-05 05:35:51"), UpdateDate = DateTime.Parse("2021-11-05 05:35:51"), ProductId = 1, Path = "https://cdn.shopify.com/s/files/1/2358/2817/products/nike-air-force-1-low-lxx-serena-summit-white-3_300x.png?v=1643803817" },
                new Image { ImageId = 4, CreateDate = DateTime.Parse("2021-11-05 05:35:51"), UpdateDate = DateTime.Parse("2021-11-05 05:35:51"), ProductId = 2, Path = "http://purchaze.com/pictures/nike-wmns-roshe-two-black-black-844931-004.jpg" },
                new Image { ImageId = 5, CreateDate = DateTime.Parse("2021-11-05 05:35:51"), UpdateDate = DateTime.Parse("2021-11-05 05:35:51"), ProductId = 2, Path = "http://purchaze.com/pictures/nike-wmns-roshe-two-black-black-844931-004_1.jpg" },
                new Image { ImageId = 6, CreateDate = DateTime.Parse("2021-11-05 05:35:51"), UpdateDate = DateTime.Parse("2021-11-05 05:35:51"), ProductId = 2, Path = "http://purchaze.com/pictures/nike-wmns-roshe-two-black-black-844931-004_2.jpg" },
                new Image { ImageId = 7, CreateDate = DateTime.Parse("2021-11-05 05:35:51"), UpdateDate = DateTime.Parse("2021-11-05 05:35:51"), ProductId = 3, Path = "https://static.nike.com/a/images/t_prod_ss/w_640,c_limit,f_auto/ktfan65igkw4nb8c3jvs/nike-react-element-87-sail-rush-orange-release-date.jpg" },
                new Image { ImageId = 8, CreateDate = DateTime.Parse("2021-11-05 05:35:51"), UpdateDate = DateTime.Parse("2021-11-05 05:35:51"), ProductId = 3, Path = "https://static.nike.com/a/images/t_prod_ss/w_640,c_limit,f_auto/w20texhnqyxylva0xbgl/nike-react-element-87-sail-rush-orange-release-date.jpg" },
                new Image { ImageId = 9, CreateDate = DateTime.Parse("2021-11-05 05:35:51"), UpdateDate = DateTime.Parse("2021-11-05 05:35:51"), ProductId = 3, Path = "https://static.nike.com/a/images/t_prod_ss/w_640,c_limit,f_auto/rdim8o3ryfqkzc7anrpd/nike-react-element-87-sail-rush-orange-release-date.jpg" },
                new Image { ImageId = 10, CreateDate = DateTime.Parse("2021-11-05 05:35:51"), UpdateDate = DateTime.Parse("2021-11-05 05:35:51"), ProductId = 4, Path = "https://m.media-amazon.com/images/I/71o4uSF26YL._AC_UX575_.jpg" },
                new Image { ImageId = 11, CreateDate = DateTime.Parse("2021-11-05 05:35:51"), UpdateDate = DateTime.Parse("2021-11-05 05:35:51"), ProductId = 4, Path = "https://m.media-amazon.com/images/I/61qqMFxGxyL._AC_UX575_.jpg" },
                new Image { ImageId = 12, CreateDate = DateTime.Parse("2021-11-05 05:35:51"), UpdateDate = DateTime.Parse("2021-11-05 05:35:51"), ProductId = 4, Path = "https://m.media-amazon.com/images/I/71uHDLaWGXL._AC_UX575_.jpg" },
                new Image { ImageId = 13, CreateDate = DateTime.Parse("2021-11-05 05:35:51"), UpdateDate = DateTime.Parse("2021-11-05 05:35:51"), ProductId = 5, Path = "https://m.media-amazon.com/images/I/71M2oxWCjkS._AC_UX575_.jpg" },
                new Image { ImageId = 14, CreateDate = DateTime.Parse("2021-11-05 05:35:51"), UpdateDate = DateTime.Parse("2021-11-05 05:35:51"), ProductId = 5, Path = "https://m.media-amazon.com/images/I/715R0-wRKeS._AC_UX575_.jpg" },
                new Image { ImageId = 15, CreateDate = DateTime.Parse("2021-11-05 05:35:51"), UpdateDate = DateTime.Parse("2021-11-05 05:35:51"), ProductId = 5, Path = "https://m.media-amazon.com/images/I/71ADbn83HWS._AC_UX575_.jpg" },
                new Image { ImageId = 16, CreateDate = DateTime.Parse("2021-11-05 05:35:51"), UpdateDate = DateTime.Parse("2021-11-05 05:35:51"), ProductId = 6, Path = "https://m.media-amazon.com/images/I/41lyjznmaSL._AC_.jpg" },
                new Image { ImageId = 17, CreateDate = DateTime.Parse("2021-11-05 05:35:51"), UpdateDate = DateTime.Parse("2021-11-05 05:35:51"), ProductId = 6, Path = "https://m.media-amazon.com/images/I/510MaQWslcL._AC_.jpg" },
                new Image { ImageId = 18, CreateDate = DateTime.Parse("2021-11-05 05:35:51"), UpdateDate = DateTime.Parse("2021-11-05 05:35:51"), ProductId = 7, Path = "https://m.media-amazon.com/images/I/71Hm60lorWL._AC_UX575_.jpg" },
                new Image { ImageId = 19, CreateDate = DateTime.Parse("2021-11-05 05:35:51"), UpdateDate = DateTime.Parse("2021-11-05 05:35:51"), ProductId = 7, Path = "https://m.media-amazon.com/images/I/61FGZx9tVtL._AC_UY675_.jpg" },
                new Image { ImageId = 20, CreateDate = DateTime.Parse("2021-11-05 05:35:51"), UpdateDate = DateTime.Parse("2021-11-05 05:35:51"), ProductId = 7, Path = "https://m.media-amazon.com/images/I/61ju+hAFY3L._AC_UY625_.jpg" },
                new Image { ImageId = 21, CreateDate = DateTime.Parse("2021-11-05 05:35:51"), UpdateDate = DateTime.Parse("2021-11-05 05:35:51"), ProductId = 7, Path = "https://m.media-amazon.com/images/I/61ZrxFvudzL._AC_UX575_.jpg" },
                new Image { ImageId = 22, CreateDate = DateTime.Parse("2021-11-05 05:35:51"), UpdateDate = DateTime.Parse("2021-11-05 05:35:51"), ProductId = 8, Path = "https://m.media-amazon.com/images/I/71zg2Y4-9+L._AC_UY575_.jpg" },
                new Image { ImageId = 23, CreateDate = DateTime.Parse("2021-11-05 05:35:51"), UpdateDate = DateTime.Parse("2021-11-05 05:35:51"), ProductId = 8, Path = "https://m.media-amazon.com/images/I/61pql62AGKL._AC_UY575_.jpg" },
                new Image { ImageId = 24, CreateDate = DateTime.Parse("2021-11-05 05:35:51"), UpdateDate = DateTime.Parse("2021-11-05 05:35:51"), ProductId = 8, Path = "https://m.media-amazon.com/images/I/61UjkEy3z+L._AC_UY575_.jpg" },
                new Image { ImageId = 25, CreateDate = DateTime.Parse("2021-11-05 05:35:51"), UpdateDate = DateTime.Parse("2021-11-05 05:35:51"), ProductId = 8, Path = "https://m.media-amazon.com/images/I/61w-vJBt1JL._AC_UY575_.jpg" }

                );
        }
    }
}
