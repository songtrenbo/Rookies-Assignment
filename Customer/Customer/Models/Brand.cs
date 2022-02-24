using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Customer.Models
{
    public class Brand
    {
        [Key]
        public int BrandId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(250)")]
        public string BrandName { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
