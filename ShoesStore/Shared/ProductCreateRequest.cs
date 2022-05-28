using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class ProductCreateRequest
    {
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string ProductDesc { get; set; }
        [Required]
        [Range(0,999999)]
        public double Price { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public int BrandId { get; set; }
        [Required]
        [Range(0,9999)]
        public int Stock { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
