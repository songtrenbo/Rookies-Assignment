using System;
using System.Collections.Generic;

#nullable disable

namespace Customer.Models
{
    public partial class Image
    {
        public int ImageId { get; set; }
        public string Path { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
