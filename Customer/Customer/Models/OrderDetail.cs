using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Customer.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailsId { get; set; }
        public double ProductPrice { get; set; }
        public int ProductQty { get; set; }
        public int Subtotal { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }

        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
