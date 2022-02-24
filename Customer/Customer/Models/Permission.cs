using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Customer.Models
{
    public class Permission
    {
        [Key]
        public int PermissionId { get; set; }
        public string PermissionName { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
