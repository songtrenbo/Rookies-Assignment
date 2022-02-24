using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Customer.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int? Status { get; set; }
        public double? OrderTotal { get; set; }
        public DateTime? ShippingDate { get; set; }
        public int? UserId { get; set; }

        public User User { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
        public ICollection<Rate> Rates { get; set; }
    }
}
