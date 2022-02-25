using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class SizeProduct
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int SizeProductId { get; set; }
        public int SizeId { get; set; }
        public int ProductId { get; set; }

        public Product Product { get; set; }
        public Size Size { get; set; }
    }
}
