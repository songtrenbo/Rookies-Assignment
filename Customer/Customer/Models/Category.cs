using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Customer.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(250)")]
        public string CategoryName { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
