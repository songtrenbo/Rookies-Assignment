using System;
using System.Collections.Generic;

#nullable disable

namespace Customer.Models
{
    public partial class OrderDetail
    {
        public int OrderDetailsId { get; set; }
        public double ProductPrice { get; set; }
        public int ProductQty { get; set; }
        public int Subtotal { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
