using System;
using System.Collections.Generic;

#nullable disable

namespace Customer.Models
{
    public partial class Rate
    {
        public int RateId { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public int OrderId { get; set; }
        public int Points { get; set; }
        public string Content { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
    }
}
