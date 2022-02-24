using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Customer.Models
{
    public class Size
    {
        [Key]
        public int SizeId { get; set; }

        [Required]
        public double SizeName { get; set; }

        public ICollection<SizeProduct> SizeProducts { get; set; }
    }
}
