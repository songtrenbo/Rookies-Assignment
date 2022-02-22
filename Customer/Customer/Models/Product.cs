using System;
using System.Collections.Generic;

#nullable disable

namespace Customer.Models
{
    public partial class Product
    {
        public Product()
        {
            Images = new HashSet<Image>();
            OrderDetails = new HashSet<OrderDetail>();
            Rates = new HashSet<Rate>();
            SizeProducts = new HashSet<SizeProduct>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDesc { get; set; }
        public double? Price { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public int Stock { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<Rate> Rates { get; set; }
        public virtual ICollection<SizeProduct> SizeProducts { get; set; }
    }
}
