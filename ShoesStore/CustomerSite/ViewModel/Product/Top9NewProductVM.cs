using CustomerSite.ViewModel.Image;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSite.ViewModel.Product
{
    public class Top9NewProductVM
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public double? Price { get; set; }

        public string ProductDesc { get; set; }
        public string Path { get; set; }
    }
}
