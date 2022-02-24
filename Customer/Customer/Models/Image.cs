using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Customer.Models
{
    public class Image
    {
        [Key]
        public int ImageId { get; set; }


        [Required]
        [Column(TypeName = "nvarchar(500)")]
        public string Path { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int ProductId { get; set; }

        public Product Product { get; set; }
    }
}
