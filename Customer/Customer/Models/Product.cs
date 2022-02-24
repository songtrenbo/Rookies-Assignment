using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Customer.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [Column(TypeName ="nvarchar(250)")]
        public string ProductName { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(1000)")]
        public string ProductDesc { get; set; }

        [Required]
        public double? Price { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public int Stock { get; set; }

        public Brand Brand { get; set; }
        public Category Category { get; set; }
        public ICollection<Image> Images { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
        public ICollection<Rate> Rates { get; set; }
        public ICollection<SizeProduct> SizeProducts { get; set; }
    }
}
