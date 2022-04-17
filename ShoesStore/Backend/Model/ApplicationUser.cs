using Backend.Models;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Backend.Model
{
    public class ApplicationUser: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Rate> Rates { get; set; }
    }
}
