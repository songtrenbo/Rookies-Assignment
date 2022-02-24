using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Customer.Models
{
    public class SizeProduct
    {
        [Key]
        public int SizeProductId { get; set; }
        public int SizeId { get; set; }
        public int ProductId { get; set; }

        public Product Product { get; set; }
        public Size Size { get; set; }
    }
}
