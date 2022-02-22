using System;
using System.Collections.Generic;

#nullable disable

namespace Customer.Models
{
    public partial class User
    {
        public User()
        {
            Orders = new HashSet<Order>();
            Rates = new HashSet<Rate>();
        }

        public int UserId { get; set; }
        public string UserEmail { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int PermissionId { get; set; }

        public virtual Permission Permission { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Rate> Rates { get; set; }
    }
}
