using System;
using System.Collections.Generic;

#nullable disable

namespace Customer.Models
{
    public partial class SizeProduct
    {
        public int SizeProductId { get; set; }
        public int SizeId { get; set; }
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
        public virtual Size Size { get; set; }
    }
}
