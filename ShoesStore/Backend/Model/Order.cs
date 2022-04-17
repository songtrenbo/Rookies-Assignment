using Backend.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int? Status { get; set; }
        public double? OrderTotal { get; set; }
        public DateTime? ShippingDate { get; set; }
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
        public ICollection<Rate> Rates { get; set; }
    }
}
