using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSite.ViewModel.Product
{
    public class ProductVM
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string ProductDesc { get; set; }

        public double? Price { get; set; }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int? BrandId { get; set; }
        public string BrandName { get; set; }
        public int Stock { get; set; }
        public string Path { get; set; }
        public double SizeName { get; set; }
    }
}
