using Backend.Models;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.BackendTesting.Mock.MockData
{
    public class CategoriesMockData
    {
        //Check get all products
        public static List<Category> GetCategories()
        {
            return new List<Category>{
                new Category { CategoryName = "BOOT" },
                new Category { CategoryName = "SLIP ON" },
                new Category { CategoryName = "FORMAL" },
            };
        }
        public static Category GetOneCategory()
        {
            return new Category
            {
                CategoryName = "STRAP"
            };
        }

        // Check if product list is empty
        public static List<Category> GetEmptyCategories()
        {
            return new List<Category>();
        }

        //Check if can create product
        public static CategoryCreateRequest NewCategory()
        {
            return new CategoryCreateRequest
            {
                CategoryName = "LACE UP"
            };
        }
    }
}
