using Backend.Models;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.BackendTesting.Mock.MockData
{
    public class ProductsMockData
    {
        //Check get all products
        public static List<Product> GetProducts()
        {
            return new List<Product>{
                 new Product{
                     ProductName = "Nike Air Force 1 '07",
                     ProductDesc = "The radiance lives on in the Nike Air Force 1 '07, the b-ball OG that puts a fresh spin on what you know best: durably stitched overlays, clean finishes and the perfect amount of flash to make you shine.",
                     Price = 123,
                     Stock = 5,
                     BrandId = 1,
                     CategoryId = 2                     
                 },
                new Product{
                     ProductName = "Nike Metcon 7 AMP",
                     ProductDesc = "The Nike Metcon 7 AMP is the gold standard for weight training—even tougher and more stable than previous versions. We've also added React foam that ups the comfort to keep you ready for high-intensity cardio. Plus, a tab locks down your laces so you can forget about them coming untied when you're focused on your next PR.",
                     Price = 103,
                     Stock = 21,
                     BrandId = 3,
                     CategoryId = 4
                 }, new Product{
                     ProductName = "Jordan Why Not .5 PF",
                     ProductDesc = "Russell Westbrook is fast. The Jordan Why Not .5 helps keep him contained with updated cushioning, data-informed traction and a full-foot fit system that keeps him in control. It has the rugged utility look of a trail running shoe",
                     Price = 137,
                     Stock = 14,
                     BrandId = 4,
                     CategoryId = 3
                 }
            };
        }
        public static Product GetOneProduct()
        {
            return new Product
            {
                ProductId = 1,
                ProductName = "Jordan Why Not .5 PF",
                ProductDesc = "Russell Westbrook is fast. The Jordan Why Not .5 helps keep him contained with updated cushioning, data-informed traction and a full-foot fit system that keeps him in control. It has the rugged utility look of a trail running shoe",
                Price = 137,
                Stock = 14,
                BrandId = 4,
                CategoryId = 3
            };
        }
           
        // Check if product list is empty
        public static List<Product> GetEmptyProducts()
        {
            return new List<Product>();
        }

        //Check if can create product
        public static ProductCreateRequest NewProduct()
        {
            return new ProductCreateRequest
            {
                ProductName = "Jordan .5 PF",
                ProductDesc = "The Jordan Why Not .5 helps keep him contained with updated cushioning, data-informed traction and a full-foot fit system that keeps him in control. It has the rugged utility look of a trail running shoe",
                Price = 111,
                Stock = 11,
                BrandId = 1,
                CategoryId = 1
            };        
        }
    }
}
