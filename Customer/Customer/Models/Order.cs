using System;
using System.Collections.Generic;

#nullable disable

namespace Customer.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
            Rates = new HashSet<Rate>();
        }

        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int? Status { get; set; }
        public double? OrderTotal { get; set; }
        public DateTime? ShippingDate { get; set; }
        public int? UserId { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<Rate> Rates { get; set; }
    }
}
