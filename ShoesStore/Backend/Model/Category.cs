using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class Category
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int CategoryId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(250)")]
        public string CategoryName { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
