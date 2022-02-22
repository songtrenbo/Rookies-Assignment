using System;
using System.Collections.Generic;

#nullable disable

namespace Customer.Models
{
    public partial class Size
    {
        public Size()
        {
            SizeProducts = new HashSet<SizeProduct>();
        }

        public int SizeId { get; set; }
        public double SizeName { get; set; }

        public virtual ICollection<SizeProduct> SizeProducts { get; set; }
    }
}
