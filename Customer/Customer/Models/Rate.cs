using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Customer.Models
{
    public class Rate
    {
        [Key]
        public int RateId { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public int OrderId { get; set; }
        public int Points { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(500)")]
        public string Content { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool? IsDeleted { get; set; }

        public Order Order { get; set; }
        public Product Product { get; set; }
        public User User { get; set; }
    }
}
