using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int UserId { get; set; }


        [Required]
        [Column(TypeName = "nvarchar(250)")]
        public string UserEmail { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(250)")]
        public string FirstName { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(250)")]
        public string LastName { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(30)")]
        public string Password { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int PermissionId { get; set; }

        public Permission Permission { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Rate> Rates { get; set; }
    }
}
